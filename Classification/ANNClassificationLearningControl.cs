using Accord;
using Accord.Math;
using Accord.Math.Random;
using Accord.Neuro;
using Accord.Neuro.Learning;
using MindFusion.Diagramming;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class ANNClassificationLearningControl : UserControl
    {
        // Fields
        private string[] features = null;
        private Dictionary<int, string> classes = null;

        private double[][] trainingInputColumns = null;
        private int[] classIndexes = null;
        private int[][] outputIntegerColumns;

        private bool useRegularization = false;
        private bool useNguyenWidrow = false;
        private bool useSameWeights = false;
        private double learningRate = 0.1;
        private int maxIteration = 1000;

        private IActivationFunction activationFunction = null;
        private ActivationNetwork ann = null;
        private LearningMethod learningMethod;

        private Thread workerThread = null;
        private int iteration = 0;
        private double error = 0;
        private TimeSpan elapsed = TimeSpan.Zero;
        private volatile bool needToStop = false;
        private double tolerance = 0;
        private bool isConverged = false;

        private DiagramNodeCollection inputNodes = null;
        private DiagramNodeCollection[] hiddenNodes;
        private DiagramNodeCollection outputNodes = null;
        private DiagramLinkCollection[][] links = null;

        private bool isNetworkDiagramBuilt = false;

        // Events
        public delegate void TrainingStartedEventHandler(ModelModifiedEventArgs e);
        public event TrainingStartedEventHandler TrainingStarted;

        public delegate void TrainingUpdateEventHandler(ModelModifiedEventArgs e);
        public event TrainingUpdateEventHandler TrainingUpdate;

        public delegate void TrainingStoppedEventHandler(ModelModifiedEventArgs e);
        public event TrainingStoppedEventHandler TrainingStopped;

        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelConverged;

        // Delegate
        private delegate void enableCallback(bool enable);

        // Enum
        private enum LearningMethod
        {
            LevenbergMarquardt, Backpropagation, ResilientBackpropagation, ParallelResilientBackpropagation,
            Perceptron, DeltaRule
        }

        // Properties
        public ActivationNetwork ANN { set { ann = value; } }

        public bool IsNetworkBuilt { get { return ann != null; } }

        public bool IsNetworkDiagramBuilt { get { return isNetworkDiagramBuilt; } }

        public bool IsConverged { get { return isConverged; } }

        // Constructor
        public ANNClassificationLearningControl(double[][] trainingInputColumns, int[] trainingClassIndexColumn, string[] features, Dictionary<int, string> classes)
        {
            InitializeComponent();

            networkStructureDataGridView.Rows.Add(new string[] { "Hidden 1", "3" });
            activationFunctionComboBox.SelectedIndex = 2;
            learningMethodComboBox.SelectedIndex = 0;

            this.features = features;
            this.classes = classes;

            this.trainingInputColumns = trainingInputColumns;

            classIndexes = trainingClassIndexColumn.Distinct().OrderBy(i => i).ToArray();
            outputIntegerColumns = new int[trainingClassIndexColumn.Length][];
            for (int rowIndex = 0; rowIndex < trainingClassIndexColumn.Length; rowIndex++)
            {
                outputIntegerColumns[rowIndex] = new int[classIndexes.Length];
                for (int columnIndex = 0; columnIndex < classIndexes.Length; columnIndex++)
                    if (trainingClassIndexColumn[rowIndex] == classIndexes[columnIndex])
                        outputIntegerColumns[rowIndex][columnIndex] = 1;
                    else
                        outputIntegerColumns[rowIndex][columnIndex] = -1;
            }

            TrainingStarted += onTrainingStarted;
            TrainingStopped += onTrainingStopped;
        }

        // Methods
        private void addLayerButton_Click(object sender, EventArgs e)
        {
            int currentNumberOfLayers = networkStructureDataGridView.Rows.Count;
            if (currentNumberOfLayers == 5)
                return;

            networkStructureDataGridView.Rows.Add(new string[] { "Hidden " + (currentNumberOfLayers + 1).ToString(), "3" });
        }

        private void deleteLayerButton_Click(object sender, EventArgs e)
        {
            if (networkStructureDataGridView.Rows.Count == 1)
                return;

            networkStructureDataGridView.Rows.RemoveAt(networkStructureDataGridView.Rows.Count - 1);
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            useRegularization = bayesianRegularizationCheckBox.Checked;
            useNguyenWidrow = nguyenWidrowCheckBox.Checked;
            useSameWeights = sameWeightsCheckBox.Checked;
            learningRate = (double)learningRateNumericUpDown.Value;
            tolerance = (double)toleranceNumericUpDown.Value;
            maxIteration = (int)maxIterationNumericUpDown.Value;
            activationFunction = createActivationFunction();

            int numberOfInputs = trainingInputColumns[0].Length;
            int[] layers = new int[networkStructureDataGridView.Rows.Count + 1]; // hidden layers + output layer
            try
            {
                for (int layerIndex = 0; layerIndex < networkStructureDataGridView.Rows.Count; layerIndex++)  // hidden layer
                {
                    int numberOfNeurons = Convert.ToInt32(networkStructureDataGridView.Rows[layerIndex].Cells[1].Value);
                    if (numberOfNeurons <= 0)
                        throw new Exception("Invalid number of neurons!");
                    if (numberOfNeurons > 50)
                        throw new Exception("Too many neurons!");
                    layers[layerIndex] = numberOfNeurons;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            layers[layers.Length - 1] = classIndexes.Length; // output layer
            ann = new ActivationNetwork(activationFunction, numberOfInputs, layers);

            BuildNetworkDiagram();

            startButton.Enabled = true;
        }

        private IActivationFunction createActivationFunction()
        {
            switch (activationFunctionComboBox.SelectedItem.ToString())
            {
                case "Bipolar Sigmoid":
                    return new BipolarSigmoidFunction((double)alphaNumericUpDown.Value);
                case "Sigmoid":
                    return new SigmoidFunction((double)alphaNumericUpDown.Value);
                case "Linear":
                    return new LinearFunction(new DoubleRange((double)lowerLimitNumericUpDown.Value, (double)upperLimitNumericUpDown.Value));
                case "Rectified Linear":
                    return new RectifiedLinearFunction();
                case "Threshold":
                    return new ThresholdFunction();
                case "Identity":
                    return new IdentityFunction();
                default:
                    throw new Exception("No function selected!");
            }
        }

        public void BuildNetworkDiagram()
        {
            networkDiagram.ClearAll();

            int neuronDistance = 15;
            int layerDistance = 30;

            // Input layer
            inputNodes = new DiagramNodeCollection();
            for (int featureIndex = 0; featureIndex < features.Length; featureIndex++)
            {
                ShapeNode inputNode = networkDiagram.Factory.CreateShapeNode(5, 5 + neuronDistance * featureIndex, 10, 10, Shapes.Ellipse);
                inputNode.Text = features[featureIndex];
                inputNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Cyan);
                inputNode.EnabledHandles = AdjustmentHandles.None;

                inputNodes.Add(inputNode);
            }

            // Hidden layers
            hiddenNodes = new DiagramNodeCollection[ann.Layers.Length - 1];
            links = new DiagramLinkCollection[ann.Layers.Length][];
            for (int layerIndex = 0; layerIndex < ann.Layers.Length - 1; layerIndex++)
            {
                hiddenNodes[layerIndex] = new DiagramNodeCollection();
                links[layerIndex] = new DiagramLinkCollection[ann.Layers[layerIndex].Neurons.Length];

                for (int neuronIndex = 0; neuronIndex < ann.Layers[layerIndex].Neurons.Length; neuronIndex++)
                {
                    ShapeNode hiddenNode = networkDiagram.Factory.CreateShapeNode(5 + layerDistance + layerDistance * layerIndex, 5 + neuronDistance * neuronIndex, 10, 10, Shapes.Ellipse);
                    hiddenNode.Text = (layerIndex + 1).ToString() + "-" + (neuronIndex + 1).ToString();
                    hiddenNode.EnabledHandles = AdjustmentHandles.None;

                    hiddenNodes[layerIndex].Add(hiddenNode);
                    links[layerIndex][neuronIndex] = new DiagramLinkCollection();

                    if (layerIndex == 0) // Link to input layer
                    {
                        for (int featureIndex = 0; featureIndex < features.Length; featureIndex++)
                        {
                            DiagramLink link = networkDiagram.Factory.CreateDiagramLink(inputNodes[featureIndex], hiddenNode);
                            link.AllowMoveStart = false;
                            link.AllowMoveEnd = false;

                            links[layerIndex][neuronIndex].Add(link);
                        }
                    }
                    else // Link to previous hidden layer
                    {
                        for (int previousNeuronIndex = 0; previousNeuronIndex < ann.Layers[layerIndex - 1].Neurons.Length; previousNeuronIndex++)
                        {
                            DiagramLink link = networkDiagram.Factory.CreateDiagramLink(hiddenNodes[layerIndex - 1][previousNeuronIndex], hiddenNode);
                            link.AllowMoveStart = false;
                            link.AllowMoveEnd = false;

                            links[layerIndex][neuronIndex].Add(link);
                        }
                    }
                }
            }

            // Output layer
            outputNodes = new DiagramNodeCollection();
            links[ann.Layers.Length - 1] = new DiagramLinkCollection[classes.Count];
            for (int classIndex = 0; classIndex < classes.Count; classIndex++)
            {
                outputNodes.Add(networkDiagram.Factory.CreateShapeNode(5 + layerDistance * ann.Layers.Length, 5 + neuronDistance * classIndex, 10, 10, Shapes.Ellipse));
                outputNodes[classIndex].Text = classes[classIndex];
                outputNodes[classIndex].Brush = new MindFusion.Drawing.SolidBrush(Color.Magenta);
                outputNodes[classIndex].EnabledHandles = AdjustmentHandles.None;

                links[ann.Layers.Length - 1][classIndex] = new DiagramLinkCollection();
                for (int previousNeuronIndex = 0; previousNeuronIndex < ann.Layers[ann.Layers.Length - 2].Neurons.Length; previousNeuronIndex++)
                {
                    DiagramLink link = networkDiagram.Factory.CreateDiagramLink(hiddenNodes[hiddenNodes.Length - 1][previousNeuronIndex], outputNodes[classIndex]);
                    link.AllowMoveStart = false;
                    link.AllowMoveEnd = false;

                    links[ann.Layers.Length - 1][classIndex].Add(link);
                }
            }

            isNetworkDiagramBuilt = true;

            updateNetworkDiagram();
        }

        private void updateNetworkDiagram()
        {
            // Update bias
            for (int layerIndex = 0; layerIndex < ann.Layers.Length - 1; layerIndex++)
            {
                for (int neuronIndex = 0; neuronIndex < ann.Layers[layerIndex].Neurons.Length; neuronIndex++)
                {
                    ActivationNeuron hiddenNeuron = (ActivationNeuron)ann.Layers[layerIndex].Neurons[neuronIndex];
                    hiddenNodes[layerIndex][neuronIndex].ToolTip = "Bias = " + Math.Round(hiddenNeuron.Threshold, 3).ToString();
                }
            }

            for (int classIndex = 0; classIndex < classes.Count; classIndex++)
            {
                ActivationNeuron outputNeuron = (ActivationNeuron)ann.Layers[ann.Layers.Length - 1].Neurons[classIndex];
                outputNodes[classIndex].ToolTip = "Bias = " + Math.Round(outputNeuron.Threshold, 3).ToString();
            }

            // Update weights
            for (int layerIndex = 0; layerIndex < ann.Layers.Length - 1; layerIndex++)
            {
                if (layerIndex == 0)
                {
                    for (int neuronIndex = 0; neuronIndex < ann.Layers[layerIndex].Neurons.Length; neuronIndex++)
                    {
                        ActivationNeuron hiddenNeuron = (ActivationNeuron)ann.Layers[layerIndex].Neurons[neuronIndex];
                        for (int featureIndex = 0; featureIndex < features.Length; featureIndex++)
                            links[layerIndex][neuronIndex][featureIndex].ToolTip = "Weight = " + Math.Round(hiddenNeuron.Weights[featureIndex], 3).ToString();
                    }
                }
                else
                {
                    for (int neuronIndex = 0; neuronIndex < ann.Layers[layerIndex].Neurons.Length; neuronIndex++)
                    {
                        ActivationNeuron hiddenNeuron = (ActivationNeuron)ann.Layers[layerIndex].Neurons[neuronIndex];
                        for (int previousNeuronIndex = 0; previousNeuronIndex < ann.Layers[layerIndex - 1].Neurons.Length; previousNeuronIndex++)
                            links[layerIndex][neuronIndex][previousNeuronIndex].ToolTip = "Weight = " + Math.Round(hiddenNeuron.Weights[previousNeuronIndex], 3).ToString();
                    }
                }
            }

            for (int classIndex = 0; classIndex < classes.Count; classIndex++)
            {
                ActivationNeuron outputNeuron = (ActivationNeuron)ann.Layers[ann.Layers.Length - 1].Neurons[classIndex];
                for (int previousNeuronIndex = 0; previousNeuronIndex < ann.Layers[ann.Layers.Length - 2].Neurons.Length; previousNeuronIndex++)
                {
                    links[ann.Layers.Length - 1][classIndex][previousNeuronIndex].ToolTip = "Weight = " + Math.Round(outputNeuron.Weights[previousNeuronIndex], 3).ToString();
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTraining();
        }

        public void StartTraining()
        {
            isConverged = false;

            maxIteration = Convert.ToInt32(maxIterationNumericUpDown.Value);
            tolerance = Convert.ToDouble(toleranceNumericUpDown.Value);

            if (useNguyenWidrow)
            {
                if (useSameWeights)
                    Generator.Seed = 1;

                NguyenWidrow initializer = new NguyenWidrow(ann);
                initializer.Randomize();
            }

            int[] layers = new int[networkStructureDataGridView.Rows.Count + 1];
            switch (learningMethodComboBox.SelectedItem.ToString())
            {
                case "Levenberg-Marquardt":
                    learningMethod = LearningMethod.LevenbergMarquardt;
                    break;
                case "Backpropagation":
                    learningMethod = LearningMethod.Backpropagation;
                    break;
                case "Resilient Backpropagation":
                    learningMethod = LearningMethod.ResilientBackpropagation;
                    break;
                case "Parallel Resilient Backpropagation":
                    learningMethod = LearningMethod.ParallelResilientBackpropagation;
                    break;
                case "Perceptron":
                    if (layers.Length >= 2)
                    {
                        MessageBox.Show(this, "Perceptron learning can only be applied to perceptron!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    learningMethod = LearningMethod.Perceptron;
                    break;
                case "Delta Rule":
                    if (layers.Length >= 2)
                    {
                        MessageBox.Show(this, "Delta Rule learning can only be applied to perceptron!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    learningMethod = LearningMethod.DeltaRule;
                    break;
            }

            TrainingStarted(new ModelModifiedEventArgs { Model = ann });

            needToStop = false;
            trainingTimer.Start();

            //Run worker thread
            workerThread = new Thread(new ThreadStart(searchSolution));
            workerThread.Start();
        }

        private void onTrainingStarted(ModelModifiedEventArgs e)
        {
            enableControls(false);
        }

        private void searchSolution() // On worker thread
        {
            int numberOfEntries = trainingInputColumns.Length;

            try
            {
                //Create learner
                object annLearning = null;
                switch (learningMethod)
                {
                    case LearningMethod.LevenbergMarquardt:
                        annLearning = new LevenbergMarquardtLearning(ann, useRegularization)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.Backpropagation:
                        annLearning = new BackPropagationLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.ResilientBackpropagation:
                        annLearning = new ResilientBackpropagationLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.ParallelResilientBackpropagation:
                        annLearning = new ParallelResilientBackpropagationLearning(ann);
                        break;
                    case LearningMethod.Perceptron:
                        annLearning = new PerceptronLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.DeltaRule:
                        annLearning = new DeltaRuleLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                }

                //Iterations
                iteration = 1;
                Stopwatch stopwatch = Stopwatch.StartNew();

                //Loop
                while (!needToStop)
                {
                    //Run epoch of learning procedure
                    switch (learningMethod)
                    {
                        case LearningMethod.LevenbergMarquardt:
                            error = ((LevenbergMarquardtLearning)annLearning).RunEpoch(trainingInputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.Backpropagation:
                            error = ((BackPropagationLearning)annLearning).RunEpoch(trainingInputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.ResilientBackpropagation:
                            error = ((ResilientBackpropagationLearning)annLearning).RunEpoch(trainingInputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.ParallelResilientBackpropagation:
                            error = ((ParallelResilientBackpropagationLearning)annLearning).RunEpoch(trainingInputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.Perceptron:
                            error = ((PerceptronLearning)annLearning).RunEpoch(trainingInputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.DeltaRule:
                            error = ((DeltaRuleLearning)annLearning).RunEpoch(trainingInputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                    }

                    //Increase current iteration
                    iteration++;
                    elapsed = stopwatch.Elapsed;
                    updateStatus();

                    //Check if model converged
                    if (iteration > maxIteration)
                    {
                        if (error <= tolerance)
                            isConverged = true;

                        break;
                    }
                }

                stopwatch.Stop();
            }
            catch
            {
                isConverged = false;
            }
        }

        private void enableControls(bool enable)
        {
            if (InvokeRequired)
            {
                enableCallback d = new enableCallback(enableControls);
                Invoke(d, new object[] { enable });
            }
            else
            {
                startButton.Enabled = enable;
                stopButton.Enabled = !enable;
            }
        }

        private void updateStatus()
        {
            if (!iterationTextBox.InvokeRequired)
            {
                iterationTextBox.Text = iteration.ToString();
                errorTextBox.Text = error.ToString("N10");
                elapsedTextBox.Text = elapsed.ToString();
            }
            else
            {
                iterationTextBox.BeginInvoke(new System.Action(updateStatus));
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            needToStop = true;
            while (!workerThread.Join(100))
                Application.DoEvents();
            workerThread = null;

            if (error <= tolerance)
                isConverged = true;
        }

        private void onTrainingStopped(EventArgs e)
        {
            enableControls(true);

            updateNetworkDiagram();
        }

        private void trainingTimer_Tick(object sender, EventArgs e)
        {
            if (isConverged)
            {
                ModelConverged(new ModelTrainedEventArgs() { Model = ann });

                trainingTimer.Stop();

                TrainingStopped(new ModelModifiedEventArgs { Model = ann });

                return;
            }

            TrainingUpdate(new ModelModifiedEventArgs { Model = ann });
        }

        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();
            string[][] hiddenLayers = new string[networkStructureDataGridView.Rows.Count][];
            for (int i = 0; i < networkStructureDataGridView.Rows.Count; i++)
            {
                hiddenLayers[i] = new string[2];
                hiddenLayers[i][0] = networkStructureDataGridView.Rows[i].Cells[0].Value.ToString();
                hiddenLayers[i][1] = networkStructureDataGridView.Rows[i].Cells[1].Value.ToString();
            }
            learningParameters.Add("hidden layers", JsonConvert.SerializeObject(hiddenLayers));
            learningParameters.Add("activation function", activationFunctionComboBox.SelectedIndex.ToString());
            learningParameters.Add("alpha", alphaNumericUpDown.Value.ToString());
            learningParameters.Add("lower limit", lowerLimitNumericUpDown.Value.ToString());
            learningParameters.Add("upper limit", upperLimitNumericUpDown.Value.ToString());
            learningParameters.Add("method", learningMethodComboBox.SelectedIndex.ToString());
            learningParameters.Add("bayesian regularization", bayesianRegularizationCheckBox.Checked.ToString());
            learningParameters.Add("nguyen-widrow", nguyenWidrowCheckBox.Checked.ToString());
            learningParameters.Add("same weights", sameWeightsCheckBox.Checked.ToString());
            learningParameters.Add("tolerance", toleranceNumericUpDown.Value.ToString());
            learningParameters.Add("max iteration", maxIterationNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            string[][] hiddenLayers = JsonConvert.DeserializeObject<string[][]>(learningParameters["hidden layers"]);
            networkStructureDataGridView.Rows.Clear();
            for (int i = 0;i < hiddenLayers.Length; i++)
                networkStructureDataGridView.Rows.Add(hiddenLayers[i][0], hiddenLayers[i][1]);
            activationFunctionComboBox.SelectedIndex = Convert.ToInt32(learningParameters["activation function"]);
            alphaNumericUpDown.Value = Convert.ToDecimal(learningParameters["alpha"]);
            lowerLimitNumericUpDown.Value = Convert.ToDecimal(learningParameters["lower limit"]);
            upperLimitNumericUpDown.Value = Convert.ToDecimal(learningParameters["upper limit"]);
            learningMethodComboBox.SelectedIndex = Convert.ToInt32(learningParameters["method"]);
            bayesianRegularizationCheckBox.Checked = Convert.ToBoolean(learningParameters["bayesian regularization"]);
            nguyenWidrowCheckBox.Checked = Convert.ToBoolean(learningParameters["nguyen-widrow"]);
            sameWeightsCheckBox.Checked = Convert.ToBoolean(learningParameters["same weights"]);
            toleranceNumericUpDown.Value = Convert.ToDecimal(learningParameters["tolerance"]);
            maxIterationNumericUpDown.Value = Convert.ToDecimal(learningParameters["max iteration"]);
        }
    }
}
