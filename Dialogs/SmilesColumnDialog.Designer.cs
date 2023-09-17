namespace JadeChem.Dialogs
{
    partial class SmilesColumnDialog
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
            okButton = new Button();
            cancelButton = new Button();
            smilesColumnLabel = new Label();
            columnComboBox = new ComboBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(179, 107);
            okButton.Margin = new Padding(2);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(258, 107);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // smilesColumnLabel
            // 
            smilesColumnLabel.AutoSize = true;
            smilesColumnLabel.Location = new Point(12, 26);
            smilesColumnLabel.Margin = new Padding(2, 0, 2, 0);
            smilesColumnLabel.Name = "smilesColumnLabel";
            smilesColumnLabel.Size = new Size(300, 15);
            smilesColumnLabel.TabIndex = 0;
            smilesColumnLabel.Text = "Choose a column contains the SMILES of the molecules";
            // 
            // columnComboBox
            // 
            columnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            columnComboBox.FormattingEnabled = true;
            columnComboBox.Location = new Point(12, 44);
            columnComboBox.Name = "columnComboBox";
            columnComboBox.Size = new Size(320, 23);
            columnComboBox.TabIndex = 0;
            // 
            // SmilesColumnDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(344, 141);
            Controls.Add(columnComboBox);
            Controls.Add(smilesColumnLabel);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SmilesColumnDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SMILES Column";
            FormClosing += EditSplitRatioDialog_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private Label smilesColumnLabel;
        private ComboBox columnComboBox;
    }
}