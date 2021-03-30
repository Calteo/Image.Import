
namespace Image.Import
{
    partial class ProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelImageExtensions = new System.Windows.Forms.Label();
            this.labelImageExpression = new System.Windows.Forms.Label();
            this.labelRawExtensions = new System.Windows.Forms.Label();
            this.textBoxImageExtensions = new System.Windows.Forms.TextBox();
            this.textBoxImageExpression = new System.Windows.Forms.TextBox();
            this.textBoxRawExtensions = new System.Windows.Forms.TextBox();
            this.labelRawExpression = new System.Windows.Forms.Label();
            this.labelVideoExtensions = new System.Windows.Forms.Label();
            this.labelVideoFolder = new System.Windows.Forms.Label();
            this.textBoxRawExpression = new System.Windows.Forms.TextBox();
            this.textBoxVideoExtensions = new System.Windows.Forms.TextBox();
            this.textBoxVideoExpression = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelImageExtensions, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelImageExpression, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelRawExtensions, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxImageExtensions, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxImageExpression, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxRawExtensions, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelRawExpression, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelVideoExtensions, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelVideoFolder, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.textBoxRawExpression, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxVideoExtensions, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.textBoxVideoExpression, 1, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(649, 575);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 34);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(143, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(503, 27);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxNameTextChanged);
            // 
            // labelImageExtensions
            // 
            this.labelImageExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImageExtensions.Location = new System.Drawing.Point(3, 34);
            this.labelImageExtensions.Name = "labelImageExtensions";
            this.labelImageExtensions.Size = new System.Drawing.Size(134, 34);
            this.labelImageExtensions.TabIndex = 2;
            this.labelImageExtensions.Text = "Image Extension";
            this.labelImageExtensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelImageExpression
            // 
            this.labelImageExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImageExpression.Location = new System.Drawing.Point(3, 68);
            this.labelImageExpression.Name = "labelImageExpression";
            this.labelImageExpression.Size = new System.Drawing.Size(134, 34);
            this.labelImageExpression.TabIndex = 3;
            this.labelImageExpression.Text = "Image Folder";
            this.labelImageExpression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRawExtensions
            // 
            this.labelRawExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRawExtensions.Location = new System.Drawing.Point(3, 102);
            this.labelRawExtensions.Name = "labelRawExtensions";
            this.labelRawExtensions.Size = new System.Drawing.Size(134, 34);
            this.labelRawExtensions.TabIndex = 4;
            this.labelRawExtensions.Text = "Raw Extension";
            this.labelRawExtensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxImageExtensions
            // 
            this.textBoxImageExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImageExtensions.Location = new System.Drawing.Point(143, 37);
            this.textBoxImageExtensions.Name = "textBoxImageExtensions";
            this.textBoxImageExtensions.Size = new System.Drawing.Size(503, 27);
            this.textBoxImageExtensions.TabIndex = 5;
            this.textBoxImageExtensions.TextChanged += new System.EventHandler(this.TextBoxImageExtensionsTextChanged);
            // 
            // textBoxImageExpression
            // 
            this.textBoxImageExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImageExpression.Location = new System.Drawing.Point(143, 71);
            this.textBoxImageExpression.Name = "textBoxImageExpression";
            this.textBoxImageExpression.Size = new System.Drawing.Size(503, 27);
            this.textBoxImageExpression.TabIndex = 6;
            this.textBoxImageExpression.TextChanged += new System.EventHandler(this.TextBoxImageExpressionTextChanged);
            // 
            // textBoxRawExtensions
            // 
            this.textBoxRawExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRawExtensions.Location = new System.Drawing.Point(143, 105);
            this.textBoxRawExtensions.Name = "textBoxRawExtensions";
            this.textBoxRawExtensions.Size = new System.Drawing.Size(503, 27);
            this.textBoxRawExtensions.TabIndex = 7;
            this.textBoxRawExtensions.TextChanged += new System.EventHandler(this.TextBoxRawExtensionsTextChanged);
            // 
            // labelRawExpression
            // 
            this.labelRawExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRawExpression.Location = new System.Drawing.Point(3, 136);
            this.labelRawExpression.Name = "labelRawExpression";
            this.labelRawExpression.Size = new System.Drawing.Size(134, 34);
            this.labelRawExpression.TabIndex = 8;
            this.labelRawExpression.Text = "Raw Folder";
            this.labelRawExpression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVideoExtensions
            // 
            this.labelVideoExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVideoExtensions.Location = new System.Drawing.Point(3, 170);
            this.labelVideoExtensions.Name = "labelVideoExtensions";
            this.labelVideoExtensions.Size = new System.Drawing.Size(134, 34);
            this.labelVideoExtensions.TabIndex = 9;
            this.labelVideoExtensions.Text = "Video Extension";
            this.labelVideoExtensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVideoFolder
            // 
            this.labelVideoFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVideoFolder.Location = new System.Drawing.Point(3, 204);
            this.labelVideoFolder.Name = "labelVideoFolder";
            this.labelVideoFolder.Size = new System.Drawing.Size(134, 34);
            this.labelVideoFolder.TabIndex = 10;
            this.labelVideoFolder.Text = "Video Folder";
            this.labelVideoFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRawExpression
            // 
            this.textBoxRawExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRawExpression.Location = new System.Drawing.Point(143, 139);
            this.textBoxRawExpression.Name = "textBoxRawExpression";
            this.textBoxRawExpression.Size = new System.Drawing.Size(503, 27);
            this.textBoxRawExpression.TabIndex = 11;
            this.textBoxRawExpression.TextChanged += new System.EventHandler(this.TextBoxRawExpressionTextChanged);
            // 
            // textBoxVideoExtensions
            // 
            this.textBoxVideoExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVideoExtensions.Location = new System.Drawing.Point(143, 173);
            this.textBoxVideoExtensions.Name = "textBoxVideoExtensions";
            this.textBoxVideoExtensions.Size = new System.Drawing.Size(503, 27);
            this.textBoxVideoExtensions.TabIndex = 12;
            this.textBoxVideoExtensions.TextChanged += new System.EventHandler(this.TextBoxVideoExtensionsTextChanged);
            // 
            // textBoxVideoExpression
            // 
            this.textBoxVideoExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVideoExpression.Location = new System.Drawing.Point(143, 207);
            this.textBoxVideoExpression.Name = "textBoxVideoExpression";
            this.textBoxVideoExpression.Size = new System.Drawing.Size(503, 27);
            this.textBoxVideoExpression.TabIndex = 13;
            this.textBoxVideoExpression.TextChanged += new System.EventHandler(this.TextBoxVideoExpressionTextChanged);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(649, 575);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelImageExtensions;
        private System.Windows.Forms.Label labelImageExpression;
        private System.Windows.Forms.Label labelRawExtensions;
        private System.Windows.Forms.TextBox textBoxImageExtensions;
        private System.Windows.Forms.TextBox textBoxImageExpression;
        private System.Windows.Forms.TextBox textBoxRawExtensions;
        private System.Windows.Forms.Label labelRawExpression;
        private System.Windows.Forms.Label labelVideoExtensions;
        private System.Windows.Forms.Label labelVideoFolder;
        private System.Windows.Forms.TextBox textBoxRawExpression;
        private System.Windows.Forms.TextBox textBoxVideoExtensions;
        private System.Windows.Forms.TextBox textBoxVideoExpression;
    }
}
