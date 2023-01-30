using Accord;
using Accord.IO;
using Accord.Math;
using Accord.Statistics.Analysis;
using JadeML.Classification;
using MindFusion.Diagramming;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Accord.Statistics.Kernels;
using System.Text;

namespace JadeML.DA
{
    public partial class DATask : Form
    {
        // Fields
        private KernelDiscriminantAnalysis kda = null;
        private KernelDiscriminantAnalysis.Pipeline kdaPipeline = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();
        private string[] features = null;
        private string target = "";
        private string[] discriminants = null;

        private DataTable dataset = null;

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private string[] trainingOutputColumn = null;
        private int[] trainingClassIndexColumn = null;
        private DataTable projectedTrainingDataset = null;

        private DataTable testingDataset = null;
        private double[][] testInputColumns = null;
        private string[] testOutputColumn = null;

        private DataTable predictionDataset = null;
        private DataTable projectedPreditionDataset = null;

        private string serializedLearningParameters = "";

        private bool modelTrained = false;

        // Property
        public bool IsDatasetLoaded { get { return dataset != null; } }
        public bool IsTrainingDatasetLoaded { get { return trainingDataset != null; } }
        public bool IsTestingDatasetLoaded { get { return testingDataset != null; } }
        public bool IsPredictionDatasetLoaded { get { return predictionDataset != null; } }
        public bool IsModelLoaded { get { return true; } }
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
        public DATask()
        {
            InitializeComponent();

            DatasetLoaded += OnDatasetLoaded;
            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            TestingDatasetLoaded += OnTestingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += (EventArgs e) => { return; };
            ModelTrained += onModelTrained;
        }

        public DATask(object model, DataTable dataset, DataTable trainingDataset, DataTable testingDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            DatasetLoaded += OnDatasetLoaded;
            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            TestingDatasetLoaded += OnTestingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += (EventArgs e) => { return; };
            ModelTrained += onModelTrained;

            DatasetLoaded(new DatasetLoadedEventArgs { Dataset = dataset });
            TrainingDatasetLoaded(new DatasetLoadedEventArgs { Dataset = trainingDataset });
            TestingDatasetLoaded(new DatasetLoadedEventArgs { Dataset = testingDataset });

            SetLearningParameters(serializedLearningParameters);

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
            modelNode.Text = "DA";
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

            ShapeNode predictionNode = taskDiagram.Factory.CreateShapeNode(55, 45, 30, 10, Shapes.RoundRect);
            predictionNode.Text = "Projection\n(prediction dataset)";
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

            ShapeNode projectedTrainingDatasetNode = taskDiagram.Factory.CreateShapeNode(110, 45, 30, 10, Shapes.RoundRect);
            projectedTrainingDatasetNode.Text = "Projection\n(training dataset)";
            projectedTrainingDatasetNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Orange);
            projectedTrainingDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link8 = taskDiagram.Factory.CreateDiagramLink(modelNode, projectedTrainingDatasetNode);
            link8.AllowMoveStart = false;
            link8.AllowMoveEnd = false;
        }

        private void BinaryClassificationTask_Resize(object sender, EventArgs e)
        {
            taskSplitContainer.Height = Height - 64;
        }
        
        private void BinaryClassificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (kda != null && modelTrained)
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
            if (!modelTrained || kda == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 5; // da
                    byte modelIndex = 0;

                    kda.Save(out byte[] serializedModel);
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

        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            int kernel = 0;
            if (gaussianKernelRadioButton.Checked)
                kernel = 1;
            else if (laplacianKernelRadioButton.Checked)
                kernel = 2;
            else if (sigmoidKernelRadioButton.Checked)
                kernel = 3;
            learningParameters.Add("kernel", kernel.ToString());
            learningParameters.Add("polynomial degree", polynomialDegreeNumericUpDown.Value.ToString());
            learningParameters.Add("polynomial constant", polynomialConstantNumericUpDown.Value.ToString());
            learningParameters.Add("gaussian sigma", gaussianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("laplacian sigma", laplacianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid alpha", sigmoidAlphaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid constant", sigmoidConstantNumericUpDown.Value.ToString());
            learningParameters.Add("number of discriminants", numberOfDiscriminantsNumericUpDown.Value.ToString());
            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);

            int kernel = Convert.ToInt32(learningParameters["kernel"]);
            if (kernel == 1)
                gaussianKernelRadioButton.Checked = true;
            else if (kernel == 2)
                laplacianKernelRadioButton.Checked = true;
            else if (kernel == 3)
                sigmoidKernelRadioButton.Checked = true;
            polynomialDegreeNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial degree"]);
            polynomialConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial constant"]);
            gaussianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["gaussian sigma"]);
            laplacianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["laplacian sigma"]);
            sigmoidAlphaNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid alpha"]);
            sigmoidConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid constant"]);
            numberOfDiscriminantsNumericUpDown.Value = Convert.ToDecimal(learningParameters["number of discriminants"]);
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
                case "Projection\n(training dataset)":
                    datasetLabel.Text = "Projected training dataset";
                    datasetDataGridView.DataSource = null;
                    if (projectedTrainingDataset != null)
                    {
                        datasetDataGridView.DataSource = projectedTrainingDataset;
                        for (int i = 0; i < datasetDataGridView.Rows.Count; i++)
                            if (datasetDataGridView.Rows[i].Cells[datasetDataGridView.ColumnCount - 1].Value == datasetDataGridView.Rows[i].Cells[datasetDataGridView.ColumnCount - 2].Value)
                                datasetDataGridView.Rows[i].Cells[datasetDataGridView.ColumnCount - 1].Style.BackColor = Color.LightGreen;
                            else
                                datasetDataGridView.Rows[i].Cells[datasetDataGridView.ColumnCount - 1].Style.BackColor = Color.Red;
                    }
                    taskTabControl.SelectTab(0);
                    break;
                case "DA":
                    taskTabControl.SelectTab(1);
                    break;
                case "Evaluation":
                    taskTabControl.SelectTab(2);
                    break;
                case "Projection\n(prediction dataset)":
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

            if (features == null)
            {
                features = new string[trainingDataset.Columns.Count];
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

            numberOfDiscriminantsNumericUpDown.Maximum = features.Length;
            numberOfDiscriminantsNumericUpDown.Value = features.Length;

            modelTableLayoutPanel.Enabled = true;
            ModelLoaded(EventArgs.Empty);
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
            else if (datasetLabel.Text == "Projected training dataset" && projectedTrainingDataset != null)
            {
                VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(projectedTrainingDataset, "Projected training dataset");
                visualizeClassificationDataDialog.Show(this);
            }
        }

        // Kernel
        private IKernel createKernel()
        {
            if (gaussianKernelRadioButton.Checked)
                return new Gaussian((double)gaussianSigmaNumericUpDown.Value);
            else if (polynomialKernelRadioButton.Checked)
            {
                if (polynomialDegreeNumericUpDown.Value == 1)
                    return new Linear((double)polynomialConstantNumericUpDown.Value);
                return new Polynomial((int)polynomialDegreeNumericUpDown.Value, (double)polynomialConstantNumericUpDown.Value);
            }
            else if (laplacianKernelRadioButton.Checked)
                return new Laplacian((double)laplacianSigmaNumericUpDown.Value);
            else // sigmoidKernelRadioButton.Checked
                return new Sigmoid((double)sigmoidAlphaNumericUpDown.Value, (double)sigmoidConstantNumericUpDown.Value);
        }

        private void gaussianEstimateButton_Click(object sender, EventArgs e)
        {
            Gaussian gaussian = Gaussian.Estimate(trainingInputColumns, trainingInputColumns.Length);
            gaussianSigmaNumericUpDown.Value = (decimal)gaussian.Sigma;
        }

        private void laplacianEstimateButton_Click(object sender, EventArgs e)
        {
            Laplacian laplacian = Laplacian.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);
            laplacianSigmaNumericUpDown.Value = (decimal)laplacian.Sigma;
        }

        private void sigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            Sigmoid sigmoid = Sigmoid.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                sigmoidAlphaNumericUpDown.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                sigmoidConstantNumericUpDown.Value = (decimal)sigmoid.Constant;
        }
        
        // Training
        public void TrainModel()
        {
            if (trainingInputColumns == null)
            {
                MessageBox.Show(this, "Training dataset cannot be empty!", "Training dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modelTabPage.BackColor = SystemColors.Control;
            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            KernelDiscriminantAnalysis kda = null;
            IKernel kernel = createKernel();
            try
            {
                kda = new KernelDiscriminantAnalysis(kernel)
                {
                    NumberOfOutputs = Convert.ToInt32(numberOfDiscriminantsNumericUpDown.Value)
                };
                kda.Learn(trainingInputColumns, trainingClassIndexColumn);

                ModelTrained(new ModelTrainedEventArgs() { Model = kda });
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
            kda = (KernelDiscriminantAnalysis)e.Model;
            kdaPipeline = kda.Learn(trainingInputColumns, trainingClassIndexColumn);
            int[] predictedClassIndexColumn = kdaPipeline.Decide(trainingInputColumns);

            serializedLearningParameters = GetLearningParameters();

            modelTrained = true;

            discriminants = new string[kda.Discriminants.Count];
            discriminentComboBox.Items.Clear();
            for (int i = 0; i < kda.Discriminants.Count; i++)
            {
                discriminants[i] = "Discriminant " + (i + 1).ToString();
                discriminentComboBox.Items.Add("Discriminant " + (i + 1).ToString());
            }
            discriminentComboBox.SelectedIndex = 0;

            discriminantsGroupBox.Enabled = true;

            double[][] projectionResult = kda.Transform(trainingInputColumns);
            int outputColumnIndex = discriminants.Length;
            projectedTrainingDataset = projectionResult.ToTable(discriminants);
            projectedTrainingDataset.Columns.Add(target);
            for (int i = 0; i < predictedClassIndexColumn.Length; i++)
                projectedTrainingDataset.Rows[i][outputColumnIndex] = classes[trainingClassIndexColumn[i]];
            projectedTrainingDataset.Columns.Add(target + " (projected)");
            for (int i = 0; i < predictedClassIndexColumn.Length; i++)
                projectedTrainingDataset.Rows[i][outputColumnIndex + 1] = classes[predictedClassIndexColumn[i]];

            singleProjectionInputDataGridView.Columns.Clear();
            foreach (string feature in features)
                singleProjectionInputDataGridView.Columns.Add(feature, feature);
            singleProjectionInputDataGridView.Rows.Add();

            singleProjectionPCDataGridView.Columns.Clear();
            foreach (string discriminant in discriminants)
                singleProjectionPCDataGridView.Columns.Add(discriminant, discriminant);
            singleProjectionPCDataGridView.Columns.Add(target, target);
            singleProjectionPCDataGridView.Rows.Add();

            singleProjectionGroupBox.Enabled = true;
            datasetProjectionGroupBox.Enabled = true;

            modelTabPage.BackColor = Color.LightGreen;
            taskTabControl.SelectTab(1);

            statusLabel.Text = "Status: Model trained.";
            Cursor = Cursors.Default;
        }

        // Discriminants
        private void discriminantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!modelTrained)
                return;

            Discriminant discriminant = kda.Discriminants[discriminentComboBox.SelectedIndex];
            eigenvalueTextBox.Text = discriminant.Eigenvalue.ToString();
            proportionTextBox.Text = discriminant.Proportion.ToString();
            eigenvectorDataGridView.DataSource = discriminant.Eigenvector.ToJagged().ToTable();
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

            if (!modelTrained || kda == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            taskTabControl.SelectTab(2);
            Cursor = Cursors.WaitCursor;

            try
            {
                int[] predictedClassIndexColumn = null;

                predictedClassIndexColumn = kdaPipeline.Decide(testInputColumns);

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

                testMulticlassClassificationControl.TestDataTable = testDataTable;
                testMulticlassClassificationControl.Enabled = true;

                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        // Prediction
        private void projectButton_Click(object sender, EventArgs e)
        {
            if (kda == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                double[] inputs = new double[features.Length];
                for (int i = 0; i < features.Length; i++)
                    inputs[i] = Convert.ToDouble(singleProjectionInputDataGridView.Rows[0].Cells[i].Value);

                double[] projectedData = kda.Transform(inputs);
                int classIndex = kdaPipeline.Decide(inputs);
                for (int i = 0; i < discriminants.Length; i++)
                    singleProjectionPCDataGridView.Rows[0].Cells[i].Value = projectedData[i].ToString();
                singleProjectionPCDataGridView.Rows[0].Cells[singleProjectionPCDataGridView.Columns.Count - 1].Value = classes[classIndex];

                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        public void MakeDatasetPrediction()
        {
            if (kda == null)
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

                projectedPreditionDataset = kda.Transform(inputColumns).ToTable(discriminants);

                int[] classIndexColumns = kdaPipeline.Decide(inputColumns);
                projectedPreditionDataset.Columns.Add(target, typeof(string));
                for (int i = 0; i < classIndexColumns.Length; i++)
                    projectedPreditionDataset.Rows[i][discriminants.Length] = classes[classIndexColumns[i]];

                datasetProjectionDataGridView.DataSource = null;
                datasetProjectionDataGridView.DataSource = projectedPreditionDataset;
                for (int i = 0; i < datasetProjectionDataGridView.Rows.Count; i++)
                    datasetProjectionDataGridView.Rows[i].Cells[datasetProjectionDataGridView.ColumnCount - 1].Style.BackColor = Color.LightGreen;

                visualizeProjectedDataButton.Enabled = true;
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        private void visualizeProjectedDataButton_Click(object sender, EventArgs e)
        {
            VisualizeClassificationDataDialog visualizeClassificationDataDialog = new VisualizeClassificationDataDialog(projectedPreditionDataset, "Projected prediction dataset");
            visualizeClassificationDataDialog.Show(this);
        }
    }
}
