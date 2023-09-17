namespace JadeChem.Dialogs
{
    partial class HiddenLayerDialog
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
            cancelButton = new Button();
            okButton = new Button();
            activationFunctionComboBox = new ComboBox();
            numberOfNeuronsNumericUpDown = new NumericUpDown();
            activationFunctionLabel = new Label();
            numberOfNeuronsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numberOfNeuronsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(257, 106);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(176, 106);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // activationFunctionComboBox
            // 
            activationFunctionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activationFunctionComboBox.FormattingEnabled = true;
            activationFunctionComboBox.Items.AddRange(new object[] { "LeakyReLU", "ReLU", "Sigmoid", "Tanh" });
            activationFunctionComboBox.Location = new Point(176, 42);
            activationFunctionComboBox.Name = "activationFunctionComboBox";
            activationFunctionComboBox.Size = new Size(121, 23);
            activationFunctionComboBox.TabIndex = 1;
            // 
            // numberOfNeuronsNumericUpDown
            // 
            numberOfNeuronsNumericUpDown.Location = new Point(28, 42);
            numberOfNeuronsNumericUpDown.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            numberOfNeuronsNumericUpDown.Name = "numberOfNeuronsNumericUpDown";
            numberOfNeuronsNumericUpDown.Size = new Size(120, 23);
            numberOfNeuronsNumericUpDown.TabIndex = 0;
            numberOfNeuronsNumericUpDown.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // activationFunctionLabel
            // 
            activationFunctionLabel.AutoSize = true;
            activationFunctionLabel.Location = new Point(176, 24);
            activationFunctionLabel.Name = "activationFunctionLabel";
            activationFunctionLabel.Size = new Size(109, 15);
            activationFunctionLabel.TabIndex = 0;
            activationFunctionLabel.Text = "Activation function";
            // 
            // numberOfNeuronsLabel
            // 
            numberOfNeuronsLabel.AutoSize = true;
            numberOfNeuronsLabel.Location = new Point(28, 24);
            numberOfNeuronsLabel.Name = "numberOfNeuronsLabel";
            numberOfNeuronsLabel.Size = new Size(113, 15);
            numberOfNeuronsLabel.TabIndex = 0;
            numberOfNeuronsLabel.Text = "Number of Neurons";
            // 
            // HiddenLayerDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = okButton;
            ClientSize = new Size(344, 141);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(activationFunctionComboBox);
            Controls.Add(numberOfNeuronsNumericUpDown);
            Controls.Add(activationFunctionLabel);
            Controls.Add(numberOfNeuronsLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HiddenLayerDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hidden Layer";
            FormClosing += AddHiddenLayerDialog_FormClosing;
            Load += HiddenLayerDialog_Load;
            ((System.ComponentModel.ISupportInitialize)numberOfNeuronsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button okButton;
        private ComboBox activationFunctionComboBox;
        private NumericUpDown numberOfNeuronsNumericUpDown;
        private Label activationFunctionLabel;
        private Label numberOfNeuronsLabel;
    }
}