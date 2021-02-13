
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel.SuspendLayout();
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
            this.tableLayoutPanel.Controls.Add(this.textBoxProtocol, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.progressBar, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelProfile, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxProfiles, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonEdit, 2, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(832, 487);
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
            this.textBoxProtocol.Location = new System.Drawing.Point(3, 139);
            this.textBoxProtocol.MaxLength = 500000;
            this.textBoxProtocol.Multiline = true;
            this.textBoxProtocol.Name = "textBoxProtocol";
            this.textBoxProtocol.ReadOnly = true;
            this.textBoxProtocol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxProtocol.Size = new System.Drawing.Size(826, 345);
            this.textBoxProtocol.TabIndex = 5;
            this.textBoxProtocol.WordWrap = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel.SetColumnSpan(this.progressBar, 3);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 105);
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
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a source folder";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            this.folderBrowserDialog.UseDescriptionForTitle = true;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 487);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ImportForm";
            this.Text = "Image Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportFormFormClosing);
            this.Load += new System.EventHandler(this.ImportFormLoad);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

