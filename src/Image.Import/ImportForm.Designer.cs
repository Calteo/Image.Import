
namespace Image.Import
{
    partial class ImportForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelSource = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelFiles = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.textBoxProtocol = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProfile = new System.Windows.Forms.Label();
            this.comboBoxProfiles = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.checkBoxOnlyAfterLastImport = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegisterAutoplay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.Controls.Add(this.labelSource, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxSource, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonSelect, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.labelFiles, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonImport, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxProtocol, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.progressBar, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelProfile, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxProfiles, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonEdit, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.checkBoxOverwrite, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.checkBoxOnlyAfterLastImport, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(832, 463);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelSource
            // 
            this.labelSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSource.Location = new System.Drawing.Point(3, 0);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(144, 34);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";
            this.labelSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource.Location = new System.Drawing.Point(153, 3);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(526, 27);
            this.textBoxSource.TabIndex = 1;
            this.textBoxSource.TextChanged += new System.EventHandler(this.TextBoxSourceTextChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelect.Location = new System.Drawing.Point(685, 3);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(144, 28);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "&Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelectClick);
            // 
            // labelFiles
            // 
            this.labelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFiles.Location = new System.Drawing.Point(153, 34);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(526, 34);
            this.labelFiles.TabIndex = 3;
            this.labelFiles.Text = "Found 0 files.";
            this.labelFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonImport
            // 
            this.buttonImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(685, 37);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(144, 28);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "&Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.ButtonImportClick);
            // 
            // textBoxProtocol
            // 
            this.textBoxProtocol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.textBoxProtocol, 3);
            this.textBoxProtocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProtocol.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProtocol.Location = new System.Drawing.Point(3, 207);
            this.textBoxProtocol.MaxLength = 500000;
            this.textBoxProtocol.Multiline = true;
            this.textBoxProtocol.Name = "textBoxProtocol";
            this.textBoxProtocol.ReadOnly = true;
            this.textBoxProtocol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxProtocol.Size = new System.Drawing.Size(826, 253);
            this.textBoxProtocol.TabIndex = 5;
            this.textBoxProtocol.WordWrap = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel.SetColumnSpan(this.progressBar, 3);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 173);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(826, 28);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProfile.Location = new System.Drawing.Point(3, 68);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(144, 34);
            this.labelProfile.TabIndex = 7;
            this.labelProfile.Text = "Profile";
            this.labelProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxProfiles
            // 
            this.comboBoxProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfiles.Location = new System.Drawing.Point(153, 71);
            this.comboBoxProfiles.Name = "comboBoxProfiles";
            this.comboBoxProfiles.Size = new System.Drawing.Size(526, 28);
            this.comboBoxProfiles.Sorted = true;
            this.comboBoxProfiles.TabIndex = 8;
            this.comboBoxProfiles.SelectedValueChanged += new System.EventHandler(this.comboBoxProfiles_SelectedValueChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.Location = new System.Drawing.Point(685, 71);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(144, 28);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(153, 105);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(526, 28);
            this.checkBoxOverwrite.TabIndex = 10;
            this.checkBoxOverwrite.Text = "Overwrite existing files";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnlyAfterLastImport
            // 
            this.checkBoxOnlyAfterLastImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOnlyAfterLastImport.Enabled = false;
            this.checkBoxOnlyAfterLastImport.Location = new System.Drawing.Point(153, 139);
            this.checkBoxOnlyAfterLastImport.Name = "checkBoxOnlyAfterLastImport";
            this.checkBoxOnlyAfterLastImport.Size = new System.Drawing.Size(526, 28);
            this.checkBoxOnlyAfterLastImport.TabIndex = 11;
            this.checkBoxOnlyAfterLastImport.Text = "Only files newer than last import";
            this.checkBoxOnlyAfterLastImport.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a source folder";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            this.folderBrowserDialog.UseDescriptionForTitle = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(832, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRegisterAutoplay,
            this.toolStripSeparator1,
            this.menuItemQuit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemRegisterAutoplay
            // 
            this.menuItemRegisterAutoplay.Name = "menuItemRegisterAutoplay";
            this.menuItemRegisterAutoplay.Size = new System.Drawing.Size(188, 22);
            this.menuItemRegisterAutoplay.Text = "Autoplay Registration";
            this.menuItemRegisterAutoplay.Click += new System.EventHandler(this.MenuItemRegisterAutoplayClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemQuit.Size = new System.Drawing.Size(188, 22);
            this.menuItemQuit.Text = "&Quit";
            this.menuItemQuit.Click += new System.EventHandler(this.MenuItemQuitClick);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCheckUpdates,
            this.toolStripSeparator2,
            this.menuItemVersion});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "Help";
            // 
            // menuItemCheckUpdates
            // 
            this.menuItemCheckUpdates.Name = "menuItemCheckUpdates";
            this.menuItemCheckUpdates.Size = new System.Drawing.Size(152, 22);
            this.menuItemCheckUpdates.Text = "Check updates";
            this.menuItemCheckUpdates.Click += new System.EventHandler(this.MenuItemCheckUpdatesClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemVersion
            // 
            this.menuItemVersion.Name = "menuItemVersion";
            this.menuItemVersion.Size = new System.Drawing.Size(152, 22);
            this.menuItemVersion.Text = "Version";
            this.menuItemVersion.Click += new System.EventHandler(this.MenuItemVersionClick);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 487);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportForm";
            this.Text = "Image Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportFormFormClosing);
            this.Load += new System.EventHandler(this.ImportFormLoad);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.TextBox textBoxProtocol;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.ComboBox comboBoxProfiles;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.CheckBox checkBoxOnlyAfterLastImport;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegisterAutoplay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheckUpdates;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

