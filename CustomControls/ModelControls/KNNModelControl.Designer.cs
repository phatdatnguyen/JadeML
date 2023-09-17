namespace JadeChem.CustomControls.ModelControls
{
    partial class KNNModelControl
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
            knnLabel = new Label();
            kLabel = new Label();
            kNumericUpDown = new NumericUpDown();
            trainButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)kNumericUpDown).BeginInit();
            hyperparametersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // knnLabel
            // 
            knnLabel.AutoSize = true;
            knnLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            knnLabel.Location = new Point(20, 20);
            knnLabel.Name = "knnLabel";
            knnLabel.Size = new Size(124, 15);
            knnLabel.TabIndex = 0;
            knnLabel.Text = "K-Nearest Neighbors";
            // 
            // kLabel
            // 
            kLabel.AutoSize = true;
            kLabel.Location = new Point(6, 24);
            kLabel.Name = "kLabel";
            kLabel.Size = new Size(24, 15);
            kLabel.TabIndex = 0;
            kLabel.Text = "k =";
            // 
            // kNumericUpDown
            // 
            kNumericUpDown.Location = new Point(36, 22);
            kNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            kNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            kNumericUpDown.Name = "kNumericUpDown";
            kNumericUpDown.Size = new Size(120, 23);
            kNumericUpDown.TabIndex = 0;
            kNumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            kNumericUpDown.ValueChanged += KNumericUpDown_ValueChanged;
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 116);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 1;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(kNumericUpDown);
            hyperparametersGroupBox.Controls.Add(kLabel);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(170, 60);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // KNNModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainButton);
            Controls.Add(knnLabel);
            Name = "KNNModelControl";
            Size = new Size(790, 350);
            ((System.ComponentModel.ISupportInitialize)kNumericUpDown).EndInit();
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label knnLabel;
        private Label kLabel;
        private NumericUpDown kNumericUpDown;
        private Button trainButton;
        private GroupBox hyperparametersGroupBox;
    }
}
