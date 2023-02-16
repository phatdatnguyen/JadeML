namespace JadeML
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.facultyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.universityLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.contactLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel.Controls.Add(this.facultyLogoPictureBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.universityLogoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.productNameLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.versionLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.copyrightLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.authorLabel, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.descriptionTextBox, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.contactLinkLabel, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 310);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // facultyLogoPictureBox
            // 
            this.facultyLogoPictureBox.Image = global::JadeML.Properties.Resources.FacultyLogo;
            this.facultyLogoPictureBox.Location = new System.Drawing.Point(3, 96);
            this.facultyLogoPictureBox.Name = "facultyLogoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.facultyLogoPictureBox, 2);
            this.facultyLogoPictureBox.Size = new System.Drawing.Size(87, 87);
            this.facultyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facultyLogoPictureBox.TabIndex = 25;
            this.facultyLogoPictureBox.TabStop = false;
            // 
            // universityLogoPictureBox
            // 
            this.universityLogoPictureBox.Image = global::JadeML.Properties.Resources.UniversityLogo;
            this.universityLogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.universityLogoPictureBox.Name = "universityLogoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.universityLogoPictureBox, 3);
            this.universityLogoPictureBox.Size = new System.Drawing.Size(87, 87);
            this.universityLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.universityLogoPictureBox.TabIndex = 12;
            this.universityLogoPictureBox.TabStop = false;
            // 
            // productNameLabel
            // 
            this.productNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(110, 0);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.productNameLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(304, 17);
            this.productNameLabel.TabIndex = 19;
            this.productNameLabel.Text = "Product Name";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionLabel.Location = new System.Drawing.Point(110, 31);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.versionLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(304, 17);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "Version";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyrightLabel.Location = new System.Drawing.Point(110, 62);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.copyrightLabel.MaximumSize = new System.Drawing.Size(0, 17);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(304, 17);
            this.copyrightLabel.TabIndex = 21;
            this.copyrightLabel.Text = "Copyright";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(110, 93);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(82, 13);
            this.authorLabel.TabIndex = 22;
            this.authorLabel.Text = "Company Name";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(110, 189);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.Size = new System.Drawing.Size(304, 87);
            this.descriptionTextBox.TabIndex = 23;
            this.descriptionTextBox.TabStop = false;
            this.descriptionTextBox.Text = "A GUI software for simple machine learning (ML) tasks in Windows.";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(339, 285);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 22);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // contactLinkLabel
            // 
            this.contactLinkLabel.AutoSize = true;
            this.contactLinkLabel.Location = new System.Drawing.Point(107, 155);
            this.contactLinkLabel.Name = "contactLinkLabel";
            this.contactLinkLabel.Size = new System.Drawing.Size(44, 13);
            this.contactLinkLabel.TabIndex = 26;
            this.contactLinkLabel.TabStop = true;
            this.contactLinkLabel.Text = "Contact";
            this.contactLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactLinkLabel_LinkClicked);
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(435, 328);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About JadeML";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox universityLogoPictureBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox facultyLogoPictureBox;
        private System.Windows.Forms.LinkLabel contactLinkLabel;
    }
}
