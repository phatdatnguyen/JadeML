using Accord.Math;
using Accord.IO;
using JadeChem.CustomEventArgs;
using JadeChem.Dialogs;
using JadeChem.Models;
using JadeChem.Utils;
using TorchSharp;
using TorchSharp.Modules;
using System.Data;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class MLPModelControl : UserControl
    {
        #region Fields
        private DeviceType deviceType = DeviceType.CPU;
        private torch.ScalarType dataType = torch.ScalarType.Float32;
        private MLP? mlp;
        private int trainedEpochs = 0;
        private torch.optim.Optimizer? optimizer = null;
        private Dictionary<string, double> optimizerParameters = new();
        private torch.optim.lr_scheduler.LRScheduler? lrScheduler = null;
        private Dictionary<string, double> lrSchedulerParameters = new();

        private readonly PredictionTaskForm.PredictionType predictionType;
        private readonly string[] inputColumnNames;
        private readonly double[][] inputColumns;
        private readonly double[]? outputColumnForRegression;
        private readonly string[]? outputColumnForClassification;
        private readonly int[]? classIndices;
        private readonly string[]? classLabels;

        private double[][]? trainInputColumns;
        private double[]? trainOutputColumnForRegression;
        private string[]? trainOutputColumnForClassification;
        private int[]? trainClassIndices;

        private double[][]? validationInputColumns;
        private double[]? validationOutputColumnForRegression;
        private string[]? validationOutputColumnForClassification;
        private int[]? validationClassIndices;

        private readonly OneHotEncoder oneHotEncoder = new();

        private torch.Tensor? xTrain;
        private torch.Tensor? yTrain;
        private torch.Tensor? xValidation;
        private torch.Tensor? yValidation;

        private string logFolderPath = Directory.GetCurrentDirectory();
        private string saveFolderPath = Directory.GetCurrentDirectory();

        private SummaryWriter summaryWriter;

        private readonly List<int> trainEpochs = new();
        private readonly List<float> trainLosses = new();
        private readonly List<int> validationEpochs = new();
        private readonly List<float> validationLosses = new();

        // Flags
        private bool trainWithValidation = true;
        private bool logWithTensorboard = false;
        #endregion

        #region Properties
        public DeviceType DeviceType { get { return deviceType; } }
        public torch.ScalarType DataType { get { return dataType; } }
        #endregion

        #region Events
        public delegate void ModelCreatedEventHandler(ModelEventArgs e);
        public event ModelCreatedEventHandler? ModelCreated;
        public delegate void ModelTrainedEventHandler(ModelEventArgs e);
        public event ModelTrainedEventHandler? ModelTrained;
        #endregion

        #region Constructors
        public MLPModelControl(PredictionTaskForm.PredictionType predictionType, string[] inputColumnNames, double[][] inputColumns, double[] outputColumn)
        {
            InitializeComponent();

            this.predictionType = predictionType;
            this.inputColumnNames = inputColumnNames;
            this.inputColumns = inputColumns;
            outputColumnForRegression = outputColumn;

            // Get the loss function for each prediction type
            lossFunctionComboBox.Items.Clear();
            switch (predictionType)
            {
                case PredictionTaskForm.PredictionType.BinaryClassification:
                    lossFunctionComboBox.Items.Add("Binary cross entropy with logits loss");

                    break;
                case PredictionTaskForm.PredictionType.MulticlassClassification:
                    lossFunctionComboBox.Items.Add("Cross entropy loss");

                    break;
                case PredictionTaskForm.PredictionType.Regression:
                    lossFunctionComboBox.Items.Add("Mean square error loss");

                    break;
            }

            // Default parameters
            if (torch.cuda.is_available())
            {
                deviceComboBox.Items.Add("CUDA");
                deviceComboBox.SelectedIndex = 1;
            }
            else
            {
                deviceComboBox.SelectedIndex = 0;
            }

            dataType = torch.ScalarType.Float32;

            saveFolderBrowserDialog.InitialDirectory = saveFolderPath;
            loadCheckpointFileDialog.InitialDirectory = saveFolderPath;
            logFolderBrowserDialog.InitialDirectory = logFolderPath;
            summaryWriter = torch.utils.tensorboard.SummaryWriter(logFolderPath);

            dataTypeComboBox.SelectedIndex = 1;
            optimizerComboBox.SelectedIndex = 2;
            schedulerComboBox.SelectedIndex = 0;
            lossFunctionComboBox.SelectedIndex = 0;
        }

        public MLPModelControl(PredictionTaskForm.PredictionType predictionType, string[] inputColumnNames, double[][] inputColumns, string[] outputColumn)
        {
            InitializeComponent();

            this.predictionType = predictionType;
            this.inputColumnNames = inputColumnNames;
            this.inputColumns = inputColumns;
            outputColumnForClassification = outputColumn;
            classLabels = outputColumn.Distinct().OrderBy(x => x).ToArray();
            classIndices = new int[outputColumn.Length];
            for (int rowIndex = 0; rowIndex < outputColumn.Length; rowIndex++)
                classIndices[rowIndex] = classLabels.IndexOf(outputColumn[rowIndex]);

            lossFunctionComboBox.Items.Clear();
            switch (predictionType)
            {
                case PredictionTaskForm.PredictionType.BinaryClassification:
                    lossFunctionComboBox.Items.Add("Binary cross entropy with logits loss");

                    break;
                case PredictionTaskForm.PredictionType.MulticlassClassification:
                    lossFunctionComboBox.Items.Add("Cross entropy loss");

                    break;
                case PredictionTaskForm.PredictionType.Regression:
                    lossFunctionComboBox.Items.Add("Mean square error loss");

                    break;
            }

            // Default parameters
            if (torch.cuda.is_available())
            {
                deviceComboBox.Items.Add("CUDA");
                deviceComboBox.SelectedIndex = 1;
            }
            else
            {
                deviceComboBox.SelectedIndex = 0;
            }

            dataType = torch.ScalarType.Float32;

            saveFolderBrowserDialog.InitialDirectory = saveFolderPath;
            loadCheckpointFileDialog.InitialDirectory = saveFolderPath;
            logFolderBrowserDialog.InitialDirectory = logFolderPath;
            summaryWriter = torch.utils.tensorboard.SummaryWriter(logFolderPath);

            dataTypeComboBox.SelectedIndex = 1;
            optimizerComboBox.SelectedIndex = 2;
            schedulerComboBox.SelectedIndex = 0;
            lossFunctionComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Methods
        private void DeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deviceComboBox.SelectedIndex == -1)
                return;

            if (deviceComboBox.SelectedIndex == 0)
                deviceType = DeviceType.CPU;
            else if (deviceComboBox.SelectedIndex == 1)
                deviceType = DeviceType.CUDA;
        }

        private void DataTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataTypeComboBox.SelectedIndex == -1)
                return;

            switch (dataTypeComboBox.SelectedIndex)
            {
                case 0:
                    dataType = torch.ScalarType.Float16;

                    break;
                case 1:
                    dataType = torch.ScalarType.Float32;

                    break;
                case 2:
                    dataType = torch.ScalarType.Float64;

                    break;
                case 3:
                    dataType = torch.ScalarType.BFloat16;

                    break;
            }
        }

        private void ValidationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            trainWithValidation = validationCheckBox.Checked;
            splitDataButton.Enabled = validationCheckBox.Checked;
        }

        private void SplitDataButton_Click(object sender, EventArgs e)
        {
            EditSplitRatioDialog editSplitRatioDialog = new(inputColumns.Rows(), EditSplitRatioDialog.SplitType.TrainValidationSplit);
            if (editSplitRatioDialog.ShowDialog(this) != DialogResult.OK)
                return;

            double splitRatio = editSplitRatioDialog.SplitRatio;
            int randomSeed = editSplitRatioDialog.RandomSeed;

            // Split train dataset into train dataset and validation dataset
            TrainTestSpliter trainValidationSpliter = new();
            if (predictionType == PredictionTaskForm.PredictionType.Regression)
            {
                double[][] trainOutputColumnsForRegression;
                double[][] validationOutputColumnsForRegression;
                (trainInputColumns, trainOutputColumnsForRegression, validationInputColumns, validationOutputColumnsForRegression) = trainValidationSpliter.Split(inputColumns, outputColumnForRegression.ToJagged(), 1 - splitRatio, randomSeed);
                trainOutputColumnForRegression = trainOutputColumnsForRegression.GetColumn(0);
                validationOutputColumnForRegression = validationOutputColumnsForRegression.GetColumn(0);
            }
            else
            {
                string[][] trainOutputColumnsForClassification;
                string[][] validationOutputColumnsForClassification;
                (trainInputColumns, trainOutputColumnsForClassification, validationInputColumns, validationOutputColumnsForClassification) = trainValidationSpliter.Split(inputColumns, outputColumnForClassification.ToJagged(), 1 - splitRatio, randomSeed);
                trainOutputColumnForClassification = trainOutputColumnsForClassification.GetColumn(0);
                validationOutputColumnForClassification = validationOutputColumnsForClassification.GetColumn(0);
                trainClassIndices = classIndices.Get(trainValidationSpliter.TrainIndices);
                validationClassIndices = classIndices.Get(trainValidationSpliter.TestIndices);
            }
        }

        private void LogWithTensorboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            logWithTensorboard = logWithTensorboardCheckBox.Checked;
            chooseLogFolderButton.Enabled = logWithTensorboardCheckBox.Checked;
        }

        private void ChooseLogFolderButton_Click(object sender, EventArgs e)
        {
            if (logFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                logFolderPath = logFolderBrowserDialog.SelectedPath;
                summaryWriter = torch.utils.tensorboard.SummaryWriter(logFolderPath);
            }
        }

        private void NetworkNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (networkNameTextBox.Text == "")
            {
                MessageBox.Show(this, "Network name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                networkNameTextBox.Text = "MLP";
            }

            if (networkNameTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0
                || networkNameTextBox.Text.Contains('.'))
            {
                MessageBox.Show(this, "Network name cannot contain invalid characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                networkNameTextBox.Text = "MLP";
            }
        }

        private void AddLayerButton_Click(object sender, EventArgs e)
        {
            HiddenLayerDialog hiddenLayerDialog = new()
            {
                Text = "Add hidden layer"
            };
            if (hiddenLayerDialog.ShowDialog(this) == DialogResult.OK)
            {
                ListViewItem item = hiddenLayersListView.Items.Add((hiddenLayersListView.Items.Count + 1).ToString());
                item.SubItems.Add(hiddenLayerDialog.NumberOfNeurons.ToString());
                item.SubItems.Add(hiddenLayerDialog.ActivationFunction);
            }
        }

        private void EditLayerButton_Click(object sender, EventArgs e)
        {
            if (hiddenLayersListView.SelectedIndices.Count == 0)
                return;

            HiddenLayerDialog hiddenLayerDialog = new()
            {
                NumberOfNeurons = int.Parse(hiddenLayersListView.SelectedItems[0].SubItems[1].Text),
                ActivationFunction = hiddenLayersListView.SelectedItems[0].SubItems[2].Text,
                Text = "Edit hidden layer"
            };
            if (hiddenLayerDialog.ShowDialog(this) == DialogResult.OK)
            {
                hiddenLayersListView.SelectedItems[0].SubItems[1].Text = hiddenLayerDialog.NumberOfNeurons.ToString();
                hiddenLayersListView.SelectedItems[0].SubItems[2].Text = hiddenLayerDialog.ActivationFunction;
            }
        }

        private void RemoveLayerButton_Click(object sender, EventArgs e)
        {
            if (hiddenLayersListView.SelectedIndices.Count == 0)
                return;

            hiddenLayersListView.Items.RemoveAt(hiddenLayersListView.SelectedIndices[0]);
            for (int rowIndex = 0; rowIndex < hiddenLayersListView.Items.Count; rowIndex++)
                hiddenLayersListView.Items[rowIndex].Text = (rowIndex + 1).ToString();
        }

        private void CreateNetworkButton_Click(object sender, EventArgs e)
        {
            if (mlp != null)
            {
                if (MessageBox.Show(this, "Do you want to override the current network?", "Override model", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            try
            {
                // Check the number of hidden layers
                if (hiddenLayersListView.Items.Count == 0)
                    throw new Exception("You have to choose 1 or more hidden layers!");

                // Get the parameters for the MLP model
                int inputSize = inputColumns.Columns();
                int[] hiddenSizes = new int[hiddenLayersListView.Items.Count];
                string[] activationFunctions = new string[hiddenLayersListView.Items.Count];
                for (int rowIndex = 0; rowIndex < hiddenLayersListView.Items.Count; rowIndex++)
                {
                    hiddenSizes[rowIndex] = int.Parse(hiddenLayersListView.Items[rowIndex].SubItems[1].Text);
                    activationFunctions[rowIndex] = hiddenLayersListView.Items[rowIndex].SubItems[2].Text;
                }
                int outputSize = 1; // For binary classification and regression
                if (predictionType == PredictionTaskForm.PredictionType.MulticlassClassification)
                {
                    // One-hot encoder for multiclass classification
                    if (outputColumnForClassification != null)
                    {
                        byte[][] encodedOutputColumns = oneHotEncoder.FitTransform(outputColumnForClassification);

                        outputSize = encodedOutputColumns.Columns();
                    }
                }

                // Build a new MLP network
                int randomSeed = (int)randomSeedNumericUpDown.Value;
                torch.random.manual_seed(randomSeed);
                torch.cuda.manual_seed(randomSeed);
                mlp = new MLP(networkNameTextBox.Text, inputSize, hiddenSizes, activationFunctions, outputSize);
                mlp = mlp.to(deviceType);
                trainedEpochs = 0;

                // Reset the losses visualization
                trainEpochs.Clear();
                trainLosses.Clear();
                validationEpochs.Clear();
                validationLosses.Clear();
                visualizeLossesButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }

            // Raise the event
            ModelCreated?.Invoke(new ModelEventArgs { Model = mlp });
        }

        private void LoadCheckpointButton_Click(object sender, EventArgs e)
        {
            if (mlp == null)
            {
                MessageBox.Show(this, "MLP network was not created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loadCheckpointFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    // Load the MLP model from a checkpoint
                    MLP loadedCheckpoint = (MLP)mlp.load(loadCheckpointFileDialog.FileName);
                    string fileName = loadCheckpointFileDialog.SafeFileName;
                    fileName = fileName.Remove(fileName.IndexOf(".ckpt"));
                    trainedEpochs = int.Parse(fileName.Split('_').Last());
                    mlp = loadedCheckpoint;
                    mlp = mlp.to(deviceType);

                    // Update the hiddenLayersListView
                    for (int moduleIndex = 0; moduleIndex < mlp.Sequential.Count; moduleIndex++)
                    {
                        if (moduleIndex % 2 == 1)
                        {
                            torch.nn.IModule<torch.Tensor, torch.Tensor> module = mlp.Sequential[moduleIndex];
                            if (module.GetType() == typeof(LeakyReLU))
                                hiddenLayersListView.Items[moduleIndex / 2].SubItems[2].Text = "LeakyReLU";
                            else if (module.GetType() == typeof(ReLU))
                                hiddenLayersListView.Items[moduleIndex / 2].SubItems[2].Text = "ReLU";
                            else if (module.GetType() == typeof(Sigmoid))
                                hiddenLayersListView.Items[moduleIndex / 2].SubItems[2].Text = "Sigmoid";
                            else if (module.GetType() == typeof(Tanh))
                                hiddenLayersListView.Items[moduleIndex / 2].SubItems[2].Text = "Tanh";
                        }
                    }

                    // Reset the losses visualization
                    trainEpochs.Clear();
                    trainLosses.Clear();
                    validationEpochs.Clear();
                    validationLosses.Clear();
                    visualizeLossesButton.Enabled = false;
                }
                catch
                {
                    MessageBox.Show(this, "Cannot load checkpoint! The structure of MLP network in the checkpoint must be the same with the created MLP network.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewNetworkStructureButton_Click(object sender, EventArgs e)
        {
            if (mlp == null)
            {
                MessageBox.Show(this, "MLP network was not created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<int, (Dictionary<int, (List<double>, double)>, string)> mlpNetworkStructure = new();

            // Hidden layers and output layer
            int layerIndex = 0;
            Dictionary<int, (List<double>, double)> neuronDictionary = new();
            for (int moduleIndex = 0; moduleIndex < mlp.Sequential.Count; moduleIndex++)
            {
                if (moduleIndex % 2 == 0) // Linear model
                {
                    Linear linear = (Linear)mlp.Sequential[moduleIndex];

                    // Reset the neuron dictionary
                    neuronDictionary = new();
                    long numberOfInputs = linear.weight.shape[0];
                    for (int neuronIndex = 0; neuronIndex < numberOfInputs; neuronIndex++)
                    {
                        List<double> weights = new();
                        // Get the weights and bias
                        for (int weightIndex = 0; weightIndex < linear.weight.shape[1]; weightIndex++)
                            weights.Add(linear.weight[neuronIndex, weightIndex].ToDouble());

                        double bias = linear.bias[neuronIndex].ToDouble();

                        neuronDictionary.Add(neuronIndex, (weights, bias));
                    }

                    if (moduleIndex == mlp.Sequential.Count - 1)
                    {
                        // Output layer
                        mlpNetworkStructure[layerIndex] = (neuronDictionary, "None");
                        break;
                    }
                }
                else if (moduleIndex % 2 == 1) // Activation function
                {
                    torch.nn.IModule<torch.Tensor, torch.Tensor> module = mlp.Sequential[moduleIndex];
                    string activationFunction = "ReLU";
                    if (module.GetType() == typeof(LeakyReLU))
                        activationFunction = "LeakyReLU";
                    else if (module.GetType() == typeof(ReLU))
                        activationFunction = "ReLU";
                    else if (module.GetType() == typeof(Sigmoid))
                        activationFunction = "Sigmoid";
                    else if (module.GetType() == typeof(Tanh))
                        activationFunction = "Tanh";

                    mlpNetworkStructure[layerIndex] = (neuronDictionary, activationFunction);
                    layerIndex++;
                }
            }

            MLPStructureDialog mlpStructureDialog = new(mlpNetworkStructure, inputColumnNames);
            mlpStructureDialog.ShowDialog(ParentForm);
        }

        private void OptimizerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optimizerComboBox.SelectedIndex == -1)
                return;

            ResetOptimizerParameters();
        }

        private void ResetOptimizerParameters()
        {
            optimizerParameters.Clear();

            string optimizerName = optimizerComboBox.Text;
            if (optimizerName == "Adadelta")
            {
                optimizerParameters["rho"] = 0.9;
                optimizerParameters["eps"] = 1E-6;
                optimizerParameters["weight_decay"] = 0;
            }
            else if (optimizerName == "Adagrad")
            {
                optimizerParameters["lr_decay"] = 0;
                optimizerParameters["weight_decay"] = 0;
                optimizerParameters["initial_accumulator_value"] = 0;
                optimizerParameters["eps"] = 1E-10;
            }
            else if (optimizerName == "Adam")
            {
                optimizerParameters["beta1"] = 0.9;
                optimizerParameters["beta2"] = 0.999;
                optimizerParameters["eps"] = 1E-8;
                optimizerParameters["weight_decay"] = 0;
            }
            else if (optimizerName == "Adamax")
            {
                optimizerParameters["beta1"] = 0.9;
                optimizerParameters["beta2"] = 0.999;
                optimizerParameters["eps"] = 1E-8;
                optimizerParameters["weight_decay"] = 0;
            }
            else if (optimizerName == "AdamW")
            {
                optimizerParameters["beta1"] = 0.9;
                optimizerParameters["beta2"] = 0.999;
                optimizerParameters["eps"] = 1E-8;
                optimizerParameters["weight_decay"] = 0;
            }
            else if (optimizerName == "ASGD")
            {
                optimizerParameters["lambd"] = 0.0001;
                optimizerParameters["alpha"] = 0.75;
                optimizerParameters["t0"] = 1000000;
                optimizerParameters["weight_decay"] = 0;
            }
            else if (optimizerName == "NAdam")
            {
                optimizerParameters["beta1"] = 0.9;
                optimizerParameters["beta2"] = 0.999;
                optimizerParameters["eps"] = 1E-8;
                optimizerParameters["weight_decay"] = 0;
                optimizerParameters["momentum_decay"] = 0.004;
            }
            else if (optimizerName == "RAdam")
            {
                optimizerParameters["beta1"] = 0.9;
                optimizerParameters["beta2"] = 0.999;
                optimizerParameters["eps"] = 1E-8;
                optimizerParameters["weight_decay"] = 0;
            }
            else if (optimizerName == "RMSProp")
            {
                optimizerParameters["alpha"] = 0.99;
                optimizerParameters["eps"] = 1E-8;
                optimizerParameters["weight_decay"] = 0;
                optimizerParameters["momentum"] = 0;
            }
            else if (optimizerName == "Rprop")
            {
                optimizerParameters["etaminus"] = 0.5;
                optimizerParameters["etaplus"] = 1.2;
                optimizerParameters["min_step"] = 1E-6;
                optimizerParameters["max_step"] = 50;
            }
            else if (optimizerName == "SGD")
            {
                optimizerParameters["momentum"] = 0;
                optimizerParameters["dampening"] = 0;
                optimizerParameters["weight_decay"] = 0;
            }
        }

        private void SchedulerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (schedulerComboBox.SelectedIndex == -1)
                return;

            ResetLRSchedulerParameters();
        }

        private void ResetLRSchedulerParameters()
        {
            lrSchedulerParameters.Clear();

            string lrSchedulerName = schedulerComboBox.Text;
            if (lrSchedulerName == "ConstantLR")
            {
                lrSchedulerParameters["factor"] = 1.0 / 3.0;
                lrSchedulerParameters["total_iters"] = 5;
                lrSchedulerParameters["last_epoch"] = -1;
            }
            else if (lrSchedulerName == "CosineAnnealingLR")
            {
                lrSchedulerParameters["T_max"] = (int)epochsNumericUpDown.Value;
                lrSchedulerParameters["eta_min"] = 0;
                lrSchedulerParameters["last_epoch"] = -1;
            }
            else if (lrSchedulerName == "ExponentialLR")
            {
                lrSchedulerParameters["gamma"] = 0.95;
                lrSchedulerParameters["last_epoch"] = -1;
            }
            else if (lrSchedulerName == "LinearLR")
            {
                lrSchedulerParameters["start_factor"] = 1.0 / 3.0;
                lrSchedulerParameters["end_factor"] = 1;
                lrSchedulerParameters["total_iters"] = 5;
                lrSchedulerParameters["last_epoch"] = -1;
            }
            else if (lrSchedulerName == "PolynomialLR")
            {
                lrSchedulerParameters["total_iters"] = 5;
                lrSchedulerParameters["power"] = 1;
                lrSchedulerParameters["last_epoch"] = -1;
            }
            else if (lrSchedulerName == "StepLR")
            {
                lrSchedulerParameters["step_size"] = 30;
                lrSchedulerParameters["gamma"] = 0.1;
                lrSchedulerParameters["last_epoch"] = -1;
            }
        }

        private void ChooseSaveFolderButton_Click(object sender, EventArgs e)
        {
            if (saveFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                saveFolderPath = saveFolderBrowserDialog.SelectedPath;
                saveFolderBrowserDialog.InitialDirectory = saveFolderPath;
                loadCheckpointFileDialog.InitialDirectory = saveFolderPath;
            }
        }

        private void ConfigureOptimerAndSchedulerButton_Click(object sender, EventArgs e)
        {
            ConfigureOptimizerAndSchedulerDialog configureOptimizerAndSchedulerDialog = new(optimizerComboBox.Text, optimizerParameters.DeepClone(), schedulerComboBox.Text, lrSchedulerParameters.DeepClone());
            if (configureOptimizerAndSchedulerDialog.ShowDialog(this) == DialogResult.OK)
            {
                optimizerParameters = configureOptimizerAndSchedulerDialog.OptimizerParameters;
                lrSchedulerParameters = configureOptimizerAndSchedulerDialog.LRSchedulerParameters;
            }
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            if (mlp == null)
            {
                MessageBox.Show(this, "MLP network was not created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                // Check if the dataset was splitted
                if (trainWithValidation && validationInputColumns == null)
                    throw new Exception("In order to train with validation, you have to split the train dataset!");

                // Prepare inputs and outputs
                if (!trainWithValidation)
                {
                    trainInputColumns = inputColumns;
                    if (predictionType == PredictionTaskForm.PredictionType.Regression)
                        trainOutputColumnForRegression = outputColumnForRegression;
                    else
                    {
                        trainOutputColumnForClassification = outputColumnForClassification;
                        trainClassIndices = classIndices;
                    }
                }

                xTrain = torch.tensor(trainInputColumns.ToMatrix(), dataType);
                if (trainWithValidation)
                    xValidation = torch.tensor(validationInputColumns.ToMatrix(), dataType);

                switch (predictionType)
                {
                    case PredictionTaskForm.PredictionType.BinaryClassification:
                        if (trainClassIndices != null)
                            yTrain = torch.tensor(trainClassIndices, dataType).unsqueeze(1);

                        if (trainWithValidation && validationClassIndices != null)
                            yValidation = torch.tensor(validationClassIndices, dataType).unsqueeze(1);

                        break;
                    case PredictionTaskForm.PredictionType.MulticlassClassification:
                        // Encode the output column with OneHotEncoder
                        if (trainOutputColumnForClassification != null)
                        {
                            byte[][] encodedTrainOutputColumns = oneHotEncoder.Transform(trainOutputColumnForClassification);
                            yTrain = torch.tensor(encodedTrainOutputColumns.ToMatrix(), dataType);
                        }

                        if (trainWithValidation && validationOutputColumnForClassification != null)
                        {
                            byte[][] encodedValidationOutputColumns = oneHotEncoder.Transform(validationOutputColumnForClassification);
                            yValidation = torch.tensor(encodedValidationOutputColumns.ToMatrix(), dataType);
                        }

                        break;
                    case PredictionTaskForm.PredictionType.Regression:
                        if (trainOutputColumnForRegression != null)
                            yTrain = torch.tensor(trainOutputColumnForRegression, dataType).unsqueeze(1);

                        if (trainWithValidation && validationOutputColumnForRegression != null)
                            yValidation = torch.tensor(validationOutputColumnForRegression, dataType).unsqueeze(1);

                        break;
                }

                // Get the training parameters
                mlp = mlp.to(dataType).to(deviceType);
                optimizer = CreateOptimizer();
                lrScheduler = CreateLRScheduler();

                // Training
                int randomSeed = (int)randomSeedNumericUpDown.Value;
                torch.random.manual_seed(randomSeed);
                torch.cuda.manual_seed(randomSeed);

                trainProgressBar.Visible = true;
                int epochs = (int)epochsNumericUpDown.Value;
                int startEpochIndex = trainedEpochs;
                int saveInterval = (int)saveIntervalNumericUpDown.Value;
                for (int epochIndex = startEpochIndex; epochIndex < startEpochIndex + epochs; epochIndex++)
                {
                    // Forward and calculate losses
                    xTrain = xTrain.to(deviceType);
                    yTrain = yTrain.to(deviceType);
                    float trainLoss = Train(xTrain, yTrain);

                    trainEpochs.Add(epochIndex + 1);
                    trainLosses.Add(trainLoss);
                    if (logWithTensorboard)
                        summaryWriter.add_scalar("Loss/Train", trainLoss, epochIndex + 1);

                    float validationLoss = 0;
                    if (trainWithValidation)
                    {
                        xValidation = xValidation.to(deviceType);
                        yValidation = yValidation.to(deviceType);
                        validationLoss = Validate(xValidation, yValidation);

                        validationEpochs.Add(epochIndex + 1);
                        validationLosses.Add(validationLoss);
                        if (logWithTensorboard)
                            summaryWriter.add_scalar("Loss/Validation", validationLoss, epochIndex + 1);
                    }

                    // Advance the learning rate schedule
                    lrScheduler?.step();

                    // Update progress
                    trainProgressBar.Value = (int)Math.Ceiling((float)(epochIndex - startEpochIndex + 1) / epochs * 100);
                    trainProgressBar.Update();
                    trainProgressLabel.Text = "Epoch " + (epochIndex + 1).ToString() + "/" + (startEpochIndex + epochs).ToString();
                    trainProgressLabel.Update();
                    trainLossLabel.Text = "Train loss: " + Math.Round(trainLoss, 4).ToString();
                    trainLossLabel.Update();
                    if (trainWithValidation)
                    {
                        validationLossLabel.Text = "Validation loss: " + Math.Round(validationLoss, 4).ToString();
                        validationLossLabel.Update();
                    }

                    // Save checkpoint
                    if ((epochIndex + 1) % saveInterval == 0)
                    {
                        string checkpointName = mlp.GetName() + "_" + (epochIndex + 1).ToString() + ".ckpt";

                        if (SaveCheckpoint(mlp, saveFolderPath, checkpointName))
                        {
                            saveStatusLabel.Text = "Saved: " + checkpointName;
                            saveStatusLabel.Update();
                        }
                        else
                        {
                            saveStatusLabel.Text = "Cannot save checkpoint:\n" + checkpointName;
                            saveStatusLabel.Update();
                        }
                    }

                    trainedEpochs++;
                }

                // Enable losses visualization
                visualizeLossesButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }

            Cursor = Cursors.Default;

            // Raise the event
            ModelTrained?.Invoke(new ModelEventArgs { Model = mlp });
        }

        private torch.optim.Optimizer CreateOptimizer()
        {
            torch.optim.Optimizer optimizer;
            string optimizerName = optimizerComboBox.Text;

            // Create the optimizer
            if (optimizerName == "Adadelta")
            {
                optimizer = torch.optim.Adadelta(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["rho"],
                    optimizerParameters["eps"],
                    optimizerParameters["weight_decay"]);
            }
            else if (optimizerName == "Adagrad")
            {
                optimizer = torch.optim.Adagrad(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["lr_decay"],
                    optimizerParameters["weight_decay"],
                    optimizerParameters["initial_accumulator_value"],
                    optimizerParameters["eps"]);
            }
            else if (optimizerName == "Adam")
            {
                optimizer = torch.optim.Adam(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["beta1"],
                    optimizerParameters["beta2"],
                    optimizerParameters["eps"],
                    optimizerParameters["weight_decay"]);
            }
            else if (optimizerName == "Adamax")
            {
                optimizer = torch.optim.Adamax(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["beta1"],
                    optimizerParameters["beta2"],
                    optimizerParameters["eps"],
                    optimizerParameters["weight_decay"]);
            }
            else if (optimizerName == "AdamW")
            {
                optimizer = torch.optim.AdamW(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["beta1"],
                    optimizerParameters["beta2"],
                    optimizerParameters["eps"],
                    optimizerParameters["weight_decay"]);
            }
            else if (optimizerName == "ASGD")
            {
                optimizer = torch.optim.ASGD(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["lambd"],
                    optimizerParameters["alpha"],
                    optimizerParameters["t0"],
                    optimizerParameters["weight_decay"]);
            }
            else if (optimizerName == "NAdam")
            {
                optimizer = torch.optim.NAdam(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["beta1"],
                    optimizerParameters["beta2"],
                    optimizerParameters["eps"],
                    optimizerParameters["weight_decay"],
                    optimizerParameters["momentum_decay"]);
            }
            else if (optimizerName == "RAdam")
            {
                optimizer = torch.optim.RAdam(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["beta1"],
                    optimizerParameters["beta2"],
                    optimizerParameters["eps"],
                    optimizerParameters["weight_decay"]);
            }
            else if (optimizerName == "RMSProp")
            {
                optimizer = torch.optim.RMSProp(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["alpha"],
                    optimizerParameters["eps"],
                    optimizerParameters["weight_decay"],
                    optimizerParameters["momentum"]);
            }
            else if (optimizerName == "Rprop")
            {
                optimizer = torch.optim.Rprop(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["etaminus"],
                    optimizerParameters["etaplus"],
                    optimizerParameters["min_step"],
                    optimizerParameters["max_step"]);
            }
            else // if (optimizerName == "SGD")
            {
                optimizer = torch.optim.SGD(mlp.parameters(),
                    (double)learningRateNumericUpDown.Value,
                    optimizerParameters["momentum"],
                    optimizerParameters["dampening"],
                    optimizerParameters["weight_decay"]);
            }

            return optimizer;
        }

        private torch.optim.lr_scheduler.LRScheduler? CreateLRScheduler()
        {
            if (optimizer == null)
                return null;

            torch.optim.lr_scheduler.LRScheduler lrScheduler;
            string lrSchedulerName = schedulerComboBox.Text;

            // Create the learning rate scheduler
            if (lrSchedulerName == "None")
            {
                return null;
            }
            if (lrSchedulerName == "ConstantLR")
            {
                lrScheduler = torch.optim.lr_scheduler.ConstantLR(optimizer,
                    lrSchedulerParameters["factor"],
                    (int)lrSchedulerParameters["total_iters"],
                    (int)lrSchedulerParameters["last_epoch"]);
            }
            else if (lrSchedulerName == "CosineAnnealingLR")
            {
                lrScheduler = torch.optim.lr_scheduler.CosineAnnealingLR(optimizer,
                    lrSchedulerParameters["T_max"],
                    lrSchedulerParameters["eta_min"],
                    (int)lrSchedulerParameters["last_epoch"]);
            }
            else if (lrSchedulerName == "ExponentialLR")
            {
                lrScheduler = torch.optim.lr_scheduler.ExponentialLR(optimizer,
                    lrSchedulerParameters["gamma"],
                    (int)lrSchedulerParameters["last_epoch"]);
            }
            else if (lrSchedulerName == "LinearLR")
            {
                lrScheduler = torch.optim.lr_scheduler.LinearLR(optimizer,
                    lrSchedulerParameters["start_factor"],
                    lrSchedulerParameters["end_factor"],
                    (int)lrSchedulerParameters["total_iters"],
                    (int)lrSchedulerParameters["last_epoch"]);
            }
            else if (lrSchedulerName == "PolynomialLR")
            {
                lrScheduler = torch.optim.lr_scheduler.PolynomialLR(optimizer,
                    (int)lrSchedulerParameters["total_iters"],
                    (int)lrSchedulerParameters["power"],
                    (int)lrSchedulerParameters["last_epoch"]);
            }
            else // if (lrSchedulerName == "StepLR")
            {
                lrScheduler = torch.optim.lr_scheduler.StepLR(optimizer,
                    (int)lrSchedulerParameters["step_size"],
                    lrSchedulerParameters["gamma"],
                    (int)lrSchedulerParameters["last_epoch"]);
            }

            return lrScheduler;
        }

        private float Train(torch.Tensor input, torch.Tensor expectedOutput)
        {
            if (mlp == null || optimizer == null)
                return -1;

            mlp.train();
            torch.Tensor output = mlp.forward(input);
            torch.Tensor loss;
            if (predictionType == PredictionTaskForm.PredictionType.BinaryClassification)
                loss = torch.nn.functional.binary_cross_entropy_with_logits(output, expectedOutput);
            else if (predictionType == PredictionTaskForm.PredictionType.MulticlassClassification)
                loss = torch.nn.functional.cross_entropy(output, expectedOutput);
            else // Regression
                loss = torch.nn.functional.mse_loss(output, expectedOutput, torch.nn.Reduction.Sum);

            optimizer.zero_grad();
            loss.backward();
            optimizer.step();

            return loss.cpu().detach().ToSingle();
        }

        private float Validate(torch.Tensor input, torch.Tensor expectedOutput)
        {
            if (mlp == null)
                return -1;

            mlp.eval();
            torch.Tensor output = mlp.forward(input);
            torch.Tensor loss;
            if (predictionType == PredictionTaskForm.PredictionType.BinaryClassification)
                loss = torch.nn.functional.binary_cross_entropy_with_logits(output, expectedOutput);
            else if (predictionType == PredictionTaskForm.PredictionType.MulticlassClassification)
                loss = torch.nn.functional.cross_entropy(output, expectedOutput);
            else // Regression
                loss = torch.nn.functional.mse_loss(output, expectedOutput, torch.nn.Reduction.Sum);

            return loss.cpu().detach().ToSingle();
        }

        private static bool SaveCheckpoint(MLP model, string saveFolderPath, string checkpointName)
        {
            bool isSaveSuccessful;
            try
            {
                string filePath = saveFolderPath + "\\" + checkpointName;

                if (File.Exists(filePath))
                    File.Delete(filePath);

                model.save(filePath);

                isSaveSuccessful = true;
            }
            catch
            {
                isSaveSuccessful = false;
            }

            return isSaveSuccessful;
        }

        private void VisualizeLossesButton_Click(object sender, EventArgs e)
        {
            string lossFunctionName;
            if (predictionType == PredictionTaskForm.PredictionType.BinaryClassification)
                lossFunctionName = "BCE loss with logits";
            else if (predictionType == PredictionTaskForm.PredictionType.MulticlassClassification)
                lossFunctionName = "Cross entropy loss";
            else
                lossFunctionName = "MSE loss";

            VisualizeLossesDialog visualizeLossesDialog = new(trainEpochs, trainLosses, validationEpochs, validationLosses, lossFunctionName);
            visualizeLossesDialog.ShowDialog(this);
        }
        #endregion
    }
}
