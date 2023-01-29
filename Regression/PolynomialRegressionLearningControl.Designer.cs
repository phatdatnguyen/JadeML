namespace JadeML.Regression
{
    partial class PolynomialRegressionLearningControl
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
            this.degreeLabel = new System.Windows.Forms.Label();
            this.DegreeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DegreeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Location = new System.Drawing.Point(55, 55);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(42, 13);
            this.degreeLabel.TabIndex = 2;
            this.degreeLabel.Text = "Degree";
            // 
            // DegreeNumericUpDown
            // 
            this.DegreeNumericUpDown.Location = new System.Drawing.Point(103, 53);
            this.DegreeNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DegreeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.DegreeNumericUpDown.Name = "DegreeNumericUpDown";
            this.DegreeNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.DegreeNumericUpDown.TabIndex = 3;
            this.DegreeNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(27, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(190, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Polynomial Regression";
            // 
            // PolynomialRegressionLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.DegreeNumericUpDown);
            this.Name = "PolynomialRegressionLearningControl";
            this.Size = new System.Drawing.Size(240, 98);
            ((System.ComponentModel.ISupportInitialize)(this.DegreeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.NumericUpDown DegreeNumericUpDown;
    }
}
