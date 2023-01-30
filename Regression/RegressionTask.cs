using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Neuro;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression.Linear;
using MindFusion.Diagramming;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace JadeML.Regression
{
    public partial class RegressionTask : Form
    {
        // Fields
        private object regressor = null;
        private string[] features;
        private string target;

        private DataTable dataset = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private double[] trainingOutputColumn = null;

        private DataTable testingDataset = null;
        private double[][] testInputColumns = null;
        private double[] testOutputColumn = null;

        private DataTable predictionDataset = null;

        private string serializedLearningParameters = "";

        private bool modelTrained = false;

        // Property
        public bool IsDatasetLoaded { get { return dataset != null; } }
        public bool IsTrainingDatasetLoaded { get { return trainingDataset != null; } }
        public bool IsTestingDatasetLoaded { get { return testingDataset != null; } }
        public bool IsPredictionDatasetLoaded { get { return predictionDataset != null; } }
        public bool IsModelLoaded { get { return modelTabPage.Controls.Count > 0; } }
        public bool IsModelTrained { get { return modelTrained; } }

        // Event
        public delegate void DataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event DataLoadedEventHandler DatasetLoaded;
        public delegate void TrainingDataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event TrainingDataLoadedEventHandler TrainingDatasetLoaded;
        public delegate void TestingDataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event TestingDataLoadedEventHandler TestingDatasetLoaded;
        public delegate void PredictionDataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event PredictionDataLoadedEventHandler PredictionDatasetLoaded;
        public delegate void ModelLoadedEventHandler(EventArgs e);
        public event ModelLoadedEventHandler ModelLoaded;
        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        // Constructors
        public RegressionTask()
        {
            InitializeComponent();

            DatasetLoaded += OnDatasetLoaded;
            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            TestingDatasetLoaded += OnTestingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += onModelLoaded;
            ModelTrained += onModelTrained;
        }

        public RegressionTask(object model, DataTable dataset, DataTable trainingDataset, DataTable testingDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            DatasetLoaded += OnDatasetLoaded;
            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            TestingDatasetLoaded += OnTestingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += onModelLoaded;
            ModelTrained += onModelTrained;

            DatasetLoaded(new DatasetLoadedEventArgs { Dataset = dataset });
            TrainingDatasetLoaded(new DatasetLoadedEventArgs { Dataset = trainingDataset });
            TestingDatasetLoaded(new DatasetLoadedEventArgs { Dataset = testingDataset });

            if (model.GetType() == typeof(MultipleLinearRegression))
            {
                modelTabPage.Controls.Add(new LinearRegressionLearningControl());
                ((LinearRegressionLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(PolynomialRegression))
            {
                modelTabPage.Controls.Add(new PolynomialRegressionLearningControl());
                ((PolynomialRegressionLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(SupportVectorMachine) || model.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                SVMRegressionLearningControl svmRegressionLearningControl = new SVMRegressionLearningControl();
                modelTabPage.Controls.Add(svmRegressionLearningControl);

                if (trainingInputColumns != null)
                    svmRegressionLearningControl.InputColumns = trainingInputColumns;

                svmRegressionLearningControl.SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(ActivationNetwork))
            {
                ANNRegressionLearningControl annRegressionLearningControl = new ANNRegressionLearningControl(trainingInputColumns, trainingOutputColumn, features, target);
                modelTabPage.Controls.Add(annRegressionLearningControl);

                annRegressionLearningControl.ANN = (ActivationNetwork)model;
                annRegressionLearningControl.SetLearningParameters(serializedLearningParameters);

                annRegressionLearningControl.TrainingStarted += onANNTrainingStarted;
                annRegressionLearningControl.TrainingUpdate += onANNTrainingUpdate;
                annRegressionLearningControl.ModelConverged += onANNConverged;
                annRegressionLearningControl.TrainingStopped += onANNTrainingStopped;
            }

            ModelTrained(new ModelTrainedEventArgs() { Model = model });
        }

        // Form event handlers
        private void BinaryClassificationTask_Load(object sender, EventArgs e)
        {
            ShapeNode datasetNode = taskDiagram.Factory.CreateShapeNode(5, 5, 20, 10, Shapes.Rectangle);
            datasetNode.Text = "Dataset";
            datasetNode.EnabledHandles = AdjustmentHandles.Move;

            ShapeNode trainingDatasetNode = taskDiagram.Factory.CreateShapeNode(5, 25, 20, 10, Shapes.Rectangle);
            trainingDatasetNode.Text = "Training dataset";
            trainingDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link1 = taskDiagram.Factory.CreateDiagramLink(datasetNode, trainingDatasetNode);
            link1.AllowMoveStart = false;
            link1.AllowMoveEnd = false;
            link1.Pen = new MindFusion.Drawing.Pen(Color.Brown);
            link1.HeadPen = new MindFusion.Drawing.Pen(Color.Brown);

            ShapeNode testingDatasetNode = taskDiagram.Factory.CreateShapeNode(110, 5, 20, 10, Shapes.Rectangle);
            testingDatasetNode.Text = "Testing dataset";
            testingDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link2 = taskDiagram.Factory.CreateDiagramLink(datasetNode, testingDatasetNode);
            link2.AllowMoveStart = false;
            link2.AllowMoveEnd = false;
            link2.Pen = new MindFusion.Drawing.Pen(Color.Brown);
            link2.HeadPen = new MindFusion.Drawing.Pen(Color.Brown);

            ShapeNode modelNode = taskDiagram.Factory.CreateShapeNode(55, 25, 30, 10, Shapes.Cube);
            modelNode.Text = "Model";
            modelNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Cyan);
            modelNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link3 = taskDiagram.Factory.CreateDiagramLink(trainingDatasetNode, modelNode);
            link3.AllowMoveStart = false;
            link3.AllowMoveEnd = false;

            ShapeNode evaluationNode = taskDiagram.Factory.CreateShapeNode(110, 25, 20, 10, Shapes.RoundRect);
            evaluationNode.Text = "Evaluation";
            evaluationNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Magenta);
            evaluationNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link4 = taskDiagram.Factory.CreateDiagramLink(modelNode, evaluationNode);
            link4.AllowMoveStart = false;
            link4.AllowMoveEnd = false;

            DiagramLink link5 = taskDiagram.Factory.CreateDiagramLink(testingDatasetNode, evaluationNode);
            link5.AllowMoveStart = false;
            link5.AllowMoveEnd = false;

            ShapeNode predictionNode = taskDiagram.Factory.CreateShapeNode(55, 45, 30, 10, Shapes.Octagon);
            predictionNode.Text = "Prediction";
            predictionNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Orange);
            predictionNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link6 = taskDiagram.Factory.CreateDiagramLink(modelNode, predictionNode);
            link6.AllowMoveStart = false;
            link6.AllowMoveEnd = false;

            ShapeNode predictionDatasetNode = taskDiagram.Factory.CreateShapeNode(5, 45, 20, 10, Shapes.Rectangle);
            predictionDatasetNode.Text = "Prediction dataset";
            predictionDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link7 = taskDiagram.Factory.CreateDiagramLink(predictionDatasetNode, predictionNode);
            link7.AllowMoveStart = false;
            link7.AllowMoveEnd = false;
        }

        private void BinaryClassificationTask_Resize(object sender, EventArgs e)
        {
            taskSplitContainer.Height = Height - 64;
        }
        
        private void BinaryClassificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (regressor != null && modelTrained)
            {
                switch (MessageBox.Show(mainForm, "Do you want to save this task?", "Save task", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        mainForm.SaveCurrentModel();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
        }

        public void SaveModel(string filePath)
        {
            if (!modelTrained || regressor == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 2; // regression
                    byte modelIndex = 0;

                    byte[] serializedModel = null;
                    if (regressor.GetType() == typeof(MultipleLinearRegression))
                    {
                        modelIndex = 0;
                        ((MultipleLinearRegression)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(PolynomialRegression))
                    {
                        modelIndex = 1;
                        ((PolynomialRegression)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(SupportVectorMachine))
                    {
                        modelIndex = 2;
                        ((SupportVectorMachine)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                    {
                        modelIndex = 3;
                        ((SupportVectorMachine<IKernel>)regressor).Save(out serializedModel);
                    }
                    else if (regressor.GetType() == typeof(ActivationNetwork))
                    {
                        modelIndex = 4;
                        ((ActivationNetwork)regressor).Save(out serializedModel);
                    }
                    int modelSize = serializedModel.Length;

                    byte[] serializedData = null;
                    int dataSize = 0;
                    if (dataset != null)
                    {
                        dataset.Save(out serializedData);
                        dataSize = serializedData.Length;
                    }

                    byte[] serializedTrainingDataset = null;
                    int trainingDatasetSize = 0;
                    if (trainingDataset != null)
                    {
                        trainingDataset.Save(out serializedTrainingDataset);
                        trainingDatasetSize = serializedTrainingDataset.Length;
                    }

                    byte[] serializedTestDataset = null;
                    int testDataSize = 0;
                    if (testingDataset != null)
                    {
                        testingDataset.Save(out serializedTestDataset);
                        testDataSize = serializedTestDataset.Length;
                    }

                    binaryWriter.Write(taskIndex);
                    binaryWriter.Write(modelIndex);
                    binaryWriter.Write(serializedLearningParameters);
                    binaryWriter.Write(modelSize);
                    binaryWriter.Write(serializedModel);
                    binaryWriter.Write(dataSize);
                    binaryWriter.Write(serializedData);
                    binaryWriter.Write(trainingDatasetSize);
                    binaryWriter.Write(serializedTrainingDataset);
                    binaryWriter.Write(testDataSize);
                    binaryWriter.Write(serializedTestDataset);
                }
            }
        }

        // Diagram
        private void taskDiagram_SelectionChanged(object sender, EventArgs e)
        {
            if (taskDiagram.ActiveItem == null || taskDiagram.ActiveItem.GetType() != typeof(ShapeNode))
                return;

            ShapeNode activeNode = (ShapeNode)taskDiagram.ActiveItem;
            switch (activeNode.Text)
            {
                case "Dataset":
                    datasetLabel.Text = "Dataset";
                    datasetDataGridView.DataSource = null;
                    if (dataset != null)
                        datasetDataGridView.DataSource = dataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Training dataset":
                    datasetLabel.Text = "Training dataset";
                    datasetDataGridView.DataSource = null;
                    if (trainingDataset != null)
                        datasetDataGridView.DataSource = trainingDataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Testing dataset":
                    datasetLabel.Text = "Testing dataset";
                    datasetDataGridView.DataSource = null;
                    if (testingDataset != null)
                        datasetDataGridView.DataSource = testingDataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Prediction dataset":
                    datasetLabel.Text = "Prediction dataset";
                    datasetDataGridView.DataSource = null;
                    if (predictionDataset != null)
                        datasetDataGridView.DataSource = predictionDataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Model":
                    taskTabControl.SelectTab(1);
                    break;
                case "Evaluation":
                    taskTabControl.SelectTab(2);
                    break;
                case "Prediction":
                    taskTabControl.SelectTab(3);
                    break;
            }
        }

        private void taskDiagram_NodeDeleting(object sender, NodeValidationEventArgs e)
        {
            e.Cancel = true;
        }

        private void taskDiagram_LinkDeleting(object sender, LinkValidationEventArgs e)
        {
            e.Cancel = true;
        }

        // Load data
        public void LoadDataset(DataTable dataset)
        {
            DatasetLoaded(new DatasetLoadedEventArgs() { Dataset = dataset });
        }

        public void OnDatasetLoaded(DatasetLoadedEventArgs e)
        {
            dataset = e.Dataset;

            target = dataset.Columns[dataset.Columns.Count - 1].ColumnName;
            features = new string[dataset.Columns.Count - 1];
            for (int i = 0; i < features.Length; i++)
                features[i] = dataset.Columns[i].ColumnName;

            if (datasetLabel.Text == "Dataset")
            {
                datasetDataGridView.Columns.Clear();
                datasetDataGridView.DataSource = dataset;
            }
        }

        public bool SplitDataset(float percentageOfTrainingDataset)
        {
            int[] rowIndexes = new int[dataset.Rows.Count];
            for (int i = 0; i < dataset.Rows.Count; i++)
                rowIndexes[i] = i;

            int numberOfRowsInTrainingDataset = Convert.ToInt32(dataset.Rows.Count * percentageOfTrainingDataset / 100f);
            int numberOfRowsInTestDataset = dataset.Rows.Count - numberOfRowsInTrainingDataset;

            if (numberOfRowsInTrainingDataset == 0 || numberOfRowsInTestDataset == 0)
            {
                MessageBox.Show(this, "Cannot split data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Random random = new Random();
            rowIndexes = rowIndexes.OrderBy(i => random.Next()).ToArray();
            int[] trainingRowIndexes = rowIndexes.Take(numberOfRowsInTrainingDataset).ToArray();
            int[] testRowIndexes = rowIndexes.Skip(numberOfRowsInTrainingDataset).Take(numberOfRowsInTestDataset).ToArray();

            trainingDataset = dataset.DeepClone();
            for (int i = trainingDataset.Rows.Count - 1; i >= 0; i--)
                if (testRowIndexes.Contains(i))
                    trainingDataset.Rows.RemoveAt(i);

            testingDataset = dataset.DeepClone();
            for (int i = testingDataset.Rows.Count - 1; i >= 0; i--)
                if (trainingRowIndexes.Contains(i))
                    testingDataset.Rows.RemoveAt(i);

            TrainingDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = trainingDataset });
            TestingDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = testingDataset });

            return true;
        }

        public void LoadTrainingDataset(DataTable dataset)
        {
            TrainingDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = dataset });
        }

        public void OnTrainingDatasetLoaded(DatasetLoadedEventArgs e)
        {
            trainingDataset = e.Dataset;

            DataTable trainingDataTable = e.Dataset.DeepClone();
            trainingOutputColumn = trainingDataTable.Columns[trainingDataTable.Columns.Count - 1].ToArray<double>();
            trainingDataTable.Columns.RemoveAt(trainingDataTable.Columns.Count - 1);
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();

            if (target == "" || features == null)
            {
                target = trainingDataset.Columns[trainingDataset.Columns.Count - 1].ColumnName;
                features = new string[trainingDataset.Columns.Count - 1];
                for (int i = 0; i < features.Length; i++)
                    features[i] = trainingDataset.Columns[i].ColumnName;
            }

            if (datasetLabel.Text == "Training dataset")
            {
                datasetDataGridView.Columns.Clear();
                datasetDataGridView.DataSource = trainingDataset;
            }
        }

        public void LoadTestingDataset(DataTable dataset)
        {
            TestingDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = dataset });
        }

        public void OnTestingDatasetLoaded(DatasetLoadedEventArgs e)
        {
            testingDataset = e.Dataset;

            DataTable testingDataTable = e.Dataset.DeepClone();
            testOutputColumn = testingDataTable.Columns[testingDataTable.Columns.Count - 1].ToArray<double>();
            testingDataTable.Columns.RemoveAt(testingDataTable.Columns.Count - 1);
            testInputColumns = testingDataTable.ToMatrix().ToJagged();

            if (target == "" || features == null)
            {
                target = testingDataset.Columns[testingDataset.Columns.Count - 1].ColumnName;
                features = new string[testingDataset.Columns.Count - 1];
                for (int i = 0; i < features.Length; i++)
                    features[i] = testingDataset.Columns[i].ColumnName;
            }

            if (datasetLabel.Text == "Testing dataset")
            {
                datasetDataGridView.Columns.Clear();
                datasetDataGridView.DataSource = testingDataset;
            }
        }

        public void LoadPredictionDataset(DataTable dataset)
        {
            PredictionDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = dataset });
        }

        public void OnPredictionDatasetLoaded(DatasetLoadedEventArgs e)
        {
            predictionDataset = e.Dataset;

            if (datasetLabel.Text == "Prediction dataset")
            {
                datasetDataGridView.Columns.Clear();
                datasetDataGridView.DataSource = predictionDataset;
            }
        }

        private void datasetVisualizeButton_Click(object sender, EventArgs e)
        {
            if (datasetLabel.Text == "Dataset" && dataset != null)
            {
                VisualizeRegressionDataDialog visualizeRegressionDataDialog = new VisualizeRegressionDataDialog(dataset, "Dataset");
                visualizeRegressionDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Training dataset" && trainingDataset != null)
            {
                VisualizeRegressionDataDialog visualizeRegressionDataDialog = new VisualizeRegressionDataDialog(trainingDataset, "Training dataset");
                visualizeRegressionDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Testing dataset" && testingDataset != null)
            {
                VisualizeRegressionDataDialog visualizeRegressionDataDialog = new VisualizeRegressionDataDialog(testingDataset, "Testing dataset");
                visualizeRegressionDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Prediction dataset" && predictionDataset != null)
            {
                VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(predictionDataset, "Prediction dataset");
                visualizeDataDialog.Show(this);
            }
        }

        // Model
        public void LoadModel(int modelIndex)
        {
            modelTabPage.Controls.Clear();
            modelTabPage.BackColor = SystemColors.Control;

            switch (modelIndex)
            {
                case 0:
                    LinearRegressionLearningControl linearRegressionLearningControl = new LinearRegressionLearningControl();
                    modelTabPage.Controls.Add(linearRegressionLearningControl);

                    break;
                case 1:
                    PolynomialRegressionLearningControl polynomialRegressionLearningControl = new PolynomialRegressionLearningControl();
                    modelTabPage.Controls.Add(polynomialRegressionLearningControl);

                    break;
                case 2:
                    SVMRegressionLearningControl svmRegressionLearningControl = new SVMRegressionLearningControl();
                    modelTabPage.Controls.Add(svmRegressionLearningControl);

                    if (trainingInputColumns != null)
                        svmRegressionLearningControl.InputColumns = trainingInputColumns;

                    break;
                case 3:
                    ANNRegressionLearningControl annRegressionLearningControl = new ANNRegressionLearningControl(trainingInputColumns, trainingOutputColumn, features, target);
                    modelTabPage.Controls.Add(annRegressionLearningControl);

                    annRegressionLearningControl.TrainingStarted += onANNTrainingStarted;
                    annRegressionLearningControl.TrainingUpdate += onANNTrainingUpdate;
                    annRegressionLearningControl.ModelConverged += onANNConverged;
                    annRegressionLearningControl.TrainingStopped += onANNTrainingStopped;

                    break;
            }

            ModelLoaded(EventArgs.Empty);
        }

        private void onModelLoaded(EventArgs e)
        {
            regressor = null;
            modelTrained = false;
            serializedLearningParameters = "";

            taskTabControl.SelectTab(1);
        }
        
        // Training
        public void TrainModel()
        {
            if (trainingInputColumns == null)
            {
                MessageBox.Show(this, "Training dataset cannot be empty!", "Training dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (modelTabPage.Controls.Count == 0)
            {
                MessageBox.Show(this, "You have to choose a model!", "Choose model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modelTabPage.BackColor = SystemColors.Control;
            if (modelTabPage.Controls.Count == 2)
                modelTabPage.Controls.RemoveAt(1);
            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            try
            {
                object regressor = null;

                if (modelTabPage.Controls[0].GetType() == typeof(LinearRegressionLearningControl))
                {
                    LinearRegressionLearningControl linearRegressionControl = (LinearRegressionLearningControl)modelTabPage.Controls[0];
                    OrdinaryLeastSquares ordinaryLeastSquares = new OrdinaryLeastSquares()
                    {
                        UseIntercept = !linearRegressionControl.InterceptCheckBox.Checked
                    };
                    regressor = ordinaryLeastSquares.Learn(trainingInputColumns, trainingOutputColumn);
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(PolynomialRegressionLearningControl))
                {
                    if (trainingInputColumns.Columns() != 1)
                        throw new Exception("You can only have 1 feature for polynomial regression!");

                    PolynomialRegressionLearningControl polynomialRegressionLearningControl = (PolynomialRegressionLearningControl)modelTabPage.Controls[0];
                    PolynomialLeastSquares polynomialLeastSquares = new PolynomialLeastSquares()
                    {
                        Degree = Convert.ToInt32(polynomialRegressionLearningControl.DegreeNumericUpDown.Value)
                    };
                    regressor = polynomialLeastSquares.Learn(trainingInputColumns.GetColumn(0), trainingOutputColumn);
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(SVMRegressionLearningControl))
                {
                    SVMRegressionLearningControl svmRegressionLearningControl = (SVMRegressionLearningControl)modelTabPage.Controls[0];
                    IKernel kernel = svmRegressionLearningControl.CreateKernel();
                    if (svmRegressionLearningControl.SequentialMinimalOptimizationRegressionRadioButton.Checked)
                    {
                        SequentialMinimalOptimizationRegression<IKernel> sequentialMinimalOptimizationRegression = new SequentialMinimalOptimizationRegression<IKernel>()
                        {
                            Complexity = Convert.ToDouble(svmRegressionLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmRegressionLearningControl.ToleranceNumericUpDown.Value),
                            Epsilon = Convert.ToDouble(svmRegressionLearningControl.EpsilonNumericUpDown.Value),
                            Kernel = kernel
                        };
                        regressor = sequentialMinimalOptimizationRegression.Learn(trainingInputColumns, trainingOutputColumn);
                    }
                    else if (svmRegressionLearningControl.LinearRegressionCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                        LinearRegressionCoordinateDescent linearRegressionCoordinateDescent = new LinearRegressionCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmRegressionLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmRegressionLearningControl.ToleranceNumericUpDown.Value),
                            Epsilon = Convert.ToDouble(svmRegressionLearningControl.EpsilonNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        regressor = linearRegressionCoordinateDescent.Learn(trainingInputColumns, trainingOutputColumn);
                    }
                    else if (svmRegressionLearningControl.LinearRegressionNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Newton method can only use linear kernel!");
                        LinearRegressionNewtonMethod linearRegressionNewtonMethod = new LinearRegressionNewtonMethod()
                        {
                            Complexity = Convert.ToDouble(svmRegressionLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmRegressionLearningControl.ToleranceNumericUpDown.Value),
                            Epsilon = Convert.ToDouble(svmRegressionLearningControl.EpsilonNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        regressor = linearRegressionNewtonMethod.Learn(trainingInputColumns, trainingOutputColumn);
                    }
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(ANNRegressionLearningControl))
                {
                    ANNRegressionLearningControl annRegressionLearningControl = (ANNRegressionLearningControl)modelTabPage.Controls[0];
                    if (!annRegressionLearningControl.IsNetworkBuilt)
                        throw new Exception("The neural network was not built!");

                    annRegressionLearningControl.StartTraining();

                    Cursor = Cursors.Default;
                    return;
                }

                ModelTrained(new ModelTrainedEventArgs() { Model = regressor });
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Status:";
                Cursor = Cursors.Default;
            }
        }

        private void onModelTrained(ModelTrainedEventArgs e)
        {
            regressor = e.Model;

            if (regressor.GetType() == typeof(MultipleLinearRegression))
            {
                serializedLearningParameters = ((LinearRegressionLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                modelTabPage.Controls.Add(new LinearRegressionModelControl((MultipleLinearRegression)regressor, features));
                modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;
            }
            else if (regressor.GetType() == typeof(PolynomialRegression))
            {
                serializedLearningParameters = ((PolynomialRegressionLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                modelTabPage.Controls.Add(new PolynomialRegressionModelControl((PolynomialRegression)regressor));
                modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;
            }
            else if (regressor.GetType() == typeof(SupportVectorMachine))
            {
                serializedLearningParameters = ((SVMRegressionLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
            }
            else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                serializedLearningParameters = ((SVMRegressionLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                SupportVectorMachine<IKernel> svm = (SupportVectorMachine<IKernel>)regressor;

                if (svm.SupportVectors != null && svm.SupportVectors.Length > 0)
                {
                    modelTabPage.Controls.Add(new SVMRegressionModelControl(svm.SupportVectors, svm.Weights, features, target, trainingInputColumns, trainingOutputColumn));
                    modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;
                }
            }
            else if (regressor.GetType() == typeof(ActivationNetwork))
            {
                serializedLearningParameters = ((ANNRegressionLearningControl)modelTabPage.Controls[0]).GetLearningParameters();

                if (!((ANNRegressionLearningControl)modelTabPage.Controls[0]).IsNetworkDiagramBuilt)
                    ((ANNRegressionLearningControl)modelTabPage.Controls[0]).BuildNetworkDiagram();
            }

            modelTabPage.BackColor = Color.LightGreen;
            taskTabControl.SelectTab(1);

            makePredictionRegressionControl.Regressor = regressor;
            makePredictionRegressionControl.OutputRange = trainingOutputColumn.GetRange();
            makePredictionRegressionControl.ColumnNames = features.Concatenate(target);
            makePredictionRegressionControl.Enabled = true;

            if (features.Length == 1)
            {
                modelVisualizationGroupBox.Visible = true;
                update2dVisualization();
            }
            else
                modelVisualizationGroupBox.Visible = false;

            modelTrained = true;
            statusLabel.Text = "Status: Model trained.";
            Cursor = Cursors.Default;
        }

        private void onANNTrainingStarted(ModelModifiedEventArgs e)
        {
            regressor = null;
            modelTrained = false;
            serializedLearningParameters = "";

            modelTabPage.BackColor = SystemColors.Control;
        }

        private void onANNConverged(ModelTrainedEventArgs e)
        {
            ModelTrained(new ModelTrainedEventArgs() { Model = e.Model });
        }

        private void onANNTrainingUpdate(ModelModifiedEventArgs e)
        {
            regressor = e.Model;

            if (features.Length == 1)
            {
                modelVisualizationGroupBox.Visible = true;
                update2dVisualization();
            }
            else
                modelVisualizationGroupBox.Visible = false;
        }

        private void onANNTrainingStopped(ModelModifiedEventArgs e)
        {
            regressor = e.Model;

            if (features.Length == 1)
            {
                modelVisualizationGroupBox.Visible = true;
                update2dVisualization();
            }
            else
                modelVisualizationGroupBox.Visible = false;
        }

        private void update2dVisualization()
        {
            //Get the ranges for each variable (X and Y)
            double[][] xValues = trainingInputColumns.GetColumn(0).GetRange().Range(0.1).ToJagged();

            double[] outputColumn = new double[xValues.Length];

            if (regressor.GetType() == typeof(MultipleLinearRegression))
            {
                outputColumn = ((MultipleLinearRegression)regressor).Transform(xValues);
            }
            else if (regressor.GetType() == typeof(PolynomialRegression))
            {
                outputColumn = ((PolynomialRegression)regressor).Transform(xValues.GetColumn(0));
            }
            else if (regressor.GetType() == typeof(SupportVectorMachine))
            {
                outputColumn = ((SupportVectorMachine)regressor).Score(xValues);
            }
            else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                outputColumn = ((SupportVectorMachine<IKernel>)regressor).Score(xValues);
            }
            else if (regressor.GetType() == typeof(ActivationNetwork))
            {
                outputColumn = new double[xValues.Length];
                DoubleRange unitRange = new DoubleRange(-1, 1);
                DoubleRange outputRange = trainingOutputColumn.GetRange();
                for (int i = 0; i < xValues.Length; i++)
                    outputColumn[i] = ((ActivationNetwork)regressor).Compute(xValues[i])[0].Scale(unitRange, outputRange);
            }

            // Update plot
            PlotModel plotModel = new PlotModel();

            LineSeries series = new LineSeries()
            {
                Title = target,
                StrokeThickness = 5
            };
            plotModel.Series.Add(series);

            for (int i = 0; i < xValues.Length; i++)
                series.Points.Add(new OxyPlot.DataPoint(xValues[i][0], outputColumn[i]));

            LinearAxis xAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Title = features[0],
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray,
                Minimum = xValues.GetColumn(0).Min(),
                Maximum = xValues.GetColumn(0).Max(),
            };
            LinearAxis yAxis = new LinearAxis()
            {
                Position = AxisPosition.Left,
                Title = target,
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray,
                Minimum = outputColumn.Min(),
                Maximum = outputColumn.Max()
            };
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.Legends.Add(new OxyPlot.Legends.Legend()
            {
                LegendTitle = target,
                LegendPlacement = LegendPlacement.Outside
            });
            modelVisualizationPlotView.Model = plotModel;
        }

        // Testing
        public void TestModel()
        {
            if (testInputColumns == null)
            {
                MessageBox.Show(this, "Test dataset cannot be empty!", "Test dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (testInputColumns.Columns() != features.Length)
            {
                MessageBox.Show(this, "Test dataset does not match training dataset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!modelTrained || regressor == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            taskTabControl.SelectTab(2);
            Cursor = Cursors.WaitCursor;

            try
            {
                double[] predictedOutputColumn = null;
                if (regressor.GetType() == typeof(MultipleLinearRegression))
                {
                    predictedOutputColumn = ((MultipleLinearRegression)regressor).Transform(testInputColumns);
                }
                else if (regressor.GetType() == typeof(PolynomialRegression))
                {
                    predictedOutputColumn = ((PolynomialRegression)regressor).Transform(testInputColumns.GetColumn(0));
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine))
                {
                    predictedOutputColumn = ((SupportVectorMachine)regressor).Score(testInputColumns);
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    predictedOutputColumn = ((SupportVectorMachine<IKernel>)regressor).Score(testInputColumns);
                }
                else if (regressor.GetType() == typeof(ActivationNetwork))
                {
                    ActivationNetwork ann = (ActivationNetwork)regressor;
                    DoubleRange unitRange = new DoubleRange(-1, 1);
                    DoubleRange outputRange = trainingOutputColumn.GetRange();
                    predictedOutputColumn = new double[testInputColumns.Length];
                    for (int i = 0; i < predictedOutputColumn.Length; i++)
                        predictedOutputColumn[i] = ann.Compute(testInputColumns[i])[0].Scale(unitRange, outputRange);
                }

                DataTable testDataTable = testInputColumns.ToTable(features);
                testDataTable.Columns.Add(target);
                testDataTable.Columns.Add(target + " (predicted)");

                for (int i = 0; i < testDataTable.Rows.Count; i++)
                {
                    testDataTable.Rows[i][target] = testOutputColumn[i];
                    testDataTable.Rows[i][target + " (predicted)"] = predictedOutputColumn[i];
                }

                for (int i = 0; i < testDataTable.Columns.Count; i++)
                    testDataTable.Columns[i].ReadOnly = false;

                testRegressionControl.Visible = true;
                testRegressionControl.TestDataTable = testDataTable;

                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        // Prediction
        public void MakeDatasetPrediction()
        {
            if (regressor == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (predictionDataset == null)
            {
                MessageBox.Show(this, "Prediction dataset cannot be empty!", "Prediction dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (predictionDataset.Columns.Count != trainingDataset.Columns.Count - 1)
            {
                MessageBox.Show(this, "Prediction dataset does not match training dataset!", "Prediction dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            taskTabControl.SelectTab(3);
            Cursor = Cursors.WaitCursor;

            try
            {
                double[][] inputColumns = predictionDataset.ToMatrix().ToJagged();
                double[] outputColumn = null;
                if (regressor.GetType() == typeof(MultipleLinearRegression))
                {
                    outputColumn = ((MultipleLinearRegression)regressor).Transform(inputColumns);
                }
                else if (regressor.GetType() == typeof(PolynomialRegression))
                {
                    outputColumn = ((PolynomialRegression)regressor).Transform(inputColumns.GetColumn(0));
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine))
                {
                    outputColumn = ((SupportVectorMachine)regressor).Score(inputColumns);
                }
                else if (regressor.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    outputColumn = ((SupportVectorMachine<IKernel>)regressor).Score(inputColumns);
                }
                else if (regressor.GetType() == typeof(ActivationNetwork))
                {
                    outputColumn = new double[inputColumns.Length];
                    DoubleRange unitRange = new DoubleRange(-1, 1);
                    DoubleRange outputRange = trainingOutputColumn.GetRange();
                    for (int i = 0; i < inputColumns.Length; i++)
                        outputColumn[i] = ((ActivationNetwork)regressor).Compute(inputColumns[i])[0].Scale(unitRange, outputRange);
                }

                makePredictionRegressionControl.UpdatePredictionResult(predictionDataset, outputColumn);
                
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }
    }
}
