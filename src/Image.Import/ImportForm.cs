using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Toolbox;
using Toolbox.Update;

namespace Image.Import
{
    internal partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();

            FileHandlers = new Dictionary<string, Func<FileInfo, bool>>(StringComparer.InvariantCultureIgnoreCase);

            Scanner = new BackgroundWorker<DirectoryInfo, List<FileInfo>>(this, InitScan, DoScan, CompleteScan);
            Importer = new BackgroundWorker<Profile, ImportStats>(this, InitImport, DoImport, CompletedImport);

            Text += $" - {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        public ImportOptions Options { get; set; }

        public List<FileInfo> Files { get; set; }
        public Dictionary<string, Func<FileInfo, bool>> FileHandlers { get; }

        private void ButtonSelectClick(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxSource.Text;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                textBoxSource.Text = folderBrowserDialog.SelectedPath;
            }
        }

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

        private BackgroundWorker<DirectoryInfo, List<FileInfo>> Scanner { get; }            

        public void StartScan()
        {
            Scanner.Start();
        }

        private DirectoryInfo InitScan()
        {
            var folder = textBoxSource.Text;
            if (folder == "")
            {
                labelFiles.Text = "No folder";
                return null;
            }
            var directory = new DirectoryInfo(folder);

            if (!directory.Exists)
            {
                labelFiles.Text = "Folder does not exist.";
                return null;
            }

            buttonImport.Enabled = false;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Visible = true;

            labelFiles.Text = "Scanning...";

            return directory;
        }

        private List<FileInfo> DoScan(DirectoryInfo directory)
        {
            if (directory == null) return null;

            var files = new List<FileInfo>();

            foreach (var file in directory.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {
                if (Scanner.CancellationPending) return null;

                if (FileHandlers.ContainsKey(file.Extension))
                    files.Add(file);
            }

            return files;
        }

        private void CompleteScan(List<FileInfo> files, bool canceled, Exception exception)
        {
            progressBar.Visible = false;

            if (exception != null)
            {
                labelFiles.Text = $"Exception: {exception.Message}";
            }
            else if (canceled)
            {
                labelFiles.Text = "Scan aborted.";
            }
            else if (files == null)
            {
                labelFiles.Text = "No files found.";
            }
            else
            {
                Files = files;                

                var groups = Files.GroupBy(f => f.Extension.ToLower()).Select(g => $"{g.Count():#,###} {g.Key.Substring(1)}-files");
                var text = $"Found {string.Join(", ", groups)}.";
                labelFiles.Text = text;
                if (Files.Count > 0)
                {
                    buttonImport.Enabled = true;
                }
            }
        }

        public BackgroundWorker<Profile, ImportStats> Importer { get; }

        private Profile InitImport()
        {
            textBoxSource.Enabled =
            buttonEdit.Enabled =
            comboBoxProfiles.Enabled =
            checkBoxOverwrite.Enabled =
            buttonSelect.Enabled = false;

            progressBar.Value = 0;
            progressBar.Maximum = Files.Count;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = true;

            buttonImport.Text = "&Abort";

            textBoxProtocol.Text = "";
            AddProtocol($"import from {textBoxSource.Text}");
            
            return Profile;
        }

        private ImportStats DoImport(Profile profile)
        {
            var stats = new ImportStats();

            AddProtocol($"profile {profile.Name}");

            foreach (var file in Files)
            {
                try
                {
                    if (Importer.CancellationPending) return stats;

                    if (checkBoxOnlyAfterLastImport.Checked && file.LastWriteTime < OnlyAfter)
                        stats.Skipped++;
                    else if (FileHandlers[file.Extension](file))
                        stats.Copied++;
                    else
                        stats.Skipped++;
                }
                catch (Exception exception)
                {
                    AddProtocol($"failed - {file.FullName}");
                    AddProtocol($"         {exception.Message}");
                    stats.Failed++;
                }
                Invoke((MethodInvoker)delegate
                {
                    progressBar.Value++;
                });
            }

            return stats;
        }

        private void CompletedImport(ImportStats stats, bool canceled, Exception exception)
        {
            progressBar.Visible = false;

            buttonImport.Text = "&Import";
            
            if (stats != null)
            {
                var results = new List<string>();

                if (stats.Copied > 0)
                    results.Add($"{stats.Copied:#,##0} copied");
                if (stats.Skipped > 0)
                    results.Add($"{stats.Skipped:#,##0} skipped");
                if (stats.Failed > 0)
                    results.Add($"{stats.Failed:#,##0} failed");
                var result = string.Join(", ", results);
                if (result.NotEmpty())
                    AddProtocol($"result - {result}");
            }

            if (canceled)
                AddProtocol("import aborted.");
            else if (exception != null)
            {
                AddProtocol($"import failed - {exception.Message}");
            }
            else
            {
                var state = new ImportState
                {
                    Timestamp = DateTime.Now,
                    Overwrite = checkBoxOverwrite.Checked,
                    OnlyAfterLastImport = checkBoxOnlyAfterLastImport.Checked,
                    ProfileName = Profile.Name
                };

                if (state.Save(textBoxSource.Text))
                {
                    AddProtocol("state saved");
                }

                AddProtocol($"import completed");
            }

            textBoxSource.Enabled =
            buttonSelect.Enabled =
            buttonEdit.Enabled =
            comboBoxProfiles.Enabled =
            checkBoxOverwrite.Enabled =
            buttonImport.Enabled = true;
        }

        private static Regex PatternReplacments { get; } = new Regex(@"\$\{(?<name>\w+)(:(?<format>[^}]+))?\}", RegexOptions.Compiled);

        private bool ImportFile(FileInfo file, string filename)
        {
            var directory = Path.GetDirectoryName(filename);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (checkBoxOverwrite.Checked || !File.Exists(filename))
            {
                file.CopyTo(filename, checkBoxOverwrite.Checked);
                return true;
            }
            return false;
        }

        private bool ImportImage(FileInfo file)
        {
            var metadata = new Metadata(file);
            var filename = PatternReplacments.Replace(Profile.ImageExpression, m => ReplaceImagePatterns(m, file, metadata));
            return ImportFile(file, filename);
        }

        private string ReplaceFilePatterns(Match match, FileInfo file)
        {
            var name = match.Groups["name"].Value;

            switch (name.ToLower())
            {
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

        private string ReplaceImagePatterns(Match match, FileInfo file, Metadata metadata)
        {
            var name = match.Groups["name"].Value;

            switch (name.ToLower())
            {
                case "taken":
                    {
                        var format = match.Groups["format"].Value ?? "yyyy-MM-dd-HH-mm-ss";
                        return metadata.DateTaken.ToString(format);
                    }
                default:
                    {
                        return ReplaceFilePatterns(match, file);
                    }
            }
        }

        private bool ImportRaw(FileInfo file)
        {
            var filename = PatternReplacments.Replace(Profile.RawExpression, m => ReplaceFilePatterns(m, file));
            return ImportFile(file, filename);
        }

        private bool ImportVideo(FileInfo file)
        {
            var filename = PatternReplacments.Replace(Profile.VideoExpression, m => ReplaceFilePatterns(m, file));
            return ImportFile(file, filename);
        }


        private void TextBoxSourceTextChanged(object sender, EventArgs e)
        {
            var state = ImportState.Load(textBoxSource.Text);
            if (state != null)
            {
                checkBoxOverwrite.Checked = state.Overwrite;
                var profile = ProfileContainer.Profiles.FirstOrDefault(p => p.Name == state.ProfileName);
                if (profile != null)
                    comboBoxProfiles.SelectedItem = profile;

                checkBoxOnlyAfterLastImport.Enabled = true;
                checkBoxOnlyAfterLastImport.Checked = state.OnlyAfterLastImport;
                OnlyAfter = state.Timestamp;
            }
            else
            {
                checkBoxOnlyAfterLastImport.Enabled = false;
                checkBoxOnlyAfterLastImport.Checked = false;
            }

            StartScan();
        }

        private void ButtonImportClick(object sender, EventArgs e)
        {
            if (Importer.Running)
            {
                buttonImport.Text = "Aborting...";
                buttonImport.Enabled = false;
                Importer.Cancel();
            }
            else
            {
                Importer.Start();
            }
        }

        private void RegisterFileHandlers(string extensions, Func<FileInfo, bool> handler)
        {
            var parts = extensions.Split(" .,;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                FileHandlers[$".{part}"] = handler;
            }
        }

        private void ImportFormFormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public ProfileContainer ProfileContainer { get; set; }

        private void ImportFormLoad(object sender, EventArgs e)
        {
            ProfileContainer = ProfileContainer.Get();

            comboBoxProfiles.DataSource = ProfileContainer.Profiles;
            comboBoxProfiles.DisplayMember = "Name";

            textBoxSource.Text = Options.Source;
            menuItemRegisterAutoplay.Checked = AutoPlayRegistration.IsRegistered(Registry.CurrentUser);
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

        #region
        private Profile profile;
        public Profile Profile 
        { 
            get => profile;
            set
            {
                profile = value;

                FileHandlers.Clear();

                if (profile != null)
                {
                    RegisterFileHandlers(Profile.ImageExtensions ?? "", ImportImage);
                    RegisterFileHandlers(Profile.RawExtensions ?? "", ImportRaw);
                    RegisterFileHandlers(Profile.VideoExtensions ?? "", ImportVideo);                   
                }
                StartScan();
            }
        }
        #endregion

        public DateTime OnlyAfter { get; set; } = DateTime.MinValue;

        public object Asssembly { get; private set; }

        private void ComboBoxProfilesSelectedValueChanged(object sender, EventArgs e)
        {
            Profile = (Profile)comboBoxProfiles.SelectedValue;
        }

        private void MenuItemQuitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemRegisterAutoplayClick(object sender, EventArgs e)
        {
            try
            {
                if (menuItemRegisterAutoplay.Checked)
                    AutoPlayRegistration.Unregister(Registry.CurrentUser);
                else
                    AutoPlayRegistration.Register(Registry.CurrentUser);

                menuItemRegisterAutoplay.Checked = !menuItemRegisterAutoplay.Checked;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemCheckUpdatesClick(object sender, EventArgs e)
        {
            try
            {
                UseWaitCursor = true;

                var updater = new GitHubUpdater("Calteo", "Image.Import");
                var latest = updater.GetLatestVersion();

                var version = new Version(latest.Version.Replace("v", ""));
                if (version > Assembly.GetExecutingAssembly().GetName().Version)
                {
                    var rc = MessageBox.Show(this, $"Latest version {latest.Name}\nPublished {latest.Published}\n\nInstall this version?", "Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rc == DialogResult.Yes)
                    {
                        updater.Install(latest);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, $"This is the newest version.", "Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception execption)
            {
                MessageBox.Show(this, execption.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void MenuItemVersionClick(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"Current version {Assembly.GetExecutingAssembly().GetName().Version}", "Installed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}