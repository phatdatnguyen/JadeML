namespace JadeChem.Dialogs
{
    partial class MulticlassClassificationModelSelectionDialog
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
            modelLabel = new Label();
            modelComboBox = new ComboBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(11, 45);
            modelLabel.Margin = new Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(41, 15);
            modelLabel.TabIndex = 0;
            modelLabel.Text = "Model";
            // 
            // modelComboBox
            // 
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Items.AddRange(new object[] { "K-Nearest Neighbors", "Decision Tree", "Random Forest", "Multinomial Logistic Regression", "Support Vector Machine", "Multilayer Perceptron" });
            modelComboBox.Location = new Point(56, 42);
            modelComboBox.Margin = new Padding(2);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(277, 23);
            modelComboBox.TabIndex = 0;
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
            // MulticlassClassificationModelSelectionDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(344, 141);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(modelComboBox);
            Controls.Add(modelLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MulticlassClassificationModelSelectionDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multiclass Classification Model";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modelLabel;
        private ComboBox modelComboBox;
        private Button okButton;
        private Button cancelButton;
    }
}