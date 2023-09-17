namespace JadeChem.CustomControls.ModelControls
{
    partial class LinearRegressionModelControl
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
            linearRegressionLabel = new Label();
            trainButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            setInterceptZeroCheckBox = new CheckBox();
            fittingEquationGroupBox = new GroupBox();
            weightsAndInterceptLabel = new Label();
            weightsAndInterceptDataGridView = new DataGridView();
            fittingEquationLabel = new Label();
            hyperparametersGroupBox.SuspendLayout();
            fittingEquationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).BeginInit();
            SuspendLayout();
            // 
            // linearRegressionLabel
            // 
            linearRegressionLabel.AutoSize = true;
            linearRegressionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linearRegressionLabel.Location = new Point(20, 20);
            linearRegressionLabel.Name = "linearRegressionLabel";
            linearRegressionLabel.Size = new Size(105, 15);
            linearRegressionLabel.TabIndex = 0;
            linearRegressionLabel.Text = "Linear Regression";
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
            hyperparametersGroupBox.Controls.Add(setInterceptZeroCheckBox);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(150, 60);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // setInterceptZeroCheckBox
            // 
            setInterceptZeroCheckBox.AutoSize = true;
            setInterceptZeroCheckBox.Location = new Point(19, 24);
            setInterceptZeroCheckBox.Name = "setInterceptZeroCheckBox";
            setInterceptZeroCheckBox.Size = new Size(112, 19);
            setInterceptZeroCheckBox.TabIndex = 0;
            setInterceptZeroCheckBox.Text = "Set intercept = 0";
            setInterceptZeroCheckBox.UseVisualStyleBackColor = true;
            setInterceptZeroCheckBox.CheckedChanged += SetInterceptZeroCheckBox_CheckedChanged;
            // 
            // fittingEquationGroupBox
            // 
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptLabel);
            fittingEquationGroupBox.Controls.Add(weightsAndInterceptDataGridView);
            fittingEquationGroupBox.Controls.Add(fittingEquationLabel);
            fittingEquationGroupBox.Location = new Point(176, 50);
            fittingEquationGroupBox.Name = "fittingEquationGroupBox";
            fittingEquationGroupBox.Size = new Size(590, 150);
            fittingEquationGroupBox.TabIndex = 2;
            fittingEquationGroupBox.TabStop = false;
            fittingEquationGroupBox.Text = "Fitting equation";
            fittingEquationGroupBox.Visible = false;
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
            weightsAndInterceptDataGridView.Size = new Size(578, 75);
            weightsAndInterceptDataGridView.TabIndex = 0;
            // 
            // fittingEquationLabel
            // 
            fittingEquationLabel.AutoSize = true;
            fittingEquationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fittingEquationLabel.Location = new Point(250, 28);
            fittingEquationLabel.Name = "fittingEquationLabel";
            fittingEquationLabel.Size = new Size(98, 15);
            fittingEquationLabel.TabIndex = 0;
            fittingEquationLabel.Text = "y = ∑(wi * xi) + b";
            // 
            // LinearRegressionModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fittingEquationGroupBox);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainButton);
            Controls.Add(linearRegressionLabel);
            Name = "LinearRegressionModelControl";
            Size = new Size(790, 350);
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            fittingEquationGroupBox.ResumeLayout(false);
            fittingEquationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndInterceptDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label linearRegressionLabel;
        private Button trainButton;
        private GroupBox hyperparametersGroupBox;
        private CheckBox setInterceptZeroCheckBox;
        private GroupBox fittingEquationGroupBox;
        private Label weightsAndInterceptLabel;
        private DataGridView weightsAndInterceptDataGridView;
        private Label fittingEquationLabel;
    }
}
