using JadeChem.CustomControls.DiagramControls;

namespace JadeChem
{
    partial class PredictionTaskForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            mainTableLayoutPanel = new TableLayoutPanel();
            workflowDiagramControl = new WorkflowDiagramControl();
            taskTabControl = new TabControl();
            inputDataTabPage = new TabPage();
            inputDataTableLayoutPanel = new TableLayoutPanel();
            inputDataPanel = new Panel();
            inputDataHasHeadersCheckBox = new CheckBox();
            loadDataButton = new Button();
            inputDataDataGridView = new DataGridView();
            dataProcessingTabPage = new TabPage();
            dataProcessingTableLayoutPanel = new TableLayoutPanel();
            predictionTypeGroupBox = new GroupBox();
            regressionRadioButton = new RadioButton();
            multiclassClassificationRadioButton = new RadioButton();
            binaryClassificationRadioButton = new RadioButton();
            inputAndOutputColumnsGroupBox = new GroupBox();
            columnsDataGridView = new DataGridView();
            columnColumn = new DataGridViewTextBoxColumn();
            inputColumn = new DataGridViewCheckBoxColumn();
            outputColumn = new DataGridViewCheckBoxColumn();
            processingStepsGroupBox = new GroupBox();
            processingStepsListBox = new ListBox();
            editProcessingStepsButton = new Button();
            processDataGroupBox = new GroupBox();
            processingProgressLabel = new Label();
            processingProgressBar = new ProgressBar();
            processButton = new Button();
            processedDataTabPage = new TabPage();
            processedDataTableLayoutPanel = new TableLayoutPanel();
            processedDataPanel = new Panel();
            processedDataVisualizeButton = new Button();
            splitDataButton = new Button();
            processedDataDataGridView = new DataGridView();
            trainDatasetTabPage = new TabPage();
            trainDatasetTableLayoutPanel = new TableLayoutPanel();
            trainDatasetPanel = new Panel();
            trainDatasetVisualizeButton = new Button();
            trainDatasetDataGridView = new DataGridView();
            testDatasetTabPage = new TabPage();
            testDatasetTableLayoutPanel = new TableLayoutPanel();
            testDatasetDataGridView = new DataGridView();
            testDatasetPanel = new Panel();
            testDatasetVisualizeButton = new Button();
            modelTabPage = new TabPage();
            modelTableLayoutPanel = new TableLayoutPanel();
            loadModelButton = new Button();
            modelPanel = new Panel();
            evaluationTabPage = new TabPage();
            evaluationTableLayoutPanel = new TableLayoutPanel();
            evaluationPanel = new Panel();
            visualizeEvaluationButton = new Button();
            evaluateButton = new Button();
            evaluationMetricsPanel = new Panel();
            evaluationDataGridView = new DataGridView();
            predictionTabPage = new TabPage();
            predictionTableLayoutPanel = new TableLayoutPanel();
            singlePredictionPanel = new Panel();
            predictButton = new Button();
            predictionDataGridView = new DataGridView();
            predictTableLayoutPanel = new TableLayoutPanel();
            datasetPredictionPanel = new Panel();
            visualizePredictionButton = new Button();
            predictionDataHasHeadersCheckBox = new CheckBox();
            predictionProgressLabel = new Label();
            loadPredictionDataButton = new Button();
            predictionProgressBar = new ProgressBar();
            predictDatasetButton = new Button();
            predictionDatasetDataGridView = new DataGridView();
            openDataFileFileDialog = new OpenFileDialog();
            mainTableLayoutPanel.SuspendLayout();
            taskTabControl.SuspendLayout();
            inputDataTabPage.SuspendLayout();
            inputDataTableLayoutPanel.SuspendLayout();
            inputDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputDataDataGridView).BeginInit();
            dataProcessingTabPage.SuspendLayout();
            dataProcessingTableLayoutPanel.SuspendLayout();
            predictionTypeGroupBox.SuspendLayout();
            inputAndOutputColumnsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)columnsDataGridView).BeginInit();
            processingStepsGroupBox.SuspendLayout();
            processDataGroupBox.SuspendLayout();
            processedDataTabPage.SuspendLayout();
            processedDataTableLayoutPanel.SuspendLayout();
            processedDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)processedDataDataGridView).BeginInit();
            trainDatasetTabPage.SuspendLayout();
            trainDatasetTableLayoutPanel.SuspendLayout();
            trainDatasetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainDatasetDataGridView).BeginInit();
            testDatasetTabPage.SuspendLayout();
            testDatasetTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)testDatasetDataGridView).BeginInit();
            testDatasetPanel.SuspendLayout();
            modelTabPage.SuspendLayout();
            modelTableLayoutPanel.SuspendLayout();
            evaluationTabPage.SuspendLayout();
            evaluationTableLayoutPanel.SuspendLayout();
            evaluationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)evaluationDataGridView).BeginInit();
            predictionTabPage.SuspendLayout();
            predictionTableLayoutPanel.SuspendLayout();
            singlePredictionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)predictionDataGridView).BeginInit();
            predictTableLayoutPanel.SuspendLayout();
            datasetPredictionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)predictionDatasetDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(workflowDiagramControl, 0, 0);
            mainTableLayoutPanel.Controls.Add(taskTabControl, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(944, 561);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // workflowDiagramControl
            // 
            workflowDiagramControl.Dock = DockStyle.Fill;
            workflowDiagramControl.Location = new Point(4, 3);
            workflowDiagramControl.Margin = new Padding(4, 3, 4, 3);
            workflowDiagramControl.Name = "workflowDiagramControl";
            workflowDiagramControl.Size = new Size(936, 156);
            workflowDiagramControl.TabIndex = 2;
            workflowDiagramControl.InputDataBlockClicked += DiagramControl_InputDataBlockClicked;
            workflowDiagramControl.ProcessingArrowBlockClicked += DiagramControl_ProcessingArrowBlockClicked;
            workflowDiagramControl.ProcessedDataBlockClicked += DiagramControl_ProcessedDataBlockClicked;
            workflowDiagramControl.TrainDatasetBlockClicked += DiagramControl_TrainDatasetBlockClicked;
            workflowDiagramControl.TestDatasetBlockClicked += DiagramControl_TestDatasetBlockClicked;
            workflowDiagramControl.ModelBlockClicked += DiagramControl_ModelBlockClicked;
            workflowDiagramControl.EvaluationBlockClicked += DiagramControl_EvaluationBlockClicked;
            workflowDiagramControl.PredictionBlockClicked += DiagramControl_PredictionBlockClicked;
            // 
            // taskTabControl
            // 
            taskTabControl.Controls.Add(inputDataTabPage);
            taskTabControl.Controls.Add(dataProcessingTabPage);
            taskTabControl.Controls.Add(processedDataTabPage);
            taskTabControl.Controls.Add(trainDatasetTabPage);
            taskTabControl.Controls.Add(testDatasetTabPage);
            taskTabControl.Controls.Add(modelTabPage);
            taskTabControl.Controls.Add(evaluationTabPage);
            taskTabControl.Controls.Add(predictionTabPage);
            taskTabControl.Dock = DockStyle.Fill;
            taskTabControl.Location = new Point(4, 165);
            taskTabControl.Margin = new Padding(4, 3, 4, 3);
            taskTabControl.Name = "taskTabControl";
            taskTabControl.SelectedIndex = 0;
            taskTabControl.Size = new Size(936, 393);
            taskTabControl.TabIndex = 1;
            // 
            // inputDataTabPage
            // 
            inputDataTabPage.Controls.Add(inputDataTableLayoutPanel);
            inputDataTabPage.Location = new Point(4, 24);
            inputDataTabPage.Margin = new Padding(4, 3, 4, 3);
            inputDataTabPage.Name = "inputDataTabPage";
            inputDataTabPage.Padding = new Padding(4, 3, 4, 3);
            inputDataTabPage.Size = new Size(928, 365);
            inputDataTabPage.TabIndex = 0;
            inputDataTabPage.Text = "Input Data";
            inputDataTabPage.UseVisualStyleBackColor = true;
            // 
            // inputDataTableLayoutPanel
            // 
            inputDataTableLayoutPanel.ColumnCount = 2;
            inputDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            inputDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inputDataTableLayoutPanel.Controls.Add(inputDataPanel, 0, 0);
            inputDataTableLayoutPanel.Controls.Add(inputDataDataGridView, 1, 0);
            inputDataTableLayoutPanel.Dock = DockStyle.Fill;
            inputDataTableLayoutPanel.Location = new Point(4, 3);
            inputDataTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            inputDataTableLayoutPanel.Name = "inputDataTableLayoutPanel";
            inputDataTableLayoutPanel.RowCount = 1;
            inputDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            inputDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputDataTableLayoutPanel.Size = new Size(920, 359);
            inputDataTableLayoutPanel.TabIndex = 0;
            // 
            // inputDataPanel
            // 
            inputDataPanel.Controls.Add(inputDataHasHeadersCheckBox);
            inputDataPanel.Controls.Add(loadDataButton);
            inputDataPanel.Dock = DockStyle.Fill;
            inputDataPanel.Location = new Point(4, 3);
            inputDataPanel.Margin = new Padding(4, 3, 4, 3);
            inputDataPanel.Name = "inputDataPanel";
            inputDataPanel.Size = new Size(109, 353);
            inputDataPanel.TabIndex = 0;
            // 
            // inputDataHasHeadersCheckBox
            // 
            inputDataHasHeadersCheckBox.AutoSize = true;
            inputDataHasHeadersCheckBox.Checked = true;
            inputDataHasHeadersCheckBox.CheckState = CheckState.Checked;
            inputDataHasHeadersCheckBox.Location = new Point(4, 32);
            inputDataHasHeadersCheckBox.Margin = new Padding(4, 3, 4, 3);
            inputDataHasHeadersCheckBox.Name = "inputDataHasHeadersCheckBox";
            inputDataHasHeadersCheckBox.Size = new Size(83, 19);
            inputDataHasHeadersCheckBox.TabIndex = 1;
            inputDataHasHeadersCheckBox.Text = "has header";
            inputDataHasHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // loadDataButton
            // 
            loadDataButton.Location = new Point(4, 3);
            loadDataButton.Margin = new Padding(4, 3, 4, 3);
            loadDataButton.Name = "loadDataButton";
            loadDataButton.Size = new Size(100, 23);
            loadDataButton.TabIndex = 0;
            loadDataButton.Text = "Load data...";
            loadDataButton.UseVisualStyleBackColor = true;
            loadDataButton.Click += LoadDataButton_Click;
            // 
            // inputDataDataGridView
            // 
            inputDataDataGridView.AllowUserToAddRows = false;
            inputDataDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            inputDataDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            inputDataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inputDataDataGridView.Dock = DockStyle.Fill;
            inputDataDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            inputDataDataGridView.Location = new Point(121, 3);
            inputDataDataGridView.Margin = new Padding(4, 3, 4, 3);
            inputDataDataGridView.Name = "inputDataDataGridView";
            inputDataDataGridView.ReadOnly = true;
            inputDataDataGridView.RowHeadersWidth = 51;
            inputDataDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inputDataDataGridView.Size = new Size(795, 353);
            inputDataDataGridView.TabIndex = 1;
            // 
            // dataProcessingTabPage
            // 
            dataProcessingTabPage.Controls.Add(dataProcessingTableLayoutPanel);
            dataProcessingTabPage.Location = new Point(4, 24);
            dataProcessingTabPage.Margin = new Padding(4, 3, 4, 3);
            dataProcessingTabPage.Name = "dataProcessingTabPage";
            dataProcessingTabPage.Padding = new Padding(4, 3, 4, 3);
            dataProcessingTabPage.Size = new Size(928, 365);
            dataProcessingTabPage.TabIndex = 1;
            dataProcessingTabPage.Text = "Data Processing";
            dataProcessingTabPage.UseVisualStyleBackColor = true;
            // 
            // dataProcessingTableLayoutPanel
            // 
            dataProcessingTableLayoutPanel.ColumnCount = 3;
            dataProcessingTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 380F));
            dataProcessingTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            dataProcessingTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dataProcessingTableLayoutPanel.Controls.Add(predictionTypeGroupBox, 0, 0);
            dataProcessingTableLayoutPanel.Controls.Add(inputAndOutputColumnsGroupBox, 0, 1);
            dataProcessingTableLayoutPanel.Controls.Add(processingStepsGroupBox, 1, 0);
            dataProcessingTableLayoutPanel.Controls.Add(processDataGroupBox, 2, 0);
            dataProcessingTableLayoutPanel.Dock = DockStyle.Fill;
            dataProcessingTableLayoutPanel.Enabled = false;
            dataProcessingTableLayoutPanel.Location = new Point(4, 3);
            dataProcessingTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            dataProcessingTableLayoutPanel.Name = "dataProcessingTableLayoutPanel";
            dataProcessingTableLayoutPanel.RowCount = 2;
            dataProcessingTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            dataProcessingTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dataProcessingTableLayoutPanel.Size = new Size(920, 359);
            dataProcessingTableLayoutPanel.TabIndex = 1;
            // 
            // predictionTypeGroupBox
            // 
            predictionTypeGroupBox.Controls.Add(regressionRadioButton);
            predictionTypeGroupBox.Controls.Add(multiclassClassificationRadioButton);
            predictionTypeGroupBox.Controls.Add(binaryClassificationRadioButton);
            predictionTypeGroupBox.Dock = DockStyle.Fill;
            predictionTypeGroupBox.Location = new Point(4, 3);
            predictionTypeGroupBox.Margin = new Padding(4, 3, 4, 3);
            predictionTypeGroupBox.Name = "predictionTypeGroupBox";
            predictionTypeGroupBox.Padding = new Padding(4, 3, 4, 3);
            predictionTypeGroupBox.Size = new Size(372, 114);
            predictionTypeGroupBox.TabIndex = 0;
            predictionTypeGroupBox.TabStop = false;
            predictionTypeGroupBox.Text = "Prediction type";
            // 
            // regressionRadioButton
            // 
            regressionRadioButton.AutoSize = true;
            regressionRadioButton.Location = new Point(23, 74);
            regressionRadioButton.Margin = new Padding(4, 3, 4, 3);
            regressionRadioButton.Name = "regressionRadioButton";
            regressionRadioButton.Size = new Size(82, 19);
            regressionRadioButton.TabIndex = 2;
            regressionRadioButton.Text = "Regression";
            regressionRadioButton.UseVisualStyleBackColor = true;
            regressionRadioButton.CheckedChanged += PredictionTypeRadioButton_CheckedChanged;
            // 
            // multiclassClassificationRadioButton
            // 
            multiclassClassificationRadioButton.AutoSize = true;
            multiclassClassificationRadioButton.Location = new Point(23, 49);
            multiclassClassificationRadioButton.Margin = new Padding(4, 3, 4, 3);
            multiclassClassificationRadioButton.Name = "multiclassClassificationRadioButton";
            multiclassClassificationRadioButton.Size = new Size(149, 19);
            multiclassClassificationRadioButton.TabIndex = 1;
            multiclassClassificationRadioButton.Text = "Multiclass classification";
            multiclassClassificationRadioButton.UseVisualStyleBackColor = true;
            multiclassClassificationRadioButton.CheckedChanged += PredictionTypeRadioButton_CheckedChanged;
            // 
            // binaryClassificationRadioButton
            // 
            binaryClassificationRadioButton.AutoSize = true;
            binaryClassificationRadioButton.Checked = true;
            binaryClassificationRadioButton.Location = new Point(23, 24);
            binaryClassificationRadioButton.Margin = new Padding(4, 3, 4, 3);
            binaryClassificationRadioButton.Name = "binaryClassificationRadioButton";
            binaryClassificationRadioButton.Size = new Size(129, 19);
            binaryClassificationRadioButton.TabIndex = 0;
            binaryClassificationRadioButton.TabStop = true;
            binaryClassificationRadioButton.Text = "Binary classification";
            binaryClassificationRadioButton.UseVisualStyleBackColor = true;
            binaryClassificationRadioButton.CheckedChanged += PredictionTypeRadioButton_CheckedChanged;
            // 
            // inputAndOutputColumnsGroupBox
            // 
            inputAndOutputColumnsGroupBox.Controls.Add(columnsDataGridView);
            inputAndOutputColumnsGroupBox.Dock = DockStyle.Fill;
            inputAndOutputColumnsGroupBox.Location = new Point(4, 123);
            inputAndOutputColumnsGroupBox.Margin = new Padding(4, 3, 4, 3);
            inputAndOutputColumnsGroupBox.Name = "inputAndOutputColumnsGroupBox";
            inputAndOutputColumnsGroupBox.Padding = new Padding(4, 3, 4, 3);
            inputAndOutputColumnsGroupBox.Size = new Size(372, 233);
            inputAndOutputColumnsGroupBox.TabIndex = 1;
            inputAndOutputColumnsGroupBox.TabStop = false;
            inputAndOutputColumnsGroupBox.Text = "Input and output columns";
            // 
            // columnsDataGridView
            // 
            columnsDataGridView.AllowUserToAddRows = false;
            columnsDataGridView.AllowUserToDeleteRows = false;
            columnsDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            columnsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            columnsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            columnsDataGridView.Columns.AddRange(new DataGridViewColumn[] { columnColumn, inputColumn, outputColumn });
            columnsDataGridView.Dock = DockStyle.Fill;
            columnsDataGridView.Location = new Point(4, 19);
            columnsDataGridView.Margin = new Padding(4, 3, 4, 3);
            columnsDataGridView.Name = "columnsDataGridView";
            columnsDataGridView.RowHeadersVisible = false;
            columnsDataGridView.RowHeadersWidth = 51;
            columnsDataGridView.Size = new Size(364, 211);
            columnsDataGridView.TabIndex = 0;
            // 
            // columnColumn
            // 
            columnColumn.HeaderText = "Column";
            columnColumn.MinimumWidth = 6;
            columnColumn.Name = "columnColumn";
            columnColumn.ReadOnly = true;
            columnColumn.Width = 220;
            // 
            // inputColumn
            // 
            inputColumn.HeaderText = "Input";
            inputColumn.MinimumWidth = 6;
            inputColumn.Name = "inputColumn";
            inputColumn.Resizable = DataGridViewTriState.True;
            inputColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            inputColumn.Width = 60;
            // 
            // outputColumn
            // 
            outputColumn.HeaderText = "Output";
            outputColumn.MinimumWidth = 6;
            outputColumn.Name = "outputColumn";
            outputColumn.Width = 60;
            // 
            // processingStepsGroupBox
            // 
            processingStepsGroupBox.Controls.Add(processingStepsListBox);
            processingStepsGroupBox.Controls.Add(editProcessingStepsButton);
            processingStepsGroupBox.Dock = DockStyle.Fill;
            processingStepsGroupBox.Location = new Point(384, 3);
            processingStepsGroupBox.Margin = new Padding(4, 3, 4, 3);
            processingStepsGroupBox.Name = "processingStepsGroupBox";
            processingStepsGroupBox.Padding = new Padding(4, 3, 4, 3);
            dataProcessingTableLayoutPanel.SetRowSpan(processingStepsGroupBox, 2);
            processingStepsGroupBox.Size = new Size(312, 353);
            processingStepsGroupBox.TabIndex = 3;
            processingStepsGroupBox.TabStop = false;
            processingStepsGroupBox.Text = "Processing steps";
            // 
            // processingStepsListBox
            // 
            processingStepsListBox.Dock = DockStyle.Left;
            processingStepsListBox.FormattingEnabled = true;
            processingStepsListBox.HorizontalScrollbar = true;
            processingStepsListBox.ItemHeight = 15;
            processingStepsListBox.Location = new Point(4, 19);
            processingStepsListBox.Margin = new Padding(4, 3, 4, 3);
            processingStepsListBox.Name = "processingStepsListBox";
            processingStepsListBox.Size = new Size(217, 331);
            processingStepsListBox.TabIndex = 0;
            // 
            // editProcessingStepsButton
            // 
            editProcessingStepsButton.Location = new Point(229, 22);
            editProcessingStepsButton.Margin = new Padding(4, 3, 4, 3);
            editProcessingStepsButton.Name = "editProcessingStepsButton";
            editProcessingStepsButton.Size = new Size(75, 23);
            editProcessingStepsButton.TabIndex = 1;
            editProcessingStepsButton.Text = "Edit..";
            editProcessingStepsButton.UseVisualStyleBackColor = true;
            editProcessingStepsButton.Click += EditProcessingStepsButton_Click;
            // 
            // processDataGroupBox
            // 
            processDataGroupBox.Controls.Add(processingProgressLabel);
            processDataGroupBox.Controls.Add(processingProgressBar);
            processDataGroupBox.Controls.Add(processButton);
            processDataGroupBox.Dock = DockStyle.Fill;
            processDataGroupBox.Location = new Point(704, 3);
            processDataGroupBox.Margin = new Padding(4, 3, 4, 3);
            processDataGroupBox.Name = "processDataGroupBox";
            processDataGroupBox.Padding = new Padding(4, 3, 4, 3);
            dataProcessingTableLayoutPanel.SetRowSpan(processDataGroupBox, 2);
            processDataGroupBox.Size = new Size(212, 353);
            processDataGroupBox.TabIndex = 3;
            processDataGroupBox.TabStop = false;
            processDataGroupBox.Text = "Process data";
            // 
            // processingProgressLabel
            // 
            processingProgressLabel.Location = new Point(8, 90);
            processingProgressLabel.Margin = new Padding(4, 0, 4, 0);
            processingProgressLabel.Name = "processingProgressLabel";
            processingProgressLabel.Size = new Size(196, 25);
            processingProgressLabel.TabIndex = 0;
            // 
            // processingProgressBar
            // 
            processingProgressBar.Location = new Point(7, 54);
            processingProgressBar.Margin = new Padding(4, 3, 4, 3);
            processingProgressBar.Name = "processingProgressBar";
            processingProgressBar.Size = new Size(197, 27);
            processingProgressBar.TabIndex = 0;
            processingProgressBar.Visible = false;
            // 
            // processButton
            // 
            processButton.Location = new Point(7, 22);
            processButton.Margin = new Padding(4, 3, 4, 3);
            processButton.Name = "processButton";
            processButton.Size = new Size(75, 23);
            processButton.TabIndex = 0;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += ProcessButton_Click;
            // 
            // processedDataTabPage
            // 
            processedDataTabPage.Controls.Add(processedDataTableLayoutPanel);
            processedDataTabPage.Location = new Point(4, 24);
            processedDataTabPage.Margin = new Padding(4, 3, 4, 3);
            processedDataTabPage.Name = "processedDataTabPage";
            processedDataTabPage.Padding = new Padding(4, 3, 4, 3);
            processedDataTabPage.Size = new Size(928, 365);
            processedDataTabPage.TabIndex = 7;
            processedDataTabPage.Text = "Processed Data";
            processedDataTabPage.UseVisualStyleBackColor = true;
            // 
            // processedDataTableLayoutPanel
            // 
            processedDataTableLayoutPanel.ColumnCount = 2;
            processedDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            processedDataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            processedDataTableLayoutPanel.Controls.Add(processedDataPanel, 0, 0);
            processedDataTableLayoutPanel.Controls.Add(processedDataDataGridView, 1, 0);
            processedDataTableLayoutPanel.Dock = DockStyle.Fill;
            processedDataTableLayoutPanel.Enabled = false;
            processedDataTableLayoutPanel.Location = new Point(4, 3);
            processedDataTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            processedDataTableLayoutPanel.Name = "processedDataTableLayoutPanel";
            processedDataTableLayoutPanel.RowCount = 1;
            processedDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            processedDataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            processedDataTableLayoutPanel.Size = new Size(920, 359);
            processedDataTableLayoutPanel.TabIndex = 1;
            // 
            // processedDataPanel
            // 
            processedDataPanel.Controls.Add(processedDataVisualizeButton);
            processedDataPanel.Controls.Add(splitDataButton);
            processedDataPanel.Dock = DockStyle.Fill;
            processedDataPanel.Location = new Point(4, 3);
            processedDataPanel.Margin = new Padding(4, 3, 4, 3);
            processedDataPanel.Name = "processedDataPanel";
            processedDataPanel.Size = new Size(109, 353);
            processedDataPanel.TabIndex = 0;
            // 
            // processedDataVisualizeButton
            // 
            processedDataVisualizeButton.Location = new Point(4, 32);
            processedDataVisualizeButton.Margin = new Padding(4, 3, 4, 3);
            processedDataVisualizeButton.Name = "processedDataVisualizeButton";
            processedDataVisualizeButton.Size = new Size(75, 23);
            processedDataVisualizeButton.TabIndex = 1;
            processedDataVisualizeButton.Text = "Visualize...";
            processedDataVisualizeButton.UseVisualStyleBackColor = true;
            processedDataVisualizeButton.Click += ProcessedDataVisualizeButton_Click;
            // 
            // splitDataButton
            // 
            splitDataButton.Location = new Point(4, 3);
            splitDataButton.Margin = new Padding(4, 3, 4, 3);
            splitDataButton.Name = "splitDataButton";
            splitDataButton.Size = new Size(75, 23);
            splitDataButton.TabIndex = 0;
            splitDataButton.Text = "Split data...";
            splitDataButton.UseVisualStyleBackColor = true;
            splitDataButton.Click += SplitDataButton_Click;
            // 
            // processedDataDataGridView
            // 
            processedDataDataGridView.AllowUserToAddRows = false;
            processedDataDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            processedDataDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            processedDataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            processedDataDataGridView.Dock = DockStyle.Fill;
            processedDataDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            processedDataDataGridView.Location = new Point(121, 3);
            processedDataDataGridView.Margin = new Padding(4, 3, 4, 3);
            processedDataDataGridView.Name = "processedDataDataGridView";
            processedDataDataGridView.ReadOnly = true;
            processedDataDataGridView.RowHeadersWidth = 51;
            processedDataDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            processedDataDataGridView.Size = new Size(795, 353);
            processedDataDataGridView.TabIndex = 1;
            processedDataDataGridView.CellFormatting += ProcessedDataDataGridView_CellFormatting;
            // 
            // trainDatasetTabPage
            // 
            trainDatasetTabPage.Controls.Add(trainDatasetTableLayoutPanel);
            trainDatasetTabPage.Location = new Point(4, 24);
            trainDatasetTabPage.Margin = new Padding(4, 3, 4, 3);
            trainDatasetTabPage.Name = "trainDatasetTabPage";
            trainDatasetTabPage.Padding = new Padding(4, 3, 4, 3);
            trainDatasetTabPage.Size = new Size(928, 365);
            trainDatasetTabPage.TabIndex = 2;
            trainDatasetTabPage.Text = "Train Dataset";
            trainDatasetTabPage.UseVisualStyleBackColor = true;
            // 
            // trainDatasetTableLayoutPanel
            // 
            trainDatasetTableLayoutPanel.ColumnCount = 2;
            trainDatasetTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            trainDatasetTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            trainDatasetTableLayoutPanel.Controls.Add(trainDatasetPanel, 0, 0);
            trainDatasetTableLayoutPanel.Controls.Add(trainDatasetDataGridView, 1, 0);
            trainDatasetTableLayoutPanel.Dock = DockStyle.Fill;
            trainDatasetTableLayoutPanel.Enabled = false;
            trainDatasetTableLayoutPanel.Location = new Point(4, 3);
            trainDatasetTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            trainDatasetTableLayoutPanel.Name = "trainDatasetTableLayoutPanel";
            trainDatasetTableLayoutPanel.RowCount = 1;
            trainDatasetTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            trainDatasetTableLayoutPanel.Size = new Size(920, 359);
            trainDatasetTableLayoutPanel.TabIndex = 1;
            // 
            // trainDatasetPanel
            // 
            trainDatasetPanel.Controls.Add(trainDatasetVisualizeButton);
            trainDatasetPanel.Dock = DockStyle.Fill;
            trainDatasetPanel.Location = new Point(4, 3);
            trainDatasetPanel.Margin = new Padding(4, 3, 4, 3);
            trainDatasetPanel.Name = "trainDatasetPanel";
            trainDatasetPanel.Size = new Size(109, 353);
            trainDatasetPanel.TabIndex = 0;
            // 
            // trainDatasetVisualizeButton
            // 
            trainDatasetVisualizeButton.Location = new Point(4, 3);
            trainDatasetVisualizeButton.Margin = new Padding(4, 3, 4, 3);
            trainDatasetVisualizeButton.Name = "trainDatasetVisualizeButton";
            trainDatasetVisualizeButton.Size = new Size(75, 23);
            trainDatasetVisualizeButton.TabIndex = 0;
            trainDatasetVisualizeButton.Text = "Visualize...";
            trainDatasetVisualizeButton.UseVisualStyleBackColor = true;
            trainDatasetVisualizeButton.Click += TrainDatasetVisualizeButton_Click;
            // 
            // trainDatasetDataGridView
            // 
            trainDatasetDataGridView.AllowUserToAddRows = false;
            trainDatasetDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            trainDatasetDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            trainDatasetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainDatasetDataGridView.Dock = DockStyle.Fill;
            trainDatasetDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            trainDatasetDataGridView.Location = new Point(121, 3);
            trainDatasetDataGridView.Margin = new Padding(4, 3, 4, 3);
            trainDatasetDataGridView.Name = "trainDatasetDataGridView";
            trainDatasetDataGridView.ReadOnly = true;
            trainDatasetDataGridView.RowHeadersWidth = 51;
            trainDatasetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            trainDatasetDataGridView.Size = new Size(795, 353);
            trainDatasetDataGridView.TabIndex = 1;
            trainDatasetDataGridView.CellFormatting += TrainDatasetDataGridView_CellFormatting;
            // 
            // testDatasetTabPage
            // 
            testDatasetTabPage.Controls.Add(testDatasetTableLayoutPanel);
            testDatasetTabPage.Location = new Point(4, 24);
            testDatasetTabPage.Margin = new Padding(4, 3, 4, 3);
            testDatasetTabPage.Name = "testDatasetTabPage";
            testDatasetTabPage.Padding = new Padding(4, 3, 4, 3);
            testDatasetTabPage.Size = new Size(928, 365);
            testDatasetTabPage.TabIndex = 3;
            testDatasetTabPage.Text = "Test Dataset";
            testDatasetTabPage.UseVisualStyleBackColor = true;
            // 
            // testDatasetTableLayoutPanel
            // 
            testDatasetTableLayoutPanel.ColumnCount = 2;
            testDatasetTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            testDatasetTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            testDatasetTableLayoutPanel.Controls.Add(testDatasetDataGridView, 0, 0);
            testDatasetTableLayoutPanel.Controls.Add(testDatasetPanel, 0, 0);
            testDatasetTableLayoutPanel.Dock = DockStyle.Fill;
            testDatasetTableLayoutPanel.Enabled = false;
            testDatasetTableLayoutPanel.Location = new Point(4, 3);
            testDatasetTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            testDatasetTableLayoutPanel.Name = "testDatasetTableLayoutPanel";
            testDatasetTableLayoutPanel.RowCount = 1;
            testDatasetTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            testDatasetTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            testDatasetTableLayoutPanel.Size = new Size(920, 359);
            testDatasetTableLayoutPanel.TabIndex = 1;
            // 
            // testDatasetDataGridView
            // 
            testDatasetDataGridView.AllowUserToAddRows = false;
            testDatasetDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            testDatasetDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            testDatasetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testDatasetDataGridView.Dock = DockStyle.Fill;
            testDatasetDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            testDatasetDataGridView.Location = new Point(121, 3);
            testDatasetDataGridView.Margin = new Padding(4, 3, 4, 3);
            testDatasetDataGridView.Name = "testDatasetDataGridView";
            testDatasetDataGridView.ReadOnly = true;
            testDatasetDataGridView.RowHeadersWidth = 51;
            testDatasetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            testDatasetDataGridView.Size = new Size(795, 353);
            testDatasetDataGridView.TabIndex = 1;
            testDatasetDataGridView.CellFormatting += TestDatasetDataGridView_CellFormatting;
            // 
            // testDatasetPanel
            // 
            testDatasetPanel.Controls.Add(testDatasetVisualizeButton);
            testDatasetPanel.Dock = DockStyle.Fill;
            testDatasetPanel.Location = new Point(4, 3);
            testDatasetPanel.Margin = new Padding(4, 3, 4, 3);
            testDatasetPanel.Name = "testDatasetPanel";
            testDatasetPanel.Size = new Size(109, 353);
            testDatasetPanel.TabIndex = 0;
            // 
            // testDatasetVisualizeButton
            // 
            testDatasetVisualizeButton.Location = new Point(4, 3);
            testDatasetVisualizeButton.Margin = new Padding(4, 3, 4, 3);
            testDatasetVisualizeButton.Name = "testDatasetVisualizeButton";
            testDatasetVisualizeButton.Size = new Size(75, 23);
            testDatasetVisualizeButton.TabIndex = 0;
            testDatasetVisualizeButton.Text = "Visualize...";
            testDatasetVisualizeButton.UseVisualStyleBackColor = true;
            testDatasetVisualizeButton.Click += TestDatasetVisualizeButton_Click;
            // 
            // modelTabPage
            // 
            modelTabPage.Controls.Add(modelTableLayoutPanel);
            modelTabPage.Location = new Point(4, 24);
            modelTabPage.Margin = new Padding(4, 3, 4, 3);
            modelTabPage.Name = "modelTabPage";
            modelTabPage.Padding = new Padding(4, 3, 4, 3);
            modelTabPage.Size = new Size(928, 365);
            modelTabPage.TabIndex = 4;
            modelTabPage.Text = "Model";
            modelTabPage.UseVisualStyleBackColor = true;
            // 
            // modelTableLayoutPanel
            // 
            modelTableLayoutPanel.ColumnCount = 2;
            modelTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            modelTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            modelTableLayoutPanel.Controls.Add(loadModelButton, 0, 0);
            modelTableLayoutPanel.Controls.Add(modelPanel, 1, 0);
            modelTableLayoutPanel.Dock = DockStyle.Fill;
            modelTableLayoutPanel.Enabled = false;
            modelTableLayoutPanel.Location = new Point(4, 3);
            modelTableLayoutPanel.Margin = new Padding(2);
            modelTableLayoutPanel.Name = "modelTableLayoutPanel";
            modelTableLayoutPanel.RowCount = 1;
            modelTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            modelTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 362F));
            modelTableLayoutPanel.Size = new Size(920, 359);
            modelTableLayoutPanel.TabIndex = 0;
            // 
            // loadModelButton
            // 
            loadModelButton.Location = new Point(4, 3);
            loadModelButton.Margin = new Padding(4, 3, 4, 3);
            loadModelButton.Name = "loadModelButton";
            loadModelButton.Size = new Size(100, 23);
            loadModelButton.TabIndex = 0;
            loadModelButton.Text = "Load model...";
            loadModelButton.UseVisualStyleBackColor = true;
            loadModelButton.Click += LoadModelButton_Click;
            // 
            // modelPanel
            // 
            modelPanel.Dock = DockStyle.Fill;
            modelPanel.Location = new Point(121, 3);
            modelPanel.Margin = new Padding(4, 3, 4, 3);
            modelPanel.Name = "modelPanel";
            modelPanel.Size = new Size(795, 353);
            modelPanel.TabIndex = 1;
            // 
            // evaluationTabPage
            // 
            evaluationTabPage.Controls.Add(evaluationTableLayoutPanel);
            evaluationTabPage.Location = new Point(4, 24);
            evaluationTabPage.Margin = new Padding(4, 3, 4, 3);
            evaluationTabPage.Name = "evaluationTabPage";
            evaluationTabPage.Padding = new Padding(4, 3, 4, 3);
            evaluationTabPage.Size = new Size(928, 365);
            evaluationTabPage.TabIndex = 5;
            evaluationTabPage.Text = "Evaluation";
            evaluationTabPage.UseVisualStyleBackColor = true;
            // 
            // evaluationTableLayoutPanel
            // 
            evaluationTableLayoutPanel.ColumnCount = 3;
            evaluationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            evaluationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            evaluationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            evaluationTableLayoutPanel.Controls.Add(evaluationPanel, 0, 0);
            evaluationTableLayoutPanel.Controls.Add(evaluationMetricsPanel, 1, 0);
            evaluationTableLayoutPanel.Controls.Add(evaluationDataGridView, 2, 0);
            evaluationTableLayoutPanel.Dock = DockStyle.Fill;
            evaluationTableLayoutPanel.Enabled = false;
            evaluationTableLayoutPanel.Location = new Point(4, 3);
            evaluationTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            evaluationTableLayoutPanel.Name = "evaluationTableLayoutPanel";
            evaluationTableLayoutPanel.RowCount = 1;
            evaluationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            evaluationTableLayoutPanel.Size = new Size(920, 359);
            evaluationTableLayoutPanel.TabIndex = 0;
            // 
            // evaluationPanel
            // 
            evaluationPanel.Controls.Add(visualizeEvaluationButton);
            evaluationPanel.Controls.Add(evaluateButton);
            evaluationPanel.Dock = DockStyle.Fill;
            evaluationPanel.Location = new Point(3, 3);
            evaluationPanel.Name = "evaluationPanel";
            evaluationPanel.Size = new Size(111, 353);
            evaluationPanel.TabIndex = 0;
            // 
            // visualizeEvaluationButton
            // 
            visualizeEvaluationButton.Enabled = false;
            visualizeEvaluationButton.Location = new Point(4, 32);
            visualizeEvaluationButton.Margin = new Padding(4, 3, 4, 3);
            visualizeEvaluationButton.Name = "visualizeEvaluationButton";
            visualizeEvaluationButton.Size = new Size(75, 23);
            visualizeEvaluationButton.TabIndex = 1;
            visualizeEvaluationButton.Text = "Visualize...";
            visualizeEvaluationButton.UseVisualStyleBackColor = true;
            visualizeEvaluationButton.Click += VisualizeEvaluationButton_Click;
            // 
            // evaluateButton
            // 
            evaluateButton.Location = new Point(4, 3);
            evaluateButton.Margin = new Padding(4, 3, 4, 3);
            evaluateButton.Name = "evaluateButton";
            evaluateButton.Size = new Size(75, 23);
            evaluateButton.TabIndex = 0;
            evaluateButton.Text = "Evaluate";
            evaluateButton.UseVisualStyleBackColor = true;
            evaluateButton.Click += EvaluateButton_Click;
            // 
            // evaluationMetricsPanel
            // 
            evaluationMetricsPanel.Dock = DockStyle.Fill;
            evaluationMetricsPanel.Location = new Point(119, 2);
            evaluationMetricsPanel.Margin = new Padding(2);
            evaluationMetricsPanel.Name = "evaluationMetricsPanel";
            evaluationMetricsPanel.Size = new Size(346, 355);
            evaluationMetricsPanel.TabIndex = 1;
            // 
            // evaluationDataGridView
            // 
            evaluationDataGridView.AllowUserToAddRows = false;
            evaluationDataGridView.AllowUserToDeleteRows = false;
            evaluationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            evaluationDataGridView.Dock = DockStyle.Fill;
            evaluationDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            evaluationDataGridView.Location = new Point(469, 2);
            evaluationDataGridView.Margin = new Padding(2);
            evaluationDataGridView.Name = "evaluationDataGridView";
            evaluationDataGridView.ReadOnly = true;
            evaluationDataGridView.RowHeadersWidth = 51;
            evaluationDataGridView.RowTemplate.Height = 24;
            evaluationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            evaluationDataGridView.Size = new Size(449, 355);
            evaluationDataGridView.TabIndex = 2;
            evaluationDataGridView.CellFormatting += EvaluationDataGridView_CellFormatting;
            // 
            // predictionTabPage
            // 
            predictionTabPage.Controls.Add(predictionTableLayoutPanel);
            predictionTabPage.Location = new Point(4, 24);
            predictionTabPage.Margin = new Padding(4, 3, 4, 3);
            predictionTabPage.Name = "predictionTabPage";
            predictionTabPage.Padding = new Padding(4, 3, 4, 3);
            predictionTabPage.Size = new Size(928, 365);
            predictionTabPage.TabIndex = 6;
            predictionTabPage.Text = "Prediction";
            predictionTabPage.UseVisualStyleBackColor = true;
            // 
            // predictionTableLayoutPanel
            // 
            predictionTableLayoutPanel.ColumnCount = 1;
            predictionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            predictionTableLayoutPanel.Controls.Add(singlePredictionPanel, 0, 0);
            predictionTableLayoutPanel.Controls.Add(predictTableLayoutPanel, 0, 1);
            predictionTableLayoutPanel.Dock = DockStyle.Fill;
            predictionTableLayoutPanel.Enabled = false;
            predictionTableLayoutPanel.Location = new Point(4, 3);
            predictionTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            predictionTableLayoutPanel.Name = "predictionTableLayoutPanel";
            predictionTableLayoutPanel.RowCount = 2;
            predictionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            predictionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            predictionTableLayoutPanel.Size = new Size(920, 359);
            predictionTableLayoutPanel.TabIndex = 0;
            // 
            // singlePredictionPanel
            // 
            singlePredictionPanel.Controls.Add(predictButton);
            singlePredictionPanel.Controls.Add(predictionDataGridView);
            singlePredictionPanel.Dock = DockStyle.Fill;
            singlePredictionPanel.Location = new Point(3, 3);
            singlePredictionPanel.Name = "singlePredictionPanel";
            singlePredictionPanel.Size = new Size(914, 94);
            singlePredictionPanel.TabIndex = 0;
            // 
            // predictButton
            // 
            predictButton.Location = new Point(836, 3);
            predictButton.Name = "predictButton";
            predictButton.Size = new Size(75, 23);
            predictButton.TabIndex = 1;
            predictButton.Text = "Predict";
            predictButton.UseVisualStyleBackColor = true;
            predictButton.Click += PredictButton_Click;
            // 
            // predictionDataGridView
            // 
            predictionDataGridView.AllowUserToAddRows = false;
            predictionDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(224, 224, 224);
            predictionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            predictionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            predictionDataGridView.Location = new Point(3, 3);
            predictionDataGridView.Name = "predictionDataGridView";
            predictionDataGridView.RowHeadersWidth = 51;
            predictionDataGridView.RowTemplate.Height = 25;
            predictionDataGridView.Size = new Size(827, 88);
            predictionDataGridView.TabIndex = 0;
            predictionDataGridView.CellFormatting += PredictionDataGridView_CellFormatting;
            // 
            // predictTableLayoutPanel
            // 
            predictTableLayoutPanel.ColumnCount = 1;
            predictTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            predictTableLayoutPanel.Controls.Add(datasetPredictionPanel, 0, 0);
            predictTableLayoutPanel.Controls.Add(predictionDatasetDataGridView, 0, 1);
            predictTableLayoutPanel.Dock = DockStyle.Fill;
            predictTableLayoutPanel.Location = new Point(3, 103);
            predictTableLayoutPanel.Name = "predictTableLayoutPanel";
            predictTableLayoutPanel.RowCount = 2;
            predictTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            predictTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            predictTableLayoutPanel.Size = new Size(914, 253);
            predictTableLayoutPanel.TabIndex = 1;
            // 
            // datasetPredictionPanel
            // 
            datasetPredictionPanel.Controls.Add(visualizePredictionButton);
            datasetPredictionPanel.Controls.Add(predictionDataHasHeadersCheckBox);
            datasetPredictionPanel.Controls.Add(predictionProgressLabel);
            datasetPredictionPanel.Controls.Add(loadPredictionDataButton);
            datasetPredictionPanel.Controls.Add(predictionProgressBar);
            datasetPredictionPanel.Controls.Add(predictDatasetButton);
            datasetPredictionPanel.Dock = DockStyle.Fill;
            datasetPredictionPanel.Location = new Point(3, 3);
            datasetPredictionPanel.Name = "datasetPredictionPanel";
            datasetPredictionPanel.Size = new Size(908, 44);
            datasetPredictionPanel.TabIndex = 0;
            // 
            // visualizePredictionButton
            // 
            visualizePredictionButton.Enabled = false;
            visualizePredictionButton.Location = new Point(830, 8);
            visualizePredictionButton.Name = "visualizePredictionButton";
            visualizePredictionButton.Size = new Size(75, 23);
            visualizePredictionButton.TabIndex = 3;
            visualizePredictionButton.Text = "Visualize...";
            visualizePredictionButton.UseVisualStyleBackColor = true;
            visualizePredictionButton.Click += VisualizePredictionButton_Click;
            // 
            // predictionDataHasHeadersCheckBox
            // 
            predictionDataHasHeadersCheckBox.AutoSize = true;
            predictionDataHasHeadersCheckBox.Checked = true;
            predictionDataHasHeadersCheckBox.CheckState = CheckState.Checked;
            predictionDataHasHeadersCheckBox.Location = new Point(160, 10);
            predictionDataHasHeadersCheckBox.Margin = new Padding(4, 3, 4, 3);
            predictionDataHasHeadersCheckBox.Name = "predictionDataHasHeadersCheckBox";
            predictionDataHasHeadersCheckBox.Size = new Size(83, 19);
            predictionDataHasHeadersCheckBox.TabIndex = 2;
            predictionDataHasHeadersCheckBox.Text = "has header";
            predictionDataHasHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // predictionProgressLabel
            // 
            predictionProgressLabel.Location = new Point(537, 7);
            predictionProgressLabel.Margin = new Padding(4, 0, 4, 0);
            predictionProgressLabel.Name = "predictionProgressLabel";
            predictionProgressLabel.Size = new Size(286, 25);
            predictionProgressLabel.TabIndex = 0;
            // 
            // loadPredictionDataButton
            // 
            loadPredictionDataButton.Location = new Point(3, 8);
            loadPredictionDataButton.Name = "loadPredictionDataButton";
            loadPredictionDataButton.Size = new Size(150, 23);
            loadPredictionDataButton.TabIndex = 0;
            loadPredictionDataButton.Text = "Load prediction data...";
            loadPredictionDataButton.UseVisualStyleBackColor = true;
            loadPredictionDataButton.Click += LoadPredictionDataButton_Click;
            // 
            // predictionProgressBar
            // 
            predictionProgressBar.Location = new Point(332, 6);
            predictionProgressBar.Margin = new Padding(4, 3, 4, 3);
            predictionProgressBar.Name = "predictionProgressBar";
            predictionProgressBar.Size = new Size(197, 27);
            predictionProgressBar.TabIndex = 0;
            predictionProgressBar.Visible = false;
            // 
            // predictDatasetButton
            // 
            predictDatasetButton.Enabled = false;
            predictDatasetButton.Location = new Point(250, 8);
            predictDatasetButton.Name = "predictDatasetButton";
            predictDatasetButton.Size = new Size(75, 23);
            predictDatasetButton.TabIndex = 1;
            predictDatasetButton.Text = "Predict";
            predictDatasetButton.UseVisualStyleBackColor = true;
            predictDatasetButton.Click += PredictDatasetButton_Click;
            // 
            // predictionDatasetDataGridView
            // 
            predictionDatasetDataGridView.AllowUserToAddRows = false;
            predictionDatasetDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            predictionDatasetDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            predictionDatasetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            predictionDatasetDataGridView.Dock = DockStyle.Fill;
            predictionDatasetDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            predictionDatasetDataGridView.Location = new Point(3, 53);
            predictionDatasetDataGridView.Name = "predictionDatasetDataGridView";
            predictionDatasetDataGridView.ReadOnly = true;
            predictionDatasetDataGridView.RowHeadersWidth = 51;
            predictionDatasetDataGridView.RowTemplate.Height = 25;
            predictionDatasetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            predictionDatasetDataGridView.Size = new Size(908, 197);
            predictionDatasetDataGridView.TabIndex = 1;
            predictionDatasetDataGridView.CellFormatting += PredictionDatasetDataGridView_CellFormatting;
            // 
            // openDataFileFileDialog
            // 
            openDataFileFileDialog.FileName = "*.csv";
            openDataFileFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            openDataFileFileDialog.Title = "Load dataset";
            // 
            // PredictionTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(944, 561);
            Controls.Add(mainTableLayoutPanel);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(860, 548);
            Name = "PredictionTaskForm";
            ShowIcon = false;
            Text = "Prediction Task";
            mainTableLayoutPanel.ResumeLayout(false);
            taskTabControl.ResumeLayout(false);
            inputDataTabPage.ResumeLayout(false);
            inputDataTableLayoutPanel.ResumeLayout(false);
            inputDataPanel.ResumeLayout(false);
            inputDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputDataDataGridView).EndInit();
            dataProcessingTabPage.ResumeLayout(false);
            dataProcessingTableLayoutPanel.ResumeLayout(false);
            predictionTypeGroupBox.ResumeLayout(false);
            predictionTypeGroupBox.PerformLayout();
            inputAndOutputColumnsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)columnsDataGridView).EndInit();
            processingStepsGroupBox.ResumeLayout(false);
            processDataGroupBox.ResumeLayout(false);
            processedDataTabPage.ResumeLayout(false);
            processedDataTableLayoutPanel.ResumeLayout(false);
            processedDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)processedDataDataGridView).EndInit();
            trainDatasetTabPage.ResumeLayout(false);
            trainDatasetTableLayoutPanel.ResumeLayout(false);
            trainDatasetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trainDatasetDataGridView).EndInit();
            testDatasetTabPage.ResumeLayout(false);
            testDatasetTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)testDatasetDataGridView).EndInit();
            testDatasetPanel.ResumeLayout(false);
            modelTabPage.ResumeLayout(false);
            modelTableLayoutPanel.ResumeLayout(false);
            evaluationTabPage.ResumeLayout(false);
            evaluationTableLayoutPanel.ResumeLayout(false);
            evaluationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)evaluationDataGridView).EndInit();
            predictionTabPage.ResumeLayout(false);
            predictionTableLayoutPanel.ResumeLayout(false);
            singlePredictionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)predictionDataGridView).EndInit();
            predictTableLayoutPanel.ResumeLayout(false);
            datasetPredictionPanel.ResumeLayout(false);
            datasetPredictionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)predictionDatasetDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TabControl taskTabControl;
        private TabPage inputDataTabPage;
        private TabPage dataProcessingTabPage;
        private TabPage trainDatasetTabPage;
        private TabPage testDatasetTabPage;
        private TabPage modelTabPage;
        private TabPage evaluationTabPage;
        private TabPage predictionTabPage;
        private TabPage processedDataTabPage;
        private TableLayoutPanel inputDataTableLayoutPanel;
        private DataGridView inputDataDataGridView;
        private TableLayoutPanel processedDataTableLayoutPanel;
        private DataGridView processedDataDataGridView;
        private Panel inputDataPanel;
        private Button loadDataButton;
        private Panel processedDataPanel;
        private Button processedDataVisualizeButton;
        private Button splitDataButton;
        private TableLayoutPanel trainDatasetTableLayoutPanel;
        private Panel trainDatasetPanel;
        private Button trainDatasetVisualizeButton;
        private TableLayoutPanel testDatasetTableLayoutPanel;
        private Panel testDatasetPanel;
        private Button testDatasetVisualizeButton;
        private TableLayoutPanel dataProcessingTableLayoutPanel;
        private GroupBox inputAndOutputColumnsGroupBox;
        private GroupBox processingStepsGroupBox;
        private GroupBox processDataGroupBox;
        private Button processButton;
        private ListBox processingStepsListBox;
        private Button editProcessingStepsButton;
        private DataGridView columnsDataGridView;
        private GroupBox predictionTypeGroupBox;
        private RadioButton regressionRadioButton;
        private RadioButton multiclassClassificationRadioButton;
        private RadioButton binaryClassificationRadioButton;
        private OpenFileDialog openDataFileFileDialog;
        private CheckBox inputDataHasHeadersCheckBox;
        private Label processingProgressLabel;
        private ProgressBar processingProgressBar;
        private TableLayoutPanel evaluationTableLayoutPanel;
        private TableLayoutPanel predictionTableLayoutPanel;
        private TableLayoutPanel modelTableLayoutPanel;
        private Button loadModelButton;
        private Panel modelPanel;
        private Panel evaluationMetricsPanel;
        private DataGridView evaluationDataGridView;
        private Panel evaluationPanel;
        private Button visualizeEvaluationButton;
        private Button evaluateButton;
        private Panel singlePredictionPanel;
        private Button predictButton;
        private DataGridView predictionDataGridView;
        private TableLayoutPanel predictTableLayoutPanel;
        private Panel datasetPredictionPanel;
        private Button predictDatasetButton;
        private Button loadPredictionDataButton;
        private DataGridView predictionDatasetDataGridView;
        private Label predictionProgressLabel;
        private ProgressBar predictionProgressBar;
        private DataGridView trainDatasetDataGridView;
        private CheckBox predictionDataHasHeadersCheckBox;
        private Button visualizePredictionButton;
        private DataGridView testDatasetDataGridView;
        private DataGridViewTextBoxColumn columnColumn;
        private DataGridViewCheckBoxColumn inputColumn;
        private DataGridViewCheckBoxColumn outputColumn;
        private WorkflowDiagramControl workflowDiagramControl;
    }
}