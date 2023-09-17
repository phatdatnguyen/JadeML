namespace JadeChem.CustomControls.ModelControls
{
    partial class LogisticRegressionModelControl
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
            logisticRegressionLabel = new Label();
            trainButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            maxIterationsNumericUpDown = new NumericUpDown();
            maxIterationsLabel = new Label();
            toleranceNumericUpDown = new NumericUpDown();
            toleranceLabel = new Label();
            regularizationNumericUpDown = new NumericUpDown();
            regularizationLabel = new Label();
            stochasticCheckBox = new CheckBox();
            learningRateNumericUpDown = new NumericUpDown();
            learningRateLabel = new Label();
            iterativeReweightedLeastSquaresRadioButton = new RadioButton();
            logisticGradientDescentRadioButton = new RadioButton();
            fittingEquationGroupBox = new GroupBox();
            weightsAndBiasLabel = new Label();
            weightsAndInterceptDataGridView = new DataGridView();
            fittingEquationLabel = new Label();
            hyperparametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxIterationsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toleranceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)regularizationNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)learningRateNumericUpDown).BeginInit();
            fittingEquationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).BeginInit();
            SuspendLayout();
            // 
            // logisticRegressionLabel
            // 
            logisticRegressionLabel.AutoSize = true;
            logisticRegressionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logisticRegressionLabel.Location = new Point(20, 20);
            logisticRegressionLabel.Name = "logisticRegressionLabel";
            logisticRegressionLabel.Size = new Size(113, 15);
            logisticRegressionLabel.TabIndex = 0;
            logisticRegressionLabel.Text = "Logistic Regression";
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 296);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 1;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(maxIterationsNumericUpDown);
            hyperparametersGroupBox.Controls.Add(maxIterationsLabel);
            hyperparametersGroupBox.Controls.Add(toleranceNumericUpDown);
            hyperparametersGroupBox.Controls.Add(toleranceLabel);
            hyperparametersGroupBox.Controls.Add(regularizationNumericUpDown);
            hyperparametersGroupBox.Controls.Add(regularizationLabel);
            hyperparametersGroupBox.Controls.Add(stochasticCheckBox);
            hyperparametersGroupBox.Controls.Add(learningRateNumericUpDown);
            hyperparametersGroupBox.Controls.Add(learningRateLabel);
            hyperparametersGroupBox.Controls.Add(iterativeReweightedLeastSquaresRadioButton);
            hyperparametersGroupBox.Controls.Add(logisticGradientDescentRadioButton);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(340, 240);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // maxIterationsNumericUpDown
            // 
            maxIterationsNumericUpDown.Location = new Point(119, 203);
            maxIterationsNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            maxIterationsNumericUpDown.Name = "maxIterationsNumericUpDown";
            maxIterationsNumericUpDown.Size = new Size(120, 23);
            maxIterationsNumericUpDown.TabIndex = 6;
            maxIterationsNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            maxIterationsNumericUpDown.ValueChanged += MaxIterationsNumericUpDown_ValueChanged;
            // 
            // maxIterationsLabel
            // 
            maxIterationsLabel.AutoSize = true;
            maxIterationsLabel.Location = new Point(31, 205);
            maxIterationsLabel.Name = "maxIterationsLabel";
            maxIterationsLabel.Size = new Size(82, 15);
            maxIterationsLabel.TabIndex = 0;
            maxIterationsLabel.Text = "Max iterations";
            // 
            // toleranceNumericUpDown
            // 
            toleranceNumericUpDown.DecimalPlaces = 5;
            toleranceNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
            toleranceNumericUpDown.Location = new Point(119, 174);
            toleranceNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            toleranceNumericUpDown.Size = new Size(120, 23);
            toleranceNumericUpDown.TabIndex = 5;
            toleranceNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 262144 });
            toleranceNumericUpDown.ValueChanged += ToleranceNumericUpDown_ValueChanged;
            // 
            // toleranceLabel
            // 
            toleranceLabel.AutoSize = true;
            toleranceLabel.Location = new Point(56, 176);
            toleranceLabel.Name = "toleranceLabel";
            toleranceLabel.Size = new Size(57, 15);
            toleranceLabel.TabIndex = 0;
            toleranceLabel.Text = "Tolerance";
            // 
            // regularizationNumericUpDown
            // 
            regularizationNumericUpDown.Location = new Point(119, 124);
            regularizationNumericUpDown.Name = "regularizationNumericUpDown";
            regularizationNumericUpDown.Size = new Size(120, 23);
            regularizationNumericUpDown.TabIndex = 4;
            regularizationNumericUpDown.ValueChanged += RegularizationNumericUpDown_ValueChanged;
            // 
            // regularizationLabel
            // 
            regularizationLabel.AutoSize = true;
            regularizationLabel.Location = new Point(31, 126);
            regularizationLabel.Name = "regularizationLabel";
            regularizationLabel.Size = new Size(82, 15);
            regularizationLabel.TabIndex = 0;
            regularizationLabel.Text = "Regularization";
            // 
            // stochasticCheckBox
            // 
            stochasticCheckBox.AutoSize = true;
            stochasticCheckBox.Location = new Point(245, 58);
            stochasticCheckBox.Name = "stochasticCheckBox";
            stochasticCheckBox.Size = new Size(79, 19);
            stochasticCheckBox.TabIndex = 2;
            stochasticCheckBox.Text = "stochastic";
            stochasticCheckBox.UseVisualStyleBackColor = true;
            stochasticCheckBox.CheckedChanged += StochasticCheckBox_CheckedChanged;
            // 
            // learningRateNumericUpDown
            // 
            learningRateNumericUpDown.DecimalPlaces = 5;
            learningRateNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            learningRateNumericUpDown.Location = new Point(119, 56);
            learningRateNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            learningRateNumericUpDown.Name = "learningRateNumericUpDown";
            learningRateNumericUpDown.Size = new Size(120, 23);
            learningRateNumericUpDown.TabIndex = 1;
            learningRateNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            learningRateNumericUpDown.ValueChanged += LearningRateNumericUpDown_ValueChanged;
            // 
            // learningRateLabel
            // 
            learningRateLabel.AutoSize = true;
            learningRateLabel.Location = new Point(37, 58);
            learningRateLabel.Name = "learningRateLabel";
            learningRateLabel.Size = new Size(76, 15);
            learningRateLabel.TabIndex = 0;
            learningRateLabel.Text = "Learning rate";
            // 
            // iterativeReweightedLeastSquaresRadioButton
            // 
            iterativeReweightedLeastSquaresRadioButton.AutoSize = true;
            iterativeReweightedLeastSquaresRadioButton.Location = new Point(19, 99);
            iterativeReweightedLeastSquaresRadioButton.Name = "iterativeReweightedLeastSquaresRadioButton";
            iterativeReweightedLeastSquaresRadioButton.Size = new Size(199, 19);
            iterativeReweightedLeastSquaresRadioButton.TabIndex = 3;
            iterativeReweightedLeastSquaresRadioButton.Text = "Iterative reweighted least squares";
            iterativeReweightedLeastSquaresRadioButton.UseVisualStyleBackColor = true;
            iterativeReweightedLeastSquaresRadioButton.CheckedChanged += LearningMethodRadioButton_CheckedChanged;
            // 
            // logisticGradientDescentRadioButton
            // 
            logisticGradientDescentRadioButton.AutoSize = true;
            logisticGradientDescentRadioButton.Checked = true;
            logisticGradientDescentRadioButton.Location = new Point(19, 31);
            logisticGradientDescentRadioButton.Name = "logisticGradientDescentRadioButton";
            logisticGradientDescentRadioButton.Size = new Size(157, 19);
            logisticGradientDescentRadioButton.TabIndex = 0;
            logisticGradientDescentRadioButton.TabStop = true;
            logisticGradientDescentRadioButton.Text = "Logistic gradient descent";
            logisticGradientDescentRadioButton.UseVisualStyleBackColor = true;
            logisticGradientDescentRadioButton.CheckedChanged += LearningMethodRadioButton_CheckedChanged;
            // 
            // fittingEquationGroupBox
            // 
            fittingEquationGroupBox.Controls.Add(weightsAndBiasLabel);
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptDataGridView);
            fittingEquationGroupBox.Controls.Add(fittingEquationLabel);
            fittingEquationGroupBox.Location = new Point(366, 50);
            fittingEquationGroupBox.Name = "fittingEquationGroupBox";
            fittingEquationGroupBox.Size = new Size(404, 150);
            fittingEquationGroupBox.TabIndex = 3;
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
            weightsAndInterceptDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weightsAndInterceptDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            weightsAndInterceptDataGridView.Location = new Point(6, 69);
            weightsAndInterceptDataGridView.Name = "weightsAndInterceptDataGridView";
            weightsAndInterceptDataGridView.ReadOnly = true;
            weightsAndInterceptDataGridView.RowHeadersVisible = false;
            weightsAndInterceptDataGridView.RowTemplate.Height = 25;
            weightsAndInterceptDataGridView.Size = new Size(392, 75);
            weightsAndInterceptDataGridView.TabIndex = 0;
            // 
            // fittingEquationLabel
            // 
            fittingEquationLabel.AutoSize = true;
            fittingEquationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fittingEquationLabel.Location = new Point(111, 31);
            fittingEquationLabel.Name = "fittingEquationLabel";
            fittingEquationLabel.Size = new Size(187, 15);
            fittingEquationLabel.TabIndex = 0;
            fittingEquationLabel.Text = "y = 1 / (1 + exp(-(∑(wi * xi) + b)))";
            // 
            // LogisticRegressionModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fittingEquationGroupBox);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainButton);
            Controls.Add(logisticRegressionLabel);
            Name = "LogisticRegressionModelControl";
            Size = new Size(790, 350);
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxIterationsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)toleranceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)regularizationNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)learningRateNumericUpDown).EndInit();
            fittingEquationGroupBox.ResumeLayout(false);
            fittingEquationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logisticRegressionLabel;
        private Button trainButton;
        private GroupBox hyperparametersGroupBox;
        private NumericUpDown maxIterationsNumericUpDown;
        private Label maxIterationsLabel;
        private NumericUpDown toleranceNumericUpDown;
        private Label toleranceLabel;
        private NumericUpDown regularizationNumericUpDown;
        private Label regularizationLabel;
        private CheckBox stochasticCheckBox;
        private NumericUpDown learningRateNumericUpDown;
        private Label learningRateLabel;
        private RadioButton iterativeReweightedLeastSquaresRadioButton;
        private RadioButton logisticGradientDescentRadioButton;
        private GroupBox fittingEquationGroupBox;
        private Label weightsAndBiasLabel;
        private DataGridView weightsAndInterceptDataGridView;
        private Label fittingEquationLabel;
    }
}
