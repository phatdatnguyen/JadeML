namespace JadeChem.CustomControls.ModelControls
{
    partial class RidgeRegressionModelControl
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
            ridgeRegressionLabel = new Label();
            lambdaLabel = new Label();
            lambdaNumericUpDown = new NumericUpDown();
            trainButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            fittingEquationGroupBox = new GroupBox();
            fittingEquationLabel = new Label();
            weightsAndInterceptLabel = new Label();
            weightsAndInterceptDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)lambdaNumericUpDown).BeginInit();
            hyperparametersGroupBox.SuspendLayout();
            fittingEquationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ridgeRegressionLabel
            // 
            ridgeRegressionLabel.AutoSize = true;
            ridgeRegressionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ridgeRegressionLabel.Location = new Point(20, 20);
            ridgeRegressionLabel.Name = "ridgeRegressionLabel";
            ridgeRegressionLabel.Size = new Size(103, 15);
            ridgeRegressionLabel.TabIndex = 0;
            ridgeRegressionLabel.Text = "Ridge Regression";
            // 
            // lambdaLabel
            // 
            lambdaLabel.AutoSize = true;
            lambdaLabel.Location = new Point(6, 24);
            lambdaLabel.Name = "lambdaLabel";
            lambdaLabel.Size = new Size(24, 15);
            lambdaLabel.TabIndex = 0;
            lambdaLabel.Text = "λ =";
            // 
            // lambdaNumericUpDown
            // 
            lambdaNumericUpDown.DecimalPlaces = 4;
            lambdaNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            lambdaNumericUpDown.Location = new Point(36, 22);
            lambdaNumericUpDown.Name = "lambdaNumericUpDown";
            lambdaNumericUpDown.Size = new Size(120, 23);
            lambdaNumericUpDown.TabIndex = 0;
            lambdaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            lambdaNumericUpDown.ValueChanged += LambdaNumericUpDown_ValueChanged;
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 116);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 1;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(lambdaNumericUpDown);
            hyperparametersGroupBox.Controls.Add(lambdaLabel);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(170, 60);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // fittingEquationGroupBox
            // 
            fittingEquationGroupBox.Controls.Add(fittingEquationLabel);
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptLabel);
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptDataGridView);
            fittingEquationGroupBox.Location = new Point(196, 50);
            fittingEquationGroupBox.Name = "fittingEquationGroupBox";
            fittingEquationGroupBox.Size = new Size(570, 150);
            fittingEquationGroupBox.TabIndex = 3;
            fittingEquationGroupBox.TabStop = false;
            fittingEquationGroupBox.Text = "Fitting equation";
            fittingEquationGroupBox.Visible = false;
            // 
            // fittingEquationLabel
            // 
            fittingEquationLabel.AutoSize = true;
            fittingEquationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fittingEquationLabel.Location = new Point(234, 24);
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
            weightsAndInterceptDataGridView.Size = new Size(558, 75);
            weightsAndInterceptDataGridView.TabIndex = 0;
            // 
            // RidgeRegressionModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fittingEquationGroupBox);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainButton);
            Controls.Add(ridgeRegressionLabel);
            Name = "RidgeRegressionModelControl";
            Size = new Size(790, 350);
            ((System.ComponentModel.ISupportInitialize)lambdaNumericUpDown).EndInit();
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            fittingEquationGroupBox.ResumeLayout(false);
            fittingEquationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ridgeRegressionLabel;
        private Label lambdaLabel;
        private NumericUpDown lambdaNumericUpDown;
        private Button trainButton;
        private GroupBox hyperparametersGroupBox;
        private GroupBox fittingEquationGroupBox;
        private Label fittingEquationLabel;
        private Label weightsAndInterceptLabel;
        private DataGridView weightsAndInterceptDataGridView;
    }
}
