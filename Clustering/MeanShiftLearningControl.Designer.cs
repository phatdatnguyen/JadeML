namespace JadeML.Clustering
{
    partial class MeanShiftLearningControl
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
            this.RadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RadiusNumericUpDown
            // 
            this.RadiusNumericUpDown.DecimalPlaces = 4;
            this.RadiusNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.RadiusNumericUpDown.Location = new System.Drawing.Point(96, 53);
            this.RadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            this.RadiusNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.RadiusNumericUpDown.TabIndex = 0;
            this.RadiusNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(41, 55);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(49, 13);
            this.radiusLabel.TabIndex = 0;
            this.radiusLabel.Text = "Radius =";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(55, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(96, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Mean Shift";
            // 
            // MeanShiftLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadiusNumericUpDown);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MeanShiftLearningControl";
            this.Size = new System.Drawing.Size(210, 98);
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown RadiusNumericUpDown;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
