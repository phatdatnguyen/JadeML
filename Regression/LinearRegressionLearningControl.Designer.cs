namespace JadeML.Regression
{
    partial class LinearRegressionLearningControl
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
            this.InterceptCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(28, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(155, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Linear Regression";
            // 
            // InterceptCheckBox
            // 
            this.InterceptCheckBox.AutoSize = true;
            this.InterceptCheckBox.Location = new System.Drawing.Point(63, 57);
            this.InterceptCheckBox.Name = "InterceptCheckBox";
            this.InterceptCheckBox.Size = new System.Drawing.Size(86, 17);
            this.InterceptCheckBox.TabIndex = 5;
            this.InterceptCheckBox.Text = "Intercept = 0";
            this.InterceptCheckBox.UseVisualStyleBackColor = true;
            // 
            // LinearRegressionLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InterceptCheckBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "LinearRegressionLearningControl";
            this.Size = new System.Drawing.Size(210, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.CheckBox InterceptCheckBox;
    }
}
