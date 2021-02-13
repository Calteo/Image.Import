using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Toolbox;

namespace Image.Import
{
    internal partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();

            Files.ListChanged += FilesListChanged;

            FileHandlers = new Dictionary<string, Func<FileInfo, bool>>(StringComparer.InvariantCultureIgnoreCase)
            {
                { ".jpg", ImportPicture },
                { ".mp4", ImportVideo },
            };
        }

        public ImportOptions Options { get; set; }

        private void FilesListChanged(object sender, ListChangedEventArgs e)
        {
            Invoke((MethodInvoker)delegate { labelFiles.Text = $"Found {Files.Count:#,##0} files."; });
        }

        public BindingList<FileInfo> Files { get; } = new BindingList<FileInfo>();
        public Dictionary<string, Func<FileInfo, bool>> FileHandlers { get; } 
        
        
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

        private static Regex PatternReplacments { get; } = new Regex(@"\$\{(?<name>\w+)(:(?<format>[^}]+))?\}", RegexOptions.Compiled);

        private bool ImportPicture(FileInfo file)
        {
            var metadata = new Metadata(file);
            var filename = Path.Combine(Profile.Target, PatternReplacments.Replace(Profile.PicturesExpression, m => ReplacePicturePatterns(m, file, metadata)));
            var directory = Path.GetDirectoryName(filename);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (Profile.Overwrite || !File.Exists(filename))
            {
                file.CopyTo(filename, Profile.Overwrite);
                return true;
            }
            return false;            
        }

        private string ReplacePicturePatterns(Match match, FileInfo file, Metadata metadata)
        {
            var name = match.Groups["name"].Value;

            switch (name.ToLower())
            {
                case "taken":
                    {
                        var format = match.Groups["format"].Value ?? "yyyy-MM-dd-HH-mm-ss";
                        return metadata.DateTaken.ToString(format);
                    }
                case "filedate":
                    {
                        var format = match.Groups["format"].Value ?? "yyyy-MM-dd-HH-mm-ss";
                        return file.LastWriteTime.ToString(format);
                    }
                case "filename":
                    {
                        return file.Name;
                    }
                default:
                    {
                        return $"Unknown-{name}";
                    }
            }
        }

        private bool ImportVideo(FileInfo file)
        {
            throw new NotImplementedException(file.FullName);
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

                textBoxProtocol.Text = "";
                AddProtocol($"import from {textBoxSource.Text}");

                Task.Run(() => Import(), TokenSource.Token)
                    .ContinueWith(CompleteImport);
            }
        }

        public int Copied { get; private set; }
        public int Skipped { get; private set; }
        public int Failed { get; private set; }

        private void Import()
        {
            AddProtocol($"profile {Profile.Name}");

            Copied = Skipped = Failed = 0;

            foreach (var file in Files)
            {
                try
                {
                    if (FileHandlers[file.Extension](file))
                        Copied++;
                    else
                        Skipped++;
                }
                catch (Exception exception)
                {
                    AddProtocol($"failed - {file.FullName}");
                    AddProtocol($"       {exception.Message}");
                    Failed++;
                }
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

                progressBar.Visible = false;

                buttonImport.Text = "&Import";

                var results = new List<string>();
                if (Copied > 0)
                    results.Add($"{Copied:#,##0} copied");
                if (Skipped > 0)
                    results.Add($"{Skipped:#,##0} skipped");
                if (Failed > 0)
                    results.Add($"{Failed:#,##0} failed");

                var result = string.Join(", ", results);
                if (result.NotEmpty())
                    AddProtocol($"result - {result}");

                if (task.IsCanceled)
                    AddProtocol("import aborted.");
                else if (task.IsFaulted)
                {
                    AddProtocol($"import failed - {task.Exception?.Message}");
                }
                else
                {
                    AddProtocol($"import completed");
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

            textBoxSource.Text = Options.Source;
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

        public Profile Profile { get; set; }

        private void comboBoxProfiles_SelectedValueChanged(object sender, EventArgs e)
        {
            Profile = (Profile)comboBoxProfiles.SelectedValue;
        }
    }
}