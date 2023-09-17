namespace JadeChem.CustomControls.ModelControls
{
    partial class MultinomialLogisticRegressionModelControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            multinomialLogisticRegressionLabel = new Label();
            toleranceNumericUpDown = new NumericUpDown();
            broydenFletcherGoldfarbShannoRadioButton = new RadioButton();
            maxIterationNumericUpDown = new NumericUpDown();
            gradientDescentRadioButton = new RadioButton();
            toleranceLabel = new Label();
            conjugateGradientRadioButton = new RadioButton();
            lowerBoundNewtonRaphsonRadioButton = new RadioButton();
            maxIterationsLabel = new Label();
            trainButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            fittingEquationGroupBox = new GroupBox();
            weightsAndBiasLabel = new Label();
            weightsAndInterceptDataGridView = new DataGridView();
            fittingEquationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)toleranceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxIterationNumericUpDown).BeginInit();
            hyperparametersGroupBox.SuspendLayout();
            fittingEquationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).BeginInit();
            SuspendLayout();
            // 
            // multinomialLogisticRegressionLabel
            // 
            multinomialLogisticRegressionLabel.AutoSize = true;
            multinomialLogisticRegressionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            multinomialLogisticRegressionLabel.Location = new Point(21, 24);
            multinomialLogisticRegressionLabel.Margin = new Padding(2, 0, 2, 0);
            multinomialLogisticRegressionLabel.Name = "multinomialLogisticRegressionLabel";
            multinomialLogisticRegressionLabel.Size = new Size(182, 15);
            multinomialLogisticRegressionLabel.TabIndex = 0;
            multinomialLogisticRegressionLabel.Text = "Multinomial Logistic Regression";
            // 
            // toleranceNumericUpDown
            // 
            toleranceNumericUpDown.DecimalPlaces = 4;
            toleranceNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            toleranceNumericUpDown.Location = new Point(143, 80);
            toleranceNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            toleranceNumericUpDown.Size = new Size(120, 23);
            toleranceNumericUpDown.TabIndex = 2;
            toleranceNumericUpDown.TextAlign = HorizontalAlignment.Center;
            toleranceNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 262144 });
            toleranceNumericUpDown.ValueChanged += ToleranceNumericUpDown_ValueChanged;
            // 
            // broydenFletcherGoldfarbShannoRadioButton
            // 
            broydenFletcherGoldfarbShannoRadioButton.AutoSize = true;
            broydenFletcherGoldfarbShannoRadioButton.Location = new Point(9, 175);
            broydenFletcherGoldfarbShannoRadioButton.Margin = new Padding(4, 3, 4, 3);
            broydenFletcherGoldfarbShannoRadioButton.Name = "broydenFletcherGoldfarbShannoRadioButton";
            broydenFletcherGoldfarbShannoRadioButton.Size = new Size(212, 19);
            broydenFletcherGoldfarbShannoRadioButton.TabIndex = 5;
            broydenFletcherGoldfarbShannoRadioButton.TabStop = true;
            broydenFletcherGoldfarbShannoRadioButton.Text = "Broyden-Fletcher-Goldfarb-Shanno";
            broydenFletcherGoldfarbShannoRadioButton.UseVisualStyleBackColor = true;
            broydenFletcherGoldfarbShannoRadioButton.CheckedChanged += LearningMethodRadioButton_CheckedChanged;
            // 
            // maxIterationNumericUpDown
            // 
            maxIterationNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            maxIterationNumericUpDown.Location = new Point(143, 51);
            maxIterationNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            maxIterationNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            maxIterationNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            maxIterationNumericUpDown.Name = "maxIterationNumericUpDown";
            maxIterationNumericUpDown.Size = new Size(120, 23);
            maxIterationNumericUpDown.TabIndex = 1;
            maxIterationNumericUpDown.TextAlign = HorizontalAlignment.Center;
            maxIterationNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            maxIterationNumericUpDown.ValueChanged += MaxInterationNumericUpDown_ValueChanged;
            // 
            // gradientDescentRadioButton
            // 
            gradientDescentRadioButton.AutoSize = true;
            gradientDescentRadioButton.Location = new Point(9, 146);
            gradientDescentRadioButton.Margin = new Padding(4, 3, 4, 3);
            gradientDescentRadioButton.Name = "gradientDescentRadioButton";
            gradientDescentRadioButton.Size = new Size(114, 19);
            gradientDescentRadioButton.TabIndex = 4;
            gradientDescentRadioButton.TabStop = true;
            gradientDescentRadioButton.Text = "Gradient descent";
            gradientDescentRadioButton.UseVisualStyleBackColor = true;
            gradientDescentRadioButton.CheckedChanged += LearningMethodRadioButton_CheckedChanged;
            // 
            // toleranceLabel
            // 
            toleranceLabel.AutoSize = true;
            toleranceLabel.Location = new Point(78, 82);
            toleranceLabel.Margin = new Padding(4, 0, 4, 0);
            toleranceLabel.Name = "toleranceLabel";
            toleranceLabel.Size = new Size(57, 15);
            toleranceLabel.TabIndex = 0;
            toleranceLabel.Text = "Tolerance";
            // 
            // conjugateGradientRadioButton
            // 
            conjugateGradientRadioButton.AutoSize = true;
            conjugateGradientRadioButton.Location = new Point(9, 117);
            conjugateGradientRadioButton.Margin = new Padding(4, 3, 4, 3);
            conjugateGradientRadioButton.Name = "conjugateGradientRadioButton";
            conjugateGradientRadioButton.Size = new Size(127, 19);
            conjugateGradientRadioButton.TabIndex = 3;
            conjugateGradientRadioButton.TabStop = true;
            conjugateGradientRadioButton.Text = "Conjugate gradient";
            conjugateGradientRadioButton.UseVisualStyleBackColor = true;
            conjugateGradientRadioButton.CheckedChanged += LearningMethodRadioButton_CheckedChanged;
            // 
            // lowerBoundNewtonRaphsonRadioButton
            // 
            lowerBoundNewtonRaphsonRadioButton.AutoSize = true;
            lowerBoundNewtonRaphsonRadioButton.Location = new Point(9, 22);
            lowerBoundNewtonRaphsonRadioButton.Margin = new Padding(4, 3, 4, 3);
            lowerBoundNewtonRaphsonRadioButton.Name = "lowerBoundNewtonRaphsonRadioButton";
            lowerBoundNewtonRaphsonRadioButton.Size = new Size(191, 19);
            lowerBoundNewtonRaphsonRadioButton.TabIndex = 0;
            lowerBoundNewtonRaphsonRadioButton.TabStop = true;
            lowerBoundNewtonRaphsonRadioButton.Text = "Lower bound Newton-Raphson";
            lowerBoundNewtonRaphsonRadioButton.UseVisualStyleBackColor = true;
            lowerBoundNewtonRaphsonRadioButton.CheckedChanged += LearningMethodRadioButton_CheckedChanged;
            // 
            // maxIterationsLabel
            // 
            maxIterationsLabel.AutoSize = true;
            maxIterationsLabel.Location = new Point(53, 53);
            maxIterationsLabel.Margin = new Padding(4, 0, 4, 0);
            maxIterationsLabel.Name = "maxIterationsLabel";
            maxIterationsLabel.Size = new Size(82, 15);
            maxIterationsLabel.TabIndex = 0;
            maxIterationsLabel.Text = "Max iterations";
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 266);
            trainButton.Margin = new Padding(4, 3, 4, 3);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 1;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(toleranceNumericUpDown);
            hyperparametersGroupBox.Controls.Add(lowerBoundNewtonRaphsonRadioButton);
            hyperparametersGroupBox.Controls.Add(broydenFletcherGoldfarbShannoRadioButton);
            hyperparametersGroupBox.Controls.Add(maxIterationsLabel);
            hyperparametersGroupBox.Controls.Add(maxIterationNumericUpDown);
            hyperparametersGroupBox.Controls.Add(conjugateGradientRadioButton);
            hyperparametersGroupBox.Controls.Add(gradientDescentRadioButton);
            hyperparametersGroupBox.Controls.Add(toleranceLabel);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(270, 210);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // fittingEquationGroupBox
            // 
            fittingEquationGroupBox.Controls.Add(weightsAndBiasLabel);
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptDataGridView);
            fittingEquationGroupBox.Controls.Add(fittingEquationLabel);
            fittingEquationGroupBox.Location = new Point(296, 50);
            fittingEquationGroupBox.Name = "fittingEquationGroupBox";
            fittingEquationGroupBox.Size = new Size(470, 210);
            fittingEquationGroupBox.TabIndex = 4;
            fittingEquationGroupBox.TabStop = false;
            fittingEquationGroupBox.Text = "Fitting equation";
            fittingEquationGroupBox.Visible = false;
            // 
            // weightsAndBiasLabel
            // 
            weightsAndBiasLabel.AutoSize = true;
            weightsAndBiasLabel.Location = new Point(6, 51);
            weightsAndBiasLabel.Name = "weightsAndBiasLabel";
            weightsAndBiasLabel.Size = new Size(97, 15);
            weightsAndBiasLabel.TabIndex = 0;
            weightsAndBiasLabel.Text = "Weights and bias";
            // 
            // weightsAndInterceptDataGridView
            // 
            weightsAndInterceptDataGridView.AllowUserToAddRows = false;
            weightsAndInterceptDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            weightsAndInterceptDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            weightsAndInterceptDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weightsAndInterceptDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            weightsAndInterceptDataGridView.Location = new Point(6, 69);
            weightsAndInterceptDataGridView.Name = "weightsAndInterceptDataGridView";
            weightsAndInterceptDataGridView.ReadOnly = true;
            weightsAndInterceptDataGridView.RowHeadersVisible = false;
            weightsAndInterceptDataGridView.RowTemplate.Height = 25;
            weightsAndInterceptDataGridView.Size = new Size(458, 135);
            weightsAndInterceptDataGridView.TabIndex = 0;
            // 
            // fittingEquationLabel
            // 
            fittingEquationLabel.AutoSize = true;
            fittingEquationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fittingEquationLabel.Location = new Point(142, 31);
            fittingEquationLabel.Name = "fittingEquationLabel";
            fittingEquationLabel.Size = new Size(187, 15);
            fittingEquationLabel.TabIndex = 0;
            fittingEquationLabel.Text = "y = 1 / (1 + exp(-(∑(wi * xi) + b)))";
            // 
            // MultinomialLogisticRegressionModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fittingEquationGroupBox);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainButton);
            Controls.Add(multinomialLogisticRegressionLabel);
            Margin = new Padding(2);
            Name = "MultinomialLogisticRegressionModelControl";
            Size = new Size(790, 350);
            Load += MultinomialLogisticRegressionModelControl_Load;
            ((System.ComponentModel.ISupportInitialize)toleranceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxIterationNumericUpDown).EndInit();
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            fittingEquationGroupBox.ResumeLayout(false);
            fittingEquationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label multinomialLogisticRegressionLabel;
        private NumericUpDown maxIterationNumericUpDown;
        private Label toleranceLabel;
        private Label maxIterationsLabel;
        private RadioButton broydenFletcherGoldfarbShannoRadioButton;
        private RadioButton gradientDescentRadioButton;
        private RadioButton conjugateGradientRadioButton;
        private RadioButton lowerBoundNewtonRaphsonRadioButton;
        private Button trainButton;
        private NumericUpDown toleranceNumericUpDown;
        private GroupBox hyperparametersGroupBox;
        private GroupBox fittingEquationGroupBox;
        private Label weightsAndBiasLabel;
        private DataGridView weightsAndInterceptDataGridView;
        private Label fittingEquationLabel;
    }
}
