using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Neuro;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression.Fitting;
using Accord.Statistics.Models.Regression;
using MindFusion.Diagramming;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class BinaryClassificationTask : Form
    {
        // Fields
        private object classifier = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private string[] features = null;
        private string target = "";

        private DataTable dataset = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private string[] trainingOutputColumn = null;
        private int[] trainingClassIndexColumn = null;

        private DataTable testingDataset = null;
        private double[][] testInputColumns = null;
        private string[] testOutputColumn = null;

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
        public BinaryClassificationTask()
        {
            InitializeComponent();

            DatasetLoaded += OnDatasetLoaded;
            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            TestingDatasetLoaded += OnTestingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += onModelLoaded;
            ModelTrained += onModelTrained;
        }

        public BinaryClassificationTask(object model, DataTable dataset, DataTable trainingDataset, DataTable testingDataset, string serializedLearningParameters)
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

            if (model.GetType() == typeof(LogisticRegression))
            {
                modelTabPage.Controls.Add(new LogisticRegressionLearningControl());
                ((LogisticRegressionLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(KNearestNeighbors))
            {
                modelTabPage.Controls.Add(new KNearestNeighborsLearningControl());
                ((KNearestNeighborsLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(MinimumMeanDistanceClassifier))
            {
                modelTabPage.Controls.Add(new MinimumMeanDistanceLearningControl());
            }
            else if (model.GetType() == typeof(NaiveBayes<NormalDistribution>))
            {
                modelTabPage.Controls.Add(new NaiveBayesLearningControl());
            }
            else if (model.GetType() == typeof(DecisionTree))
            {
                modelTabPage.Controls.Add(new DecisionTreeLearningControl());
                ((DecisionTreeLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(RandomForest))
            {
                modelTabPage.Controls.Add(new RandomForestLearningControl());
                ((RandomForestLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(SupportVectorMachine) || model.GetType() == typeof(SupportVectorMachine<IKernel>) || model.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
            {
                SVMClassificationLearningControl svmClassificationLearningControl = new SVMClassificationLearningControl(trainingInputColumns);
                modelTabPage.Controls.Add(svmClassificationLearningControl);

                svmClassificationLearningControl.SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(ActivationNetwork))
            {
                ANNClassificationLearningControl annClassificationLearningControl = new ANNClassificationLearningControl(trainingInputColumns, trainingClassIndexColumn, features, classes);
                modelTabPage.Controls.Add(annClassificationLearningControl);

                annClassificationLearningControl.ANN = (ActivationNetwork)model;
                annClassificationLearningControl.SetLearningParameters(serializedLearningParameters);

                annClassificationLearningControl.TrainingStarted += onANNTrainingStarted;
                annClassificationLearningControl.TrainingUpdate += onANNTrainingUpdate;
                annClassificationLearningControl.ModelConverged += onANNConverged;
                annClassificationLearningControl.TrainingStopped += onANNTrainingStopped;
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

            if (classifier != null && modelTrained)
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
            if (!modelTrained || classifier == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 0; // binary classification
                    byte modelIndex = 0;

                    byte[] serializedModel = null;
                    if (classifier.GetType() == typeof(LogisticRegression))
                    {
                        modelIndex = 0;
                        ((LogisticRegression)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(KNearestNeighbors))
                    {
                        modelIndex = 1;
                        ((KNearestNeighbors)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                    {
                        modelIndex = 2;
                        ((MinimumMeanDistanceClassifier)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                    {
                        modelIndex = 3;
                        ((NaiveBayes<NormalDistribution>)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(DecisionTree))
                    {
                        modelIndex = 4;
                        ((DecisionTree)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(RandomForest))
                    {
                        modelIndex = 5;
                        ((RandomForest)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine))
                    {
                        modelIndex = 6;
                        ((SupportVectorMachine)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                    {
                        modelIndex = 7;
                        ((SupportVectorMachine<IKernel>)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                    {
                        modelIndex = 8;
                        ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Save(out serializedModel);
                    }
                    else if (classifier.GetType() == typeof(ActivationNetwork))
                    {
                        modelIndex = 9;
                        ((ActivationNetwork)classifier).Save(out serializedModel);
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
            trainingOutputColumn = trainingDataTable.Columns[trainingDataTable.Columns.Count - 1].ToArray<string>();
            trainingDataTable.Columns.RemoveAt(trainingDataTable.Columns.Count - 1);
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();

            if (target == "" || features == null)
            {
                target = trainingDataset.Columns[trainingDataset.Columns.Count - 1].ColumnName;
                features = new string[trainingDataset.Columns.Count - 1];
                for (int i = 0; i < features.Length; i++)
                    features[i] = trainingDataset.Columns[i].ColumnName;
            }

            string[] classLabels = trainingOutputColumn.Distinct().OrderBy(x => x).ToArray();
            classes = new Dictionary<int, string>();
            for (int i = 0; i < classLabels.Length; i++)
                classes.Add(i, classLabels[i]);

            trainingClassIndexColumn = new int[trainingOutputColumn.Length];
            for (int i = 0; i < trainingOutputColumn.Length; i++)
                trainingClassIndexColumn[i] = classes.FirstOrDefault(x => x.Value == trainingOutputColumn[i]).Key;

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

            DataTable testDataTable = e.Dataset.DeepClone();
            testOutputColumn = testDataTable.Columns[testDataTable.Columns.Count - 1].ToArray<string>();
            testDataTable.Columns.RemoveAt(testDataTable.Columns.Count - 1);
            testInputColumns = testDataTable.ToMatrix().ToJagged();

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
                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(dataset, "Dataset");
                visualizeClassificationDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Training dataset" && trainingDataset != null)
            {
                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(trainingDataset, "Training dataset");
                visualizeClassificationDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Testing dataset" && testingDataset != null)
            {
                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(testingDataset, "Testing dataset");
                visualizeClassificationDataDialog.Show(this);
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
                    LogisticRegressionLearningControl logisticRegressionLearningControl = new LogisticRegressionLearningControl();
                    modelTabPage.Controls.Add(logisticRegressionLearningControl);

                    break;
                case 1:
                    KNearestNeighborsLearningControl kNearestNeighborsLearningControl = new KNearestNeighborsLearningControl();
                    modelTabPage.Controls.Add(kNearestNeighborsLearningControl);

                    break;
                case 2:
                    MinimumMeanDistanceLearningControl minimumMeanDistanceLearningControl = new MinimumMeanDistanceLearningControl();
                    modelTabPage.Controls.Add(minimumMeanDistanceLearningControl);

                    break;
                case 3:
                    NaiveBayesLearningControl naiveBayesLearningControl = new NaiveBayesLearningControl();
                    modelTabPage.Controls.Add(naiveBayesLearningControl);

                    break;
                case 4:
                    DecisionTreeLearningControl decisionTreeLearningControl = new DecisionTreeLearningControl();
                    modelTabPage.Controls.Add(decisionTreeLearningControl);

                    break;
                case 5:
                    RandomForestLearningControl randomForestLearningControl = new RandomForestLearningControl();
                    modelTabPage.Controls.Add(randomForestLearningControl);

                    break;
                case 6:
                    SVMClassificationLearningControl svmBinaryClassificationLearningControl = new SVMClassificationLearningControl(trainingInputColumns);
                    modelTabPage.Controls.Add(svmBinaryClassificationLearningControl);

                    break;
                case 7:
                    ANNClassificationLearningControl annClassificationLearningControl = new ANNClassificationLearningControl(trainingInputColumns, trainingClassIndexColumn, features, classes);
                    modelTabPage.Controls.Add(annClassificationLearningControl);

                    annClassificationLearningControl.TrainingStarted += onANNTrainingStarted;
                    annClassificationLearningControl.TrainingUpdate += onANNTrainingUpdate;
                    annClassificationLearningControl.ModelConverged += onANNConverged;
                    annClassificationLearningControl.TrainingStopped += onANNTrainingStopped;

                    break;
            }

            ModelLoaded(EventArgs.Empty);
        }

        private void onModelLoaded(EventArgs e)
        {
            classifier = null;
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
                object classifier = null;

                if (modelTabPage.Controls[0].GetType() == typeof(LogisticRegressionLearningControl))
                {
                    LogisticRegressionLearningControl logisticRegressionLearningControl = (LogisticRegressionLearningControl)modelTabPage.Controls[0];
                    if (logisticRegressionLearningControl.IterativeReweightedLeastSquaresRadioButton.Checked)
                    {
                        IterativeReweightedLeastSquares<LogisticRegression> iterativeReweightedLeastSquares = new IterativeReweightedLeastSquares<LogisticRegression>()
                        {
                            Tolerance = Convert.ToDouble(logisticRegressionLearningControl.ToleranceNumericUpDown.Value),
                            MaxIterations = Convert.ToInt32(logisticRegressionLearningControl.MaxIterationNumericUpDown.Value),
                            Regularization = Convert.ToDouble(logisticRegressionLearningControl.RegularizationNumericUpDown.Value)
                        };
                        classifier = iterativeReweightedLeastSquares.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else // LogisticGradientDescentRadioButton.Checked
                    {
                        LogisticGradientDescent logisticGradientDescent = new LogisticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(logisticRegressionLearningControl.ToleranceNumericUpDown.Value),
                            MaxIterations = Convert.ToInt32(logisticRegressionLearningControl.MaxIterationNumericUpDown.Value),
                            LearningRate = Convert.ToDouble(logisticRegressionLearningControl.LearningRateNumericUpDown.Value),
                            Stochastic = logisticRegressionLearningControl.StochasticCheckBox.Checked
                        };
                        classifier = logisticGradientDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(KNearestNeighborsLearningControl))
                {
                    KNearestNeighborsLearningControl kNearestNeighborsLearningControl = (KNearestNeighborsLearningControl)modelTabPage.Controls[0];
                    classifier = new KNearestNeighbors(Convert.ToInt32(kNearestNeighborsLearningControl.KNumericUpDown.Value));
                    ((KNearestNeighbors)classifier).Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(MinimumMeanDistanceLearningControl))
                {
                    classifier = new MinimumMeanDistanceClassifier();
                    ((MinimumMeanDistanceClassifier)classifier).Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(NaiveBayesLearningControl))
                {
                    NaiveBayesLearning<NormalDistribution> naiveBayesLearning = new NaiveBayesLearning<NormalDistribution>();
                    classifier = naiveBayesLearning.Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(DecisionTreeLearningControl))
                {
                    DecisionTreeLearningControl decisionTreeLearningControl = (DecisionTreeLearningControl)modelTabPage.Controls[0];
                    DecisionVariable[] decisionVariables = new DecisionVariable[features.Length];
                    for (int columnIndex = 0; columnIndex < features.Length; columnIndex++)
                        decisionVariables[columnIndex] = new DecisionVariable(features[columnIndex], DecisionVariableKind.Continuous);
                    C45Learning c45Learning = new C45Learning(decisionVariables);
                    classifier = c45Learning.Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(RandomForestLearningControl))
                {
                    RandomForestLearningControl randomForestLearningControl = (RandomForestLearningControl)modelTabPage.Controls[0];
                    RandomForestLearning randomForestLearning = new RandomForestLearning()
                    {
                        NumberOfTrees = Convert.ToInt32(randomForestLearningControl.NumberOfTreesNumericUpDown.Value),
                        SampleRatio = Convert.ToDouble(randomForestLearningControl.SampleRatioNumericUpDown.Value)
                    };
                    classifier = randomForestLearning.Learn(trainingInputColumns, trainingClassIndexColumn);
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(SVMClassificationLearningControl))
                {
                    SVMClassificationLearningControl svmBinaryClassificationLearningControl = (SVMClassificationLearningControl)modelTabPage.Controls[0];
                    IKernel kernel = svmBinaryClassificationLearningControl.CreateKernel();
                    if (svmBinaryClassificationLearningControl.SequentialMinimalOptimizationRadioButton.Checked)
                    {
                        SequentialMinimalOptimization<IKernel> sequentialMinimalOptimization = new SequentialMinimalOptimization<IKernel>()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = kernel
                        };
                        classifier = sequentialMinimalOptimization.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LeastSquaresRadioButton.Checked)
                    {
                        LeastSquaresLearning leastSquaresLearning = new LeastSquaresLearning()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = kernel
                        };
                        classifier = leastSquaresLearning.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LinearCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                        LinearCoordinateDescent linearCoordinateDescent = new LinearCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = linearCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LinearDualCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Dual Coordinate Descent method can only use linear kernel!");
                        LinearDualCoordinateDescent linearDualCoordinateDescent = new LinearDualCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = linearDualCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.LinearNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Newton method can only use linear kernel!");
                        LinearNewtonMethod linearNewtonMethod = new LinearNewtonMethod()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = linearNewtonMethod.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.ProbabilisticCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Coordinate Descent method can only use linear kernel!");
                        ProbabilisticCoordinateDescent probabilisticCoordinateDescent = new ProbabilisticCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = probabilisticCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.ProbabilisticDualCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Dual Coordinate Descent method can only use linear kernel!");
                        ProbabilisticDualCoordinateDescent probabilisticDualCoordinateDescent = new ProbabilisticDualCoordinateDescent()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = probabilisticDualCoordinateDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.ProbabilisticNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Newton method can only use linear kernel!");
                        ProbabilisticNewtonMethod probabilisticNewtonMethod = new ProbabilisticNewtonMethod()
                        {
                            Complexity = Convert.ToDouble(svmBinaryClassificationLearningControl.ComplexityNumericUpDown.Value),
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            PositiveWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.PositiveWeightNumericUpDown.Value),
                            NegativeWeight = Convert.ToDouble(svmBinaryClassificationLearningControl.NegativeWeightNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = probabilisticNewtonMethod.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmBinaryClassificationLearningControl.StochasticGradientDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Stochastic Gradient Descent method can only use linear kernel!");
                        StochasticGradientDescent stochasticGradientDescent = new StochasticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = stochasticGradientDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else // svmBinaryClassificationLearningControl.StochasticGradientDescentRadioButton.Checked
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Averaged Stochastic Gradient Descent method can only use linear kernel!");
                        AveragedStochasticGradientDescent averagedStochasticGradientDescent = new AveragedStochasticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(svmBinaryClassificationLearningControl.ToleranceNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        classifier = averagedStochasticGradientDescent.Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(ANNClassificationLearningControl))
                {
                    ANNClassificationLearningControl annClassificationLearningControl = (ANNClassificationLearningControl)modelTabPage.Controls[0];
                    if (!annClassificationLearningControl.IsNetworkBuilt)
                        throw new Exception("The neural network was not built!");

                    annClassificationLearningControl.StartTraining();

                    Cursor = Cursors.Default;
                    return;
                }

                ModelTrained(new ModelTrainedEventArgs() { Model = classifier });
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
            classifier = e.Model;

            if (classifier.GetType() == typeof(LogisticRegression))
            {
                serializedLearningParameters = ((LogisticRegressionLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                modelTabPage.Controls.Add(new LogisticRegressionModelControl((LogisticRegression)classifier, features));
                modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;
            }
            if (classifier.GetType() == typeof(KNearestNeighbors))
            {
                serializedLearningParameters = ((KNearestNeighborsLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
            }
            else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
            {
                modelTabPage.Controls.Add(new NaiveBayesModelControl((NaiveBayes<NormalDistribution>)classifier, features, target, classes.Values.ToArray()));
                modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;
            }
            else if (classifier.GetType() == typeof(DecisionTree))
            {
                serializedLearningParameters = ((DecisionTreeLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                modelTabPage.Controls.Add(new DecisionTreeModelControl((DecisionTree)classifier, trainingInputColumns, trainingClassIndexColumn, features, classes));
                modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;

                ((DecisionTreeModelControl)modelTabPage.Controls[1]).ModelModified += onModelModified; 
            }
            else if (classifier.GetType() == typeof(RandomForest))
            {
                serializedLearningParameters = ((RandomForestLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                modelTabPage.Controls.Add(new RandomForestModelControl((RandomForest)classifier, trainingInputColumns, trainingClassIndexColumn, features, classes));
                modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;

                ((RandomForestModelControl)modelTabPage.Controls[1]).ModelModified += onModelModified;

            }
            else if (classifier.GetType() == typeof(SupportVectorMachine))
            {
                serializedLearningParameters = ((SVMClassificationLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                serializedLearningParameters = ((SVMClassificationLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                SupportVectorMachine<IKernel> svm = (SupportVectorMachine<IKernel>)classifier;
                if (svm.SupportVectors != null && svm.SupportVectors.Length > 0)
                {
                    modelTabPage.Controls.Add(new SVMClassificationModelControl(svm.SupportVectors, svm.Weights, features, target, trainingInputColumns, trainingOutputColumn));
                    modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;
                } 
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
            {
                serializedLearningParameters = ((SVMClassificationLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                SupportVectorMachine<IKernel<double[]>, double[]> svm = (SupportVectorMachine<IKernel<double[]>, double[]>)classifier;
                if (svm.SupportVectors != null && svm.SupportVectors.Length > 0)
                {
                    modelTabPage.Controls.Add(new SVMClassificationModelControl(svm.SupportVectors, svm.Weights, features, target, trainingInputColumns, trainingOutputColumn));
                    modelTabPage.Controls[1].Left = modelTabPage.Controls[0].Width + 5;
                }  
            }
            else if (classifier.GetType() == typeof(ActivationNetwork))
            {
                serializedLearningParameters = ((ANNClassificationLearningControl)modelTabPage.Controls[0]).GetLearningParameters();

                if (!((ANNClassificationLearningControl)modelTabPage.Controls[0]).IsNetworkDiagramBuilt)
                    ((ANNClassificationLearningControl)modelTabPage.Controls[0]).BuildNetworkDiagram();
            }

            modelTabPage.BackColor = Color.LightGreen;
            taskTabControl.SelectTab(1);

            makePredictionClassificationControl.Classifier = classifier;
            makePredictionClassificationControl.Classes = classes;
            makePredictionClassificationControl.ColumnNames = features.Concatenate(target);
            makePredictionClassificationControl.Enabled = true;

            if (features.Length == 2)
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
            classifier = null;
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
            classifier = e.Model;

            if (features.Length == 2)
            {
                modelVisualizationGroupBox.Visible = true;
                update2dVisualization();
            }
            else
                modelVisualizationGroupBox.Visible = false;
        }

        private void onANNTrainingStopped(ModelModifiedEventArgs e)
        {
            classifier = e.Model;

            if (features.Length == 2)
            {
                modelVisualizationGroupBox.Visible = true;
                update2dVisualization();
            }
            else
                modelVisualizationGroupBox.Visible = false;
        }

        private void onModelModified(ModelModifiedEventArgs e)
        {
            classifier = e.Model;

            if (features.Length == 2)
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
            double[] xValues = trainingInputColumns.GetColumn(0);
            double[] yValues = trainingInputColumns.GetColumn(1);

            //Generate a map
            double[][] map = Matrix.Mesh(xValues.GetRange(), 200, yValues.GetRange(), 200);

            int[] outputClassIndex = new int[map.Length];

            if (classifier.GetType() == typeof(LogisticRegression))
            {
                bool[] result = ((LogisticRegression)classifier).Decide(map);
                for (int i = 0; i < result.Length; i++)
                    outputClassIndex[i] = result[i] ? 1 : 0;
            }
            else if (classifier.GetType() == typeof(KNearestNeighbors))
            {
                outputClassIndex = ((KNearestNeighbors)classifier).Decide(map);
            }
            else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
            {
                outputClassIndex = ((MinimumMeanDistanceClassifier)classifier).Decide(map);
            }
            else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
            {
                outputClassIndex = ((NaiveBayes<NormalDistribution>)classifier).Decide(map);
            }
            else if (classifier.GetType() == typeof(DecisionTree))
            {
                outputClassIndex = ((DecisionTree)classifier).Decide(map);
            }
            else if (classifier.GetType() == typeof(RandomForest))
            {
                outputClassIndex = ((RandomForest)classifier).Decide(map);
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine))
            {
                bool[] result = ((SupportVectorMachine)classifier).Decide(map);
                for (int i = 0; i < result.Length; i++)
                    outputClassIndex[i] = result[i] ? 1 : 0;
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                bool[] result = ((SupportVectorMachine<IKernel>)classifier).Decide(map);
                for (int i = 0; i < result.Length; i++)
                    outputClassIndex[i] = result[i] ? 1 : 0;
            }
            else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
            {
                bool[] result = ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(map);
                for (int i = 0; i < result.Length; i++)
                    outputClassIndex[i] = result[i] ? 1 : 0;
            }
            else if (classifier.GetType() == typeof(ActivationNetwork))
            {
                for (int i = 0; i < map.Length; i++)
                {
                    double[] output = ((ActivationNetwork)classifier).Compute(map[i]);
                    outputClassIndex[i] = output.IndexOf(output.Max());
                }
            }

            // Update plot
            PlotModel plotModel = new PlotModel();

            for (int i = 0; i < classes.Count; i++)
            {
                ScatterSeries series = new ScatterSeries()
                {
                    Title = classes[i],
                    MarkerSize = 1
                };
                plotModel.Series.Add(series);
            }

            for (int i = 0; i < map.Length; i++)
                ((ScatterSeries)plotModel.Series[outputClassIndex[i]]).Points.Add(new ScatterPoint(map[i][0], map[i][1]));

            LinearAxis xAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Title = features[0],
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray,
                Minimum = xValues.Min(),
                Maximum = xValues.Max(),
            };
            LinearAxis yAxis = new LinearAxis()
            {
                Position = AxisPosition.Left,
                Title = features[1],
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray,
                Minimum = yValues.Min(),
                Maximum = yValues.Max()
            };
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.Legends.Add(new OxyPlot.Legends.Legend()
            {
                LegendTitle = "Classes",
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

            if (!modelTrained || classifier == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            taskTabControl.SelectTab(2);
            Cursor = Cursors.WaitCursor;

            try
            {
                int[] predictedClassIndexColumn = null;
                if (classifier.GetType() == typeof(LogisticRegression))
                {
                    bool[] predictedColumn = ((LogisticRegression)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(KNearestNeighbors))
                {
                    predictedClassIndexColumn = ((KNearestNeighbors)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                {
                    predictedClassIndexColumn = ((MinimumMeanDistanceClassifier)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                {
                    predictedClassIndexColumn = ((NaiveBayes<NormalDistribution>)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(DecisionTree))
                {
                    predictedClassIndexColumn = ((DecisionTree)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(RandomForest))
                {
                    predictedClassIndexColumn = ((RandomForest)classifier).Decide(testInputColumns);
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    bool[] predictedColumn = ((SupportVectorMachine<IKernel>)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    bool[] predictedColumn = ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine))
                {
                    bool[] predictedColumn = ((SupportVectorMachine)classifier).Decide(testInputColumns);
                    predictedClassIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        predictedClassIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(ActivationNetwork))
                {
                    ActivationNetwork ann = (ActivationNetwork)classifier;

                    predictedClassIndexColumn = new int[testInputColumns.Length];
                    for (int i = 0; i < testInputColumns.Length; i++)
                    {
                        double[] output = ann.Compute(testInputColumns[i]);
                        predictedClassIndexColumn[i] = output.IndexOf(output.Max());
                    }
                }

                DataTable testDataTable = testInputColumns.ToTable(features);
                testDataTable.Columns.Add(target);
                testDataTable.Columns.Add(target + " (predicted)");

                for (int i = 0; i < testDataTable.Rows.Count; i++)
                {
                    testDataTable.Rows[i][target] = testOutputColumn[i];
                    testDataTable.Rows[i][target + " (predicted)"] = classes[predictedClassIndexColumn[i]];
                }

                for (int i = 0; i < testDataTable.Columns.Count; i++)
                    testDataTable.Columns[i].ReadOnly = false;

                testBinaryClassificationControl.TestDataTable = testDataTable;
                testBinaryClassificationControl.Enabled = true;

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
            if (classifier == null)
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
                int[] classIndexColumn = null;
                if (classifier.GetType() == typeof(LogisticRegression))
                {
                    bool[] predictedColumn = ((LogisticRegression)classifier).Decide(inputColumns);
                    classIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(MultinomialLogisticRegression))
                {
                    classIndexColumn = ((MultinomialLogisticRegression)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(KNearestNeighbors))
                {
                    classIndexColumn = ((KNearestNeighbors)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(MinimumMeanDistanceClassifier))
                {
                    classIndexColumn = ((MinimumMeanDistanceClassifier)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(NaiveBayes<NormalDistribution>))
                {
                    classIndexColumn = ((NaiveBayes<NormalDistribution>)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(DecisionTree))
                {
                    classIndexColumn = ((DecisionTree)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(RandomForest))
                {
                    classIndexColumn = ((RandomForest)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel>))
                {
                    bool[] predictedColumn = ((SupportVectorMachine<IKernel>)classifier).Decide(inputColumns);
                    classIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    bool[] predictedColumn = ((SupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputColumns);
                    classIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(SupportVectorMachine))
                {
                    bool[] predictedColumn = ((SupportVectorMachine)classifier).Decide(inputColumns);
                    classIndexColumn = new int[predictedColumn.Length];
                    for (int i = 0; i < predictedColumn.Length; i++)
                        classIndexColumn[i] = predictedColumn[i] ? 1 : 0;
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
                {
                    classIndexColumn = ((MulticlassSupportVectorMachine<IKernel>)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel<double[]>, double[]>))
                {
                    classIndexColumn = ((MulticlassSupportVectorMachine<IKernel<double[]>, double[]>)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<Linear>))
                {
                    classIndexColumn = ((MulticlassSupportVectorMachine<Linear>)classifier).Decide(inputColumns);
                }
                else if (classifier.GetType() == typeof(ActivationNetwork))
                {
                    ActivationNetwork ann = (ActivationNetwork)classifier;
                    classIndexColumn = new int[inputColumns.Length];
                    for (int i = 0; i < inputColumns.Length; i++)
                    {
                        double[] output = ann.Compute(inputColumns[i]);
                        classIndexColumn[i] = output.IndexOf(output.Max());
                    }
                }

                makePredictionClassificationControl.UpdatePredictionResult(predictionDataset, classIndexColumn);
                
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
