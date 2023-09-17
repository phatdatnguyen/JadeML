namespace JadeChem.CustomControls.ModelControls
{
    partial class MLPModelControl
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
            trainButton = new Button();
            deviceGroupBox = new GroupBox();
            deviceComboBox = new ComboBox();
            addLayerButton = new Button();
            hiddenLayersListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            removeLayerButton = new Button();
            epochsLabel = new Label();
            epochsNumericUpDown = new NumericUpDown();
            optimizerComboBox = new ComboBox();
            optimizerLabel = new Label();
            trainProgressBar = new ProgressBar();
            learningRateNumericUpDown = new NumericUpDown();
            learningRateLabel = new Label();
            lossFunctionLabel = new Label();
            mlpLabel = new Label();
            hyperparametersGroupBox = new GroupBox();
            viewNetworkStructureButton = new Button();
            editLayerButton = new Button();
            modelNameLabel = new Label();
            networkNameTextBox = new TextBox();
            createNetworkButton = new Button();
            loadCheckpointButton = new Button();
            lossFunctionComboBox = new ComboBox();
            validationGroupBox = new GroupBox();
            splitDataButton = new Button();
            validationCheckBox = new CheckBox();
            trainingGroupBox = new GroupBox();
            configureOptimerAndSchedulerButton = new Button();
            schedulerComboBox = new ComboBox();
            schedulerLabel = new Label();
            visualizeLossesButton = new Button();
            saveStatusLabel = new Label();
            validationLossLabel = new Label();
            trainLossLabel = new Label();
            chooseSaveFolderButton = new Button();
            trainProgressLabel = new Label();
            saveIntervalNumericUpDown = new NumericUpDown();
            saveIntervalLabel = new Label();
            chooseLogFolderButton = new Button();
            logWithTensorboardCheckBox = new CheckBox();
            dataTypeGroupBox = new GroupBox();
            dataTypeComboBox = new ComboBox();
            logFolderBrowserDialog = new FolderBrowserDialog();
            saveFolderBrowserDialog = new FolderBrowserDialog();
            loadCheckpointFileDialog = new OpenFileDialog();
            groupBox1 = new GroupBox();
            randomSeedNumericUpDown = new NumericUpDown();
            groupBox2 = new GroupBox();
            deviceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epochsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)learningRateNumericUpDown).BeginInit();
            hyperparametersGroupBox.SuspendLayout();
            validationGroupBox.SuspendLayout();
            trainingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saveIntervalNumericUpDown).BeginInit();
            dataTypeGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)randomSeedNumericUpDown).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // trainButton
            // 
            trainButton.Location = new Point(203, 141);
            trainButton.Margin = new Padding(4, 3, 4, 3);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 8;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // deviceGroupBox
            // 
            deviceGroupBox.Controls.Add(deviceComboBox);
            deviceGroupBox.Location = new Point(20, 50);
            deviceGroupBox.Name = "deviceGroupBox";
            deviceGroupBox.Size = new Size(106, 53);
            deviceGroupBox.TabIndex = 0;
            deviceGroupBox.TabStop = false;
            deviceGroupBox.Text = "Device";
            // 
            // deviceComboBox
            // 
            deviceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deviceComboBox.FormattingEnabled = true;
            deviceComboBox.Items.AddRange(new object[] { "CPU" });
            deviceComboBox.Location = new Point(11, 20);
            deviceComboBox.Name = "deviceComboBox";
            deviceComboBox.Size = new Size(80, 23);
            deviceComboBox.TabIndex = 0;
            deviceComboBox.SelectedIndexChanged += DeviceComboBox_SelectedIndexChanged;
            // 
            // addLayerButton
            // 
            addLayerButton.Location = new Point(6, 150);
            addLayerButton.Name = "addLayerButton";
            addLayerButton.Size = new Size(100, 23);
            addLayerButton.TabIndex = 2;
            addLayerButton.Text = "Add layer...";
            addLayerButton.UseVisualStyleBackColor = true;
            addLayerButton.Click += AddLayerButton_Click;
            // 
            // hiddenLayersListView
            // 
            hiddenLayersListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            hiddenLayersListView.FullRowSelect = true;
            hiddenLayersListView.Location = new Point(6, 51);
            hiddenLayersListView.MultiSelect = false;
            hiddenLayersListView.Name = "hiddenLayersListView";
            hiddenLayersListView.Size = new Size(308, 93);
            hiddenLayersListView.TabIndex = 1;
            hiddenLayersListView.UseCompatibleStateImageBehavior = false;
            hiddenLayersListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hidden layer";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Neurons";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Activation function";
            columnHeader3.Width = 120;
            // 
            // removeLayerButton
            // 
            removeLayerButton.Location = new Point(218, 150);
            removeLayerButton.Name = "removeLayerButton";
            removeLayerButton.Size = new Size(96, 23);
            removeLayerButton.TabIndex = 4;
            removeLayerButton.Text = "Remove layer";
            removeLayerButton.UseVisualStyleBackColor = true;
            removeLayerButton.Click += RemoveLayerButton_Click;
            // 
            // epochsLabel
            // 
            epochsLabel.AutoSize = true;
            epochsLabel.Location = new Point(27, 143);
            epochsLabel.Name = "epochsLabel";
            epochsLabel.Size = new Size(45, 15);
            epochsLabel.TabIndex = 0;
            epochsLabel.Text = "Epochs";
            // 
            // epochsNumericUpDown
            // 
            epochsNumericUpDown.Location = new Point(78, 141);
            epochsNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            epochsNumericUpDown.Name = "epochsNumericUpDown";
            epochsNumericUpDown.Size = new Size(121, 23);
            epochsNumericUpDown.TabIndex = 7;
            epochsNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // optimizerComboBox
            // 
            optimizerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            optimizerComboBox.FormattingEnabled = true;
            optimizerComboBox.Items.AddRange(new object[] { "Adadelta", "Adagrad", "Adam", "Adamax", "AdamW", "ASGD", "NAdam", "RAdam", "RMSProp", "Rprop", "SGD" });
            optimizerComboBox.Location = new Point(78, 51);
            optimizerComboBox.Name = "optimizerComboBox";
            optimizerComboBox.Size = new Size(132, 23);
            optimizerComboBox.TabIndex = 1;
            optimizerComboBox.SelectedIndexChanged += OptimizerComboBox_SelectedIndexChanged;
            // 
            // optimizerLabel
            // 
            optimizerLabel.AutoSize = true;
            optimizerLabel.Location = new Point(13, 54);
            optimizerLabel.Name = "optimizerLabel";
            optimizerLabel.Size = new Size(59, 15);
            optimizerLabel.TabIndex = 0;
            optimizerLabel.Text = "Optimizer";
            // 
            // trainProgressBar
            // 
            trainProgressBar.Location = new Point(8, 170);
            trainProgressBar.Name = "trainProgressBar";
            trainProgressBar.Size = new Size(128, 23);
            trainProgressBar.TabIndex = 0;
            trainProgressBar.Visible = false;
            // 
            // learningRateNumericUpDown
            // 
            learningRateNumericUpDown.DecimalPlaces = 7;
            learningRateNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 458752 });
            learningRateNumericUpDown.Location = new Point(297, 51);
            learningRateNumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            learningRateNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 458752 });
            learningRateNumericUpDown.Name = "learningRateNumericUpDown";
            learningRateNumericUpDown.Size = new Size(120, 23);
            learningRateNumericUpDown.TabIndex = 2;
            learningRateNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 196608 });
            // 
            // learningRateLabel
            // 
            learningRateLabel.AutoSize = true;
            learningRateLabel.Location = new Point(215, 53);
            learningRateLabel.Name = "learningRateLabel";
            learningRateLabel.Size = new Size(76, 15);
            learningRateLabel.TabIndex = 0;
            learningRateLabel.Text = "Learning rate";
            // 
            // lossFunctionLabel
            // 
            lossFunctionLabel.AutoSize = true;
            lossFunctionLabel.Location = new Point(6, 25);
            lossFunctionLabel.Name = "lossFunctionLabel";
            lossFunctionLabel.Size = new Size(78, 15);
            lossFunctionLabel.TabIndex = 0;
            lossFunctionLabel.Text = "Loss function";
            // 
            // mlpLabel
            // 
            mlpLabel.AutoSize = true;
            mlpLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mlpLabel.Location = new Point(20, 20);
            mlpLabel.Name = "mlpLabel";
            mlpLabel.Size = new Size(164, 15);
            mlpLabel.TabIndex = 0;
            mlpLabel.Text = "Multilayer Perceptron (MLP)";
            // 
            // hyperparametersGroupBox
            // 
            hyperparametersGroupBox.Controls.Add(viewNetworkStructureButton);
            hyperparametersGroupBox.Controls.Add(editLayerButton);
            hyperparametersGroupBox.Controls.Add(modelNameLabel);
            hyperparametersGroupBox.Controls.Add(networkNameTextBox);
            hyperparametersGroupBox.Controls.Add(createNetworkButton);
            hyperparametersGroupBox.Controls.Add(loadCheckpointButton);
            hyperparametersGroupBox.Controls.Add(hiddenLayersListView);
            hyperparametersGroupBox.Controls.Add(addLayerButton);
            hyperparametersGroupBox.Controls.Add(removeLayerButton);
            hyperparametersGroupBox.Location = new Point(20, 109);
            hyperparametersGroupBox.Name = "hyperparametersGroupBox";
            hyperparametersGroupBox.Size = new Size(320, 225);
            hyperparametersGroupBox.TabIndex = 5;
            hyperparametersGroupBox.TabStop = false;
            hyperparametersGroupBox.Text = "Network structure";
            // 
            // viewNetworkStructureButton
            // 
            viewNetworkStructureButton.Location = new Point(218, 179);
            viewNetworkStructureButton.Name = "viewNetworkStructureButton";
            viewNetworkStructureButton.Size = new Size(96, 40);
            viewNetworkStructureButton.TabIndex = 7;
            viewNetworkStructureButton.Text = "View network structure...";
            viewNetworkStructureButton.UseVisualStyleBackColor = true;
            viewNetworkStructureButton.Click += ViewNetworkStructureButton_Click;
            // 
            // editLayerButton
            // 
            editLayerButton.Location = new Point(112, 150);
            editLayerButton.Name = "editLayerButton";
            editLayerButton.Size = new Size(100, 23);
            editLayerButton.TabIndex = 3;
            editLayerButton.Text = "Edit layer...";
            editLayerButton.UseVisualStyleBackColor = true;
            editLayerButton.Click += EditLayerButton_Click;
            // 
            // modelNameLabel
            // 
            modelNameLabel.AutoSize = true;
            modelNameLabel.Location = new Point(6, 25);
            modelNameLabel.Name = "modelNameLabel";
            modelNameLabel.Size = new Size(85, 15);
            modelNameLabel.TabIndex = 0;
            modelNameLabel.Text = "Network name";
            // 
            // networkNameTextBox
            // 
            networkNameTextBox.Location = new Point(97, 22);
            networkNameTextBox.Name = "networkNameTextBox";
            networkNameTextBox.Size = new Size(217, 23);
            networkNameTextBox.TabIndex = 0;
            networkNameTextBox.Text = "MLP";
            networkNameTextBox.TextChanged += NetworkNameTextBox_TextChanged;
            // 
            // createNetworkButton
            // 
            createNetworkButton.Location = new Point(6, 179);
            createNetworkButton.Name = "createNetworkButton";
            createNetworkButton.Size = new Size(100, 40);
            createNetworkButton.TabIndex = 5;
            createNetworkButton.Text = "Create MLP network";
            createNetworkButton.UseVisualStyleBackColor = true;
            createNetworkButton.Click += CreateNetworkButton_Click;
            // 
            // loadCheckpointButton
            // 
            loadCheckpointButton.Location = new Point(112, 179);
            loadCheckpointButton.Name = "loadCheckpointButton";
            loadCheckpointButton.Size = new Size(100, 40);
            loadCheckpointButton.TabIndex = 6;
            loadCheckpointButton.Text = "Load parameters...";
            loadCheckpointButton.UseVisualStyleBackColor = true;
            loadCheckpointButton.Click += LoadCheckpointButton_Click;
            // 
            // lossFunctionComboBox
            // 
            lossFunctionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lossFunctionComboBox.FormattingEnabled = true;
            lossFunctionComboBox.Location = new Point(90, 22);
            lossFunctionComboBox.Name = "lossFunctionComboBox";
            lossFunctionComboBox.Size = new Size(326, 23);
            lossFunctionComboBox.TabIndex = 0;
            // 
            // validationGroupBox
            // 
            validationGroupBox.Controls.Add(splitDataButton);
            validationGroupBox.Controls.Add(validationCheckBox);
            validationGroupBox.Location = new Point(386, 50);
            validationGroupBox.Name = "validationGroupBox";
            validationGroupBox.Size = new Size(174, 53);
            validationGroupBox.TabIndex = 3;
            validationGroupBox.TabStop = false;
            validationGroupBox.Text = "Train with validation";
            // 
            // splitDataButton
            // 
            splitDataButton.Location = new Point(84, 20);
            splitDataButton.Margin = new Padding(4, 3, 4, 3);
            splitDataButton.Name = "splitDataButton";
            splitDataButton.Size = new Size(75, 23);
            splitDataButton.TabIndex = 1;
            splitDataButton.Text = "Split data...";
            splitDataButton.UseVisualStyleBackColor = true;
            splitDataButton.Click += SplitDataButton_Click;
            // 
            // validationCheckBox
            // 
            validationCheckBox.AutoSize = true;
            validationCheckBox.Checked = true;
            validationCheckBox.CheckState = CheckState.Checked;
            validationCheckBox.Location = new Point(6, 22);
            validationCheckBox.Name = "validationCheckBox";
            validationCheckBox.Size = new Size(78, 19);
            validationCheckBox.TabIndex = 0;
            validationCheckBox.Text = "Validation";
            validationCheckBox.UseVisualStyleBackColor = true;
            validationCheckBox.CheckedChanged += ValidationCheckBox_CheckedChanged;
            // 
            // trainingGroupBox
            // 
            trainingGroupBox.Controls.Add(configureOptimerAndSchedulerButton);
            trainingGroupBox.Controls.Add(schedulerComboBox);
            trainingGroupBox.Controls.Add(schedulerLabel);
            trainingGroupBox.Controls.Add(visualizeLossesButton);
            trainingGroupBox.Controls.Add(saveStatusLabel);
            trainingGroupBox.Controls.Add(validationLossLabel);
            trainingGroupBox.Controls.Add(trainLossLabel);
            trainingGroupBox.Controls.Add(chooseSaveFolderButton);
            trainingGroupBox.Controls.Add(trainProgressLabel);
            trainingGroupBox.Controls.Add(saveIntervalNumericUpDown);
            trainingGroupBox.Controls.Add(saveIntervalLabel);
            trainingGroupBox.Controls.Add(optimizerComboBox);
            trainingGroupBox.Controls.Add(lossFunctionComboBox);
            trainingGroupBox.Controls.Add(optimizerLabel);
            trainingGroupBox.Controls.Add(learningRateNumericUpDown);
            trainingGroupBox.Controls.Add(learningRateLabel);
            trainingGroupBox.Controls.Add(trainProgressBar);
            trainingGroupBox.Controls.Add(epochsNumericUpDown);
            trainingGroupBox.Controls.Add(lossFunctionLabel);
            trainingGroupBox.Controls.Add(epochsLabel);
            trainingGroupBox.Controls.Add(trainButton);
            trainingGroupBox.Location = new Point(346, 109);
            trainingGroupBox.Name = "trainingGroupBox";
            trainingGroupBox.Size = new Size(423, 225);
            trainingGroupBox.TabIndex = 6;
            trainingGroupBox.TabStop = false;
            trainingGroupBox.Text = "Training";
            // 
            // configureOptimerAndSchedulerButton
            // 
            configureOptimerAndSchedulerButton.Location = new Point(216, 79);
            configureOptimerAndSchedulerButton.Name = "configureOptimerAndSchedulerButton";
            configureOptimerAndSchedulerButton.Size = new Size(200, 23);
            configureOptimerAndSchedulerButton.TabIndex = 4;
            configureOptimerAndSchedulerButton.Text = "Configure optimizer && scheduler...";
            configureOptimerAndSchedulerButton.UseVisualStyleBackColor = true;
            configureOptimerAndSchedulerButton.Click += ConfigureOptimerAndSchedulerButton_Click;
            // 
            // schedulerComboBox
            // 
            schedulerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            schedulerComboBox.FormattingEnabled = true;
            schedulerComboBox.Items.AddRange(new object[] { "None", "ConstantLR", "CosineAnnealingLR", "ExponentialLR", "LinearLR", "PolynomialLR", "StepLR" });
            schedulerComboBox.Location = new Point(78, 80);
            schedulerComboBox.Name = "schedulerComboBox";
            schedulerComboBox.Size = new Size(132, 23);
            schedulerComboBox.TabIndex = 3;
            schedulerComboBox.SelectedIndexChanged += SchedulerComboBox_SelectedIndexChanged;
            // 
            // schedulerLabel
            // 
            schedulerLabel.AutoSize = true;
            schedulerLabel.Location = new Point(13, 84);
            schedulerLabel.Name = "schedulerLabel";
            schedulerLabel.Size = new Size(59, 15);
            schedulerLabel.TabIndex = 0;
            schedulerLabel.Text = "Scheduler";
            // 
            // visualizeLossesButton
            // 
            visualizeLossesButton.Enabled = false;
            visualizeLossesButton.Location = new Point(297, 196);
            visualizeLossesButton.Name = "visualizeLossesButton";
            visualizeLossesButton.Size = new Size(120, 23);
            visualizeLossesButton.TabIndex = 9;
            visualizeLossesButton.Text = "Visualize losses...";
            visualizeLossesButton.UseVisualStyleBackColor = true;
            visualizeLossesButton.Click += VisualizeLossesButton_Click;
            // 
            // saveStatusLabel
            // 
            saveStatusLabel.Location = new Point(287, 140);
            saveStatusLabel.Margin = new Padding(4, 0, 4, 0);
            saveStatusLabel.Name = "saveStatusLabel";
            saveStatusLabel.Size = new Size(129, 51);
            saveStatusLabel.TabIndex = 0;
            saveStatusLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // validationLossLabel
            // 
            validationLossLabel.Location = new Point(146, 196);
            validationLossLabel.Margin = new Padding(4, 0, 4, 0);
            validationLossLabel.Name = "validationLossLabel";
            validationLossLabel.Size = new Size(144, 23);
            validationLossLabel.TabIndex = 0;
            validationLossLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trainLossLabel
            // 
            trainLossLabel.Location = new Point(8, 196);
            trainLossLabel.Margin = new Padding(4, 0, 4, 0);
            trainLossLabel.Name = "trainLossLabel";
            trainLossLabel.Size = new Size(130, 23);
            trainLossLabel.TabIndex = 0;
            trainLossLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chooseSaveFolderButton
            // 
            chooseSaveFolderButton.Location = new Point(6, 112);
            chooseSaveFolderButton.Name = "chooseSaveFolderButton";
            chooseSaveFolderButton.Size = new Size(130, 23);
            chooseSaveFolderButton.TabIndex = 5;
            chooseSaveFolderButton.Text = "Choose save folders...";
            chooseSaveFolderButton.UseVisualStyleBackColor = true;
            chooseSaveFolderButton.Click += ChooseSaveFolderButton_Click;
            // 
            // trainProgressLabel
            // 
            trainProgressLabel.Location = new Point(143, 167);
            trainProgressLabel.Margin = new Padding(4, 0, 4, 0);
            trainProgressLabel.Name = "trainProgressLabel";
            trainProgressLabel.Size = new Size(136, 24);
            trainProgressLabel.TabIndex = 0;
            trainProgressLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // saveIntervalNumericUpDown
            // 
            saveIntervalNumericUpDown.Location = new Point(297, 114);
            saveIntervalNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            saveIntervalNumericUpDown.Name = "saveIntervalNumericUpDown";
            saveIntervalNumericUpDown.Size = new Size(120, 23);
            saveIntervalNumericUpDown.TabIndex = 6;
            saveIntervalNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // saveIntervalLabel
            // 
            saveIntervalLabel.AutoSize = true;
            saveIntervalLabel.Location = new Point(155, 116);
            saveIntervalLabel.Name = "saveIntervalLabel";
            saveIntervalLabel.Size = new Size(135, 15);
            saveIntervalLabel.TabIndex = 0;
            saveIntervalLabel.Text = "Save checkpoint interval";
            // 
            // chooseLogFolderButton
            // 
            chooseLogFolderButton.Enabled = false;
            chooseLogFolderButton.Location = new Point(67, 19);
            chooseLogFolderButton.Name = "chooseLogFolderButton";
            chooseLogFolderButton.Size = new Size(130, 23);
            chooseLogFolderButton.TabIndex = 1;
            chooseLogFolderButton.Text = "Choose log folders...";
            chooseLogFolderButton.UseVisualStyleBackColor = true;
            chooseLogFolderButton.Click += ChooseLogFolderButton_Click;
            // 
            // logWithTensorboardCheckBox
            // 
            logWithTensorboardCheckBox.AutoSize = true;
            logWithTensorboardCheckBox.Location = new Point(15, 21);
            logWithTensorboardCheckBox.Name = "logWithTensorboardCheckBox";
            logWithTensorboardCheckBox.Size = new Size(46, 19);
            logWithTensorboardCheckBox.TabIndex = 0;
            logWithTensorboardCheckBox.Text = "Log";
            logWithTensorboardCheckBox.UseVisualStyleBackColor = true;
            logWithTensorboardCheckBox.CheckedChanged += LogWithTensorboardCheckBox_CheckedChanged;
            // 
            // dataTypeGroupBox
            // 
            dataTypeGroupBox.Controls.Add(dataTypeComboBox);
            dataTypeGroupBox.Location = new Point(132, 50);
            dataTypeGroupBox.Name = "dataTypeGroupBox";
            dataTypeGroupBox.Size = new Size(113, 53);
            dataTypeGroupBox.TabIndex = 1;
            dataTypeGroupBox.TabStop = false;
            dataTypeGroupBox.Text = "Data type";
            // 
            // dataTypeComboBox
            // 
            dataTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dataTypeComboBox.FormattingEnabled = true;
            dataTypeComboBox.Items.AddRange(new object[] { "Float16", "Float32", "Float64", "BFloat16" });
            dataTypeComboBox.Location = new Point(6, 20);
            dataTypeComboBox.Name = "dataTypeComboBox";
            dataTypeComboBox.Size = new Size(96, 23);
            dataTypeComboBox.TabIndex = 0;
            dataTypeComboBox.SelectedIndexChanged += DataTypeComboBox_SelectedIndexChanged;
            // 
            // loadCheckpointFileDialog
            // 
            loadCheckpointFileDialog.FileName = "*.ckpt";
            loadCheckpointFileDialog.Filter = "Checkpoint files|*.ckpt";
            loadCheckpointFileDialog.Title = "Load checkpoint";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(randomSeedNumericUpDown);
            groupBox1.Location = new Point(251, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(129, 53);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Random seed";
            // 
            // randomSeedNumericUpDown
            // 
            randomSeedNumericUpDown.Location = new Point(16, 21);
            randomSeedNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            randomSeedNumericUpDown.Name = "randomSeedNumericUpDown";
            randomSeedNumericUpDown.Size = new Size(100, 23);
            randomSeedNumericUpDown.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(logWithTensorboardCheckBox);
            groupBox2.Controls.Add(chooseLogFolderButton);
            groupBox2.Location = new Point(566, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(203, 53);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log with Tensorboard";
            // 
            // MLPModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataTypeGroupBox);
            Controls.Add(trainingGroupBox);
            Controls.Add(validationGroupBox);
            Controls.Add(hyperparametersGroupBox);
            Controls.Add(mlpLabel);
            Controls.Add(deviceGroupBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MLPModelControl";
            Size = new Size(790, 350);
            deviceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)epochsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)learningRateNumericUpDown).EndInit();
            hyperparametersGroupBox.ResumeLayout(false);
            hyperparametersGroupBox.PerformLayout();
            validationGroupBox.ResumeLayout(false);
            validationGroupBox.PerformLayout();
            trainingGroupBox.ResumeLayout(false);
            trainingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saveIntervalNumericUpDown).EndInit();
            dataTypeGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)randomSeedNumericUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button trainButton;
        private GroupBox deviceGroupBox;
        private Button addLayerButton;
        private ListView hiddenLayersListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button removeLayerButton;
        private Label epochsLabel;
        private NumericUpDown epochsNumericUpDown;
        private ComboBox optimizerComboBox;
        private Label optimizerLabel;
        private ProgressBar trainProgressBar;
        private NumericUpDown learningRateNumericUpDown;
        private Label learningRateLabel;
        private Label lossFunctionLabel;
        private Label mlpLabel;
        private GroupBox hyperparametersGroupBox;
        private ComboBox lossFunctionComboBox;
        private GroupBox validationGroupBox;
        private CheckBox validationCheckBox;
        private GroupBox trainingGroupBox;
        private CheckBox logWithTensorboardCheckBox;
        private GroupBox dataTypeGroupBox;
        private ComboBox dataTypeComboBox;
        private Button chooseLogFolderButton;
        private Label saveIntervalLabel;
        private NumericUpDown saveIntervalNumericUpDown;
        private Label trainProgressLabel;
        private Button loadCheckpointButton;
        private Label validationLossLabel;
        private Label trainLossLabel;
        private Button createNetworkButton;
        private Button chooseSaveFolderButton;
        private FolderBrowserDialog logFolderBrowserDialog;
        private FolderBrowserDialog saveFolderBrowserDialog;
        private Label saveStatusLabel;
        private Label modelNameLabel;
        private TextBox networkNameTextBox;
        private OpenFileDialog loadCheckpointFileDialog;
        private Button editLayerButton;
        private ComboBox deviceComboBox;
        private Button splitDataButton;
        private GroupBox groupBox1;
        private NumericUpDown randomSeedNumericUpDown;
        private GroupBox groupBox2;
        private Button visualizeLossesButton;
        private Button viewNetworkStructureButton;
        private Button configureOptimerAndSchedulerButton;
        private ComboBox schedulerComboBox;
        private Label schedulerLabel;
    }
}
