namespace JadeML.Regression
{
    partial class ANNRegressionLearningControl
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
            this.components = new System.ComponentModel.Container();
            this.trainingTimer = new System.Windows.Forms.Timer(this.components);
            this.learningTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.networkViewPanel = new System.Windows.Forms.Panel();
            this.networkDiagramView = new MindFusion.Diagramming.WinForms.DiagramView();
            this.networkDiagram = new MindFusion.Diagramming.Diagram();
            this.networkDiagramZoomControl = new MindFusion.Common.WinForms.ZoomControl();
            this.trainingGroupBox = new System.Windows.Forms.GroupBox();
            this.toleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.maxIterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.elapsedTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.maxIterationLabel = new System.Windows.Forms.Label();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.iterationTextBox = new System.Windows.Forms.TextBox();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.trainingParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.nguyenWidrowCheckBox = new System.Windows.Forms.CheckBox();
            this.bayesianRegularizationCheckBox = new System.Windows.Forms.CheckBox();
            this.sameWeightsCheckBox = new System.Windows.Forms.CheckBox();
            this.learningRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.learningRateLabel = new System.Windows.Forms.Label();
            this.learningMethodComboBox = new System.Windows.Forms.ComboBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.networkLabel = new System.Windows.Forms.Label();
            this.trainingLabel = new System.Windows.Forms.Label();
            this.networkStructureGroupBox = new System.Windows.Forms.GroupBox();
            this.networkStructurePanel = new System.Windows.Forms.Panel();
            this.buildButton = new System.Windows.Forms.Button();
            this.deleteLayerButton = new System.Windows.Forms.Button();
            this.addLayerButton = new System.Windows.Forms.Button();
            this.networkStructureDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activationFuncionGroupBox = new System.Windows.Forms.GroupBox();
            this.upperLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.upperLimitLabel = new System.Windows.Forms.Label();
            this.lowerLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowerLimitLabel = new System.Windows.Forms.Label();
            this.activationFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.alphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activationFunctionLabel = new System.Windows.Forms.Label();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.learningTableLayoutPanel.SuspendLayout();
            this.networkViewPanel.SuspendLayout();
            this.trainingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumericUpDown)).BeginInit();
            this.trainingParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNumericUpDown)).BeginInit();
            this.networkStructureGroupBox.SuspendLayout();
            this.networkStructurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkStructureDataGridView)).BeginInit();
            this.activationFuncionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingTimer
            // 
            this.trainingTimer.Tick += new System.EventHandler(this.trainingTimer_Tick);
            // 
            // learningTableLayoutPanel
            // 
            this.learningTableLayoutPanel.ColumnCount = 3;
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.learningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.learningTableLayoutPanel.Controls.Add(this.networkViewPanel, 2, 0);
            this.learningTableLayoutPanel.Controls.Add(this.trainingGroupBox, 1, 3);
            this.learningTableLayoutPanel.Controls.Add(this.trainingParametersGroupBox, 0, 3);
            this.learningTableLayoutPanel.Controls.Add(this.networkLabel, 0, 0);
            this.learningTableLayoutPanel.Controls.Add(this.trainingLabel, 0, 2);
            this.learningTableLayoutPanel.Controls.Add(this.networkStructureGroupBox, 0, 1);
            this.learningTableLayoutPanel.Controls.Add(this.activationFuncionGroupBox, 1, 1);
            this.learningTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.learningTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.learningTableLayoutPanel.Name = "learningTableLayoutPanel";
            this.learningTableLayoutPanel.RowCount = 4;
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.learningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.learningTableLayoutPanel.Size = new System.Drawing.Size(1200, 488);
            this.learningTableLayoutPanel.TabIndex = 1;
            // 
            // networkViewPanel
            // 
            this.networkViewPanel.Controls.Add(this.networkDiagramView);
            this.networkViewPanel.Controls.Add(this.networkDiagramZoomControl);
            this.networkViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkViewPanel.Location = new System.Drawing.Point(593, 3);
            this.networkViewPanel.Name = "networkViewPanel";
            this.learningTableLayoutPanel.SetRowSpan(this.networkViewPanel, 4);
            this.networkViewPanel.Size = new System.Drawing.Size(604, 482);
            this.networkViewPanel.TabIndex = 4;
            // 
            // networkDiagramView
            // 
            this.networkDiagramView.Behavior = MindFusion.Diagramming.Behavior.Modify;
            this.networkDiagramView.Diagram = this.networkDiagram;
            this.networkDiagramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkDiagramView.LicenseKey = null;
            this.networkDiagramView.Location = new System.Drawing.Point(0, 0);
            this.networkDiagramView.Name = "networkDiagramView";
            this.networkDiagramView.Size = new System.Drawing.Size(544, 482);
            this.networkDiagramView.TabIndex = 0;
            this.networkDiagramView.Text = "diagramView1";
            // 
            // networkDiagram
            // 
            this.networkDiagram.TouchThreshold = 0F;
            // 
            // networkDiagramZoomControl
            // 
            this.networkDiagramZoomControl.BackColor = System.Drawing.Color.Transparent;
            this.networkDiagramZoomControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.networkDiagramZoomControl.Location = new System.Drawing.Point(544, 0);
            this.networkDiagramZoomControl.Name = "networkDiagramZoomControl";
            this.networkDiagramZoomControl.Padding = new System.Windows.Forms.Padding(5);
            this.networkDiagramZoomControl.Size = new System.Drawing.Size(60, 482);
            this.networkDiagramZoomControl.TabIndex = 1;
            this.networkDiagramZoomControl.Target = this.networkDiagramView;
            this.networkDiagramZoomControl.TickPosition = MindFusion.Common.WinForms.TickPosition.Left;
            // 
            // trainingGroupBox
            // 
            this.trainingGroupBox.Controls.Add(this.toleranceNumericUpDown);
            this.trainingGroupBox.Controls.Add(this.toleranceLabel);
            this.trainingGroupBox.Controls.Add(this.maxIterationNumericUpDown);
            this.trainingGroupBox.Controls.Add(this.elapsedTextBox);
            this.trainingGroupBox.Controls.Add(this.startButton);
            this.trainingGroupBox.Controls.Add(this.maxIterationLabel);
            this.trainingGroupBox.Controls.Add(this.errorTextBox);
            this.trainingGroupBox.Controls.Add(this.stopButton);
            this.trainingGroupBox.Controls.Add(this.iterationTextBox);
            this.trainingGroupBox.Controls.Add(this.elapsedLabel);
            this.trainingGroupBox.Controls.Add(this.errorLabel);
            this.trainingGroupBox.Controls.Add(this.iterationLabel);
            this.trainingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingGroupBox.Location = new System.Drawing.Point(327, 275);
            this.trainingGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.trainingGroupBox.Name = "trainingGroupBox";
            this.trainingGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.trainingGroupBox.Size = new System.Drawing.Size(261, 211);
            this.trainingGroupBox.TabIndex = 3;
            this.trainingGroupBox.TabStop = false;
            this.trainingGroupBox.Text = "Training";
            // 
            // toleranceNumericUpDown
            // 
            this.toleranceNumericUpDown.DecimalPlaces = 4;
            this.toleranceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.toleranceNumericUpDown.Location = new System.Drawing.Point(144, 33);
            this.toleranceNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            this.toleranceNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.toleranceNumericUpDown.TabIndex = 0;
            this.toleranceNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceLabel.Location = new System.Drawing.Point(85, 35);
            this.toleranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(55, 13);
            this.toleranceLabel.TabIndex = 0;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // maxIterationNumericUpDown
            // 
            this.maxIterationNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxIterationNumericUpDown.Location = new System.Drawing.Point(144, 56);
            this.maxIterationNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.maxIterationNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxIterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIterationNumericUpDown.Name = "maxIterationNumericUpDown";
            this.maxIterationNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.maxIterationNumericUpDown.TabIndex = 1;
            this.maxIterationNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // elapsedTextBox
            // 
            this.elapsedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTextBox.Location = new System.Drawing.Point(127, 173);
            this.elapsedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.elapsedTextBox.Name = "elapsedTextBox";
            this.elapsedTextBox.ReadOnly = true;
            this.elapsedTextBox.Size = new System.Drawing.Size(92, 19);
            this.elapsedTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Image = global::JadeML.Properties.Resources.start;
            this.startButton.Location = new System.Drawing.Point(96, 82);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // maxIterationLabel
            // 
            this.maxIterationLabel.AutoSize = true;
            this.maxIterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxIterationLabel.Location = new System.Drawing.Point(73, 58);
            this.maxIterationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxIterationLabel.Name = "maxIterationLabel";
            this.maxIterationLabel.Size = new System.Drawing.Size(67, 13);
            this.maxIterationLabel.TabIndex = 0;
            this.maxIterationLabel.Text = "Max iteration";
            // 
            // errorTextBox
            // 
            this.errorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTextBox.Location = new System.Drawing.Point(127, 148);
            this.errorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.Size = new System.Drawing.Size(92, 19);
            this.errorTextBox.TabIndex = 5;
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Image = global::JadeML.Properties.Resources.stop;
            this.stopButton.Location = new System.Drawing.Point(160, 82);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // iterationTextBox
            // 
            this.iterationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationTextBox.Location = new System.Drawing.Point(127, 122);
            this.iterationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iterationTextBox.Name = "iterationTextBox";
            this.iterationTextBox.ReadOnly = true;
            this.iterationTextBox.Size = new System.Drawing.Size(92, 19);
            this.iterationTextBox.TabIndex = 4;
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedLabel.Location = new System.Drawing.Point(78, 176);
            this.elapsedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(45, 13);
            this.elapsedLabel.TabIndex = 0;
            this.elapsedLabel.Text = "Elapsed";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(94, 151);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(29, 13);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "Error";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationLabel.Location = new System.Drawing.Point(78, 125);
            this.iterationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(45, 13);
            this.iterationLabel.TabIndex = 0;
            this.iterationLabel.Text = "Iteration";
            // 
            // trainingParametersGroupBox
            // 
            this.trainingParametersGroupBox.Controls.Add(this.nguyenWidrowCheckBox);
            this.trainingParametersGroupBox.Controls.Add(this.bayesianRegularizationCheckBox);
            this.trainingParametersGroupBox.Controls.Add(this.sameWeightsCheckBox);
            this.trainingParametersGroupBox.Controls.Add(this.learningRateNumericUpDown);
            this.trainingParametersGroupBox.Controls.Add(this.learningRateLabel);
            this.trainingParametersGroupBox.Controls.Add(this.learningMethodComboBox);
            this.trainingParametersGroupBox.Controls.Add(this.methodLabel);
            this.trainingParametersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingParametersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingParametersGroupBox.Location = new System.Drawing.Point(2, 275);
            this.trainingParametersGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.trainingParametersGroupBox.Name = "trainingParametersGroupBox";
            this.trainingParametersGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.trainingParametersGroupBox.Size = new System.Drawing.Size(321, 211);
            this.trainingParametersGroupBox.TabIndex = 2;
            this.trainingParametersGroupBox.TabStop = false;
            this.trainingParametersGroupBox.Text = "Training Parameters";
            // 
            // nguyenWidrowCheckBox
            // 
            this.nguyenWidrowCheckBox.AutoSize = true;
            this.nguyenWidrowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguyenWidrowCheckBox.Location = new System.Drawing.Point(140, 146);
            this.nguyenWidrowCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.nguyenWidrowCheckBox.Name = "nguyenWidrowCheckBox";
            this.nguyenWidrowCheckBox.Size = new System.Drawing.Size(163, 17);
            this.nguyenWidrowCheckBox.TabIndex = 3;
            this.nguyenWidrowCheckBox.Text = "Use Nguyen-Widrow weights";
            this.nguyenWidrowCheckBox.UseVisualStyleBackColor = true;
            // 
            // bayesianRegularizationCheckBox
            // 
            this.bayesianRegularizationCheckBox.AutoSize = true;
            this.bayesianRegularizationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayesianRegularizationCheckBox.Location = new System.Drawing.Point(140, 122);
            this.bayesianRegularizationCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.bayesianRegularizationCheckBox.Name = "bayesianRegularizationCheckBox";
            this.bayesianRegularizationCheckBox.Size = new System.Drawing.Size(156, 17);
            this.bayesianRegularizationCheckBox.TabIndex = 2;
            this.bayesianRegularizationCheckBox.Text = "Use Bayesian regularization";
            this.bayesianRegularizationCheckBox.UseVisualStyleBackColor = true;
            // 
            // sameWeightsCheckBox
            // 
            this.sameWeightsCheckBox.AutoSize = true;
            this.sameWeightsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameWeightsCheckBox.Location = new System.Drawing.Point(140, 171);
            this.sameWeightsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.sameWeightsCheckBox.Name = "sameWeightsCheckBox";
            this.sameWeightsCheckBox.Size = new System.Drawing.Size(164, 17);
            this.sameWeightsCheckBox.TabIndex = 4;
            this.sameWeightsCheckBox.Text = "Use always same initialization";
            this.sameWeightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // learningRateNumericUpDown
            // 
            this.learningRateNumericUpDown.DecimalPlaces = 4;
            this.learningRateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningRateNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.learningRateNumericUpDown.Location = new System.Drawing.Point(93, 72);
            this.learningRateNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.learningRateNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.learningRateNumericUpDown.Name = "learningRateNumericUpDown";
            this.learningRateNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.learningRateNumericUpDown.TabIndex = 1;
            this.learningRateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // learningRateLabel
            // 
            this.learningRateLabel.AutoSize = true;
            this.learningRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningRateLabel.Location = new System.Drawing.Point(20, 74);
            this.learningRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.learningRateLabel.Name = "learningRateLabel";
            this.learningRateLabel.Size = new System.Drawing.Size(69, 13);
            this.learningRateLabel.TabIndex = 0;
            this.learningRateLabel.Text = "Learning rate";
            // 
            // learningMethodComboBox
            // 
            this.learningMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.learningMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningMethodComboBox.FormattingEnabled = true;
            this.learningMethodComboBox.Items.AddRange(new object[] {
            "Levenberg-Marquardt",
            "Backpropagation",
            "Resilient Backpropagation",
            "Parallel Resilient Backpropagation",
            "Perceptron",
            "Delta Rule"});
            this.learningMethodComboBox.Location = new System.Drawing.Point(93, 46);
            this.learningMethodComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.learningMethodComboBox.Name = "learningMethodComboBox";
            this.learningMethodComboBox.Size = new System.Drawing.Size(204, 21);
            this.learningMethodComboBox.TabIndex = 0;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLabel.Location = new System.Drawing.Point(46, 49);
            this.methodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(43, 13);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "Method";
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.learningTableLayoutPanel.SetColumnSpan(this.networkLabel, 2);
            this.networkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkLabel.Location = new System.Drawing.Point(3, 0);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(584, 49);
            this.networkLabel.TabIndex = 0;
            this.networkLabel.Text = "Artificial Neural Network - Build Network";
            this.networkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.learningTableLayoutPanel.SetColumnSpan(this.trainingLabel, 2);
            this.trainingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingLabel.Location = new System.Drawing.Point(3, 224);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(584, 49);
            this.trainingLabel.TabIndex = 0;
            this.trainingLabel.Text = "Artificial Neural Network - Training";
            this.trainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkStructureGroupBox
            // 
            this.networkStructureGroupBox.Controls.Add(this.networkStructurePanel);
            this.networkStructureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkStructureGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkStructureGroupBox.Location = new System.Drawing.Point(2, 51);
            this.networkStructureGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.networkStructureGroupBox.Name = "networkStructureGroupBox";
            this.networkStructureGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.networkStructureGroupBox.Size = new System.Drawing.Size(321, 171);
            this.networkStructureGroupBox.TabIndex = 0;
            this.networkStructureGroupBox.TabStop = false;
            this.networkStructureGroupBox.Text = "Network Structure";
            // 
            // networkStructurePanel
            // 
            this.networkStructurePanel.Controls.Add(this.buildButton);
            this.networkStructurePanel.Controls.Add(this.deleteLayerButton);
            this.networkStructurePanel.Controls.Add(this.addLayerButton);
            this.networkStructurePanel.Controls.Add(this.networkStructureDataGridView);
            this.networkStructurePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkStructurePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkStructurePanel.Location = new System.Drawing.Point(2, 18);
            this.networkStructurePanel.Margin = new System.Windows.Forms.Padding(2);
            this.networkStructurePanel.Name = "networkStructurePanel";
            this.networkStructurePanel.Size = new System.Drawing.Size(317, 151);
            this.networkStructurePanel.TabIndex = 0;
            // 
            // buildButton
            // 
            this.buildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildButton.Location = new System.Drawing.Point(255, 101);
            this.buildButton.Margin = new System.Windows.Forms.Padding(2);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(60, 46);
            this.buildButton.TabIndex = 3;
            this.buildButton.Text = "Build network";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // deleteLayerButton
            // 
            this.deleteLayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLayerButton.Location = new System.Drawing.Point(255, 29);
            this.deleteLayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteLayerButton.Name = "deleteLayerButton";
            this.deleteLayerButton.Size = new System.Drawing.Size(60, 23);
            this.deleteLayerButton.TabIndex = 2;
            this.deleteLayerButton.Text = "Delete";
            this.deleteLayerButton.UseVisualStyleBackColor = true;
            this.deleteLayerButton.Click += new System.EventHandler(this.deleteLayerButton_Click);
            // 
            // addLayerButton
            // 
            this.addLayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLayerButton.Location = new System.Drawing.Point(255, 2);
            this.addLayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addLayerButton.Name = "addLayerButton";
            this.addLayerButton.Size = new System.Drawing.Size(60, 23);
            this.addLayerButton.TabIndex = 1;
            this.addLayerButton.Text = "Add";
            this.addLayerButton.UseVisualStyleBackColor = true;
            this.addLayerButton.Click += new System.EventHandler(this.addLayerButton_Click);
            // 
            // networkStructureDataGridView
            // 
            this.networkStructureDataGridView.AllowUserToAddRows = false;
            this.networkStructureDataGridView.AllowUserToDeleteRows = false;
            this.networkStructureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.networkStructureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.networkStructureDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkStructureDataGridView.Location = new System.Drawing.Point(0, 0);
            this.networkStructureDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.networkStructureDataGridView.Name = "networkStructureDataGridView";
            this.networkStructureDataGridView.RowHeadersVisible = false;
            this.networkStructureDataGridView.RowHeadersWidth = 51;
            this.networkStructureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.networkStructureDataGridView.Size = new System.Drawing.Size(251, 151);
            this.networkStructureDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hidden layer";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Neurons";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activationFuncionGroupBox
            // 
            this.activationFuncionGroupBox.Controls.Add(this.upperLimitNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.upperLimitLabel);
            this.activationFuncionGroupBox.Controls.Add(this.lowerLimitNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.lowerLimitLabel);
            this.activationFuncionGroupBox.Controls.Add(this.activationFunctionComboBox);
            this.activationFuncionGroupBox.Controls.Add(this.alphaNumericUpDown);
            this.activationFuncionGroupBox.Controls.Add(this.activationFunctionLabel);
            this.activationFuncionGroupBox.Controls.Add(this.alphaLabel);
            this.activationFuncionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activationFuncionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationFuncionGroupBox.Location = new System.Drawing.Point(327, 51);
            this.activationFuncionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.activationFuncionGroupBox.Name = "activationFuncionGroupBox";
            this.activationFuncionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.activationFuncionGroupBox.Size = new System.Drawing.Size(261, 171);
            this.activationFuncionGroupBox.TabIndex = 1;
            this.activationFuncionGroupBox.TabStop = false;
            this.activationFuncionGroupBox.Text = "Activation Function";
            // 
            // upperLimitNumericUpDown
            // 
            this.upperLimitNumericUpDown.DecimalPlaces = 1;
            this.upperLimitNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperLimitNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.upperLimitNumericUpDown.Location = new System.Drawing.Point(159, 127);
            this.upperLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.upperLimitNumericUpDown.Name = "upperLimitNumericUpDown";
            this.upperLimitNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.upperLimitNumericUpDown.TabIndex = 3;
            this.upperLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upperLimitLabel
            // 
            this.upperLimitLabel.AutoSize = true;
            this.upperLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperLimitLabel.Location = new System.Drawing.Point(62, 129);
            this.upperLimitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upperLimitLabel.Name = "upperLimitLabel";
            this.upperLimitLabel.Size = new System.Drawing.Size(93, 13);
            this.upperLimitLabel.TabIndex = 0;
            this.upperLimitLabel.Text = "Linear\'s upper limit";
            // 
            // lowerLimitNumericUpDown
            // 
            this.lowerLimitNumericUpDown.DecimalPlaces = 1;
            this.lowerLimitNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLimitNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lowerLimitNumericUpDown.Location = new System.Drawing.Point(159, 101);
            this.lowerLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.lowerLimitNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lowerLimitNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lowerLimitNumericUpDown.Name = "lowerLimitNumericUpDown";
            this.lowerLimitNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.lowerLimitNumericUpDown.TabIndex = 2;
            this.lowerLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lowerLimitLabel
            // 
            this.lowerLimitLabel.AutoSize = true;
            this.lowerLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLimitLabel.Location = new System.Drawing.Point(64, 103);
            this.lowerLimitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(91, 13);
            this.lowerLimitLabel.TabIndex = 0;
            this.lowerLimitLabel.Text = "Linear\'s lower limit";
            // 
            // activationFunctionComboBox
            // 
            this.activationFunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activationFunctionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationFunctionComboBox.FormattingEnabled = true;
            this.activationFunctionComboBox.Items.AddRange(new object[] {
            "Rectified Linear",
            "Sigmoid",
            "Bipolar Sigmoid",
            "Linear",
            "Threshold",
            "Identity"});
            this.activationFunctionComboBox.Location = new System.Drawing.Point(84, 47);
            this.activationFunctionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.activationFunctionComboBox.Name = "activationFunctionComboBox";
            this.activationFunctionComboBox.Size = new System.Drawing.Size(151, 21);
            this.activationFunctionComboBox.TabIndex = 0;
            // 
            // alphaNumericUpDown
            // 
            this.alphaNumericUpDown.DecimalPlaces = 1;
            this.alphaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphaNumericUpDown.Location = new System.Drawing.Point(159, 75);
            this.alphaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.alphaNumericUpDown.Name = "alphaNumericUpDown";
            this.alphaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.alphaNumericUpDown.TabIndex = 1;
            this.alphaNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // activationFunctionLabel
            // 
            this.activationFunctionLabel.AutoSize = true;
            this.activationFunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationFunctionLabel.Location = new System.Drawing.Point(32, 50);
            this.activationFunctionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activationFunctionLabel.Name = "activationFunctionLabel";
            this.activationFunctionLabel.Size = new System.Drawing.Size(48, 13);
            this.activationFunctionLabel.TabIndex = 0;
            this.activationFunctionLabel.Text = "Function";
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaLabel.Location = new System.Drawing.Point(94, 77);
            this.alphaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(61, 13);
            this.alphaLabel.TabIndex = 0;
            this.alphaLabel.Text = "Sigmoid\'s α";
            // 
            // ANNRegressionLearningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.learningTableLayoutPanel);
            this.Name = "ANNRegressionLearningControl";
            this.Size = new System.Drawing.Size(1200, 488);
            this.learningTableLayoutPanel.ResumeLayout(false);
            this.learningTableLayoutPanel.PerformLayout();
            this.networkViewPanel.ResumeLayout(false);
            this.trainingGroupBox.ResumeLayout(false);
            this.trainingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationNumericUpDown)).EndInit();
            this.trainingParametersGroupBox.ResumeLayout(false);
            this.trainingParametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNumericUpDown)).EndInit();
            this.networkStructureGroupBox.ResumeLayout(false);
            this.networkStructurePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.networkStructureDataGridView)).EndInit();
            this.activationFuncionGroupBox.ResumeLayout(false);
            this.activationFuncionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer trainingTimer;
        private System.Windows.Forms.TableLayoutPanel learningTableLayoutPanel;
        private System.Windows.Forms.GroupBox trainingGroupBox;
        private System.Windows.Forms.NumericUpDown toleranceNumericUpDown;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.NumericUpDown maxIterationNumericUpDown;
        private System.Windows.Forms.TextBox elapsedTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label maxIterationLabel;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox iterationTextBox;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.GroupBox trainingParametersGroupBox;
        private System.Windows.Forms.CheckBox nguyenWidrowCheckBox;
        private System.Windows.Forms.CheckBox bayesianRegularizationCheckBox;
        private System.Windows.Forms.CheckBox sameWeightsCheckBox;
        private System.Windows.Forms.NumericUpDown learningRateNumericUpDown;
        private System.Windows.Forms.Label learningRateLabel;
        private System.Windows.Forms.ComboBox learningMethodComboBox;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Label trainingLabel;
        private System.Windows.Forms.GroupBox networkStructureGroupBox;
        private System.Windows.Forms.Panel networkStructurePanel;
        private System.Windows.Forms.Button deleteLayerButton;
        private System.Windows.Forms.Button addLayerButton;
        private System.Windows.Forms.DataGridView networkStructureDataGridView;
        private System.Windows.Forms.GroupBox activationFuncionGroupBox;
        private System.Windows.Forms.NumericUpDown upperLimitNumericUpDown;
        private System.Windows.Forms.Label upperLimitLabel;
        private System.Windows.Forms.NumericUpDown lowerLimitNumericUpDown;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.ComboBox activationFunctionComboBox;
        private System.Windows.Forms.NumericUpDown alphaNumericUpDown;
        private System.Windows.Forms.Label activationFunctionLabel;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Panel networkViewPanel;
        private MindFusion.Diagramming.WinForms.DiagramView networkDiagramView;
        private MindFusion.Common.WinForms.ZoomControl networkDiagramZoomControl;
        private MindFusion.Diagramming.Diagram networkDiagram;
    }
}
