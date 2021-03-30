
namespace Image.Import
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.listBoxProfiles = new System.Windows.Forms.ListBox();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.profileControl = new Image.Import.ProfileControl();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel.Controls.Add(this.buttonOk, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonCancel, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonNew, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.listBoxProfiles, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBoxProfile, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonDelete, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(941, 596);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOk.Location = new System.Drawing.Point(683, 565);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(124, 28);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(813, 565);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNew.Location = new System.Drawing.Point(3, 565);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(114, 28);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNewClick);
            // 
            // listBoxProfiles
            // 
            this.tableLayoutPanel.SetColumnSpan(this.listBoxProfiles, 3);
            this.listBoxProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.IntegralHeight = false;
            this.listBoxProfiles.ItemHeight = 20;
            this.listBoxProfiles.Location = new System.Drawing.Point(3, 3);
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxProfiles.Size = new System.Drawing.Size(322, 556);
            this.listBoxProfiles.Sorted = true;
            this.listBoxProfiles.TabIndex = 5;
            this.listBoxProfiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxProfilesSelectedIndexChanged);
            // 
            // groupBoxProfile
            // 
            this.tableLayoutPanel.SetColumnSpan(this.groupBoxProfile, 3);
            this.groupBoxProfile.Controls.Add(this.profileControl);
            this.groupBoxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProfile.Location = new System.Drawing.Point(331, 3);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(607, 556);
            this.groupBoxProfile.TabIndex = 6;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Profile";
            // 
            // profileControl
            // 
            this.profileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileControl.Location = new System.Drawing.Point(3, 23);
            this.profileControl.Name = "profileControl";
            this.profileControl.Profile = null;
            this.profileControl.Size = new System.Drawing.Size(601, 530);
            this.profileControl.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(211, 565);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 28);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // ProfileForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(941, 596);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.ProfileFormLoad);
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBoxProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ListBox listBoxProfiles;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private ProfileControl profileControl;
        private System.Windows.Forms.Button buttonDelete;
    }
}