namespace JadeChem.CustomControls.ModelControls
{
    partial class RandomForestModelControl
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
            randomForestLabel = new Label();
            numberOfTreesLabel = new Label();
            sampleRatioLabel = new Label();
            numberOfTreesNumericUpDown = new NumericUpDown();
            sampleRatioNumericUpDown = new NumericUpDown();
            trainRFButton = new Button();
            hyperparametersGroupBox = new GroupBox();
            treeViewGroupBox = new GroupBox();
            treeLabel = new Label();
            treeComboBox = new ComboBox();
            decisionTreeViewControl = new DiagramControls.DecisionTreeViewControl();
            ((System.ComponentModel.ISupportInitialize)numberOfTreesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sampleRatioNumericUpDown).BeginInit();
            hyperparametersGroupBox.SuspendLayout();
            treeViewGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // randomForestLabel
            // 
            randomForestLabel.AutoSize = true;
            randomForestLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            randomForestLabel.Location = new Point(20, 20);
            randomForestLabel.Name = "randomForestLabel";
            randomForestLabel.Size = new Size(91, 15);
            randomForestLabel.TabIndex = 0;
            randomForestLabel.Text = "Random Forest";
            // 
            // numberOfTreesLabel
            // 
            numberOfTreesLabel.AutoSize = true;
            numberOfTreesLabel.Location = new Point(6, 24);
            numberOfTreesLabel.Name = "numberOfTreesLabel";
            numberOfTreesLabel.Size = new Size(93, 15);
            numberOfTreesLabel.TabIndex = 0;
            numberOfTreesLabel.Text = "Number of trees";
            // 
            // sampleRatioLabel
            // 
            sampleRatioLabel.AutoSize = true;
            sampleRatioLabel.Location = new Point(26, 53);
            sampleRatioLabel.Name = "sampleRatioLabel";
            sampleRatioLabel.Size = new Size(73, 15);
            sampleRatioLabel.TabIndex = 0;
            sampleRatioLabel.Text = "Sample ratio";
            // 
            // numberOfTreesNumericUpDown
            // 
            numberOfTreesNumericUpDown.Location = new Point(105, 22);
            numberOfTreesNumericUpDown.Name = "numberOfTreesNumericUpDown";
            numberOfTreesNumericUpDown.Size = new Size(105, 23);
            numberOfTreesNumericUpDown.TabIndex = 0;
            numberOfTreesNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numberOfTreesNumericUpDown.ValueChanged += NumberOfTreesNumericUpDown_ValueChanged;
            // 
            // sampleRatioNumericUpDown
            // 
            sampleRatioNumericUpDown.DecimalPlaces = 3;
            sampleRatioNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            sampleRatioNumericUpDown.Location = new Point(105, 51);
            sampleRatioNumericUpDown.Name = "sampleRatioNumericUpDown";
            sampleRatioNumericUpDown.Size = new Size(105, 23);
            sampleRatioNumericUpDown.TabIndex = 1;
            sampleRatioNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            sampleRatioNumericUpDown.ValueChanged += SampleRatioNumericUpDown_ValueChanged;
            // 
            // trainRFButton
            // 
            trainRFButton.Location = new Point(20, 146);
            trainRFButton.Name = "trainRFButton";
            trainRFButton.Size = new Size(75, 23);
            trainRFButton.TabIndex = 1;
            trainRFButton.Text = "Train";
            trainRFButton.UseVisualStyleBackColor = true;
            trainRFButton.Click += TrainButton_Click;
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(numberOfTreesNumericUpDown);
            hyperparametersGroupBox.Controls.Add(numberOfTreesLabel);
            hyperparametersGroupBox.Controls.Add(sampleRatioNumericUpDown);
            hyperparametersGroupBox.Controls.Add(sampleRatioLabel);
            hyperparametersGroupBox.Location = new Point(20, 50);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(220, 90);
            hyperparametersGroupBox.TabIndex = 0;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Hyperparameters";
            // 
            // treeViewGroupBox
            // 
            treeViewGroupBox.Controls.Add(treeLabel);
            treeViewGroupBox.Controls.Add(treeComboBox);
            treeViewGroupBox.Controls.Add(decisionTreeViewControl);
            treeViewGroupBox.Location = new Point(246, 50);
            treeViewGroupBox.Name = "treeViewGroupBox";
            treeViewGroupBox.Size = new Size(280, 280);
            treeViewGroupBox.TabIndex = 2;
            treeViewGroupBox.TabStop = false;
            treeViewGroupBox.Text = "Tree view";
            treeViewGroupBox.Visible = false;
            // 
            // treeLabel
            // 
            treeLabel.AutoSize = true;
            treeLabel.Location = new Point(6, 25);
            treeLabel.Name = "treeLabel";
            treeLabel.Size = new Size(28, 15);
            treeLabel.TabIndex = 0;
            treeLabel.Text = "Tree";
            // 
            // treeComboBox
            // 
            treeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            treeComboBox.FormattingEnabled = true;
            treeComboBox.Location = new Point(40, 22);
            treeComboBox.Name = "treeComboBox";
            treeComboBox.Size = new Size(121, 23);
            treeComboBox.TabIndex = 0;
            treeComboBox.SelectedIndexChanged += TreeComboBox_SelectedIndexChanged;
            // 
            // decisionTreeViewControl
            // 
            decisionTreeViewControl.AutoScroll = true;
            decisionTreeViewControl.Dock = DockStyle.Bottom;
            decisionTreeViewControl.Location = new Point(3, 51);
            decisionTreeViewControl.Name = "decisionTreeViewControl";
            decisionTreeViewControl.Size = new Size(274, 226);
            decisionTreeViewControl.TabIndex = 1;
            // 
            // RandomForestModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeViewGroupBox);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(trainRFButton);
            Controls.Add(randomForestLabel);
            Name = "RandomForestModelControl";
            Size = new Size(790, 350);
            ((System.ComponentModel.ISupportInitialize)numberOfTreesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)sampleRatioNumericUpDown).EndInit();
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            treeViewGroupBox.ResumeLayout(false);
            treeViewGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label randomForestLabel;
        private Label numberOfTreesLabel;
        private Label sampleRatioLabel;
        private NumericUpDown numberOfTreesNumericUpDown;
        private NumericUpDown sampleRatioNumericUpDown;
        private Button trainRFButton;
        private GroupBox hyperparametersGroupBox;
        private GroupBox treeViewGroupBox;
        private Label treeLabel;
        private ComboBox treeComboBox;
        private DiagramControls.DecisionTreeViewControl decisionTreeViewControl;
    }
}
