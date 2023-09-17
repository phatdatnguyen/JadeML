namespace JadeChem.CustomControls.ModelControls
{
    partial class ElasticNetRegressionModelControl
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
            elasticNetRegressionLabel = new Label();
            lambdaLabel = new Label();
            lambdaNumericUpDown = new NumericUpDown();
            trainButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            alphaNumericUpDown = new NumericUpDown();
            alphaLabel = new Label();
            maxIterationsNumericUpDown = new NumericUpDown();
            maxIterationsLabel = new Label();
            learningRateNumericUpDown = new NumericUpDown();
            learningRateLabel = new Label();
            fittingEquationGroupBox = new GroupBox();
            fittingEquationLabel = new Label();
            weightsAndInterceptLabel = new Label();
            weightsAndInterceptDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)lambdaNumericUpDown).BeginInit();
            hyperparametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alphaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxIterationsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)learningRateNumericUpDown).BeginInit();
            fittingEquationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).BeginInit();
            SuspendLayout();
            // 
            // elasticNetRegressionLabel
            // 
            elasticNetRegressionLabel.AutoSize = true;
            elasticNetRegressionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            elasticNetRegressionLabel.Location = new Point(20, 20);
            elasticNetRegressionLabel.Name = "elasticNetRegressionLabel";
            elasticNetRegressionLabel.Size = new Size(129, 15);
            elasticNetRegressionLabel.TabIndex = 0;
            elasticNetRegressionLabel.Text = "Elastic Net Regression";
            // 
            // lambdaLabel
            // 
            lambdaLabel.AutoSize = true;
            lambdaLabel.Location = new Point(64, 24);
            lambdaLabel.Name = "lambdaLabel";
            lambdaLabel.Size = new Size(24, 15);
            lambdaLabel.TabIndex = 0;
            lambdaLabel.Text = "λ =";
            // 
            // lambdaNumericUpDown
            // 
            lambdaNumericUpDown.DecimalPlaces = 4;
            lambdaNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            lambdaNumericUpDown.Location = new Point(94, 22);
            lambdaNumericUpDown.Name = "lambdaNumericUpDown";
            lambdaNumericUpDown.Size = new Size(120, 23);
            lambdaNumericUpDown.TabIndex = 0;
            lambdaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            lambdaNumericUpDown.ValueChanged += LambdaNumericUpDown_ValueChanged;
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 206);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 1;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(alphaNumericUpDown);
            hyperparametersGroupBox.Controls.Add(alphaLabel);
            hyperparametersGroupBox.Controls.Add(maxIterationsNumericUpDown);
            hyperparametersGroupBox.Controls.Add(maxIterationsLabel);
            hyperparametersGroupBox.Controls.Add(learningRateNumericUpDown);
            hyperparametersGroupBox.Controls.Add(learningRateLabel);
            hyperparametersGroupBox.Controls.Add(lambdaNumericUpDown);
            hyperparametersGroupBox.Controls.Add(lambdaLabel);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(230, 150);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // alphaNumericUpDown
            // 
            alphaNumericUpDown.DecimalPlaces = 2;
            alphaNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            alphaNumericUpDown.Location = new Point(94, 51);
            alphaNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            alphaNumericUpDown.Name = "alphaNumericUpDown";
            alphaNumericUpDown.Size = new Size(120, 23);
            alphaNumericUpDown.TabIndex = 1;
            alphaNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            alphaNumericUpDown.ValueChanged += AlphaNumericUpDown_ValueChanged;
            // 
            // alphaLabel
            // 
            alphaLabel.AutoSize = true;
            alphaLabel.Location = new Point(64, 53);
            alphaLabel.Name = "alphaLabel";
            alphaLabel.Size = new Size(25, 15);
            alphaLabel.TabIndex = 0;
            alphaLabel.Text = "α =";
            // 
            // maxIterationsNumericUpDown
            // 
            maxIterationsNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            maxIterationsNumericUpDown.Location = new Point(94, 109);
            maxIterationsNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            maxIterationsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxIterationsNumericUpDown.Name = "maxIterationsNumericUpDown";
            maxIterationsNumericUpDown.Size = new Size(120, 23);
            maxIterationsNumericUpDown.TabIndex = 3;
            maxIterationsNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            maxIterationsNumericUpDown.ValueChanged += MaxIterationsNumericUpDown_ValueChanged;
            // 
            // maxIterationsLabel
            // 
            maxIterationsLabel.AutoSize = true;
            maxIterationsLabel.Location = new Point(6, 111);
            maxIterationsLabel.Name = "maxIterationsLabel";
            maxIterationsLabel.Size = new Size(82, 15);
            maxIterationsLabel.TabIndex = 0;
            maxIterationsLabel.Text = "Max iterations";
            // 
            // learningRateNumericUpDown
            // 
            learningRateNumericUpDown.DecimalPlaces = 9;
            learningRateNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 589824 });
            learningRateNumericUpDown.Location = new Point(94, 80);
            learningRateNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 589824 });
            learningRateNumericUpDown.Name = "learningRateNumericUpDown";
            learningRateNumericUpDown.Size = new Size(120, 23);
            learningRateNumericUpDown.TabIndex = 2;
            learningRateNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 458752 });
            learningRateNumericUpDown.ValueChanged += LearningRateNumericUpDown_ValueChanged;
            // 
            // learningRateLabel
            // 
            learningRateLabel.AutoSize = true;
            learningRateLabel.Location = new Point(12, 82);
            learningRateLabel.Name = "learningRateLabel";
            learningRateLabel.Size = new Size(76, 15);
            learningRateLabel.TabIndex = 0;
            learningRateLabel.Text = "Learning rate";
            // 
            // fittingEquationGroupBox
            // 
            fittingEquationGroupBox.Controls.Add(fittingEquationLabel);
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptLabel);
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptDataGridView);
            fittingEquationGroupBox.Location = new Point(256, 50);
            fittingEquationGroupBox.Name = "fittingEquationGroupBox";
            fittingEquationGroupBox.Size = new Size(510, 150);
            fittingEquationGroupBox.TabIndex = 2;
            fittingEquationGroupBox.TabStop = false;
            fittingEquationGroupBox.Text = "Fitting equation";
            fittingEquationGroupBox.Visible = false;
            // 
            // fittingEquationLabel
            // 
            fittingEquationLabel.AutoSize = true;
            fittingEquationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fittingEquationLabel.Location = new Point(205, 24);
            fittingEquationLabel.Name = "fittingEquationLabel";
            fittingEquationLabel.Size = new Size(98, 15);
            fittingEquationLabel.TabIndex = 3;
            fittingEquationLabel.Text = "y = ∑(wi * xi) + b";
            // 
            // weightsAndInterceptLabel
            // 
            weightsAndInterceptLabel.AutoSize = true;
            weightsAndInterceptLabel.Location = new Point(6, 51);
            weightsAndInterceptLabel.Name = "weightsAndInterceptLabel";
            weightsAndInterceptLabel.Size = new Size(123, 15);
            weightsAndInterceptLabel.TabIndex = 0;
            weightsAndInterceptLabel.Text = "Weights and intercept";
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
            weightsAndInterceptDataGridView.Size = new Size(498, 75);
            weightsAndInterceptDataGridView.TabIndex = 0;
            // 
            // ElasticNetRegressionModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fittingEquationGroupBox);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainButton);
            Controls.Add(elasticNetRegressionLabel);
            Name = "ElasticNetRegressionModelControl";
            Size = new Size(790, 350);
            ((System.ComponentModel.ISupportInitialize)lambdaNumericUpDown).EndInit();
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alphaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxIterationsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)learningRateNumericUpDown).EndInit();
            fittingEquationGroupBox.ResumeLayout(false);
            fittingEquationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label elasticNetRegressionLabel;
        private Label lambdaLabel;
        private NumericUpDown lambdaNumericUpDown;
        private Button trainButton;
        private GroupBox hyperparametersGroupBox;
        private NumericUpDown maxIterationsNumericUpDown;
        private Label maxIterationsLabel;
        private NumericUpDown learningRateNumericUpDown;
        private Label learningRateLabel;
        private NumericUpDown alphaNumericUpDown;
        private Label alphaLabel;
        private GroupBox fittingEquationGroupBox;
        private Label weightsAndInterceptLabel;
        private DataGridView weightsAndInterceptDataGridView;
        private Label fittingEquationLabel;
    }
}
