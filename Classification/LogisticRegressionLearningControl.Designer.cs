namespace JadeML.Classification
{
    partial class LogisticRegressionLearningControl
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
            this.RegularizationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.regularizationLabel = new System.Windows.Forms.Label();
            this.IterativeReweightedLeastSquaresRadioButton = new System.Windows.Forms.RadioButton();
            this.StochasticCheckBox = new System.Windows.Forms.CheckBox();
            this.LearningRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningRateLabel = new System.Windows.Forms.Label();
            this.LogisticGradientDescentRadioButton = new System.Windows.Forms.RadioButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.learningPanel = new System.Windows.Forms.Panel();
            this.MaxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ToleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.maxIterationLabel = new System.Windows.Forms.Label();
            this.learningTableLayoutPanel.SuspendLayout();
            this.methodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegularizationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateNumericUpDown)).BeginInit();
            this.learningPanel.SuspendLayout();
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
            this.learningTableLayoutPanel.Controls.Add(this.learningPanel, 0, 2);
            this.learningTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.learningTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.learningTableLayoutPanel.Name = "learningTableLayoutPanel";
            this.learningTableLayoutPanel.RowCount = 3;
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.learningTableLayoutPanel.Size = new System.Drawing.Size(360, 292);
            this.learningTableLayoutPanel.TabIndex = 0;
            // 
            // methodGroupBox
            // 
            this.methodGroupBox.Controls.Add(this.RegularizationNumericUpDown);
            this.methodGroupBox.Controls.Add(this.regularizationLabel);
            this.methodGroupBox.Controls.Add(this.IterativeReweightedLeastSquaresRadioButton);
            this.methodGroupBox.Controls.Add(this.StochasticCheckBox);
            this.methodGroupBox.Controls.Add(this.LearningRateNumericUpDown);
            this.methodGroupBox.Controls.Add(this.learningRateLabel);
            this.methodGroupBox.Controls.Add(this.LogisticGradientDescentRadioButton);
            this.methodGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodGroupBox.Location = new System.Drawing.Point(3, 52);
            this.methodGroupBox.Name = "methodGroupBox";
            this.methodGroupBox.Size = new System.Drawing.Size(354, 151);
            this.methodGroupBox.TabIndex = 0;
            this.methodGroupBox.TabStop = false;
            this.methodGroupBox.Text = "Learning method";
            // 
            // RegularizationNumericUpDown
            // 
            this.RegularizationNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegularizationNumericUpDown.Location = new System.Drawing.Point(149, 118);
            this.RegularizationNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.RegularizationNumericUpDown.Name = "RegularizationNumericUpDown";
            this.RegularizationNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.RegularizationNumericUpDown.TabIndex = 4;
            // 
            // regularizationLabel
            // 
            this.regularizationLabel.AutoSize = true;
            this.regularizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularizationLabel.Location = new System.Drawing.Point(71, 120);
            this.regularizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regularizationLabel.Name = "regularizationLabel";
            this.regularizationLabel.Size = new System.Drawing.Size(74, 13);
            this.regularizationLabel.TabIndex = 0;
            this.regularizationLabel.Text = "Regularization";
            // 
            // IterativeReweightedLeastSquaresRadioButton
            // 
            this.IterativeReweightedLeastSquaresRadioButton.AutoSize = true;
            this.IterativeReweightedLeastSquaresRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterativeReweightedLeastSquaresRadioButton.Location = new System.Drawing.Point(39, 97);
            this.IterativeReweightedLeastSquaresRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.IterativeReweightedLeastSquaresRadioButton.Name = "IterativeReweightedLeastSquaresRadioButton";
            this.IterativeReweightedLeastSquaresRadioButton.Size = new System.Drawing.Size(194, 17);
            this.IterativeReweightedLeastSquaresRadioButton.TabIndex = 3;
            this.IterativeReweightedLeastSquaresRadioButton.Text = "Iterative Reweighted Least Squares";
            this.IterativeReweightedLeastSquaresRadioButton.UseVisualStyleBackColor = true;
            // 
            // StochasticCheckBox
            // 
            this.StochasticCheckBox.AutoSize = true;
            this.StochasticCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StochasticCheckBox.Location = new System.Drawing.Point(230, 58);
            this.StochasticCheckBox.Name = "StochasticCheckBox";
            this.StochasticCheckBox.Size = new System.Drawing.Size(76, 17);
            this.StochasticCheckBox.TabIndex = 2;
            this.StochasticCheckBox.Text = "Stochastic";
            this.StochasticCheckBox.UseVisualStyleBackColor = true;
            // 
            // LearningRateNumericUpDown
            // 
            this.LearningRateNumericUpDown.DecimalPlaces = 2;
            this.LearningRateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningRateNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LearningRateNumericUpDown.Location = new System.Drawing.Point(149, 57);
            this.LearningRateNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LearningRateNumericUpDown.Name = "LearningRateNumericUpDown";
            this.LearningRateNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.LearningRateNumericUpDown.TabIndex = 1;
            this.LearningRateNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // learningRateLabel
            // 
            this.learningRateLabel.AutoSize = true;
            this.learningRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningRateLabel.Location = new System.Drawing.Point(74, 59);
            this.learningRateLabel.Name = "learningRateLabel";
            this.learningRateLabel.Size = new System.Drawing.Size(69, 13);
            this.learningRateLabel.TabIndex = 0;
            this.learningRateLabel.Text = "Learning rate";
            // 
            // LogisticGradientDescentRadioButton
            // 
            this.LogisticGradientDescentRadioButton.AutoSize = true;
            this.LogisticGradientDescentRadioButton.Checked = true;
            this.LogisticGradientDescentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogisticGradientDescentRadioButton.Location = new System.Drawing.Point(39, 34);
            this.LogisticGradientDescentRadioButton.Name = "LogisticGradientDescentRadioButton";
            this.LogisticGradientDescentRadioButton.Size = new System.Drawing.Size(147, 17);
            this.LogisticGradientDescentRadioButton.TabIndex = 0;
            this.LogisticGradientDescentRadioButton.TabStop = true;
            this.LogisticGradientDescentRadioButton.Text = "Logistic Gradient Descent";
            this.LogisticGradientDescentRadioButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(354, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Logistic Regression - Learning Parameters";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // learningPanel
            // 
            this.learningPanel.Controls.Add(this.MaxIterationNumericUpDown);
            this.learningPanel.Controls.Add(this.ToleranceNumericUpDown);
            this.learningPanel.Controls.Add(this.toleranceLabel);
            this.learningPanel.Controls.Add(this.maxIterationLabel);
            this.learningPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningPanel.Location = new System.Drawing.Point(2, 208);
            this.learningPanel.Margin = new System.Windows.Forms.Padding(2);
            this.learningPanel.Name = "learningPanel";
            this.learningPanel.Size = new System.Drawing.Size(356, 82);
            this.learningPanel.TabIndex = 1;
            // 
            // MaxIterationNumericUpDown
            // 
            this.MaxIterationNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Location = new System.Drawing.Point(150, 43);
            this.MaxIterationNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxIterationNumericUpDown.Name = "MaxIterationNumericUpDown";
            this.MaxIterationNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxIterationNumericUpDown.TabIndex = 0;
            this.MaxIterationNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ToleranceNumericUpDown
            // 
            this.ToleranceNumericUpDown.DecimalPlaces = 4;
            this.ToleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.ToleranceNumericUpDown.Location = new System.Drawing.Point(150, 17);
            this.ToleranceNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ToleranceNumericUpDown.Name = "ToleranceNumericUpDown";
            this.ToleranceNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.ToleranceNumericUpDown.TabIndex = 1;
            this.ToleranceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Location = new System.Drawing.Point(89, 19);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(55, 13);
            this.toleranceLabel.TabIndex = 0;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // maxIterationLabel
            // 
            this.maxIterationLabel.AutoSize = true;
            this.maxIterationLabel.Location = new System.Drawing.Point(77, 45);
            this.maxIterationLabel.Name = "maxIterationLabel";
            this.maxIterationLabel.Size = new System.Drawing.Size(67, 13);
            this.maxIterationLabel.TabIndex = 0;
            this.maxIterationLabel.Text = "Max iteration";
            // 
            // LogisticRegressionLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.learningTableLayoutPanel);
            this.Name = "LogisticRegressionLearningControl";
            this.Size = new System.Drawing.Size(360, 292);
            this.learningTableLayoutPanel.ResumeLayout(false);
            this.learningTableLayoutPanel.PerformLayout();
            this.methodGroupBox.ResumeLayout(false);
            this.methodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegularizationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateNumericUpDown)).EndInit();
            this.learningPanel.ResumeLayout(false);
            this.learningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel learningTableLayoutPanel;
        private System.Windows.Forms.GroupBox methodGroupBox;
        private System.Windows.Forms.Label regularizationLabel;
        private System.Windows.Forms.Label learningRateLabel;
        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.NumericUpDown RegularizationNumericUpDown;
        public System.Windows.Forms.RadioButton IterativeReweightedLeastSquaresRadioButton;
        public System.Windows.Forms.CheckBox StochasticCheckBox;
        public System.Windows.Forms.NumericUpDown LearningRateNumericUpDown;
        public System.Windows.Forms.RadioButton LogisticGradientDescentRadioButton;
        private System.Windows.Forms.Panel learningPanel;
        public System.Windows.Forms.NumericUpDown MaxIterationNumericUpDown;
        public System.Windows.Forms.NumericUpDown ToleranceNumericUpDown;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.Label maxIterationLabel;
    }
}
