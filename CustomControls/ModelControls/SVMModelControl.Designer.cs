namespace JadeChem.CustomControls.ModelControls
{
    partial class SVMModelControl
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
            svmLabel = new Label();
            trainButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            forRegressionLabel = new Label();
            forClassificationLabel = new Label();
            epsilonLabel = new Label();
            epsilonNumericUpDown = new NumericUpDown();
            negativeWeightLabel = new Label();
            negativeWeightNumericUpDown = new NumericUpDown();
            positiveWeightLabel = new Label();
            positiveWeightNumericUpDown = new NumericUpDown();
            complexityEstimateButton = new Button();
            toleranceLabel = new Label();
            learningMethodComboBox = new ComboBox();
            toleranceNumericUpDown = new NumericUpDown();
            learningMethodLabel = new Label();
            complexityLabel = new Label();
            kernelGroupBox = new GroupBox();
            sigmoidEstimateButton = new Button();
            laplacianEstimateButton = new Button();
            gaussianEstimateButton = new Button();
            sigmoidConstantLabel = new Label();
            sigmoidConstantNumericUpDown = new NumericUpDown();
            sigmoidAlphaLabel = new Label();
            sigmoidAlphaNumericUpDown = new NumericUpDown();
            laplacianSigmaLabel = new Label();
            laplacianSigmaNumericUpDown = new NumericUpDown();
            gaussianSigmaLabel = new Label();
            gaussianSigmaNumericUpDown = new NumericUpDown();
            polynomialConstantLabel = new Label();
            polynomialConstantNumericUpDown = new NumericUpDown();
            polynomialDegreeLabel = new Label();
            polynomialDegreeNumericUpDown = new NumericUpDown();
            sigmoidRadioButton = new RadioButton();
            laplacianRadioButton = new RadioButton();
            gaussianRadioButton = new RadioButton();
            polynomialRadioButton = new RadioButton();
            complexityNumericUpDown = new NumericUpDown();
            viewSupportVectorsButton = new Button();
            hyperparametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epsilonNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negativeWeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)positiveWeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toleranceNumericUpDown).BeginInit();
            kernelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sigmoidConstantNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sigmoidAlphaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)laplacianSigmaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gaussianSigmaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)polynomialConstantNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)polynomialDegreeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)complexityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // svmLabel
            // 
            svmLabel.AutoSize = true;
            svmLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            svmLabel.Location = new Point(20, 20);
            svmLabel.Name = "svmLabel";
            svmLabel.Size = new Size(142, 15);
            svmLabel.TabIndex = 0;
            svmLabel.Text = "Support vector machine";
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 312);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 1;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(forRegressionLabel);
            hyperparametersGroupBox.Controls.Add(forClassificationLabel);
            hyperparametersGroupBox.Controls.Add(epsilonLabel);
            hyperparametersGroupBox.Controls.Add(epsilonNumericUpDown);
            hyperparametersGroupBox.Controls.Add(negativeWeightLabel);
            hyperparametersGroupBox.Controls.Add(negativeWeightNumericUpDown);
            hyperparametersGroupBox.Controls.Add(positiveWeightLabel);
            hyperparametersGroupBox.Controls.Add(positiveWeightNumericUpDown);
            hyperparametersGroupBox.Controls.Add(complexityEstimateButton);
            hyperparametersGroupBox.Controls.Add(toleranceLabel);
            hyperparametersGroupBox.Controls.Add(learningMethodComboBox);
            hyperparametersGroupBox.Controls.Add(toleranceNumericUpDown);
            hyperparametersGroupBox.Controls.Add(learningMethodLabel);
            hyperparametersGroupBox.Controls.Add(complexityLabel);
            hyperparametersGroupBox.Controls.Add(kernelGroupBox);
            hyperparametersGroupBox.Controls.Add(complexityNumericUpDown);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(750, 256);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // forRegressionLabel
            // 
            forRegressionLabel.AutoSize = true;
            forRegressionLabel.Location = new Point(618, 25);
            forRegressionLabel.Name = "forRegressionLabel";
            forRegressionLabel.Size = new Size(81, 15);
            forRegressionLabel.TabIndex = 30;
            forRegressionLabel.Text = "For regression";
            // 
            // forClassificationLabel
            // 
            forClassificationLabel.AutoSize = true;
            forClassificationLabel.Location = new Point(456, 25);
            forClassificationLabel.Name = "forClassificationLabel";
            forClassificationLabel.Size = new Size(95, 15);
            forClassificationLabel.TabIndex = 29;
            forClassificationLabel.Text = "For classification";
            // 
            // epsilonLabel
            // 
            epsilonLabel.AutoSize = true;
            epsilonLabel.Location = new Point(600, 53);
            epsilonLabel.Name = "epsilonLabel";
            epsilonLabel.Size = new Size(12, 15);
            epsilonLabel.TabIndex = 0;
            epsilonLabel.Text = "ε";
            // 
            // epsilonNumericUpDown
            // 
            epsilonNumericUpDown.DecimalPlaces = 4;
            epsilonNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            epsilonNumericUpDown.Location = new Point(618, 51);
            epsilonNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            epsilonNumericUpDown.Name = "epsilonNumericUpDown";
            epsilonNumericUpDown.Size = new Size(120, 23);
            epsilonNumericUpDown.TabIndex = 6;
            epsilonNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 196608 });
            epsilonNumericUpDown.ValueChanged += EpsilonNumericUpDown_ValueChanged;
            // 
            // negativeWeightLabel
            // 
            negativeWeightLabel.AutoSize = true;
            negativeWeightLabel.Location = new Point(357, 82);
            negativeWeightLabel.Name = "negativeWeightLabel";
            negativeWeightLabel.Size = new Size(93, 15);
            negativeWeightLabel.TabIndex = 0;
            negativeWeightLabel.Text = "Negative weight";
            // 
            // negativeWeightNumericUpDown
            // 
            negativeWeightNumericUpDown.DecimalPlaces = 4;
            negativeWeightNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            negativeWeightNumericUpDown.Location = new Point(456, 80);
            negativeWeightNumericUpDown.Name = "negativeWeightNumericUpDown";
            negativeWeightNumericUpDown.Size = new Size(120, 23);
            negativeWeightNumericUpDown.TabIndex = 5;
            negativeWeightNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            negativeWeightNumericUpDown.ValueChanged += NegativeWeightNumericUpDown_ValueChanged;
            // 
            // positiveWeightLabel
            // 
            positiveWeightLabel.AutoSize = true;
            positiveWeightLabel.Location = new Point(363, 53);
            positiveWeightLabel.Name = "positiveWeightLabel";
            positiveWeightLabel.Size = new Size(87, 15);
            positiveWeightLabel.TabIndex = 0;
            positiveWeightLabel.Text = "Positive weight";
            // 
            // positiveWeightNumericUpDown
            // 
            positiveWeightNumericUpDown.DecimalPlaces = 4;
            positiveWeightNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            positiveWeightNumericUpDown.Location = new Point(456, 51);
            positiveWeightNumericUpDown.Name = "positiveWeightNumericUpDown";
            positiveWeightNumericUpDown.Size = new Size(120, 23);
            positiveWeightNumericUpDown.TabIndex = 4;
            positiveWeightNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            positiveWeightNumericUpDown.ValueChanged += PositiveWeightNumericUpDown_ValueChanged;
            // 
            // complexityEstimateButton
            // 
            complexityEstimateButton.Location = new Point(251, 49);
            complexityEstimateButton.Name = "complexityEstimateButton";
            complexityEstimateButton.Size = new Size(75, 23);
            complexityEstimateButton.TabIndex = 2;
            complexityEstimateButton.Text = "Estimate";
            complexityEstimateButton.UseVisualStyleBackColor = true;
            complexityEstimateButton.Click += ComplexityEstimateButton_Click;
            // 
            // toleranceLabel
            // 
            toleranceLabel.AutoSize = true;
            toleranceLabel.Location = new Point(62, 82);
            toleranceLabel.Name = "toleranceLabel";
            toleranceLabel.Size = new Size(57, 15);
            toleranceLabel.TabIndex = 0;
            toleranceLabel.Text = "Tolerance";
            // 
            // learningMethodComboBox
            // 
            learningMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            learningMethodComboBox.FormattingEnabled = true;
            learningMethodComboBox.Items.AddRange(new object[] { "Sequential minimal optimization" });
            learningMethodComboBox.Location = new Point(125, 22);
            learningMethodComboBox.Name = "learningMethodComboBox";
            learningMethodComboBox.Size = new Size(201, 23);
            learningMethodComboBox.TabIndex = 0;
            // 
            // toleranceNumericUpDown
            // 
            toleranceNumericUpDown.DecimalPlaces = 4;
            toleranceNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            toleranceNumericUpDown.Location = new Point(125, 80);
            toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            toleranceNumericUpDown.Size = new Size(120, 23);
            toleranceNumericUpDown.TabIndex = 3;
            toleranceNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 196608 });
            toleranceNumericUpDown.ValueChanged += ToleranceNumericUpDown_ValueChanged;
            // 
            // learningMethodLabel
            // 
            learningMethodLabel.AutoSize = true;
            learningMethodLabel.Location = new Point(21, 25);
            learningMethodLabel.Name = "learningMethodLabel";
            learningMethodLabel.Size = new Size(98, 15);
            learningMethodLabel.TabIndex = 0;
            learningMethodLabel.Text = "Learning method";
            // 
            // complexityLabel
            // 
            complexityLabel.AutoSize = true;
            complexityLabel.Location = new Point(51, 53);
            complexityLabel.Name = "complexityLabel";
            complexityLabel.Size = new Size(68, 15);
            complexityLabel.TabIndex = 0;
            complexityLabel.Text = "Complexity";
            // 
            // kernelGroupBox
            // 
            kernelGroupBox.Controls.Add(sigmoidEstimateButton);
            kernelGroupBox.Controls.Add(laplacianEstimateButton);
            kernelGroupBox.Controls.Add(gaussianEstimateButton);
            kernelGroupBox.Controls.Add(sigmoidConstantLabel);
            kernelGroupBox.Controls.Add(sigmoidConstantNumericUpDown);
            kernelGroupBox.Controls.Add(sigmoidAlphaLabel);
            kernelGroupBox.Controls.Add(sigmoidAlphaNumericUpDown);
            kernelGroupBox.Controls.Add(laplacianSigmaLabel);
            kernelGroupBox.Controls.Add(laplacianSigmaNumericUpDown);
            kernelGroupBox.Controls.Add(gaussianSigmaLabel);
            kernelGroupBox.Controls.Add(gaussianSigmaNumericUpDown);
            kernelGroupBox.Controls.Add(polynomialConstantLabel);
            kernelGroupBox.Controls.Add(polynomialConstantNumericUpDown);
            kernelGroupBox.Controls.Add(polynomialDegreeLabel);
            kernelGroupBox.Controls.Add(polynomialDegreeNumericUpDown);
            kernelGroupBox.Controls.Add(sigmoidRadioButton);
            kernelGroupBox.Controls.Add(laplacianRadioButton);
            kernelGroupBox.Controls.Add(gaussianRadioButton);
            kernelGroupBox.Controls.Add(polynomialRadioButton);
            kernelGroupBox.Location = new Point(6, 111);
            kernelGroupBox.Name = "kernelGroupBox";
            kernelGroupBox.Size = new Size(738, 139);
            kernelGroupBox.TabIndex = 7;
            kernelGroupBox.TabStop = false;
            kernelGroupBox.Text = "Kernel";
            // 
            // sigmoidEstimateButton
            // 
            sigmoidEstimateButton.Location = new Point(550, 105);
            sigmoidEstimateButton.Name = "sigmoidEstimateButton";
            sigmoidEstimateButton.Size = new Size(75, 23);
            sigmoidEstimateButton.TabIndex = 12;
            sigmoidEstimateButton.Text = "Estimate";
            sigmoidEstimateButton.UseVisualStyleBackColor = true;
            sigmoidEstimateButton.Click += SigmoidEstimateButton_Click;
            // 
            // laplacianEstimateButton
            // 
            laplacianEstimateButton.Location = new Point(391, 76);
            laplacianEstimateButton.Name = "laplacianEstimateButton";
            laplacianEstimateButton.Size = new Size(75, 23);
            laplacianEstimateButton.TabIndex = 8;
            laplacianEstimateButton.Text = "Estimate";
            laplacianEstimateButton.UseVisualStyleBackColor = true;
            laplacianEstimateButton.Click += LaplacianEstimateButton_Click;
            // 
            // gaussianEstimateButton
            // 
            gaussianEstimateButton.Location = new Point(215, 76);
            gaussianEstimateButton.Name = "gaussianEstimateButton";
            gaussianEstimateButton.Size = new Size(75, 23);
            gaussianEstimateButton.TabIndex = 5;
            gaussianEstimateButton.Text = "Estimate";
            gaussianEstimateButton.UseVisualStyleBackColor = true;
            gaussianEstimateButton.Click += GaussianEstimateButton_Click;
            // 
            // sigmoidConstantLabel
            // 
            sigmoidConstantLabel.AutoSize = true;
            sigmoidConstantLabel.Location = new Point(551, 78);
            sigmoidConstantLabel.Name = "sigmoidConstantLabel";
            sigmoidConstantLabel.Size = new Size(55, 15);
            sigmoidConstantLabel.TabIndex = 0;
            sigmoidConstantLabel.Text = "Constant";
            // 
            // sigmoidConstantNumericUpDown
            // 
            sigmoidConstantNumericUpDown.DecimalPlaces = 4;
            sigmoidConstantNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            sigmoidConstantNumericUpDown.Location = new Point(612, 76);
            sigmoidConstantNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            sigmoidConstantNumericUpDown.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            sigmoidConstantNumericUpDown.Name = "sigmoidConstantNumericUpDown";
            sigmoidConstantNumericUpDown.Size = new Size(120, 23);
            sigmoidConstantNumericUpDown.TabIndex = 11;
            // 
            // sigmoidAlphaLabel
            // 
            sigmoidAlphaLabel.AutoSize = true;
            sigmoidAlphaLabel.Location = new Point(592, 49);
            sigmoidAlphaLabel.Name = "sigmoidAlphaLabel";
            sigmoidAlphaLabel.Size = new Size(14, 15);
            sigmoidAlphaLabel.TabIndex = 0;
            sigmoidAlphaLabel.Text = "α";
            // 
            // sigmoidAlphaNumericUpDown
            // 
            sigmoidAlphaNumericUpDown.DecimalPlaces = 4;
            sigmoidAlphaNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            sigmoidAlphaNumericUpDown.Location = new Point(612, 47);
            sigmoidAlphaNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            sigmoidAlphaNumericUpDown.Name = "sigmoidAlphaNumericUpDown";
            sigmoidAlphaNumericUpDown.Size = new Size(120, 23);
            sigmoidAlphaNumericUpDown.TabIndex = 10;
            sigmoidAlphaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // laplacianSigmaLabel
            // 
            laplacianSigmaLabel.AutoSize = true;
            laplacianSigmaLabel.Location = new Point(395, 49);
            laplacianSigmaLabel.Name = "laplacianSigmaLabel";
            laplacianSigmaLabel.Size = new Size(14, 15);
            laplacianSigmaLabel.TabIndex = 0;
            laplacianSigmaLabel.Text = "σ";
            // 
            // laplacianSigmaNumericUpDown
            // 
            laplacianSigmaNumericUpDown.DecimalPlaces = 4;
            laplacianSigmaNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            laplacianSigmaNumericUpDown.Location = new Point(415, 47);
            laplacianSigmaNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            laplacianSigmaNumericUpDown.Name = "laplacianSigmaNumericUpDown";
            laplacianSigmaNumericUpDown.Size = new Size(120, 23);
            laplacianSigmaNumericUpDown.TabIndex = 7;
            laplacianSigmaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gaussianSigmaLabel
            // 
            gaussianSigmaLabel.AutoSize = true;
            gaussianSigmaLabel.Location = new Point(215, 49);
            gaussianSigmaLabel.Name = "gaussianSigmaLabel";
            gaussianSigmaLabel.Size = new Size(14, 15);
            gaussianSigmaLabel.TabIndex = 0;
            gaussianSigmaLabel.Text = "σ";
            // 
            // gaussianSigmaNumericUpDown
            // 
            gaussianSigmaNumericUpDown.DecimalPlaces = 4;
            gaussianSigmaNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            gaussianSigmaNumericUpDown.Location = new Point(235, 47);
            gaussianSigmaNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            gaussianSigmaNumericUpDown.Name = "gaussianSigmaNumericUpDown";
            gaussianSigmaNumericUpDown.Size = new Size(120, 23);
            gaussianSigmaNumericUpDown.TabIndex = 4;
            gaussianSigmaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // polynomialConstantLabel
            // 
            polynomialConstantLabel.AutoSize = true;
            polynomialConstantLabel.Location = new Point(6, 78);
            polynomialConstantLabel.Name = "polynomialConstantLabel";
            polynomialConstantLabel.Size = new Size(55, 15);
            polynomialConstantLabel.TabIndex = 0;
            polynomialConstantLabel.Text = "Constant";
            // 
            // polynomialConstantNumericUpDown
            // 
            polynomialConstantNumericUpDown.DecimalPlaces = 4;
            polynomialConstantNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            polynomialConstantNumericUpDown.Location = new Point(67, 76);
            polynomialConstantNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            polynomialConstantNumericUpDown.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            polynomialConstantNumericUpDown.Name = "polynomialConstantNumericUpDown";
            polynomialConstantNumericUpDown.Size = new Size(120, 23);
            polynomialConstantNumericUpDown.TabIndex = 2;
            // 
            // polynomialDegreeLabel
            // 
            polynomialDegreeLabel.AutoSize = true;
            polynomialDegreeLabel.Location = new Point(17, 49);
            polynomialDegreeLabel.Name = "polynomialDegreeLabel";
            polynomialDegreeLabel.Size = new Size(44, 15);
            polynomialDegreeLabel.TabIndex = 0;
            polynomialDegreeLabel.Text = "Degree";
            // 
            // polynomialDegreeNumericUpDown
            // 
            polynomialDegreeNumericUpDown.Location = new Point(67, 47);
            polynomialDegreeNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            polynomialDegreeNumericUpDown.Name = "polynomialDegreeNumericUpDown";
            polynomialDegreeNumericUpDown.Size = new Size(120, 23);
            polynomialDegreeNumericUpDown.TabIndex = 1;
            polynomialDegreeNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // sigmoidRadioButton
            // 
            sigmoidRadioButton.AutoSize = true;
            sigmoidRadioButton.Location = new Point(550, 22);
            sigmoidRadioButton.Name = "sigmoidRadioButton";
            sigmoidRadioButton.Size = new Size(69, 19);
            sigmoidRadioButton.TabIndex = 9;
            sigmoidRadioButton.TabStop = true;
            sigmoidRadioButton.Text = "Sigmoid";
            sigmoidRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianRadioButton
            // 
            laplacianRadioButton.AutoSize = true;
            laplacianRadioButton.Location = new Point(391, 22);
            laplacianRadioButton.Name = "laplacianRadioButton";
            laplacianRadioButton.Size = new Size(75, 19);
            laplacianRadioButton.TabIndex = 6;
            laplacianRadioButton.TabStop = true;
            laplacianRadioButton.Text = "Laplacian";
            laplacianRadioButton.UseVisualStyleBackColor = true;
            // 
            // gaussianRadioButton
            // 
            gaussianRadioButton.AutoSize = true;
            gaussianRadioButton.Location = new Point(210, 22);
            gaussianRadioButton.Name = "gaussianRadioButton";
            gaussianRadioButton.Size = new Size(72, 19);
            gaussianRadioButton.TabIndex = 3;
            gaussianRadioButton.TabStop = true;
            gaussianRadioButton.Text = "Gaussian";
            gaussianRadioButton.UseVisualStyleBackColor = true;
            // 
            // polynomialRadioButton
            // 
            polynomialRadioButton.AutoSize = true;
            polynomialRadioButton.Checked = true;
            polynomialRadioButton.Location = new Point(6, 22);
            polynomialRadioButton.Name = "polynomialRadioButton";
            polynomialRadioButton.Size = new Size(85, 19);
            polynomialRadioButton.TabIndex = 0;
            polynomialRadioButton.TabStop = true;
            polynomialRadioButton.Text = "Polynomial";
            polynomialRadioButton.UseVisualStyleBackColor = true;
            // 
            // complexityNumericUpDown
            // 
            complexityNumericUpDown.DecimalPlaces = 4;
            complexityNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            complexityNumericUpDown.Location = new Point(125, 51);
            complexityNumericUpDown.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            complexityNumericUpDown.Name = "complexityNumericUpDown";
            complexityNumericUpDown.Size = new Size(120, 23);
            complexityNumericUpDown.TabIndex = 1;
            complexityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            complexityNumericUpDown.ValueChanged += ComplexityNumericUpDown_ValueChanged;
            // 
            // viewSupportVectorsButton
            // 
            viewSupportVectorsButton.Enabled = false;
            viewSupportVectorsButton.Location = new Point(101, 312);
            viewSupportVectorsButton.Name = "viewSupportVectorsButton";
            viewSupportVectorsButton.Size = new Size(150, 23);
            viewSupportVectorsButton.TabIndex = 2;
            viewSupportVectorsButton.Text = "View support vectors...";
            viewSupportVectorsButton.UseVisualStyleBackColor = true;
            viewSupportVectorsButton.Click += ViewSupportVectorsButton_Click;
            // 
            // SVMModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewSupportVectorsButton);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainButton);
            Controls.Add(svmLabel);
            Name = "SVMModelControl";
            Size = new Size(790, 350);
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epsilonNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)negativeWeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)positiveWeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)toleranceNumericUpDown).EndInit();
            kernelGroupBox.ResumeLayout(false);
            kernelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sigmoidConstantNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)sigmoidAlphaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)laplacianSigmaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)gaussianSigmaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)polynomialConstantNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)polynomialDegreeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)complexityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label svmLabel;
        private Button trainButton;
        private GroupBox hyperparametersGroupBox;
        private ComboBox learningMethodComboBox;
        private Label learningMethodLabel;
        private GroupBox kernelGroupBox;
        private Label sigmoidAlphaLabel;
        private NumericUpDown sigmoidAlphaNumericUpDown;
        private Label laplacianSigmaLabel;
        private NumericUpDown laplacianSigmaNumericUpDown;
        private Label gaussianSigmaLabel;
        private NumericUpDown gaussianSigmaNumericUpDown;
        private Label polynomialConstantLabel;
        private NumericUpDown polynomialConstantNumericUpDown;
        private Label polynomialDegreeLabel;
        private NumericUpDown polynomialDegreeNumericUpDown;
        private RadioButton sigmoidRadioButton;
        private RadioButton laplacianRadioButton;
        private RadioButton gaussianRadioButton;
        private RadioButton polynomialRadioButton;
        private Button sigmoidEstimateButton;
        private Button laplacianEstimateButton;
        private Button gaussianEstimateButton;
        private Label sigmoidConstantLabel;
        private NumericUpDown sigmoidConstantNumericUpDown;
        private Button complexityEstimateButton;
        private Label toleranceLabel;
        private NumericUpDown toleranceNumericUpDown;
        private Label complexityLabel;
        private NumericUpDown complexityNumericUpDown;
        private Label negativeWeightLabel;
        private NumericUpDown negativeWeightNumericUpDown;
        private Label positiveWeightLabel;
        private NumericUpDown positiveWeightNumericUpDown;
        private Label forRegressionLabel;
        private Label forClassificationLabel;
        private Label epsilonLabel;
        private NumericUpDown epsilonNumericUpDown;
        private Button viewSupportVectorsButton;
    }
}
