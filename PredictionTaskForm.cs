using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Math.Optimization;
using Accord.IO;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;
using Accord.Statistics.Models.Regression.Linear;
using JadeChem.CustomControls.EvaluationControls;
using JadeChem.CustomControls.ModelControls;
using JadeChem.CustomEventArgs;
using JadeChem.Dialogs;
using JadeChem.Models;
using JadeChem.Utils;
using TorchSharp;
using System.Data;

namespace JadeChem
{
    public partial class PredictionTaskForm : Form
    {
        #region Fields
        private DataTable? inputData = null;

        private string[]? classLabels; // only for classification

        private PredictionType predictionType = PredictionType.Regression;

        private Dictionary<string, Dictionary<string, (double, double)>> inputScalersDictionary = new();
        private Dictionary<string, Dictionary<string, (double, double)>> outputScalersDictionary = new();
        private readonly Dictionary<string, MinMaxScaler> minMaxScalers = new();
        private readonly Dictionary<string, StandardScaler> standardScalers = new();
        private Dictionary<string, Dictionary<string, double>> dimensionalityReductionStepsDictionary = new();

        private string[]? inputColumnNames;
        private string[]? processedInputColumnNames;
        private string? outputColumnName;

        private VarianceThresholdFilter? varianceThresholdFilter;
        private PCAFilter? pcaFilter;

        private DataTable? processedDataset;
        private double[][]? processedInputColumns;
        private double[]? processedOutputColumnForRegression;
        private string[]? processedOutputColumnForClassification;
        private int[]? processedClassIndices;


        private DataTable? trainDataset;
        private double[][]? trainInputColumns;
        private double[]? trainOutputColumnForRegression;
        private string[]? trainOutputColumnForClassification;
        private int[]? trainClassIndices;

        private DataTable? testDataset;
        private double[][]? testInputColumns;
        private double[]? testOutputColumnForRegression;
        private string[]? testOutputColumnForClassification;
        private int[]? testClassIndices;

        private string[]? predictedOutputColumnForClassification;
        private double[]? predictedOutputColumnForRegression;

        private DataTable? predictionDataset;
        private double[][]? predictionInputColumns;
        private double[]? predictionOutputColumnForRegression;
        private string[]? predictionOutputColumnForClassification;

        private object? model;
        private DeviceType deviceType;
        private torch.ScalarType dataType;

        // Dialogs
        private DataProcessingDialog? dataProcessingDialog;

        // Flags
        private bool isDataProcessingDialogResetNeeded = true;
        #endregion

        #region Enumeration
        public enum PredictionType
        {
            BinaryClassification,
            MulticlassClassification,
            Regression
        }
        #endregion

        #region Events
        public delegate void InputDataLoadedEventHandler(DataTableEventArgs e);
        public event InputDataLoadedEventHandler? InputDataLoaded;
        public delegate void ProcessedDataLoadedEventHandler(DataTableEventArgs e);
        public event ProcessedDataLoadedEventHandler? ProcessedDataLoaded;
        public delegate void TrainDatasetLoadedEventHandler(DataTableEventArgs e);
        public event TrainDatasetLoadedEventHandler? TrainDatasetLoaded;
        public delegate void TestDatasetLoadedEventHandler(DataTableEventArgs e);
        public event TestDatasetLoadedEventHandler? TestDatasetLoaded;
        public delegate void ModelLoadedEventHandler(EventArgs e);
        public event ModelLoadedEventHandler? ModelLoaded;
        public delegate void ModelTrainedEventHandler(ModelEventArgs e);
        public event ModelTrainedEventHandler? ModelTrained;
        public delegate void ModelEvaluatedEventHandler(EventArgs e);
        public event ModelEvaluatedEventHandler? ModelEvaluated;
        public delegate void PredictionDataLoadedEventHandler(DataTableEventArgs e);
        public event PredictionDataLoadedEventHandler? PredictionDataLoaded;
        #endregion

        #region Constructor
        public PredictionTaskForm()
        {
            InitializeComponent();

            // Register event listeners
            InputDataLoaded += OnInputDataLoaded;
            ProcessedDataLoaded += OnProcessedDataLoaded;
            TrainDatasetLoaded += OnTrainDatasetLoaded;
            TestDatasetLoaded += OnTestDatasetLoaded;
            ModelLoaded += OnModelLoaded;
            ModelTrained += OnModelTrained;
            ModelEvaluated += OnModelEvaluated;
            PredictionDataLoaded += OnPredictionDataLoaded;
        }
        #endregion

        #region Methods
        // Diagram
        private void DiagramControl_InputDataBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(inputDataTabPage);
        }

        private void DiagramControl_ProcessingArrowBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(dataProcessingTabPage);
        }

        private void DiagramControl_ProcessedDataBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(processedDataTabPage);
        }

        private void DiagramControl_TrainDatasetBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(trainDatasetTabPage);
        }

        private void DiagramControl_TestDatasetBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(testDatasetTabPage);
        }

        private void DiagramControl_ModelBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(modelTabPage);
        }

        private void DiagramControl_EvaluationBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(evaluationTabPage);
        }

        private void DiagramControl_PredictionBlockClicked(object sender, EventArgs e)
        {
            taskTabControl.SelectTab(predictionTabPage);
        }

        // inputDataTabPage
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            if (this.inputData != null)
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

            if (openDataFileFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            DataTable inputData;
            try
            {
                inputData = DataFileLoader.LoadCsvFile(openDataFileFileDialog.FileName, inputDataHasHeadersCheckBox.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inputData != null)
            {
                // Raise the event
                InputDataLoaded?.Invoke(new DataTableEventArgs() { Dataset = inputData });
            }
        }

        private void OnInputDataLoaded(DataTableEventArgs e)
        {
            inputData = e.Dataset;

            // Draw the outlines of inputDataBlock in the diagram
            workflowDiagramControl.DrawInputDataBlockOutlines(true);
            workflowDiagramControl.Refresh();

            // Show the data in DataGridView
            inputDataDataGridView.DataSource = null;
            inputDataDataGridView.DataSource = inputData;

            // Guess the prediction type
            string[] classLabels = inputData.Columns[inputData.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
            if (classLabels.Length == 2) // Binary classification
            {
                predictionType = PredictionType.BinaryClassification;
                binaryClassificationRadioButton.Checked = true;
            }
            else if (classLabels.Length <= 10) // Multiclass classification
            {
                predictionType = PredictionType.MulticlassClassification;
                multiclassClassificationRadioButton.Checked = true;
            }
            else // Regression
            {
                predictionType = PredictionType.Regression;
                regressionRadioButton.Checked = true;
            }

            // Get the columns for inputs/outputs selection
            columnsDataGridView.Rows.Clear();
            for (int columnIndex = 0; columnIndex < inputData.Columns.Count; columnIndex++)
            {
                if (columnIndex < inputData.Columns.Count - 1)
                    columnsDataGridView.Rows.Add(new object[] { inputData.Columns[columnIndex].ColumnName, true, false });
                else
                    columnsDataGridView.Rows.Add(new object[] { inputData.Columns[columnIndex].ColumnName, false, true });
            }

            // Reset the dialog, dictionaries, and listboxes
            isDataProcessingDialogResetNeeded = true;
            inputScalersDictionary.Clear();
            outputScalersDictionary.Clear();
            dimensionalityReductionStepsDictionary.Clear();
            processingStepsListBox.Items.Clear();

            // Enable the next tab page
            dataProcessingTableLayoutPanel.Enabled = true;
        }

        // dataProcessingTabpage
        private void PredictionTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (binaryClassificationRadioButton.Checked)
                predictionType = PredictionType.BinaryClassification;
            else if (multiclassClassificationRadioButton.Checked)
                predictionType = PredictionType.MulticlassClassification;
            else
                predictionType = PredictionType.Regression;
        }

        private void EditProcessingStepsButton_Click(object sender, EventArgs e)
        {
            if (inputData == null)
                return;

            // Get the input columns for feature extraction and input columns for model
            string[] inputColumnNames;
            string outputColumnName;
            try
            {
                inputColumnNames = GetInputColumnNames();
                outputColumnName = GetOutputColumnName();
                if (inputColumnNames.Length == 0 && predictionType != PredictionType.Regression)
                    throw new Exception("No column to be processed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the column selection was changed
            string[] selectedInputColumnNames = inputScalersDictionary.Keys.ToArray();
            if (!selectedInputColumnNames.SequenceEqual(inputColumnNames))
                isDataProcessingDialogResetNeeded = true;

            // Reset the dialogs if the column selection was changed or this is the first time the dialog is shown
            if (isDataProcessingDialogResetNeeded)
            {
                // Add column names to the dictionaries
                Dictionary<string, Dictionary<string, (double, double)>> inputScalersDictionary = new();
                for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                    inputScalersDictionary[inputColumnNames[columnIndex]] = new Dictionary<string, (double, double)>();

                Dictionary<string, Dictionary<string, (double, double)>> outputScalersDictionary = new();
                if (predictionType == PredictionType.Regression)
                    outputScalersDictionary[outputColumnName] = new Dictionary<string, (double, double)>();

                Dictionary<string, Dictionary<string, double>> dimensionalityReductionStepsDictionary = new();

                // Reset the dialog
                dataProcessingDialog = new DataProcessingDialog(inputScalersDictionary, outputScalersDictionary, dimensionalityReductionStepsDictionary);
            }
            else
            {
                dataProcessingDialog = new DataProcessingDialog(inputScalersDictionary.DeepClone(), outputScalersDictionary.DeepClone(), dimensionalityReductionStepsDictionary.DeepClone());
            }

            // Show the dialog
            if (dataProcessingDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Turn off the flag
                isDataProcessingDialogResetNeeded = false;

                // Save the dictionaries
                inputScalersDictionary = dataProcessingDialog.InputScalersDictionary.DeepClone();
                outputScalersDictionary = dataProcessingDialog.OutputScalersDictionary.DeepClone();
                dimensionalityReductionStepsDictionary = dataProcessingDialog.DimensionalityReductionStepsDictionary.DeepClone();

                // Create the scalers for each column
                minMaxScalers.Clear();
                standardScalers.Clear();
                foreach (KeyValuePair<string, Dictionary<string, (double, double)>> keyValuePair in inputScalersDictionary)
                {
                    string columnName = keyValuePair.Key;
                    if (keyValuePair.Value.ContainsKey("Min-max scaling"))
                    {
                        (double minOutput, double maxOutput) = keyValuePair.Value["Min-max scaling"];
                        minMaxScalers[columnName] = new MinMaxScaler(minOutput, maxOutput);
                    }
                    else if (keyValuePair.Value.ContainsKey("Standardization"))
                    {
                        standardScalers[columnName] = new StandardScaler();
                    }
                }
                foreach (KeyValuePair<string, Dictionary<string, (double, double)>> keyValuePair in outputScalersDictionary)
                {
                    string columnName = keyValuePair.Key;
                    if (keyValuePair.Value.ContainsKey("Min-max scaling"))
                    {
                        (double minOutput, double maxOutput) = keyValuePair.Value["Min-max scaling"];
                        minMaxScalers[columnName] = new MinMaxScaler(minOutput, maxOutput);
                    }
                    else if (keyValuePair.Value.ContainsKey("Standardization"))
                    {
                        standardScalers[columnName] = new StandardScaler();
                    }
                }

                // Add processing steps to the list box
                processingStepsListBox.Items.Clear();
                for (int columnIndex = 0; columnIndex < inputScalersDictionary.Keys.Count; columnIndex++)
                {
                    string columnName = inputScalersDictionary.Keys.ElementAt(columnIndex);
                    foreach (KeyValuePair<string, (double, double)> keyValuePair in inputScalersDictionary[columnName])
                    {
                        if (keyValuePair.Key == "Standardization")
                            processingStepsListBox.Items.Add(columnName + " → Standardization");
                        if (keyValuePair.Key == "Min-max scaling")
                        {
                            (double minOutput, double maxOutput) = keyValuePair.Value;
                            processingStepsListBox.Items.Add(columnName + " → Min-max scaling { range=(" + minOutput.ToString() + ", " + maxOutput.ToString() + ") }");
                        }
                    }
                }
                for (int columnIndex = 0; columnIndex < outputScalersDictionary.Keys.Count; columnIndex++)
                {
                    string columnName = outputScalersDictionary.Keys.ElementAt(columnIndex);
                    foreach (KeyValuePair<string, (double, double)> keyValuePair in outputScalersDictionary[columnName])
                    {
                        if (keyValuePair.Key == "Standardization")
                            processingStepsListBox.Items.Add(columnName + " → Standardization");
                        if (keyValuePair.Key == "Min-max scaling")
                        {
                            (double minOutput, double maxOutput) = keyValuePair.Value;
                            processingStepsListBox.Items.Add(columnName + " → Min-max scaling { range=(" + minOutput.ToString() + ", " + maxOutput.ToString() + ") }");
                        }
                    }
                }
                foreach (KeyValuePair<string, Dictionary<string, double>> keyValuePair in dimensionalityReductionStepsDictionary)
                {
                    if (keyValuePair.Key == "Variance threshold")
                        processingStepsListBox.Items.Add("Variance threshold { threshold = " + keyValuePair.Value["threshold"] + " }");
                    else if (keyValuePair.Key == "Principle component analysis")
                        processingStepsListBox.Items.Add("Principle component analysis { nComponents = " + keyValuePair.Value["nComponents"] + " }");
                }
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (inputData == null)
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                // Get the input and output columns
                inputColumnNames = GetInputColumnNames();
                outputColumnName = GetOutputColumnName();

                // Check if no input column for model
                if (inputColumnNames.Length == 0)
                    throw new Exception("No input column was selected!");

                // Check if a column was selected for multiple roles
                for (int columnIndex = 0; columnIndex < columnsDataGridView.Rows.Count; columnIndex++)
                {
                    int numberOfRoles = 0;
                    for (int roleIndex = 1; roleIndex < columnsDataGridView.ColumnCount; roleIndex++)
                        if ((bool)columnsDataGridView.Rows[columnIndex].Cells[roleIndex].Value == true)
                            numberOfRoles++;

                    if (numberOfRoles >= 2)
                        throw new Exception("You cannot choose multiple roles for 1 column!");
                }

                // Check output column
                string[] outputColumn = inputData.Columns[outputColumnName].ToArray<string>();
                string[] classLabel = outputColumn.Distinct().OrderBy(x => x).ToArray();
                if (predictionType == PredictionType.BinaryClassification && classLabel.Length != 2)
                    throw new Exception("For binary classification, output column must contain 2 classes!");
                if (predictionType == PredictionType.MulticlassClassification && classLabel.Length < 2)
                    throw new Exception("For multiclass classification, output column must contain 2 or more classes!");
                if (predictionType == PredictionType.MulticlassClassification && classLabel.Length > 10)
                    throw new Exception("The output column contains too many classes!");

                this.classLabels = classLabel;

                // Reset the dictionaries if the data processing dialog needs to be reset
                if (isDataProcessingDialogResetNeeded)
                {
                    // Add column names to the dictionaries
                    Dictionary<string, Dictionary<string, (double, double)>> inputScalersDictionary = new();
                    for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                        inputScalersDictionary[inputColumnNames[columnIndex]] = new Dictionary<string, (double, double)>();


                    Dictionary<string, Dictionary<string, (double, double)>> outputScalersDictionary = new();
                    if (predictionType == PredictionType.Regression)
                        outputScalersDictionary[outputColumnName] = new Dictionary<string, (double, double)>();

                    Dictionary<string, Dictionary<string, double>> dimensionalityReductionStepsDictionary = new();

                    // Reset the dialog
                    dataProcessingDialog = new DataProcessingDialog(inputScalersDictionary, outputScalersDictionary, dimensionalityReductionStepsDictionary);

                    // Turn off the flag
                    isDataProcessingDialogResetNeeded = false;

                    // Save the dictionaries
                    this.inputScalersDictionary = dataProcessingDialog.InputScalersDictionary.DeepClone();
                    this.outputScalersDictionary = dataProcessingDialog.OutputScalersDictionary.DeepClone();
                    this.dimensionalityReductionStepsDictionary = dataProcessingDialog.DimensionalityReductionStepsDictionary.DeepClone();
                    // Create the scalers for each column
                    minMaxScalers.Clear();
                    standardScalers.Clear();
                    foreach (KeyValuePair<string, Dictionary<string, (double, double)>> keyValuePair in inputScalersDictionary)
                    {
                        string columnName = keyValuePair.Key;
                        if (keyValuePair.Value.ContainsKey("Min-max scaling"))
                        {
                            (double minOutput, double maxOutput) = keyValuePair.Value["Min-max scaling"];
                            minMaxScalers[columnName] = new MinMaxScaler(minOutput, maxOutput);
                        }
                        else if (keyValuePair.Value.ContainsKey("Standardization"))
                        {
                            standardScalers[columnName] = new StandardScaler();
                        }
                    }
                    foreach (KeyValuePair<string, Dictionary<string, (double, double)>> keyValuePair in outputScalersDictionary)
                    {
                        string columnName = keyValuePair.Key;
                        if (keyValuePair.Value.ContainsKey("Min-max scaling"))
                        {
                            (double minOutput, double maxOutput) = keyValuePair.Value["Min-max scaling"];
                            minMaxScalers[columnName] = new MinMaxScaler(minOutput, maxOutput);
                        }
                        else if (keyValuePair.Value.ContainsKey("Standardization"))
                        {
                            standardScalers[columnName] = new StandardScaler();
                        }
                    }
                }
                else
                {
                    dataProcessingDialog = new DataProcessingDialog(inputScalersDictionary.DeepClone(), outputScalersDictionary.DeepClone(), dimensionalityReductionStepsDictionary.DeepClone());
                }

                // Get input columns
                double[][] inputColumns = new double[inputData.Rows.Count][];
                for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                {
                    double[] column = inputData.Columns[inputColumnNames[columnIndex]].ToArray();

                    if (inputColumns[0] == null)
                        inputColumns = column.ToJagged();
                    else
                        inputColumns = inputColumns.Concatenate(column.ToJagged());
                }

                if (inputColumns[0] == null)
                    throw new Exception("No input column was selected or extracted!");

                // Scaling
                processingProgressLabel.Text = "Scaling...";
                processingProgressLabel.Update();
                Thread.Sleep(500);

                double[][] scaledInputColumns = new double[inputData.Rows.Count][];
                // Scale input and feature columns
                for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                {
                    string columnName = inputColumnNames[columnIndex];
                    double[] column = inputColumns.GetColumn(columnIndex);
                    // Scale input columns
                    if (inputScalersDictionary.ContainsKey(columnName))
                    {
                        double[] scaledColumn = ScaleColumn(column, columnName);

                        // Add scaledColumn to the matrix
                        if (scaledInputColumns[0] == null)
                            scaledInputColumns = scaledColumn.ToJagged();
                        else
                            scaledInputColumns = scaledInputColumns.Concatenate(scaledColumn.ToJagged());
                    }
                }

                // Dimensionality reduction
                processingProgressLabel.Text = "Dimensionality reduction...";
                processingProgressLabel.Update();
                Thread.Sleep(500);

                processedInputColumns = new double[inputData.Rows.Count][];
                if (dimensionalityReductionStepsDictionary.ContainsKey("Variance threshold") && dimensionalityReductionStepsDictionary.ContainsKey("Principle component analysis"))
                {
                    // Apply variance threshold and PCA filters
                    double threshold = dimensionalityReductionStepsDictionary["Variance threshold"]["threshold"];
                    varianceThresholdFilter = new VarianceThresholdFilter();
                    (processedInputColumnNames, processedInputColumns) = varianceThresholdFilter.FitTransform(inputColumnNames, scaledInputColumns, threshold);

                    int nComponents = (int)dimensionalityReductionStepsDictionary["Principle component analysis"]["nComponents"];
                    pcaFilter = new PCAFilter();
                    (processedInputColumnNames, processedInputColumns) = pcaFilter.FitTransform(processedInputColumns, nComponents);
                }
                else if (dimensionalityReductionStepsDictionary.ContainsKey("Variance threshold"))
                {
                    // Apply variance threshold filter only
                    double threshold = dimensionalityReductionStepsDictionary["Variance threshold"]["threshold"];
                    varianceThresholdFilter = new VarianceThresholdFilter();
                    (processedInputColumnNames, processedInputColumns) = varianceThresholdFilter.FitTransform(inputColumnNames, scaledInputColumns, threshold);
                }
                else if (dimensionalityReductionStepsDictionary.ContainsKey("Principle component analysis"))
                {
                    // Apply PCA filter only
                    int nComponents = (int)dimensionalityReductionStepsDictionary["Principle component analysis"]["nComponents"];
                    pcaFilter = new PCAFilter();
                    (processedInputColumnNames, processedInputColumns) = pcaFilter.FitTransform(scaledInputColumns, nComponents);
                }
                else
                {
                    // No filter
                    processedInputColumnNames = inputColumnNames;
                    processedInputColumns = scaledInputColumns;
                }
                processingProgressLabel.Text = "";
                processingProgressLabel.Update();

                // Process output columns (only for regression)
                if (predictionType == PredictionType.Regression)
                {
                    // Scale output columns
                    double[] scaledOutputColumn;
                    double[] column = inputData.Columns[outputColumnName].ToArray();
                    if (outputScalersDictionary.ContainsKey(outputColumnName))
                        scaledOutputColumn = ScaleColumn(column, outputColumnName);
                    else
                        scaledOutputColumn = column;

                    processedOutputColumnForRegression = scaledOutputColumn;
                }
                else
                {
                    processedOutputColumnForClassification = inputData.Columns[outputColumnName].ToArray<string>();
                }

                // Combine the input and output column into a table
                if (predictionType == PredictionType.Regression)
                {
                    double[][] processedColumns = processedInputColumns.Concatenate(processedOutputColumnForRegression.ToJagged());
                    string[] processedColumnNames = processedInputColumnNames.Concatenate(outputColumnName);

                    processedDataset = processedColumns.ToTable(processedColumnNames);
                }
                else
                {
                    processedDataset = processedInputColumns.ToTable(processedInputColumnNames);
                    processedDataset.Columns.Add(outputColumnName, typeof(string));

                    for (int rowIndex = 0; rowIndex < inputData.Rows.Count; rowIndex++)
                        if (processedOutputColumnForClassification != null)
                            processedDataset.Rows[rowIndex][outputColumnName] = processedOutputColumnForClassification[rowIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processingProgressBar.Visible = false;
                processingProgressLabel.Text = "";
                Cursor = Cursors.Default;
                return;
            }

            processingProgressLabel.Text = "Processing done.";

            Cursor = Cursors.Default;

            // Show the processed dataset
            if (processedDataset.Columns.Count > 600)
            {
                MessageBox.Show(this, "The processed dataset contains too many columns and cannot be showed. You should reduce the number of features.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                processedDataDataGridView.DataSource = null;
            }
            else
            {
                processedDataDataGridView.DataSource = null;
                processedDataDataGridView.DataSource = processedDataset;
                processedDataDataGridView.Refresh();
            }

            // Raise the event
            ProcessedDataLoaded?.Invoke(new DataTableEventArgs() { Dataset = processedDataset });
        }

        private void OnProcessedDataLoaded(DataTableEventArgs e)
        {
            // Draw the outlines of processedData in the diagram
            workflowDiagramControl.DrawProcessDataBlockOutlines(true);
            workflowDiagramControl.Refresh();

            // Disable changing prediction type after the data is processed
            binaryClassificationRadioButton.Enabled = false;
            multiclassClassificationRadioButton.Enabled = false;
            regressionRadioButton.Enabled = false;

            // Get the column of class indices
            processedClassIndices = new int[processedInputColumns.Rows()];

            if (processedOutputColumnForClassification != null)
                for (int rowIndex = 0; rowIndex < processedOutputColumnForClassification.Rows(); rowIndex++)
                    processedClassIndices[rowIndex] = classLabels.IndexOf(processedOutputColumnForClassification[rowIndex]);

            // Enable the next tab pages
            processedDataTableLayoutPanel.Enabled = true;
            modelTableLayoutPanel.Enabled = true;
        }

        // processedDataTabPage
        private void ProcessedDataDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == processedDataDataGridView.ColumnCount - 1)
            {
                e.CellStyle ??= new DataGridViewCellStyle();

                e.CellStyle.BackColor = Color.Cyan;
            }
        }

        private void SplitDataButton_Click(object sender, EventArgs e)
        {
            if (inputData == null ||
                processedInputColumns == null ||
                processedInputColumnNames == null ||
                outputColumnName == null)
                return;

            EditSplitRatioDialog editSplitRatioDialog = new(inputData.Rows.Count, EditSplitRatioDialog.SplitType.TrainTestSplit);
            if (editSplitRatioDialog.ShowDialog(this) != DialogResult.OK)
                return;

            double splitRatio = editSplitRatioDialog.SplitRatio;
            int randomSeed = editSplitRatioDialog.RandomSeed;

            TrainTestSpliter trainTestSpliter = new();
            if (predictionType == PredictionType.Regression)
            {
                double[][] trainOutputColumnsForRegression;
                double[][] testOutputColumnsForRegression;
                (trainInputColumns, trainOutputColumnsForRegression, testInputColumns, testOutputColumnsForRegression) = trainTestSpliter.Split(processedInputColumns, processedOutputColumnForRegression.ToJagged(), 1 - splitRatio, randomSeed);
                trainOutputColumnForRegression = trainOutputColumnsForRegression.GetColumn(0);
                testOutputColumnForRegression = testOutputColumnsForRegression.GetColumn(0);

                // Combine the input and output column into a tables
                string[] processedInputColumnNames = this.processedInputColumnNames;

                double[][] trainValues = trainInputColumns.Concatenate(trainOutputColumnForRegression.ToJagged());
                string[] trainColumnNames = processedInputColumnNames.Concatenate(outputColumnName);
                trainDataset = trainValues.ToTable(trainColumnNames);

                double[][] testValues = testInputColumns.Concatenate(testOutputColumnForRegression.ToJagged());
                string[] testColumnNames = processedInputColumnNames.Concatenate(outputColumnName);
                testDataset = testValues.ToTable(testColumnNames);

            }
            else // Classification
            {
                string[][] trainOutputColumnsForClassification;
                string[][] testOutputColumnsForClassification;
                (trainInputColumns, trainOutputColumnsForClassification, testInputColumns, testOutputColumnsForClassification) = trainTestSpliter.Split(processedInputColumns, processedOutputColumnForClassification.ToJagged(), 1 - splitRatio, randomSeed);
                trainOutputColumnForClassification = trainOutputColumnsForClassification.GetColumn(0);
                testOutputColumnForClassification = testOutputColumnsForClassification.GetColumn(0);
                trainClassIndices = processedClassIndices.Get(trainTestSpliter.TrainIndices);
                testClassIndices = processedClassIndices.Get(trainTestSpliter.TestIndices);

                // Combine the input and output column into a table
                trainDataset = trainInputColumns.ToTable(processedInputColumnNames);
                testDataset = testInputColumns.ToTable(processedInputColumnNames);

                trainDataset.Columns.Add(outputColumnName, typeof(string));
                testDataset.Columns.Add(outputColumnName, typeof(string));

                for (int rowIndex = 0; rowIndex < trainDataset.Rows.Count; rowIndex++)
                    trainDataset.Rows[rowIndex][outputColumnName] = trainOutputColumnForClassification[rowIndex];
                for (int rowIndex = 0; rowIndex < testDataset.Rows.Count; rowIndex++)
                    testDataset.Rows[rowIndex][outputColumnName] = testOutputColumnForClassification[rowIndex];
            }

            // Show trainDataset and testDataset
            trainDatasetDataGridView.DataSource = null;
            trainDatasetDataGridView.DataSource = trainDataset;
            testDatasetDataGridView.DataSource = null;
            testDatasetDataGridView.DataSource = testDataset;

            // Raise the event
            TrainDatasetLoaded?.Invoke(new DataTableEventArgs() { Dataset = trainDataset });
            TestDatasetLoaded?.Invoke(new DataTableEventArgs() { Dataset = testDataset });
        }

        private void ProcessedDataVisualizeButton_Click(object sender, EventArgs e)
        {
            if (predictionType == PredictionType.Regression)
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    processedInputColumns == null ||
                    processedOutputColumnForRegression == null)
                    return;

                VisualizeRegressionDataDialog visualizeRegressionDataDialog = new(processedInputColumnNames, outputColumnName, processedInputColumns, processedOutputColumnForRegression);
                visualizeRegressionDataDialog.Show(this);
            }
            else // Classification
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    processedInputColumns == null ||
                    processedOutputColumnForClassification == null)
                    return;

                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new(processedInputColumnNames, outputColumnName, processedInputColumns, processedOutputColumnForClassification);
                visualizeClassificationDataDialog.Show(this);
            }
        }

        private void OnTrainDatasetLoaded(DataTableEventArgs e)
        {
            // Draw the outlines of trainDatasetBlock in the diagram
            workflowDiagramControl.DrawTrainDatasetBlockOutlines(true);
            workflowDiagramControl.Refresh();

            // Enable the next tab page
            trainDatasetTableLayoutPanel.Enabled = true;
        }

        private void OnTestDatasetLoaded(DataTableEventArgs e)
        {
            // Draw the outlines of testDatasetBlock in the diagram
            workflowDiagramControl.DrawTestDatasetBlockOutlines(true);
            workflowDiagramControl.Refresh();

            // Enable the next tab page
            testDatasetTableLayoutPanel.Enabled = true;
        }

        // trainDatasetTabPage
        private void TrainDatasetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == trainDatasetDataGridView.ColumnCount - 1)
            {
                e.CellStyle ??= new DataGridViewCellStyle();

                e.CellStyle.BackColor = Color.Cyan;
            }
        }

        private void TrainDatasetVisualizeButton_Click(object sender, EventArgs e)
        {
            if (predictionType == PredictionType.Regression)
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    trainInputColumns == null ||
                    trainOutputColumnForRegression == null)
                    return;

                VisualizeRegressionDataDialog visualizeRegressionDataDialog = new(processedInputColumnNames, outputColumnName, trainInputColumns, trainOutputColumnForRegression);
                visualizeRegressionDataDialog.Show(this);
            }
            else // Classification
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    trainInputColumns == null ||
                    trainOutputColumnForClassification == null)
                    return;

                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new(processedInputColumnNames, outputColumnName, trainInputColumns, trainOutputColumnForClassification);
                visualizeClassificationDataDialog.Show(this);
            }
        }

        // testDatasetTabPage
        private void TestDatasetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == testDatasetDataGridView.ColumnCount - 1)
            {
                e.CellStyle ??= new DataGridViewCellStyle();

                e.CellStyle.BackColor = Color.Cyan;
            }
        }

        private void TestDatasetVisualizeButton_Click(object sender, EventArgs e)
        {
            if (predictionType == PredictionType.Regression)
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    testInputColumns == null ||
                    testOutputColumnForRegression == null)
                    return;

                VisualizeRegressionDataDialog visualizeRegressionDataDialog = new(processedInputColumnNames, outputColumnName, testInputColumns, testOutputColumnForRegression);
                visualizeRegressionDataDialog.Show(this);
            }
            else // Classification
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    testInputColumns == null ||
                    testOutputColumnForClassification == null)
                    return;

                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new(processedInputColumnNames, outputColumnName, testInputColumns, testOutputColumnForClassification);
                visualizeClassificationDataDialog.Show(this);
            }
        }

        // modelTabPage
        private void LoadModelButton_Click(object sender, EventArgs e)
        {
            string modelName = "";

            if (modelPanel.Controls.Count > 0)
            {
                if (MessageBox.Show(this, "Do you want to override the current model?", "Override model", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            switch (predictionType)
            {
                case PredictionType.BinaryClassification:
                    BinaryClassificationModelSelectionDialog binaryClassificationModelSelectionDialog = new();

                    if (binaryClassificationModelSelectionDialog.ShowDialog(this) == DialogResult.OK)
                        modelName = binaryClassificationModelSelectionDialog.ModelName;
                    else
                        return;

                    break;
                case PredictionType.MulticlassClassification:
                    MulticlassClassificationModelSelectionDialog multiclassClassificationModelSelectionDialog = new();

                    if (multiclassClassificationModelSelectionDialog.ShowDialog(this) == DialogResult.OK)
                        modelName = multiclassClassificationModelSelectionDialog.ModelName;
                    else
                        return;

                    break;
                case PredictionType.Regression:
                    RegressionModelSelectionDialog regressionModelSelectionDialog = new();

                    if (regressionModelSelectionDialog.ShowDialog(this) == DialogResult.OK)
                        modelName = regressionModelSelectionDialog.ModelName;
                    else
                        return;

                    break;
            }

            switch (modelName)
            {
                case "K-Nearest Neighbors":
                    modelPanel.Controls.Clear();
                    KNNModelControl knnModelControl = new();
                    modelPanel.Controls.Add(knnModelControl);
                    knnModelControl.Dock = DockStyle.Fill;
                    knnModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Naïve Bayes":
                    modelPanel.Controls.Clear();
                    NaiveBayesModelControl naiveBayesModelControl = new();
                    modelPanel.Controls.Add(naiveBayesModelControl);
                    naiveBayesModelControl.Dock = DockStyle.Fill;
                    naiveBayesModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Logistic Regression":
                    modelPanel.Controls.Clear();
                    LogisticRegressionModelControl logisticRegressionModelControl = new();
                    modelPanel.Controls.Add(logisticRegressionModelControl);
                    logisticRegressionModelControl.Dock = DockStyle.Fill;
                    logisticRegressionModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Decision Tree":
                    modelPanel.Controls.Clear();
                    DecisionTreeModelControl decisionTreeModelControl = new();
                    modelPanel.Controls.Add(decisionTreeModelControl);
                    decisionTreeModelControl.Dock = DockStyle.Fill;
                    decisionTreeModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Multinomial Logistic Regression":
                    modelPanel.Controls.Clear();
                    MultinomialLogisticRegressionModelControl multinomialLogisticRegressionModelControl = new();
                    modelPanel.Controls.Add(multinomialLogisticRegressionModelControl);
                    multinomialLogisticRegressionModelControl.Dock = DockStyle.Fill;
                    multinomialLogisticRegressionModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Random Forest":
                    modelPanel.Controls.Clear();
                    RandomForestModelControl randomForestModelControl = new();
                    modelPanel.Controls.Add(randomForestModelControl);
                    randomForestModelControl.Dock = DockStyle.Fill;
                    randomForestModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Linear Regression":
                    modelPanel.Controls.Clear();
                    LinearRegressionModelControl linearRegressionModelControl = new();
                    modelPanel.Controls.Add(linearRegressionModelControl);
                    linearRegressionModelControl.Dock = DockStyle.Fill;
                    linearRegressionModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Ridge Regression":
                    modelPanel.Controls.Clear();
                    RidgeRegressionModelControl ridgeRegressionModelControl = new();
                    modelPanel.Controls.Add(ridgeRegressionModelControl);
                    ridgeRegressionModelControl.Dock = DockStyle.Fill;
                    ridgeRegressionModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Lasso Regression":
                    modelPanel.Controls.Clear();
                    LassoRegressionModelControl lassoRegressionModelControl = new();
                    modelPanel.Controls.Add(lassoRegressionModelControl);
                    lassoRegressionModelControl.Dock = DockStyle.Fill;
                    lassoRegressionModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Elastic Net Regression":
                    modelPanel.Controls.Clear();
                    ElasticNetRegressionModelControl elasticNetRegressionModelControl = new();
                    modelPanel.Controls.Add(elasticNetRegressionModelControl);
                    elasticNetRegressionModelControl.Dock = DockStyle.Fill;
                    elasticNetRegressionModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Support Vector Machine":
                    // Check if trainDataset is loaded
                    if (trainInputColumns == null)
                    {
                        MessageBox.Show("Train dataset must be prepared before loading Support Vector Machine model!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    modelPanel.Controls.Clear();
                    SVMModelControl svmModelControl = new(trainInputColumns);
                    modelPanel.Controls.Add(svmModelControl);
                    svmModelControl.Dock = DockStyle.Fill;
                    svmModelControl.TrainButtonClicked += TrainModel;

                    // Raise the event
                    ModelLoaded?.Invoke(EventArgs.Empty);

                    break;
                case "Multilayer Perceptron":
                    // Check if trainDataset is loaded
                    if (trainInputColumns == null)
                    {
                        MessageBox.Show("Train dataset must be prepared before loading Multilayer Perceptron model!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (predictionType == PredictionType.Regression)
                    {
                        if (trainOutputColumnForRegression != null && processedInputColumnNames != null)
                        {
                            modelPanel.Controls.Clear();
                            MLPModelControl mlpModelControl = new(predictionType, processedInputColumnNames, trainInputColumns, trainOutputColumnForRegression);
                            modelPanel.Controls.Add(mlpModelControl);
                            mlpModelControl.Dock = DockStyle.Fill;
                            mlpModelControl.ModelCreated += OnModelLoaded;
                            mlpModelControl.ModelTrained += OnModelTrained;
                        }
                    }
                    else
                    {
                        if (trainOutputColumnForClassification != null && processedInputColumnNames != null)
                        {
                            modelPanel.Controls.Clear();
                            MLPModelControl mlpModelControl = new(predictionType, processedInputColumnNames, trainInputColumns, trainOutputColumnForClassification);
                            modelPanel.Controls.Add(mlpModelControl);
                            mlpModelControl.Dock = DockStyle.Fill;
                            mlpModelControl.ModelCreated += OnModelLoaded;
                            mlpModelControl.ModelTrained += OnModelTrained;
                        }
                    }
                    break;
            }
        }

        private void TrainModel(EventArgs e)
        {
            // Check the train dataset
            if (trainInputColumns == null)
            {
                MessageBox.Show("Train dataset must be prepared before training a model!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object? trainedModel = null;
            Cursor = Cursors.WaitCursor;

            try
            {
                if (modelPanel.Controls[0].GetType() == typeof(KNNModelControl))
                {
                    KNNModelControl knnModelControl = (KNNModelControl)modelPanel.Controls[0];
                    KNearestNeighbors model = new(knnModelControl.Hyperparameters["k"]);

                    model.Learn(trainInputColumns, trainClassIndices);
                    trainedModel = model;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(NaiveBayesModelControl))
                {
                    NaiveBayesLearning<NormalDistribution> naiveBayesLearning = new();
                    trainedModel = naiveBayesLearning.Learn(trainInputColumns, trainClassIndices);
                }
                else if (modelPanel.Controls[0].GetType() == typeof(LogisticRegressionModelControl))
                {
                    LogisticRegressionModelControl logisticRegressionModelControl = (LogisticRegressionModelControl)modelPanel.Controls[0];
                    if ((string)logisticRegressionModelControl.Hyperparameters["learning method"] == "Logistic gradient descent")
                    {
                        LogisticGradientDescent logisticGradientDescent = new()
                        {
                            Tolerance = (double)logisticRegressionModelControl.Hyperparameters["tolerance"],
                            MaxIterations = (int)logisticRegressionModelControl.Hyperparameters["max iterations"],
                            LearningRate = (double)logisticRegressionModelControl.Hyperparameters["learning rate"],
                            Stochastic = (bool)logisticRegressionModelControl.Hyperparameters["stochastic"]
                        };
                        LogisticRegression model = logisticGradientDescent.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    }
                    else
                    {
                        IterativeReweightedLeastSquares<LogisticRegression> iterativeReweightedLeastSquares = new()
                        {
                            Tolerance = (double)logisticRegressionModelControl.Hyperparameters["tolerance"],
                            MaxIterations = (int)logisticRegressionModelControl.Hyperparameters["max iterations"],
                            Regularization = (double)logisticRegressionModelControl.Hyperparameters["regularization"]
                        };
                        LogisticRegression model = iterativeReweightedLeastSquares.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    }
                }
                else if (modelPanel.Controls[0].GetType() == typeof(DecisionTreeModelControl))
                {
                    C45Learning c45Learning = new();
                    DecisionTree model = c45Learning.Learn(trainInputColumns, trainClassIndices);
                    trainedModel = model;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(RandomForestModelControl))
                {
                    RandomForestModelControl randomForestModelControl = (RandomForestModelControl)modelPanel.Controls[0];

                    RandomForestLearning randomForestLearning = new()
                    {
                        SampleRatio = randomForestModelControl.Hyperparameters["Sample ratio"],
                        NumberOfTrees = (int)randomForestModelControl.Hyperparameters["Number of trees"]
                    };
                    RandomForest model = randomForestLearning.Learn(trainInputColumns, trainClassIndices);
                    trainedModel = model;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(MultinomialLogisticRegressionModelControl))
                {
                    MultinomialLogisticRegressionModelControl multinomialLogisticRegressionModelControl = (MultinomialLogisticRegressionModelControl)modelPanel.Controls[0];
                    if (multinomialLogisticRegressionModelControl.Hyperparameters["learning method"] == "Lower bound Newton-Raphson")
                    {
                        LowerBoundNewtonRaphson lowerBoundNewtonRaphson = new()
                        {
                            MaxIterations = int.Parse(multinomialLogisticRegressionModelControl.Hyperparameters["max iteration"]),
                            Tolerance = double.Parse(multinomialLogisticRegressionModelControl.Hyperparameters["tolerance"])
                        };
                        MultinomialLogisticRegression model = lowerBoundNewtonRaphson.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    }
                    else if (multinomialLogisticRegressionModelControl.Hyperparameters["learning method"] == "Conjugate gradient")
                    {
                        MultinomialLogisticLearning<ConjugateGradient> multinomialLogisticLearning = new();
                        MultinomialLogisticRegression model = multinomialLogisticLearning.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    }
                    else if (multinomialLogisticRegressionModelControl.Hyperparameters["learning method"] == "Gradient descent")
                    {
                        MultinomialLogisticLearning<GradientDescent> multinomialLogisticLearning = new();
                        MultinomialLogisticRegression model = multinomialLogisticLearning.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    }
                    else if (multinomialLogisticRegressionModelControl.Hyperparameters["learning method"] == "Broyden-Fletcher-Goldfarb-Shanno")
                    {
                        MultinomialLogisticLearning<BroydenFletcherGoldfarbShanno> multinomialLogisticLearning = new();
                        MultinomialLogisticRegression model = multinomialLogisticLearning.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    };
                }
                else if (modelPanel.Controls[0].GetType() == typeof(LinearRegressionModelControl))
                {
                    LinearRegressionModelControl linearRegressionModelControl = (LinearRegressionModelControl)modelPanel.Controls[0];

                    OrdinaryLeastSquares ordinaryLeastSquares = new()
                    {
                        UseIntercept = !linearRegressionModelControl.Hyperparameters["Set intercept = 0"]
                    };
                    MultipleLinearRegression model = ordinaryLeastSquares.Learn(trainInputColumns, trainOutputColumnForRegression);
                    trainedModel = model;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(RidgeRegressionModelControl))
                {
                    RidgeRegressionModelControl ridgeRegressionModelControl = (RidgeRegressionModelControl)modelPanel.Controls[0];

                    RidgeRegression model = new(ridgeRegressionModelControl.Hyperparameters["lambda"]);
                    model.Learn(trainInputColumns, trainOutputColumnForRegression);
                    trainedModel = model;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(LassoRegressionModelControl))
                {
                    LassoRegressionModelControl lassoRegressionModelControl = (LassoRegressionModelControl)modelPanel.Controls[0];

                    double lambda = lassoRegressionModelControl.Hyperparameters["lambda"];
                    double learningRate = lassoRegressionModelControl.Hyperparameters["learning rate"];
                    int maxIterations = (int)lassoRegressionModelControl.Hyperparameters["max iterations"];
                    LassoRegression model = new(lambda, learningRate, maxIterations);
                    model.Learn(trainInputColumns, trainOutputColumnForRegression);
                    trainedModel = model;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(ElasticNetRegressionModelControl))
                {
                    ElasticNetRegressionModelControl elasticNetRegressionModel = (ElasticNetRegressionModelControl)modelPanel.Controls[0];

                    double lambda = elasticNetRegressionModel.Hyperparameters["lambda"];
                    double alpha = elasticNetRegressionModel.Hyperparameters["alpha"];
                    double learningRate = elasticNetRegressionModel.Hyperparameters["learning rate"];
                    int maxIterations = (int)elasticNetRegressionModel.Hyperparameters["max iterations"];
                    ElasticNetRegression model = new(lambda, alpha, learningRate, maxIterations);
                    model.Learn(trainInputColumns, trainOutputColumnForRegression);
                    trainedModel = model;
                }
                else if (modelPanel.Controls[0].GetType() == typeof(SVMModelControl))
                {
                    if (predictionType == PredictionType.BinaryClassification)
                    {
                        SVMModelControl svmModelControl = (SVMModelControl)modelPanel.Controls[0];
                        SequentialMinimalOptimization<IKernel> sequentialMinimalOptimization = new()
                        {
                            Complexity = svmModelControl.Hyperparameters["complexity"],
                            Tolerance = svmModelControl.Hyperparameters["tolerance"],
                            PositiveWeight = svmModelControl.Hyperparameters["tolerance"],
                            NegativeWeight = svmModelControl.Hyperparameters["tolerance"],
                            Kernel = svmModelControl.CreateKernel()
                        };
                        SupportVectorMachine<IKernel> model = sequentialMinimalOptimization.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    }
                    else if (predictionType == PredictionType.MulticlassClassification)
                    {
                        SVMModelControl svmModelControl = (SVMModelControl)modelPanel.Controls[0];
                        MulticlassSupportVectorLearning<IKernel> multiclassSVMLearning = new()
                        {
                            Learner = (p) => new SequentialMinimalOptimization<IKernel>()
                            {
                                Complexity = svmModelControl.Hyperparameters["complexity"],
                                Tolerance = svmModelControl.Hyperparameters["tolerance"],
                                PositiveWeight = svmModelControl.Hyperparameters["tolerance"],
                                NegativeWeight = svmModelControl.Hyperparameters["tolerance"],
                                Kernel = svmModelControl.CreateKernel()
                            }
                        };

                        MulticlassSupportVectorMachine<IKernel> model = multiclassSVMLearning.Learn(trainInputColumns, trainClassIndices);
                        trainedModel = model;
                    }
                    else // Regression
                    {
                        SVMModelControl svmModelControl = (SVMModelControl)modelPanel.Controls[0];
                        SequentialMinimalOptimizationRegression<IKernel> sequentialMinimalOptimizationRegression = new()
                        {
                            Complexity = svmModelControl.Hyperparameters["complexity"],
                            Tolerance = svmModelControl.Hyperparameters["tolerance"],
                            Epsilon = svmModelControl.Hyperparameters["epsilon"],
                            Kernel = svmModelControl.CreateKernel()
                        };
                        SupportVectorMachine<IKernel> model = sequentialMinimalOptimizationRegression.Learn(trainInputColumns, trainOutputColumnForRegression);
                        trainedModel = model;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }

            Cursor = Cursors.Default;

            // Raise the event
            ModelTrained?.Invoke(new ModelEventArgs { Model = trainedModel });
        }

        private void OnModelLoaded(EventArgs e)
        {
            // Draw the outlines of modelBlock in the diagram
            workflowDiagramControl.DrawModelBlockDashedOutlines(true);
            workflowDiagramControl.Refresh();
        }

        private void OnModelTrained(ModelEventArgs e)
        {
            model = e.Model;

            // Draw the outlines of modelBlock in the diagram
            workflowDiagramControl.DrawModelBlockOutlines(true);
            workflowDiagramControl.Refresh();

            // Update model control
            if (modelPanel.Controls[0].GetType() == typeof(NaiveBayesModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null && outputColumnName != null)
                {
                    NaiveBayesModelControl naiveBayesModelControl = (NaiveBayesModelControl)modelPanel.Controls[0];
                    naiveBayesModelControl.UpdateNormalDistributionTable((NaiveBayes<NormalDistribution>)model, processedInputColumnNames, classLabels, outputColumnName);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(DecisionTreeModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    DecisionTreeModelControl decisionTreeModelControl = (DecisionTreeModelControl)modelPanel.Controls[0];
                    decisionTreeModelControl.UpdateDecisionTreeView((DecisionTree)model, processedInputColumnNames, classLabels);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(RandomForestModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    RandomForestModelControl randomForestModelControl = (RandomForestModelControl)modelPanel.Controls[0];
                    randomForestModelControl.UpdateDecisionTreeView((RandomForest)model, processedInputColumnNames, classLabels);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(LogisticRegressionModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    LogisticRegressionModelControl logisticRegressionModelControl = (LogisticRegressionModelControl)modelPanel.Controls[0];
                    logisticRegressionModelControl.UpdateFittingEquation((LogisticRegression)model, processedInputColumnNames);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(MultinomialLogisticRegressionModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    MultinomialLogisticRegressionModelControl multinomialLogisticRegressionModelControl = (MultinomialLogisticRegressionModelControl)modelPanel.Controls[0];
                    multinomialLogisticRegressionModelControl.UpdateFittingEquation((MultinomialLogisticRegression)model, processedInputColumnNames);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(LinearRegressionModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    LinearRegressionModelControl linearRegressionModelControl = (LinearRegressionModelControl)modelPanel.Controls[0];
                    linearRegressionModelControl.UpdateFittingEquation((MultipleLinearRegression)model, processedInputColumnNames);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(RidgeRegressionModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    RidgeRegressionModelControl ridgeRegressionModelControl = (RidgeRegressionModelControl)modelPanel.Controls[0];
                    ridgeRegressionModelControl.UpdateFittingEquation((RidgeRegression)model, processedInputColumnNames);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(LassoRegressionModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    LassoRegressionModelControl lassoRegressionModelControl = (LassoRegressionModelControl)modelPanel.Controls[0];
                    lassoRegressionModelControl.UpdateFittingEquation((LassoRegression)model, processedInputColumnNames);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(ElasticNetRegressionModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    ElasticNetRegressionModelControl elasticNetRegressionModelControl = (ElasticNetRegressionModelControl)modelPanel.Controls[0];
                    elasticNetRegressionModelControl.UpdateFittingEquation((ElasticNetRegression)model, processedInputColumnNames);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(SVMModelControl))
            {
                if (model != null && processedInputColumnNames != null && classLabels != null)
                {
                    SVMModelControl svmModelControl = (SVMModelControl)modelPanel.Controls[0];
                    if (model.GetType() == typeof(SupportVectorMachine<IKernel>))
                        svmModelControl.EnableViewSupportVectors((SupportVectorMachine<IKernel>)model, processedInputColumnNames);
                    else if (model.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
                        svmModelControl.EnableViewSupportVectors((MulticlassSupportVectorMachine<IKernel>)model, processedInputColumnNames);
                }
            }
            else if (modelPanel.Controls[0].GetType() == typeof(MLPModelControl))
            {
                MLPModelControl mlpModelControl = (MLPModelControl)modelPanel.Controls[0];
                deviceType = mlpModelControl.DeviceType;
                dataType = mlpModelControl.DataType;
            }

            // Add columns to predictionDataGrivView
            predictionDataGridView.Columns.Clear();
            if (inputColumnNames != null)
            {
                for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
                    predictionDataGridView.Columns.Add(inputColumnNames[columnIndex], inputColumnNames[columnIndex]);
                predictionDataGridView.Columns.Add(outputColumnName, outputColumnName);
                predictionDataGridView.Columns[predictionDataGridView.ColumnCount - 1].ReadOnly = true;
                predictionDataGridView.Rows.Add();
            }

            // Enable the next tab pages
            evaluationTableLayoutPanel.Enabled = true;
            predictionTableLayoutPanel.Enabled = true;
        }

        // evaluationTabPage
        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            if (model == null || testDataset == null)
                return;

            int[] predictedClassIndices = Array.Empty<int>(); // for classification
            predictedOutputColumnForClassification = Array.Empty<string>(); // for classification
            predictedOutputColumnForRegression = Array.Empty<double>(); // for regression

            if (model.GetType() == typeof(KNearestNeighbors))
            {
                KNearestNeighbors model = (KNearestNeighbors)this.model;

                predictedClassIndices = model.Decide(testInputColumns);
            }
            else if (model.GetType() == typeof(RandomForest))
            {
                RandomForest model = (RandomForest)this.model;
                predictedClassIndices = model.Decide(testInputColumns);
            }
            else if (model.GetType() == typeof(NaiveBayes<NormalDistribution>))
            {
                NaiveBayes<NormalDistribution> model = (NaiveBayes<NormalDistribution>)this.model;
                predictedClassIndices = model.Decide(testInputColumns);
            }
            else if (model.GetType() == typeof(LogisticRegression))
            {
                LogisticRegression model = (LogisticRegression)this.model;
                predictedClassIndices = model.Decide(testInputColumns).ToInt32();
            }
            else if (model.GetType() == typeof(DecisionTree))
            {
                DecisionTree model = (DecisionTree)this.model;
                predictedClassIndices = model.Decide(testInputColumns);
            }
            else if (model.GetType() == typeof(MultinomialLogisticRegression))
            {
                MultinomialLogisticRegression model = (MultinomialLogisticRegression)this.model;
                predictedClassIndices = model.Decide(testInputColumns);
            }
            else if (model.GetType() == typeof(MultipleLinearRegression))
            {
                MultipleLinearRegression model = (MultipleLinearRegression)this.model;
                predictedOutputColumnForRegression = model.Transform(testInputColumns);
            }
            else if (model.GetType() == typeof(RidgeRegression))
            {
                RidgeRegression model = (RidgeRegression)this.model;
                predictedOutputColumnForRegression = model.Transform(testInputColumns);
            }
            else if (model.GetType() == typeof(LassoRegression))
            {
                LassoRegression model = (LassoRegression)this.model;
                predictedOutputColumnForRegression = model.Transform(testInputColumns);
            }
            else if (model.GetType() == typeof(ElasticNetRegression))
            {
                ElasticNetRegression model = (ElasticNetRegression)this.model;
                predictedOutputColumnForRegression = model.Transform(testInputColumns);
            }
            else if (model.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                if (predictionType == PredictionType.BinaryClassification)
                {
                    SupportVectorMachine<IKernel> model = (SupportVectorMachine<IKernel>)this.model;
                    predictedClassIndices = model.Decide(testInputColumns).ToInt32();
                }
                else //Regression
                {
                    SupportVectorMachine<IKernel> model = (SupportVectorMachine<IKernel>)this.model;
                    predictedOutputColumnForRegression = model.Score(testInputColumns);
                }
            }
            else if (model.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
            {
                MulticlassSupportVectorMachine<IKernel> model = (MulticlassSupportVectorMachine<IKernel>)this.model;
                predictedClassIndices = model.Decide(testInputColumns);
            }
            else if (model.GetType() == typeof(MLP))
            {
                MLP mlp = (MLP)model;

                torch.Tensor x = torch.tensor(testInputColumns.ToMatrix(), dataType);
                x = x.to(deviceType);

                if (predictionType == PredictionType.BinaryClassification)
                {
                    torch.Tensor logits = mlp.forward(x);
                    torch.Tensor probabilities = torch.sigmoid(logits);
                    torch.Tensor y = torch.round(probabilities);
                    predictedClassIndices = new int[testInputColumns.Rows()];
                    for (int rowIndex = 0; rowIndex < y.shape[0]; rowIndex++)
                        predictedClassIndices[rowIndex] = y[rowIndex].cpu().detach().ToInt32();
                }
                else if (predictionType == PredictionType.MulticlassClassification)
                {
                    torch.Tensor yEncoded = mlp.forward(x);
                    predictedClassIndices = new int[testInputColumns.Rows()];
                    for (int rowIndex = 0; rowIndex < yEncoded.shape[0]; rowIndex++)
                        predictedClassIndices[rowIndex] = torch.argmax(yEncoded[rowIndex]).cpu().detach().ToInt32();
                }
                else // Regresion
                {
                    torch.Tensor y = mlp.forward(x);
                    predictedOutputColumnForRegression = new double[testInputColumns.Rows()];
                    for (int rowIndex = 0; rowIndex < y.shape[0]; rowIndex++)
                        predictedOutputColumnForRegression[rowIndex] = y[rowIndex].cpu().detach().ToDouble();
                }
            }

            if (predictionType == PredictionType.BinaryClassification)
            {
                if (classLabels == null || testClassIndices == null)
                    return;

                BinaryClassificationEvaluationControl binaryClassificationEvaluationControl = new(classLabels, predictedClassIndices, testClassIndices);
                evaluationMetricsPanel.Controls.Clear();
                evaluationMetricsPanel.Controls.Add(binaryClassificationEvaluationControl);
                evaluationMetricsPanel.Controls[0].Dock = DockStyle.Fill;

                DataTable evaluationDataTable = testDataset.DeepClone();
                evaluationDataTable.Columns.Add(outputColumnName + " (Predicted)");
                for (int rowIndex = 0; rowIndex < evaluationDataTable.Rows.Count; rowIndex++)
                    evaluationDataTable.Rows[rowIndex][evaluationDataTable.Columns.Count - 1] = classLabels[predictedClassIndices[rowIndex]];

                evaluationDataGridView.DataSource = null;
                evaluationDataGridView.DataSource = evaluationDataTable;

                predictedOutputColumnForClassification = new string[predictedClassIndices.Length];
                for (int rowIndex = 0; rowIndex < predictedClassIndices.Length; rowIndex++)
                    predictedOutputColumnForClassification[rowIndex] = classLabels[predictedClassIndices[rowIndex]];
            }
            else if (predictionType == PredictionType.MulticlassClassification)
            {
                if (classLabels == null || testClassIndices == null)
                    return;

                MulticlassClassificationEvaluationControl multiclassClassificationEvaluationControl = new(classLabels, predictedClassIndices, testClassIndices);
                evaluationMetricsPanel.Controls.Clear();
                evaluationMetricsPanel.Controls.Add(multiclassClassificationEvaluationControl);
                evaluationMetricsPanel.Controls[0].Dock = DockStyle.Fill;

                DataTable evaluationDataTable = testDataset.DeepClone();
                evaluationDataTable.Columns.Add(outputColumnName + " (Predicted)");
                for (int rowIndex = 0; rowIndex < evaluationDataTable.Rows.Count; rowIndex++)
                    evaluationDataTable.Rows[rowIndex][evaluationDataTable.Columns.Count - 1] = classLabels[predictedClassIndices[rowIndex]];

                evaluationDataGridView.DataSource = null;
                evaluationDataGridView.DataSource = evaluationDataTable;

                predictedOutputColumnForClassification = new string[predictedClassIndices.Length];
                for (int rowIndex = 0; rowIndex < predictedClassIndices.Length; rowIndex++)
                    predictedOutputColumnForClassification[rowIndex] = classLabels[predictedClassIndices[rowIndex]];
            }
            else // Regression
            {
                if (testOutputColumnForRegression == null)
                    return;

                RegressionEvaluationControl regressionEvaluationControl = new(predictedOutputColumnForRegression, testOutputColumnForRegression);
                evaluationMetricsPanel.Controls.Clear();
                evaluationMetricsPanel.Controls.Add(regressionEvaluationControl);
                evaluationMetricsPanel.Controls[0].Dock = DockStyle.Fill;

                DataTable evaluationDataTable = testDataset.DeepClone();
                evaluationDataTable.Columns.Add(outputColumnName + " (Predicted)", typeof(double));
                for (int rowIndex = 0; rowIndex < evaluationDataTable.Rows.Count; rowIndex++)
                    evaluationDataTable.Rows[rowIndex][evaluationDataTable.Columns.Count - 1] = predictedOutputColumnForRegression[rowIndex];

                evaluationDataGridView.DataSource = null;
                evaluationDataGridView.DataSource = evaluationDataTable;
            }

            // Raise the event
            ModelEvaluated?.Invoke(EventArgs.Empty);
        }

        private void OnModelEvaluated(EventArgs e)
        {
            // Draw the outlines of modelBlock in the diagram
            workflowDiagramControl.DrawEvaluationBlockOutlines(true);
            workflowDiagramControl.Refresh();

            // Enable visualization
            visualizeEvaluationButton.Enabled = true;
        }

        private void EvaluationDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == evaluationDataGridView.ColumnCount - 1 || e.ColumnIndex == evaluationDataGridView.ColumnCount - 2)
            {
                if (predictionType != PredictionType.Regression)
                {
                    string predictedClassLabel = (string)evaluationDataGridView.Rows[e.RowIndex].Cells[evaluationDataGridView.Columns.Count - 1].Value;
                    string expectedClassLabel = (string)evaluationDataGridView.Rows[e.RowIndex].Cells[evaluationDataGridView.Columns.Count - 2].Value;
                    if (predictedClassLabel != expectedClassLabel)
                    {
                        e.CellStyle ??= new DataGridViewCellStyle();

                        e.CellStyle.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        e.CellStyle ??= new DataGridViewCellStyle();

                        e.CellStyle.BackColor = Color.Cyan;
                    }
                }
                else
                {
                    e.CellStyle ??= new DataGridViewCellStyle();

                    e.CellStyle.BackColor = Color.Cyan;
                }
            }
        }

        private void VisualizeEvaluationButton_Click(object sender, EventArgs e)
        {
            if (predictionType == PredictionType.Regression)
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    testInputColumns == null ||
                    predictedOutputColumnForRegression == null ||
                    testOutputColumnForRegression == null)
                    return;

                VisualizeRegressionEvaluationDataDialog visualizeRegressionEvaluationDataDialog = new(processedInputColumnNames, outputColumnName, testInputColumns, predictedOutputColumnForRegression, testOutputColumnForRegression);
                visualizeRegressionEvaluationDataDialog.Show(this);
            }
            else // Classification
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    testInputColumns == null ||
                    predictedOutputColumnForClassification == null ||
                    testOutputColumnForClassification == null)
                    return;

                VisualizeClassificationEvaluationDataDialog visualizeClassificationEvaluationData = new(processedInputColumnNames, outputColumnName, testInputColumns, predictedOutputColumnForClassification, testOutputColumnForClassification);
                visualizeClassificationEvaluationData.Show(this);
            }
        }

        // predictionTabPage
        private void PredictButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] columnNames = new string[predictionDataGridView.ColumnCount - 1];
                string[] cellValues = new string[predictionDataGridView.ColumnCount - 1];
                for (int columnIndex = 0; columnIndex < columnNames.Length; columnIndex++)
                {
                    if (predictionDataGridView.Rows[0].Cells[columnIndex].Value == null ||
                        (string)predictionDataGridView.Rows[0].Cells[columnIndex].Value == "")
                        throw new Exception("Input value cannot be empty!");

                    columnNames[columnIndex] = predictionDataGridView.Columns[columnIndex].HeaderText;
                    cellValues[columnIndex] = (string)predictionDataGridView.Rows[0].Cells[columnIndex].Value;

                    // Check for valid input values
                    if (inputColumnNames != null && inputColumnNames.Contains(columnNames[columnIndex]))
                    {
                        // Check for number
                        if (!double.TryParse(cellValues[columnIndex], out double result))
                            throw new Exception("Invalid input for model!");
                    }
                }

                // Prediction
                string output = PredictRow(cellValues).Item2;

                predictionDataGridView.Rows[0].Cells[predictionDataGridView.ColumnCount - 1].Value = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PredictionDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == predictionDataGridView.ColumnCount - 1)
            {
                e.CellStyle ??= new DataGridViewCellStyle();

                e.CellStyle.BackColor = Color.Cyan;
            }
        }

        private void LoadPredictionDataButton_Click(object sender, EventArgs e)
        {
            if (this.predictionDataset != null)
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

            if (openDataFileFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            DataTable predictionDataset;
            try
            {
                predictionDataset = DataFileLoader.LoadCsvFile(openDataFileFileDialog.FileName, predictionDataHasHeadersCheckBox.Checked);

                if (inputColumnNames != null && predictionDataset.Columns.Count != inputColumnNames.Length)
                    throw new Exception("Prediction dataset must have the same number of input columns with processed data (" + (inputColumnNames.Length).ToString() + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (predictionDataset != null)
            {
                // Raise the event
                PredictionDataLoaded?.Invoke(new DataTableEventArgs() { Dataset = predictionDataset });
            }
        }

        private void OnPredictionDataLoaded(DataTableEventArgs e)
        {
            predictionDataset = e.Dataset;
            predictionDataset.Columns.Add(outputColumnName + " (Predicted)", typeof(string));
            for (int rowIndex = 0; rowIndex < predictionDataset.Rows.Count; rowIndex++)
                predictionDataset.Rows[rowIndex][predictionDataset.Columns.Count - 1] = "(...)";

            // Show the data in DataGridView
            predictionDatasetDataGridView.DataSource = null;
            predictionDatasetDataGridView.DataSource = predictionDataset;

            // Enable prediction
            predictDatasetButton.Enabled = true;
        }

        private void PredictDatasetButton_Click(object sender, EventArgs e)
        {
            if (predictionDataset == null)
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                predictionInputColumns = new double[predictionDatasetDataGridView.Rows.Count][];
                if (predictionType == PredictionType.Regression)
                    predictionOutputColumnForRegression = new double[predictionDatasetDataGridView.Rows.Count];
                else
                    predictionOutputColumnForClassification = new string[predictionDatasetDataGridView.Rows.Count];

                for (int rowIndex = 0; rowIndex < predictionDatasetDataGridView.Rows.Count; rowIndex++)
                {
                    string[] columnNames = new string[predictionDatasetDataGridView.ColumnCount - 1];
                    string[] cellValues = new string[predictionDatasetDataGridView.ColumnCount - 1];
                    for (int columnIndex = 0; columnIndex < columnNames.Length; columnIndex++)
                    {
                        if (predictionDatasetDataGridView.Rows[rowIndex].Cells[columnIndex].Value == null ||
                            predictionDatasetDataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString() == "")
                            throw new Exception("Input value cannot be empty!");

                        columnNames[columnIndex] = predictionDatasetDataGridView.Columns[columnIndex].HeaderText;
                        cellValues[columnIndex] = predictionDatasetDataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString() ?? "";

                        // Check for valid input values
                        if (inputColumnNames != null && inputColumnNames.Contains(columnNames[columnIndex]))
                        {
                            // Check for number
                            if (!double.TryParse(cellValues[columnIndex], out double result))
                                throw new Exception("Invalid input for model!");
                        }
                    }

                    // Prediction
                    (double[] processedInputValues, string output) = PredictRow(cellValues);

                    // Add predicted value to the last column of predictionDatasetDataGridView
                    predictionDatasetDataGridView.Rows[rowIndex].Cells[predictionDatasetDataGridView.ColumnCount - 1].Value = output;

                    // Add the row into the matrix for visualization
                    predictionInputColumns[rowIndex] = processedInputValues;
                    if (predictionType == PredictionType.Regression && predictionOutputColumnForRegression != null)
                        predictionOutputColumnForRegression[rowIndex] = double.Parse(output);
                    else if (predictionOutputColumnForClassification != null)
                        predictionOutputColumnForClassification[rowIndex] = output;

                    // Update progress
                    predictionProgressBar.Visible = true;
                    predictionProgressBar.Value = (int)Math.Ceiling((float)rowIndex / predictionDatasetDataGridView.Rows.Count * 100);
                    predictionProgressBar.Update();
                    predictionProgressLabel.Text = (rowIndex + 1).ToString() + "/" + predictionDatasetDataGridView.Rows.Count.ToString() + " rows predicted...";
                    predictionProgressLabel.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                predictionProgressBar.Visible = false;
                predictionProgressLabel.Text = "";
                Cursor = Cursors.Default;
                return;
            }

            predictionProgressBar.Value = 100;
            predictionProgressBar.Update();
            predictionProgressLabel.Text = predictionDatasetDataGridView.Rows.Count.ToString() + " rows predicted!";
            predictionProgressLabel.Update();

            // Enable visualization
            visualizePredictionButton.Enabled = true;

            Cursor = Cursors.Default;
        }

        private void PredictionDatasetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == predictionDatasetDataGridView.ColumnCount - 1)
            {
                e.CellStyle ??= new DataGridViewCellStyle();

                e.CellStyle.BackColor = Color.Cyan;
            }
        }

        // Helper methods
        private string[] GetInputColumnNames()
        {
            if (inputData == null)
                return Array.Empty<string>();

            List<string> inputColumnNamesForModel = new();

            for (int columnIndex = 0; columnIndex < columnsDataGridView.Rows.Count; columnIndex++)
            {
                if ((bool)columnsDataGridView.Rows[columnIndex].Cells[1].Value == true)
                    if (inputData.Columns[columnIndex].DataType == typeof(double))
                        inputColumnNamesForModel.Add((string)columnsDataGridView.Rows[columnIndex].Cells[0].Value);
                    else
                        throw new Exception("The column [" + (string)columnsDataGridView.Rows[columnIndex].Cells[0].Value + "] cannot be used as input for model!");
            }

            return inputColumnNamesForModel.ToArray();
        }

        private string GetOutputColumnName()
        {
            if (inputData == null)
                return "";

            List<string> outputColumnNames = new();

            for (int columnIndex = 0; columnIndex < columnsDataGridView.Rows.Count; columnIndex++)
            {
                if ((bool)columnsDataGridView.Rows[columnIndex].Cells[2].Value == true)
                    outputColumnNames.Add((string)columnsDataGridView.Rows[columnIndex].Cells[0].Value);
            }
            if (outputColumnNames.Count != 1)
                throw new Exception("You must choose 1 output column!");

            classLabels = inputData.Columns[outputColumnNames[0]].ToArray<string>().Distinct().OrderBy(x => x).ToArray();

            return outputColumnNames[0];
        }

        private double[] ScaleColumn(double[] column, string columnName)
        {
            // Do scaling for selected columns
            double[] scaledColumn;

            // Do both min-max scaling and standardization
            if (standardScalers.ContainsKey(columnName) && minMaxScalers.ContainsKey(columnName))
            {
                // Standardization
                scaledColumn = standardScalers[columnName].FitTransform(column);

                // Min-max scaling
                scaledColumn = minMaxScalers[columnName].FitTransform(scaledColumn);
            }
            // Only do min-max scaling
            else if (minMaxScalers.ContainsKey(columnName))
            {
                scaledColumn = minMaxScalers[columnName].FitTransform(column);
            }
            // Only do min-max standardization
            else if (standardScalers.ContainsKey(columnName))
            {
                scaledColumn = standardScalers[columnName].FitTransform(column);
            }
            else
            {
                scaledColumn = column;
            }

            return scaledColumn;
        }

        private double ScaleValue(double value, string columnName)
        {
            // Do scaling for selected columns
            double scaledValue;

            // Do both min-max scaling and standardization
            if (standardScalers.ContainsKey(columnName) && minMaxScalers.ContainsKey(columnName))
            {
                // Standardization
                scaledValue = standardScalers[columnName].Transform(value);

                // Min-max scaling
                scaledValue = minMaxScalers[columnName].Transform(scaledValue);
            }
            // Only do min-max scaling
            else if (minMaxScalers.ContainsKey(columnName))
            {
                scaledValue = minMaxScalers[columnName].Transform(value);
            }
            // Only do min-max standardization
            else if (standardScalers.ContainsKey(columnName))
            {
                scaledValue = standardScalers[columnName].Transform(value);
            }
            else
            {
                scaledValue = value;
            }

            return scaledValue;
        }

        private (double[], string) PredictRow(string[] cellValues)
        {
            if (model == null || inputColumnNames == null)
                return (Array.Empty<double>(), "");

            // Get input row
            List<double> inputRow = new();
            for (int columnIndex = 0; columnIndex < cellValues.Length; columnIndex++)
            {
                string cellValue = cellValues[columnIndex];
                inputRow.Add(double.Parse(cellValue));
            }

            // Data processing
            List<double> scaledInputValues = new();
            // Scaling
            for (int columnIndex = 0; columnIndex < inputColumnNames.Length; columnIndex++)
            {
                string columnName = inputColumnNames[columnIndex];
                double value = inputRow[columnIndex];

                // Scale input for model
                if (inputScalersDictionary.ContainsKey(columnName))
                {
                    double scaledValue = ScaleValue(value, columnName);

                    // Add scaledValue to the list
                    scaledInputValues.Add(scaledValue);
                }
            }

            double[] processedInputValues;
            // Dimensionality reduction
            if (dimensionalityReductionStepsDictionary.ContainsKey("Variance threshold") && dimensionalityReductionStepsDictionary.ContainsKey("Principle component analysis") && varianceThresholdFilter != null && pcaFilter != null)
            {
                // Apply variance threshold and PCA filters
                processedInputValues = varianceThresholdFilter.Transform(scaledInputValues.ToArray());

                processedInputValues = pcaFilter.Transform(processedInputValues);
            }
            else if (dimensionalityReductionStepsDictionary.ContainsKey("Variance threshold") && varianceThresholdFilter != null)
            {
                // Apply variance threshold filter only
                processedInputValues = varianceThresholdFilter.Transform(scaledInputValues.ToArray());
            }
            else if (dimensionalityReductionStepsDictionary.ContainsKey("Principle component analysis") && pcaFilter != null)
            {
                // Apply PCA filter only
                processedInputValues = pcaFilter.Transform(scaledInputValues.ToArray());
            }
            else
            {
                // Do nothing
                processedInputValues = scaledInputValues.ToArray();
            }

            // Model prediction
            int classIndex = 0; // for classification
            double regressionOutput = 0; // for regression
            if (model.GetType() == typeof(KNearestNeighbors))
            {
                KNearestNeighbors model = (KNearestNeighbors)this.model;
                classIndex = model.Decide(processedInputValues);
            }
            else if (model.GetType() == typeof(RandomForest))
            {
                RandomForest model = (RandomForest)this.model;
                classIndex = model.Decide(processedInputValues);
            }
            else if (model.GetType() == typeof(NaiveBayes<NormalDistribution>))
            {
                NaiveBayes<NormalDistribution> model = (NaiveBayes<NormalDistribution>)this.model;
                classIndex = model.Decide(processedInputValues);
            }
            else if (model.GetType() == typeof(LogisticRegression))
            {
                LogisticRegression model = (LogisticRegression)this.model;
                if (model.Decide(processedInputValues))
                    classIndex = 1;
                else
                    classIndex = 0;
            }
            else if (model.GetType() == typeof(DecisionTree))
            {
                DecisionTree model = (DecisionTree)this.model;
                classIndex = model.Decide(processedInputValues);
            }
            else if (model.GetType() == typeof(MultinomialLogisticRegression))
            {
                MultinomialLogisticRegression model = (MultinomialLogisticRegression)this.model;
                classIndex = model.Decide(processedInputValues);
            }
            else if (model.GetType() == typeof(MultipleLinearRegression))
            {
                MultipleLinearRegression model = (MultipleLinearRegression)this.model;
                regressionOutput = model.Transform(processedInputValues);
            }
            else if (model.GetType() == typeof(RidgeRegression))
            {
                RidgeRegression model = (RidgeRegression)this.model;
                regressionOutput = model.Transform(processedInputValues);
            }
            else if (model.GetType() == typeof(LassoRegression))
            {
                LassoRegression model = (LassoRegression)this.model;
                regressionOutput = model.Transform(processedInputValues);
            }
            else if (model.GetType() == typeof(ElasticNetRegression))
            {
                ElasticNetRegression model = (ElasticNetRegression)this.model;
                regressionOutput = model.Transform(processedInputValues);
            }
            else if (model.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                if (predictionType == PredictionType.BinaryClassification)
                {
                    SupportVectorMachine<IKernel> model = (SupportVectorMachine<IKernel>)this.model;
                    if (model.Decide(processedInputValues))
                        classIndex = 1;
                    else
                        classIndex = 0;
                }
                else //Regression
                {
                    SupportVectorMachine<IKernel> model = (SupportVectorMachine<IKernel>)this.model;
                    regressionOutput = model.Score(processedInputValues);
                }
            }
            else if (model.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
            {
                MulticlassSupportVectorMachine<IKernel> model = (MulticlassSupportVectorMachine<IKernel>)this.model;
                classIndex = model.Decide(processedInputValues);
            }
            else if (model.GetType() == typeof(MLP))
            {
                MLP mlp = (MLP)model;

                torch.Tensor x = torch.tensor(processedInputValues.ToMatrix(true), dataType).transpose(0, 1);
                x = x.to(deviceType);

                if (predictionType == PredictionType.BinaryClassification)
                {
                    torch.Tensor logits = mlp.forward(x);
                    torch.Tensor probabilities = torch.sigmoid(logits);
                    torch.Tensor y = torch.round(probabilities);

                    classIndex = y[0][0].cpu().detach().ToInt32();
                }
                else if (predictionType == PredictionType.MulticlassClassification)
                {
                    torch.Tensor yEncoded = mlp.forward(x);
                    classIndex = torch.argmax(yEncoded[0]).cpu().detach().ToInt32();
                }
                else // Regresion
                {
                    torch.Tensor y = mlp.forward(x);
                    regressionOutput = y[0].cpu().detach().ToDouble();
                }
            }

            // Scale output (for regression)
            double scaledOutput;
            if (predictionType == PredictionType.Regression && outputColumnName != null && outputScalersDictionary.ContainsKey(outputColumnName))
            {
                // Inverse both min-max scaling and standardization
                if (standardScalers.ContainsKey(outputColumnName) && minMaxScalers.ContainsKey(outputColumnName))
                {
                    // Min-max scaling
                    scaledOutput = minMaxScalers[outputColumnName].InverseTransform(regressionOutput);

                    // Standardization
                    scaledOutput = standardScalers[outputColumnName].InverseTransform(scaledOutput);
                }
                // Only inverse min-max scaling
                else if (minMaxScalers.ContainsKey(outputColumnName))
                {
                    scaledOutput = minMaxScalers[outputColumnName].InverseTransform(regressionOutput);
                }
                // Only inverse min-max standardization
                else if (standardScalers.ContainsKey(outputColumnName))
                {
                    scaledOutput = standardScalers[outputColumnName].InverseTransform(regressionOutput);
                }
                else
                {
                    scaledOutput = regressionOutput;
                }
            }
            else
            {
                scaledOutput = regressionOutput;
            }

            // Show output
            if (predictionType == PredictionType.BinaryClassification || predictionType == PredictionType.MulticlassClassification)
                if (classLabels != null)
                    return (processedInputValues, classLabels[classIndex]);
                else
                    return (Array.Empty<double>(), "");

            else // Regression
                return (processedInputValues, scaledOutput.ToString());
        }

        private void VisualizePredictionButton_Click(object sender, EventArgs e)
        {
            if (predictionType == PredictionType.Regression)
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    predictionInputColumns == null ||
                    predictionOutputColumnForRegression == null)
                    return;

                VisualizeRegressionDataDialog visualizeRegressionDataDialog = new(processedInputColumnNames, outputColumnName, predictionInputColumns, predictionOutputColumnForRegression);
                visualizeRegressionDataDialog.Show(this);
            }
            else // Classification
            {
                if (processedInputColumnNames == null ||
                    outputColumnName == null ||
                    predictionInputColumns == null ||
                    predictionOutputColumnForClassification == null)
                    return;

                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new(processedInputColumnNames, outputColumnName, predictionInputColumns, predictionOutputColumnForClassification);
                visualizeClassificationDataDialog.Show(this);
            }
        }
        #endregion
    }
}
