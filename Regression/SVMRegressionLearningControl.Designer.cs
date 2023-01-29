namespace JadeML.Regression
{
    partial class SVMRegressionLearningControl
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
            this.kernelGroupBox = new System.Windows.Forms.GroupBox();
            this.sigmoidEstimateButton = new System.Windows.Forms.Button();
            this.laplacianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaLabel = new System.Windows.Forms.Label();
            this.gaussianSigmaLabel = new System.Windows.Forms.Label();
            this.sigmoidConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidAlphaLabel = new System.Windows.Forms.Label();
            this.sigmoidAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialConstantLabel = new System.Windows.Forms.Label();
            this.polynomialDegreeLabel = new System.Windows.Forms.Label();
            this.polynomialConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialDegreeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidConstantLabel = new System.Windows.Forms.Label();
            this.sigmoidKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.polynomialKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            this.learningGroupBox = new System.Windows.Forms.GroupBox();
            this.complexityEstimateButton = new System.Windows.Forms.Button();
            this.ToleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LinearRegressionNewtonRadioButton = new System.Windows.Forms.RadioButton();
            this.LinearRegressionCoordinateDescentRadioButton = new System.Windows.Forms.RadioButton();
            this.SequentialMinimalOptimizationRegressionRadioButton = new System.Windows.Forms.RadioButton();
            this.EpsilonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.epsilonLabel = new System.Windows.Forms.Label();
            this.complexityLabel = new System.Windows.Forms.Label();
            this.ComplexityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningTableLayoutPanel.SuspendLayout();
            this.kernelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).BeginInit();
            this.learningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComplexityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // learningTableLayoutPanel
            // 
            this.learningTableLayoutPanel.ColumnCount = 2;
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.learningTableLayoutPanel.Controls.Add(this.kernelGroupBox, 1, 1);
            this.learningTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.learningTableLayoutPanel.Controls.Add(this.learningGroupBox, 0, 1);
            this.learningTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.learningTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.learningTableLayoutPanel.Name = "learningTableLayoutPanel";
            this.learningTableLayoutPanel.RowCount = 2;
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.learningTableLayoutPanel.Size = new System.Drawing.Size(600, 418);
            this.learningTableLayoutPanel.TabIndex = 1;
            // 
            // kernelGroupBox
            // 
            this.kernelGroupBox.Controls.Add(this.sigmoidEstimateButton);
            this.kernelGroupBox.Controls.Add(this.laplacianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.gaussianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.gaussianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.polynomialKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaNumericUpDown);
            this.kernelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kernelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kernelGroupBox.Location = new System.Drawing.Point(302, 51);
            this.kernelGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.kernelGroupBox.Name = "kernelGroupBox";
            this.kernelGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.kernelGroupBox.Size = new System.Drawing.Size(296, 365);
            this.kernelGroupBox.TabIndex = 2;
            this.kernelGroupBox.TabStop = false;
            this.kernelGroupBox.Text = "Kernel";
            // 
            // sigmoidEstimateButton
            // 
            this.sigmoidEstimateButton.Enabled = false;
            this.sigmoidEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidEstimateButton.Location = new System.Drawing.Point(200, 297);
            this.sigmoidEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidEstimateButton.Name = "sigmoidEstimateButton";
            this.sigmoidEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.sigmoidEstimateButton.TabIndex = 12;
            this.sigmoidEstimateButton.Text = "Estimate";
            this.sigmoidEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sigmoidEstimateButton.UseVisualStyleBackColor = true;
            this.sigmoidEstimateButton.Click += new System.EventHandler(this.sigmoidEstimateButton_Click);
            // 
            // laplacianEstimateButton
            // 
            this.laplacianEstimateButton.Enabled = false;
            this.laplacianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianEstimateButton.Location = new System.Drawing.Point(200, 225);
            this.laplacianEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianEstimateButton.Name = "laplacianEstimateButton";
            this.laplacianEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.laplacianEstimateButton.TabIndex = 8;
            this.laplacianEstimateButton.Text = "Estimate";
            this.laplacianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.laplacianEstimateButton.UseVisualStyleBackColor = true;
            this.laplacianEstimateButton.Click += new System.EventHandler(this.laplacianEstimateButton_Click);
            // 
            // gaussianEstimateButton
            // 
            this.gaussianEstimateButton.Enabled = false;
            this.gaussianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianEstimateButton.Location = new System.Drawing.Point(200, 148);
            this.gaussianEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianEstimateButton.Name = "gaussianEstimateButton";
            this.gaussianEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.gaussianEstimateButton.TabIndex = 5;
            this.gaussianEstimateButton.Text = "Estimate";
            this.gaussianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gaussianEstimateButton.UseVisualStyleBackColor = true;
            this.gaussianEstimateButton.Click += new System.EventHandler(this.gaussianEstimateButton_Click);
            // 
            // gaussianKernelRadioButton
            // 
            this.gaussianKernelRadioButton.AutoSize = true;
            this.gaussianKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianKernelRadioButton.Location = new System.Drawing.Point(35, 123);
            this.gaussianKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianKernelRadioButton.Name = "gaussianKernelRadioButton";
            this.gaussianKernelRadioButton.Size = new System.Drawing.Size(102, 17);
            this.gaussianKernelRadioButton.TabIndex = 3;
            this.gaussianKernelRadioButton.Text = "Gaussian Kernel";
            this.gaussianKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianSigmaLabel
            // 
            this.laplacianSigmaLabel.AutoSize = true;
            this.laplacianSigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianSigmaLabel.Location = new System.Drawing.Point(103, 230);
            this.laplacianSigmaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laplacianSigmaLabel.Name = "laplacianSigmaLabel";
            this.laplacianSigmaLabel.Size = new System.Drawing.Size(14, 13);
            this.laplacianSigmaLabel.TabIndex = 0;
            this.laplacianSigmaLabel.Text = "σ";
            // 
            // gaussianSigmaLabel
            // 
            this.gaussianSigmaLabel.AutoSize = true;
            this.gaussianSigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianSigmaLabel.Location = new System.Drawing.Point(103, 153);
            this.gaussianSigmaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gaussianSigmaLabel.Name = "gaussianSigmaLabel";
            this.gaussianSigmaLabel.Size = new System.Drawing.Size(14, 13);
            this.gaussianSigmaLabel.TabIndex = 0;
            this.gaussianSigmaLabel.Text = "σ";
            // 
            // sigmoidConstantNumericUpDown
            // 
            this.sigmoidConstantNumericUpDown.DecimalPlaces = 4;
            this.sigmoidConstantNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidConstantNumericUpDown.Location = new System.Drawing.Point(121, 323);
            this.sigmoidConstantNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidConstantNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sigmoidConstantNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.sigmoidConstantNumericUpDown.Name = "sigmoidConstantNumericUpDown";
            this.sigmoidConstantNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.sigmoidConstantNumericUpDown.TabIndex = 11;
            this.sigmoidConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sigmoidAlphaLabel
            // 
            this.sigmoidAlphaLabel.AutoSize = true;
            this.sigmoidAlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidAlphaLabel.Location = new System.Drawing.Point(103, 302);
            this.sigmoidAlphaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sigmoidAlphaLabel.Name = "sigmoidAlphaLabel";
            this.sigmoidAlphaLabel.Size = new System.Drawing.Size(14, 13);
            this.sigmoidAlphaLabel.TabIndex = 0;
            this.sigmoidAlphaLabel.Text = "α";
            // 
            // sigmoidAlphaNumericUpDown
            // 
            this.sigmoidAlphaNumericUpDown.DecimalPlaces = 4;
            this.sigmoidAlphaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidAlphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.sigmoidAlphaNumericUpDown.Location = new System.Drawing.Point(121, 300);
            this.sigmoidAlphaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidAlphaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sigmoidAlphaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.sigmoidAlphaNumericUpDown.Name = "sigmoidAlphaNumericUpDown";
            this.sigmoidAlphaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.sigmoidAlphaNumericUpDown.TabIndex = 10;
            this.sigmoidAlphaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sigmoidAlphaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // polynomialConstantLabel
            // 
            this.polynomialConstantLabel.AutoSize = true;
            this.polynomialConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialConstantLabel.Location = new System.Drawing.Point(68, 81);
            this.polynomialConstantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polynomialConstantLabel.Name = "polynomialConstantLabel";
            this.polynomialConstantLabel.Size = new System.Drawing.Size(49, 13);
            this.polynomialConstantLabel.TabIndex = 0;
            this.polynomialConstantLabel.Text = "Constant";
            // 
            // polynomialDegreeLabel
            // 
            this.polynomialDegreeLabel.AutoSize = true;
            this.polynomialDegreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialDegreeLabel.Location = new System.Drawing.Point(75, 58);
            this.polynomialDegreeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polynomialDegreeLabel.Name = "polynomialDegreeLabel";
            this.polynomialDegreeLabel.Size = new System.Drawing.Size(42, 13);
            this.polynomialDegreeLabel.TabIndex = 0;
            this.polynomialDegreeLabel.Text = "Degree";
            // 
            // polynomialConstantNumericUpDown
            // 
            this.polynomialConstantNumericUpDown.DecimalPlaces = 4;
            this.polynomialConstantNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialConstantNumericUpDown.Location = new System.Drawing.Point(121, 79);
            this.polynomialConstantNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialConstantNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.polynomialConstantNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.polynomialConstantNumericUpDown.Name = "polynomialConstantNumericUpDown";
            this.polynomialConstantNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.polynomialConstantNumericUpDown.TabIndex = 2;
            this.polynomialConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // polynomialDegreeNumericUpDown
            // 
            this.polynomialDegreeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialDegreeNumericUpDown.Location = new System.Drawing.Point(121, 56);
            this.polynomialDegreeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialDegreeNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Name = "polynomialDegreeNumericUpDown";
            this.polynomialDegreeNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.polynomialDegreeNumericUpDown.TabIndex = 1;
            this.polynomialDegreeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.polynomialDegreeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sigmoidConstantLabel
            // 
            this.sigmoidConstantLabel.AutoSize = true;
            this.sigmoidConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidConstantLabel.Location = new System.Drawing.Point(68, 325);
            this.sigmoidConstantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sigmoidConstantLabel.Name = "sigmoidConstantLabel";
            this.sigmoidConstantLabel.Size = new System.Drawing.Size(49, 13);
            this.sigmoidConstantLabel.TabIndex = 0;
            this.sigmoidConstantLabel.Text = "Constant";
            // 
            // sigmoidKernelRadioButton
            // 
            this.sigmoidKernelRadioButton.AutoSize = true;
            this.sigmoidKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidKernelRadioButton.Location = new System.Drawing.Point(35, 271);
            this.sigmoidKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidKernelRadioButton.Name = "sigmoidKernelRadioButton";
            this.sigmoidKernelRadioButton.Size = new System.Drawing.Size(95, 17);
            this.sigmoidKernelRadioButton.TabIndex = 9;
            this.sigmoidKernelRadioButton.Text = "Sigmoid Kernel";
            this.sigmoidKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianKernelRadioButton
            // 
            this.laplacianKernelRadioButton.AutoSize = true;
            this.laplacianKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianKernelRadioButton.Location = new System.Drawing.Point(35, 199);
            this.laplacianKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianKernelRadioButton.Name = "laplacianKernelRadioButton";
            this.laplacianKernelRadioButton.Size = new System.Drawing.Size(104, 17);
            this.laplacianKernelRadioButton.TabIndex = 6;
            this.laplacianKernelRadioButton.Text = "Laplacian Kernel";
            this.laplacianKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // polynomialKernelRadioButton
            // 
            this.polynomialKernelRadioButton.AutoSize = true;
            this.polynomialKernelRadioButton.Checked = true;
            this.polynomialKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialKernelRadioButton.Location = new System.Drawing.Point(35, 27);
            this.polynomialKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialKernelRadioButton.Name = "polynomialKernelRadioButton";
            this.polynomialKernelRadioButton.Size = new System.Drawing.Size(108, 17);
            this.polynomialKernelRadioButton.TabIndex = 0;
            this.polynomialKernelRadioButton.TabStop = true;
            this.polynomialKernelRadioButton.Text = "Polynomial Kernel";
            this.polynomialKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianSigmaNumericUpDown
            // 
            this.laplacianSigmaNumericUpDown.DecimalPlaces = 4;
            this.laplacianSigmaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.laplacianSigmaNumericUpDown.Location = new System.Drawing.Point(121, 228);
            this.laplacianSigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.laplacianSigmaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.laplacianSigmaNumericUpDown.Name = "laplacianSigmaNumericUpDown";
            this.laplacianSigmaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.laplacianSigmaNumericUpDown.TabIndex = 7;
            this.laplacianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.laplacianSigmaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // gaussianSigmaNumericUpDown
            // 
            this.gaussianSigmaNumericUpDown.DecimalPlaces = 4;
            this.gaussianSigmaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.gaussianSigmaNumericUpDown.Location = new System.Drawing.Point(121, 151);
            this.gaussianSigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.gaussianSigmaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.gaussianSigmaNumericUpDown.Name = "gaussianSigmaNumericUpDown";
            this.gaussianSigmaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.gaussianSigmaNumericUpDown.TabIndex = 4;
            this.gaussianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gaussianSigmaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.learningTableLayoutPanel.SetColumnSpan(this.titleLabel, 2);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(594, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Support Vector Machine - Learning Parameters\r\n";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // learningGroupBox
            // 
            this.learningGroupBox.Controls.Add(this.complexityEstimateButton);
            this.learningGroupBox.Controls.Add(this.ToleranceNumericUpDown);
            this.learningGroupBox.Controls.Add(this.LinearRegressionNewtonRadioButton);
            this.learningGroupBox.Controls.Add(this.LinearRegressionCoordinateDescentRadioButton);
            this.learningGroupBox.Controls.Add(this.SequentialMinimalOptimizationRegressionRadioButton);
            this.learningGroupBox.Controls.Add(this.EpsilonNumericUpDown);
            this.learningGroupBox.Controls.Add(this.toleranceLabel);
            this.learningGroupBox.Controls.Add(this.epsilonLabel);
            this.learningGroupBox.Controls.Add(this.complexityLabel);
            this.learningGroupBox.Controls.Add(this.ComplexityNumericUpDown);
            this.learningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningGroupBox.Location = new System.Drawing.Point(2, 51);
            this.learningGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.learningGroupBox.Name = "learningGroupBox";
            this.learningGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.learningGroupBox.Size = new System.Drawing.Size(296, 365);
            this.learningGroupBox.TabIndex = 0;
            this.learningGroupBox.TabStop = false;
            this.learningGroupBox.Text = "Learning method";
            // 
            // complexityEstimateButton
            // 
            this.complexityEstimateButton.Enabled = false;
            this.complexityEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexityEstimateButton.Location = new System.Drawing.Point(180, 246);
            this.complexityEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.complexityEstimateButton.Name = "complexityEstimateButton";
            this.complexityEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.complexityEstimateButton.TabIndex = 11;
            this.complexityEstimateButton.Text = "Estimate";
            this.complexityEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.complexityEstimateButton.UseVisualStyleBackColor = true;
            this.complexityEstimateButton.Click += new System.EventHandler(this.complexityEstimateButton_Click);
            // 
            // ToleranceNumericUpDown
            // 
            this.ToleranceNumericUpDown.DecimalPlaces = 4;
            this.ToleranceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ToleranceNumericUpDown.Location = new System.Drawing.Point(101, 295);
            this.ToleranceNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.ToleranceNumericUpDown.Name = "ToleranceNumericUpDown";
            this.ToleranceNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.ToleranceNumericUpDown.TabIndex = 14;
            this.ToleranceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToleranceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // LinearRegressionNewtonRadioButton
            // 
            this.LinearRegressionNewtonRadioButton.AutoSize = true;
            this.LinearRegressionNewtonRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinearRegressionNewtonRadioButton.Location = new System.Drawing.Point(37, 134);
            this.LinearRegressionNewtonRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LinearRegressionNewtonRadioButton.Name = "LinearRegressionNewtonRadioButton";
            this.LinearRegressionNewtonRadioButton.Size = new System.Drawing.Size(150, 17);
            this.LinearRegressionNewtonRadioButton.TabIndex = 4;
            this.LinearRegressionNewtonRadioButton.Text = "Linear Regression Newton";
            this.LinearRegressionNewtonRadioButton.UseVisualStyleBackColor = true;
            // 
            // LinearRegressionCoordinateDescentRadioButton
            // 
            this.LinearRegressionCoordinateDescentRadioButton.AutoSize = true;
            this.LinearRegressionCoordinateDescentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinearRegressionCoordinateDescentRadioButton.Location = new System.Drawing.Point(37, 97);
            this.LinearRegressionCoordinateDescentRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LinearRegressionCoordinateDescentRadioButton.Name = "LinearRegressionCoordinateDescentRadioButton";
            this.LinearRegressionCoordinateDescentRadioButton.Size = new System.Drawing.Size(207, 17);
            this.LinearRegressionCoordinateDescentRadioButton.TabIndex = 2;
            this.LinearRegressionCoordinateDescentRadioButton.Text = "Linear Regression Coordinate Descent";
            this.LinearRegressionCoordinateDescentRadioButton.UseVisualStyleBackColor = true;
            // 
            // SequentialMinimalOptimizationRegressionRadioButton
            // 
            this.SequentialMinimalOptimizationRegressionRadioButton.AutoSize = true;
            this.SequentialMinimalOptimizationRegressionRadioButton.Checked = true;
            this.SequentialMinimalOptimizationRegressionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SequentialMinimalOptimizationRegressionRadioButton.Location = new System.Drawing.Point(37, 60);
            this.SequentialMinimalOptimizationRegressionRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.SequentialMinimalOptimizationRegressionRadioButton.Name = "SequentialMinimalOptimizationRegressionRadioButton";
            this.SequentialMinimalOptimizationRegressionRadioButton.Size = new System.Drawing.Size(229, 17);
            this.SequentialMinimalOptimizationRegressionRadioButton.TabIndex = 0;
            this.SequentialMinimalOptimizationRegressionRadioButton.TabStop = true;
            this.SequentialMinimalOptimizationRegressionRadioButton.Text = "Sequential Minimal Optimization Regression";
            this.SequentialMinimalOptimizationRegressionRadioButton.UseVisualStyleBackColor = true;
            // 
            // EpsilonNumericUpDown
            // 
            this.EpsilonNumericUpDown.DecimalPlaces = 4;
            this.EpsilonNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpsilonNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.EpsilonNumericUpDown.Location = new System.Drawing.Point(101, 272);
            this.EpsilonNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.EpsilonNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EpsilonNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.EpsilonNumericUpDown.Name = "EpsilonNumericUpDown";
            this.EpsilonNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.EpsilonNumericUpDown.TabIndex = 12;
            this.EpsilonNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EpsilonNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceLabel.Location = new System.Drawing.Point(42, 297);
            this.toleranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(55, 13);
            this.toleranceLabel.TabIndex = 0;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // epsilonLabel
            // 
            this.epsilonLabel.AutoSize = true;
            this.epsilonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epsilonLabel.Location = new System.Drawing.Point(84, 274);
            this.epsilonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.epsilonLabel.Name = "epsilonLabel";
            this.epsilonLabel.Size = new System.Drawing.Size(13, 13);
            this.epsilonLabel.TabIndex = 0;
            this.epsilonLabel.Text = "ε";
            // 
            // complexityLabel
            // 
            this.complexityLabel.AutoSize = true;
            this.complexityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexityLabel.Location = new System.Drawing.Point(40, 251);
            this.complexityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.complexityLabel.Name = "complexityLabel";
            this.complexityLabel.Size = new System.Drawing.Size(57, 13);
            this.complexityLabel.TabIndex = 0;
            this.complexityLabel.Text = "Complexity";
            // 
            // ComplexityNumericUpDown
            // 
            this.ComplexityNumericUpDown.DecimalPlaces = 4;
            this.ComplexityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplexityNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ComplexityNumericUpDown.Location = new System.Drawing.Point(101, 249);
            this.ComplexityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.ComplexityNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ComplexityNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ComplexityNumericUpDown.Name = "ComplexityNumericUpDown";
            this.ComplexityNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.ComplexityNumericUpDown.TabIndex = 10;
            this.ComplexityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComplexityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SVMRegressionLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.learningTableLayoutPanel);
            this.Name = "SVMRegressionLearningControl";
            this.Size = new System.Drawing.Size(600, 418);
            this.learningTableLayoutPanel.ResumeLayout(false);
            this.learningTableLayoutPanel.PerformLayout();
            this.kernelGroupBox.ResumeLayout(false);
            this.kernelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).EndInit();
            this.learningGroupBox.ResumeLayout(false);
            this.learningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComplexityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel learningTableLayoutPanel;
        private System.Windows.Forms.GroupBox kernelGroupBox;
        private System.Windows.Forms.Button sigmoidEstimateButton;
        private System.Windows.Forms.Button laplacianEstimateButton;
        private System.Windows.Forms.Button gaussianEstimateButton;
        private System.Windows.Forms.RadioButton gaussianKernelRadioButton;
        private System.Windows.Forms.Label laplacianSigmaLabel;
        private System.Windows.Forms.Label gaussianSigmaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidConstantNumericUpDown;
        private System.Windows.Forms.Label sigmoidAlphaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidAlphaNumericUpDown;
        private System.Windows.Forms.Label polynomialConstantLabel;
        private System.Windows.Forms.Label polynomialDegreeLabel;
        private System.Windows.Forms.NumericUpDown polynomialConstantNumericUpDown;
        private System.Windows.Forms.NumericUpDown polynomialDegreeNumericUpDown;
        private System.Windows.Forms.Label sigmoidConstantLabel;
        private System.Windows.Forms.RadioButton sigmoidKernelRadioButton;
        private System.Windows.Forms.RadioButton laplacianKernelRadioButton;
        private System.Windows.Forms.RadioButton polynomialKernelRadioButton;
        private System.Windows.Forms.NumericUpDown laplacianSigmaNumericUpDown;
        private System.Windows.Forms.NumericUpDown gaussianSigmaNumericUpDown;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox learningGroupBox;
        public System.Windows.Forms.Button complexityEstimateButton;
        public System.Windows.Forms.NumericUpDown ToleranceNumericUpDown;
        public System.Windows.Forms.RadioButton LinearRegressionNewtonRadioButton;
        public System.Windows.Forms.RadioButton LinearRegressionCoordinateDescentRadioButton;
        public System.Windows.Forms.RadioButton SequentialMinimalOptimizationRegressionRadioButton;
        public System.Windows.Forms.NumericUpDown EpsilonNumericUpDown;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.Label epsilonLabel;
        private System.Windows.Forms.Label complexityLabel;
        public System.Windows.Forms.NumericUpDown ComplexityNumericUpDown;
    }
}
