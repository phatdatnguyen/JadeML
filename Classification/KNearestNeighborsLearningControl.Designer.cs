namespace JadeML.Classification
{
    partial class KNearestNeighborsLearningControl
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
            this.KNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(17, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(173, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "k-Nearest Neighbors";
            // 
            // KNumericUpDown
            // 
            this.KNumericUpDown.Location = new System.Drawing.Point(81, 53);
            this.KNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KNumericUpDown.Name = "KNumericUpDown";
            this.KNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.KNumericUpDown.TabIndex = 0;
            this.KNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(53, 55);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(22, 13);
            this.kLabel.TabIndex = 0;
            this.kLabel.Text = "k =";
            // 
            // KNearestNeighborsLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KNumericUpDown);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "KNearestNeighborsLearningControl";
            this.Size = new System.Drawing.Size(210, 98);
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label kLabel;
        public System.Windows.Forms.NumericUpDown KNumericUpDown;
    }
}
