namespace JadeML.Classification
{
    partial class RandomForestLearningControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.SampleRatioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sampleRatioLabel = new System.Windows.Forms.Label();
            this.NumberOfTreesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfTreesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SampleRatioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTreesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(24, 20);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(378, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Random Forest - Learning Parameters";
            // 
            // SampleRatioNumericUpDown
            // 
            this.SampleRatioNumericUpDown.DecimalPlaces = 3;
            this.SampleRatioNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.SampleRatioNumericUpDown.Location = new System.Drawing.Point(232, 95);
            this.SampleRatioNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SampleRatioNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SampleRatioNumericUpDown.Name = "SampleRatioNumericUpDown";
            this.SampleRatioNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.SampleRatioNumericUpDown.TabIndex = 1;
            this.SampleRatioNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // sampleRatioLabel
            // 
            this.sampleRatioLabel.AutoSize = true;
            this.sampleRatioLabel.Location = new System.Drawing.Point(140, 97);
            this.sampleRatioLabel.Name = "sampleRatioLabel";
            this.sampleRatioLabel.Size = new System.Drawing.Size(83, 16);
            this.sampleRatioLabel.TabIndex = 0;
            this.sampleRatioLabel.Text = "Sample ratio";
            // 
            // NumberOfTreesNumericUpDown
            // 
            this.NumberOfTreesNumericUpDown.Location = new System.Drawing.Point(232, 65);
            this.NumberOfTreesNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberOfTreesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfTreesNumericUpDown.Name = "NumberOfTreesNumericUpDown";
            this.NumberOfTreesNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.NumberOfTreesNumericUpDown.TabIndex = 0;
            this.NumberOfTreesNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numberOfTreesLabel
            // 
            this.numberOfTreesLabel.AutoSize = true;
            this.numberOfTreesLabel.Location = new System.Drawing.Point(117, 68);
            this.numberOfTreesLabel.Name = "numberOfTreesLabel";
            this.numberOfTreesLabel.Size = new System.Drawing.Size(102, 16);
            this.numberOfTreesLabel.TabIndex = 0;
            this.numberOfTreesLabel.Text = "Number of trees";
            // 
            // RandomForestLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumberOfTreesNumericUpDown);
            this.Controls.Add(this.numberOfTreesLabel);
            this.Controls.Add(this.SampleRatioNumericUpDown);
            this.Controls.Add(this.sampleRatioLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RandomForestLearningControl";
            this.Size = new System.Drawing.Size(467, 150);
            ((System.ComponentModel.ISupportInitialize)(this.SampleRatioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTreesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label sampleRatioLabel;
        private System.Windows.Forms.Label numberOfTreesLabel;
        public System.Windows.Forms.NumericUpDown SampleRatioNumericUpDown;
        public System.Windows.Forms.NumericUpDown NumberOfTreesNumericUpDown;
    }
}
