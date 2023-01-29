namespace JadeML.Classification
{
    partial class MultinomialLogisticRegressionLearningControl
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
            this.learningTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.methodGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ToleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BroydenFletcherGoldfarbShannoRadioButton = new System.Windows.Forms.RadioButton();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.GradientDescentRadioButton = new System.Windows.Forms.RadioButton();
            this.maxIterationLabel = new System.Windows.Forms.Label();
            this.ConjugateGradientRadioButton = new System.Windows.Forms.RadioButton();
            this.LowerBoundNewtonRaphsonRadioButton = new System.Windows.Forms.RadioButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.learningTableLayoutPanel.SuspendLayout();
            this.methodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // learningTableLayoutPanel
            // 
            this.learningTableLayoutPanel.ColumnCount = 1;
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.learningTableLayoutPanel.Controls.Add(this.methodGroupBox, 0, 1);
            this.learningTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.learningTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.learningTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.learningTableLayoutPanel.Name = "learningTableLayoutPanel";
            this.learningTableLayoutPanel.RowCount = 2;
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.learningTableLayoutPanel.Size = new System.Drawing.Size(500, 280);
            this.learningTableLayoutPanel.TabIndex = 0;
            // 
            // methodGroupBox
            // 
            this.methodGroupBox.Controls.Add(this.MaxIterationNumericUpDown);
            this.methodGroupBox.Controls.Add(this.ToleranceNumericUpDown);
            this.methodGroupBox.Controls.Add(this.BroydenFletcherGoldfarbShannoRadioButton);
            this.methodGroupBox.Controls.Add(this.toleranceLabel);
            this.methodGroupBox.Controls.Add(this.GradientDescentRadioButton);
            this.methodGroupBox.Controls.Add(this.maxIterationLabel);
            this.methodGroupBox.Controls.Add(this.ConjugateGradientRadioButton);
            this.methodGroupBox.Controls.Add(this.LowerBoundNewtonRaphsonRadioButton);
            this.methodGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodGroupBox.Location = new System.Drawing.Point(3, 63);
            this.methodGroupBox.Name = "methodGroupBox";
            this.methodGroupBox.Size = new System.Drawing.Size(494, 214);
            this.methodGroupBox.TabIndex = 0;
            this.methodGroupBox.TabStop = false;
            this.methodGroupBox.Text = "Learning method";
            // 
            // MaxIterationNumericUpDown
            // 
            this.MaxIterationNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxIterationNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Location = new System.Drawing.Point(256, 65);
            this.MaxIterationNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Name = "MaxIterationNumericUpDown";
            this.MaxIterationNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.MaxIterationNumericUpDown.TabIndex = 1;
            this.MaxIterationNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ToleranceNumericUpDown
            // 
            this.ToleranceNumericUpDown.DecimalPlaces = 4;
            this.ToleranceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.ToleranceNumericUpDown.Location = new System.Drawing.Point(256, 90);
            this.ToleranceNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ToleranceNumericUpDown.Name = "ToleranceNumericUpDown";
            this.ToleranceNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.ToleranceNumericUpDown.TabIndex = 2;
            this.ToleranceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // BroydenFletcherGoldfarbShannoRadioButton
            // 
            this.BroydenFletcherGoldfarbShannoRadioButton.AutoSize = true;
            this.BroydenFletcherGoldfarbShannoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BroydenFletcherGoldfarbShannoRadioButton.Location = new System.Drawing.Point(78, 187);
            this.BroydenFletcherGoldfarbShannoRadioButton.Name = "BroydenFletcherGoldfarbShannoRadioButton";
            this.BroydenFletcherGoldfarbShannoRadioButton.Size = new System.Drawing.Size(188, 17);
            this.BroydenFletcherGoldfarbShannoRadioButton.TabIndex = 5;
            this.BroydenFletcherGoldfarbShannoRadioButton.Text = "Broyden-Fletcher-Goldfarb-Shanno";
            this.BroydenFletcherGoldfarbShannoRadioButton.UseVisualStyleBackColor = true;
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceLabel.Location = new System.Drawing.Point(195, 92);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(55, 13);
            this.toleranceLabel.TabIndex = 0;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // GradientDescentRadioButton
            // 
            this.GradientDescentRadioButton.AutoSize = true;
            this.GradientDescentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradientDescentRadioButton.Location = new System.Drawing.Point(78, 155);
            this.GradientDescentRadioButton.Name = "GradientDescentRadioButton";
            this.GradientDescentRadioButton.Size = new System.Drawing.Size(106, 17);
            this.GradientDescentRadioButton.TabIndex = 4;
            this.GradientDescentRadioButton.Text = "Gradient descent";
            this.GradientDescentRadioButton.UseVisualStyleBackColor = true;
            // 
            // maxIterationLabel
            // 
            this.maxIterationLabel.AutoSize = true;
            this.maxIterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxIterationLabel.Location = new System.Drawing.Point(183, 67);
            this.maxIterationLabel.Name = "maxIterationLabel";
            this.maxIterationLabel.Size = new System.Drawing.Size(67, 13);
            this.maxIterationLabel.TabIndex = 0;
            this.maxIterationLabel.Text = "Max iteration";
            // 
            // ConjugateGradientRadioButton
            // 
            this.ConjugateGradientRadioButton.AutoSize = true;
            this.ConjugateGradientRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConjugateGradientRadioButton.Location = new System.Drawing.Point(78, 123);
            this.ConjugateGradientRadioButton.Name = "ConjugateGradientRadioButton";
            this.ConjugateGradientRadioButton.Size = new System.Drawing.Size(114, 17);
            this.ConjugateGradientRadioButton.TabIndex = 3;
            this.ConjugateGradientRadioButton.Text = "Conjugate gradient";
            this.ConjugateGradientRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerBoundNewtonRaphsonRadioButton
            // 
            this.LowerBoundNewtonRaphsonRadioButton.AutoSize = true;
            this.LowerBoundNewtonRaphsonRadioButton.Checked = true;
            this.LowerBoundNewtonRaphsonRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerBoundNewtonRaphsonRadioButton.Location = new System.Drawing.Point(78, 32);
            this.LowerBoundNewtonRaphsonRadioButton.Name = "LowerBoundNewtonRaphsonRadioButton";
            this.LowerBoundNewtonRaphsonRadioButton.Size = new System.Drawing.Size(173, 17);
            this.LowerBoundNewtonRaphsonRadioButton.TabIndex = 0;
            this.LowerBoundNewtonRaphsonRadioButton.TabStop = true;
            this.LowerBoundNewtonRaphsonRadioButton.Text = "Lower bound Newton-Raphson";
            this.LowerBoundNewtonRaphsonRadioButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(494, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Multinomial Logistic Regression - Learning";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultinomialLogisticRegressionLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.learningTableLayoutPanel);
            this.Name = "MultinomialLogisticRegressionLearningControl";
            this.Size = new System.Drawing.Size(500, 280);
            this.learningTableLayoutPanel.ResumeLayout(false);
            this.learningTableLayoutPanel.PerformLayout();
            this.methodGroupBox.ResumeLayout(false);
            this.methodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel learningTableLayoutPanel;
        private System.Windows.Forms.GroupBox methodGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.Label maxIterationLabel;
        public System.Windows.Forms.NumericUpDown MaxIterationNumericUpDown;
        public System.Windows.Forms.NumericUpDown ToleranceNumericUpDown;
        public System.Windows.Forms.RadioButton BroydenFletcherGoldfarbShannoRadioButton;
        public System.Windows.Forms.RadioButton GradientDescentRadioButton;
        public System.Windows.Forms.RadioButton ConjugateGradientRadioButton;
        public System.Windows.Forms.RadioButton LowerBoundNewtonRaphsonRadioButton;
    }
}
