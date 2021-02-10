using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image.Import
{
    internal partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();

            Files.ListChanged += FilesListChanged;

            FileHandlers = new Dictionary<string, Action<FileInfo>>(StringComparer.InvariantCultureIgnoreCase)
            {
                { ".jpg", ImportPicture },
                { ".mp4", ImportVideo },
            };
        }

        private void FilesListChanged(object sender, ListChangedEventArgs e)
        {
            Invoke((MethodInvoker)delegate { labelFiles.Text = $"Found {Files.Count:#,##0} files."; });
        }

        public BindingList<FileInfo> Files { get; } = new BindingList<FileInfo>();
        public Dictionary<string, Action<FileInfo>> FileHandlers { get; } 
        
        
        private void ButtonSelectClick(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxSource.Text;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                textBoxSource.Text = folderBrowserDialog.SelectedPath;                
            }
        }

        public CancellationTokenSource TokenSource { get; set; }

        public void AddProtocol(string text)
        {
            Invoke((MethodInvoker)delegate 
            {
                textBoxProtocol.Text += text + Environment.NewLine;
                textBoxProtocol.SelectionLength = 0;
                textBoxProtocol.SelectionStart = textBoxProtocol.Text.Length;
                textBoxProtocol.ScrollToCaret();
            });
        }

        public void StartScan()
        {
            TokenSource?.Cancel();

            TokenSource = new CancellationTokenSource();

            Files.Clear();

            buttonImport.Enabled = false;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Visible = true;

            Task.Run(() => Scan(textBoxSource.Text), TokenSource.Token)
                .ContinueWith(CompleteScan);
        }
       
        private void Scan(string folder)
        {
            if (folder == "") return;
            var directory = new DirectoryInfo(folder);

            if (!directory.Exists) return;

            foreach (var file in directory.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {                
                if (FileHandlers.ContainsKey(file.Extension))
                    Files.Add(file);
                if (TokenSource.Token.IsCancellationRequested) break;
            }
        }

        private void CompleteScan(Task task)
        {
            TokenSource = null;
            Invoke((MethodInvoker)delegate 
            { 
                progressBar.Visible = false;
            });

            if (task.IsCompleted)
            {
                var groups = Files.GroupBy(f => f.Extension.ToLower()).Select(g => $"{g.Count():#,###} {g.Key.Substring(1)}-files");
                var text = $"Found {string.Join(", ", groups)}.";
                Invoke((MethodInvoker)delegate { labelFiles.Text = text; });

                if (Files.Count > 0)
                {
                    Invoke((MethodInvoker)delegate { buttonImport.Enabled = true; });
                }
            }
        }

        private void ImportPicture(FileInfo file)
        {
            Thread.Sleep(150);
        }

        private void ImportVideo(FileInfo file)
        {

        }

        private void TextBoxSourceTextChanged(object sender, EventArgs e)
        {
            StartScan();
        }

        private void ButtonImportClick(object sender, EventArgs e)
        {
            if (TokenSource != null)
            {
                buttonImport.Text = "Aborting...";
                buttonImport.Enabled = false;
                TokenSource.Cancel();
            }
            else
            {
                TokenSource = new CancellationTokenSource();

                textBoxSource.Enabled =
                buttonEdit.Enabled =
                comboBoxProfiles.Enabled =
                buttonSelect.Enabled = false;

                progressBar.Value = 0;
                progressBar.Maximum = Files.Count;
                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Visible = true;

                buttonImport.Text = "&Abort";

                Task.Run(() => Import(), TokenSource.Token)
                    .ContinueWith(CompleteImport);
            }
        }

        private void Import()
        {
            foreach (var file in Files)
            {
                FileHandlers[file.Extension](file);
                Invoke((MethodInvoker)delegate
                {
                    progressBar.Value++;
                });

                TokenSource.Token.ThrowIfCancellationRequested();
            }
        }

        private void CompleteImport(Task task)
        {
            TokenSource = null;

            Invoke((MethodInvoker)delegate 
            {
                textBoxSource.Enabled =
                buttonSelect.Enabled =
                buttonEdit.Enabled =
                comboBoxProfiles.Enabled =
                buttonImport.Enabled = true;

                buttonImport.Text = "&Import";

                if (task.IsCanceled)
                    AddProtocol("import aborted.");
                else if (task.IsFaulted)
                {
                    AddProtocol($"import failed - {task.Exception?.Message}");
                }
            });
        }

        private void ImportFormFormClosing(object sender, FormClosingEventArgs e)
        {
            TokenSource?.Cancel();
        }

        public ProfileContainer ProfileContainer { get; set; }

        private void ImportFormLoad(object sender, EventArgs e)
        {
            ProfileContainer = ProfileContainer.Get();
            
            comboBoxProfiles.DataSource = ProfileContainer.Profiles;
            comboBoxProfiles.DisplayMember = "Name";
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            var form = new ProfileForm { ProfileContainer = ProfileContainer.Clone() };
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                ProfileContainer = form.ProfileContainer;
                var selected = ((Profile)comboBoxProfiles.SelectedItem).Name;
                comboBoxProfiles.DataSource = ProfileContainer.Profiles;
                comboBoxProfiles.DisplayMember = "Name";
                comboBoxProfiles.SelectedItem = ProfileContainer.Profiles.FirstOrDefault(p => p.Name == selected);
            }
        }
    }
}