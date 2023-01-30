using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.VectorMachines;
using Accord.Math;
using Accord.Neuro;
using Accord.Statistics.Analysis;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Linear;
using JadeML.Classification;
using JadeML.Clustering;
using JadeML.DA;
using JadeML.PCA;
using JadeML.Regression;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JadeML
{
    public partial class MainForm : Form
    {
        // Constructor
        public MainForm()
        {
            InitializeComponent();
        }

        // Menu
        private void newTaskRibbonButton_Click(object sender, EventArgs e)
        {
            NewTaskDialog newTaskDialog = new NewTaskDialog();
            if (newTaskDialog.ShowDialog(this) != DialogResult.OK)
                return;

            switch (newTaskDialog.SelectedTask)
            {
                case "Binary Classification":
                    BinaryClassificationTask binaryClassificationTask = new BinaryClassificationTask
                    {
                        MdiParent = this
                    };
                    binaryClassificationTask.DatasetLoaded += activeMdiChild_DatasetLoaded;
                    binaryClassificationTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                    binaryClassificationTask.ModelLoaded += activeMdiChild_ModelLoaded;
                    binaryClassificationTask.ModelTrained += activeMdiChild_ModelTrained;
                    binaryClassificationTask.FormClosed += mdiChildClosed;
                    binaryClassificationTask.Show();
                    binaryClassificationTask.Activate();
                    break;
                case "Multiclass Classification":
                    MulticlassClassificationTask multiclassClassificationTask = new MulticlassClassificationTask
                    {
                        MdiParent = this
                    };
                    multiclassClassificationTask.DatasetLoaded += activeMdiChild_DatasetLoaded;
                    multiclassClassificationTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                    multiclassClassificationTask.ModelLoaded += activeMdiChild_ModelLoaded;
                    multiclassClassificationTask.ModelTrained += activeMdiChild_ModelTrained;
                    multiclassClassificationTask.FormClosed += mdiChildClosed;
                    multiclassClassificationTask.Show();
                    multiclassClassificationTask.Activate();
                    break;
                case "Regression":
                    RegressionTask regressionTask = new RegressionTask
                    {
                        MdiParent = this
                    };
                    regressionTask.DatasetLoaded += activeMdiChild_DatasetLoaded;
                    regressionTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                    regressionTask.ModelLoaded += activeMdiChild_ModelLoaded;
                    regressionTask.ModelTrained += activeMdiChild_ModelTrained;
                    regressionTask.FormClosed += mdiChildClosed;
                    regressionTask.Show();
                    regressionTask.Activate();
                    break;
                case "Clustering":
                    ClusteringTask clusteringTask = new ClusteringTask
                    {
                        MdiParent = this
                    };
                    clusteringTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                    clusteringTask.ModelLoaded += activeMdiChild_ModelLoaded;
                    clusteringTask.ModelTrained += activeMdiChild_ModelTrained;
                    clusteringTask.FormClosed += mdiChildClosed;
                    clusteringTask.Show();
                    clusteringTask.Activate();
                    break;
                case "PCA":
                    PCATask pcaTask = new PCATask
                    {
                        MdiParent = this
                    };
                    pcaTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                    pcaTask.ModelLoaded += activeMdiChild_ModelLoaded;
                    pcaTask.ModelTrained += activeMdiChild_ModelTrained;
                    pcaTask.FormClosed += mdiChildClosed;
                    pcaTask.Show();
                    pcaTask.Activate();
                    break;
                case "DA":
                    DATask daTask = new DATask
                    {
                        MdiParent = this
                    };
                    daTask.DatasetLoaded += activeMdiChild_DatasetLoaded;
                    daTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                    daTask.ModelLoaded += activeMdiChild_ModelLoaded;
                    daTask.ModelTrained += activeMdiChild_ModelTrained;
                    daTask.FormClosed += mdiChildClosed;
                    daTask.Show();
                    daTask.Activate();
                    break;
                default:
                    return;
            }
        }

        private void openRibbonButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;
            if (!File.Exists(filePath))
                return;

            try
            {
                byte taskIndex = 0;
                byte modelIndex = 0;
                string serializedLearningParameters = "";
                int modelSize = 0;
                byte[] serializedModel = null;
                int dataSize = 0;
                byte[] serializedData = null;
                int trainingDatasetSize = 0;
                byte[] serializedTrainingDataset = null;
                int testDatasetSize = 0;
                byte[] serializedTestDataset = null;
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.UTF8, false))
                    {
                        taskIndex = binaryReader.ReadByte();
                        modelIndex = binaryReader.ReadByte();
                        serializedLearningParameters = binaryReader.ReadString();
                        modelSize = binaryReader.ReadInt32();
                        serializedModel = binaryReader.ReadBytes(modelSize);
                        dataSize = binaryReader.ReadInt32();
                        serializedData = binaryReader.ReadBytes(dataSize);
                        trainingDatasetSize = binaryReader.ReadInt32();
                        serializedTrainingDataset = binaryReader.ReadBytes(trainingDatasetSize);
                        testDatasetSize = binaryReader.ReadInt32();
                        serializedTestDataset = binaryReader.ReadBytes(testDatasetSize);
                    }
                }

                DataTable data = null;
                DataTable trainingDataset = null;
                DataTable testDataset = null;
                if (dataSize > 0)
                    data = Serializer.Load<DataTable>(serializedData);
                if (trainingDatasetSize > 0)
                    trainingDataset = Serializer.Load<DataTable>(serializedTrainingDataset);
                if (testDatasetSize > 0)
                    testDataset = Serializer.Load<DataTable>(serializedTestDataset);

                object model = null;
                switch (taskIndex)
                {
                    case 0: // binary classification
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<LogisticRegression>(serializedModel);

                                break;
                            case 1:
                                model = Serializer.Load<KNearestNeighbors>(serializedModel);

                                break;
                            case 2:
                                model = Serializer.Load<MinimumMeanDistanceClassifier>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<NaiveBayes<NormalDistribution>>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<DecisionTree>(serializedModel);

                                break;
                            case 5:
                                model = Serializer.Load<RandomForest>(serializedModel);

                                break;
                            case 6:
                                model = Serializer.Load<SupportVectorMachine>(serializedModel);

                                break;
                            case 7:
                                model = Serializer.Load<SupportVectorMachine<IKernel>>(serializedModel);

                                break;
                            case 8:
                                model = Serializer.Load<SupportVectorMachine<IKernel<double[]>, double[]>>(serializedModel);

                                break;
                            case 9:
                                model = Serializer.Load<ActivationNetwork>(serializedModel);

                                break;
                        }

                        BinaryClassificationTask binaryClassificationTask = new BinaryClassificationTask(model, data, trainingDataset, testDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        binaryClassificationTask.DatasetLoaded += activeMdiChild_DatasetLoaded;
                        binaryClassificationTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                        binaryClassificationTask.ModelLoaded += activeMdiChild_ModelLoaded;
                        binaryClassificationTask.ModelTrained += activeMdiChild_ModelTrained;
                        binaryClassificationTask.FormClosed += mdiChildClosed;
                        binaryClassificationTask.Show();
                        binaryClassificationTask.Activate();

                        saveRibbonButton.Enabled = true;
                        closeRibbonButton.Enabled = true;

                        break;
                    case 1: // multiclass classification
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<MultinomialLogisticRegression>(serializedModel);

                                break;
                            case 1:
                                model = Serializer.Load<KNearestNeighbors>(serializedModel);

                                break;
                            case 2:
                                model = Serializer.Load<MinimumMeanDistanceClassifier>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<NaiveBayes<NormalDistribution>>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<DecisionTree>(serializedModel);

                                break;
                            case 5:
                                model = Serializer.Load<RandomForest>(serializedModel);

                                break;
                            case 6:
                                model = Serializer.Load<MulticlassSupportVectorMachine<Linear>>(serializedModel);

                                break;
                            case 7:
                                model = Serializer.Load<MulticlassSupportVectorMachine<IKernel>>(serializedModel);

                                break;
                            case 8:
                                model = Serializer.Load<MulticlassSupportVectorMachine<IKernel<double[]>, double[]>>(serializedModel);

                                break;
                            case 9:
                                model = Serializer.Load<ActivationNetwork>(serializedModel);

                                break;
                        }

                        MulticlassClassificationTask multiclassClassificationTask = new MulticlassClassificationTask(model, data, trainingDataset, testDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        multiclassClassificationTask.DatasetLoaded += activeMdiChild_DatasetLoaded;
                        multiclassClassificationTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                        multiclassClassificationTask.ModelLoaded += activeMdiChild_ModelLoaded;
                        multiclassClassificationTask.ModelTrained += activeMdiChild_ModelTrained;
                        multiclassClassificationTask.FormClosed += mdiChildClosed;
                        multiclassClassificationTask.Show();
                        multiclassClassificationTask.Activate();

                        saveRibbonButton.Enabled = true;
                        closeRibbonButton.Enabled = true;

                        break;
                    case 2: // regression
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<MultipleLinearRegression>(serializedModel);

                                break;
                            case 1:
                                model = Serializer.Load<PolynomialRegression>(serializedModel);

                                break;
                            case 2:
                                model = Serializer.Load<SupportVectorMachine>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<SupportVectorMachine<IKernel>>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<ActivationNetwork>(serializedModel);

                                break;
                        }

                        RegressionTask regressionTask = new RegressionTask(model, data, trainingDataset, testDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        regressionTask.DatasetLoaded += activeMdiChild_DatasetLoaded;
                        regressionTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                        regressionTask.ModelLoaded += activeMdiChild_ModelLoaded;
                        regressionTask.ModelTrained += activeMdiChild_ModelTrained;
                        regressionTask.FormClosed += mdiChildClosed;
                        regressionTask.Show();
                        regressionTask.Activate();

                        saveRibbonButton.Enabled = true;
                        closeRibbonButton.Enabled = true;

                        break;
                    case 3: // clustering
                        switch (modelIndex)
                        {
                            case 0:
                                model = Serializer.Load<KMeans>(serializedModel);

                                break;
                            case 1: // Saving is not supported for balanced k-means model
                                break;
                            case 2:
                                model = Serializer.Load<KMedoids>(serializedModel);

                                break;
                            case 3:
                                model = Serializer.Load<BinarySplit>(serializedModel);

                                break;
                            case 4:
                                model = Serializer.Load<GaussianMixtureModel>(serializedModel);

                                break;
                            case 5:
                                model = Serializer.Load<MeanShift>(serializedModel);

                                break;
                        }

                        ClusteringTask clusteringTask = new ClusteringTask(model, trainingDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        clusteringTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                        clusteringTask.ModelLoaded += activeMdiChild_ModelLoaded;
                        clusteringTask.ModelTrained += activeMdiChild_ModelTrained;
                        clusteringTask.FormClosed += mdiChildClosed;
                        clusteringTask.Show();
                        clusteringTask.Activate();

                        saveRibbonButton.Enabled = true;
                        closeRibbonButton.Enabled = true;

                        break;
                    case 4: // PCA
                        model = Serializer.Load<KernelPrincipalComponentAnalysis>(serializedModel);

                        PCATask pcaTask = new PCATask((KernelPrincipalComponentAnalysis)model, trainingDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        pcaTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                        pcaTask.ModelLoaded += activeMdiChild_ModelLoaded;
                        pcaTask.ModelTrained += activeMdiChild_ModelTrained;
                        pcaTask.FormClosed += mdiChildClosed;
                        pcaTask.Show();
                        pcaTask.Activate();

                        saveRibbonButton.Enabled = true;
                        closeRibbonButton.Enabled = true;

                        break;
                    case 5: // DA
                        model = Serializer.Load<KernelDiscriminantAnalysis>(serializedModel);

                        DATask daTask = new DATask((KernelDiscriminantAnalysis)model, data, trainingDataset, testDataset, serializedLearningParameters)
                        {
                            MdiParent = this
                        };
                        daTask.TrainingDatasetLoaded += activeMdiChild_TrainingDatasetLoaded;
                        daTask.ModelLoaded += activeMdiChild_ModelLoaded;
                        daTask.ModelTrained += activeMdiChild_ModelTrained;
                        daTask.FormClosed += mdiChildClosed;
                        daTask.Show();
                        daTask.Activate();

                        saveRibbonButton.Enabled = true;
                        closeRibbonButton.Enabled = true;

                        break;
                }
            }
            catch
            {
                MessageBox.Show(this, "Cannot open file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveRibbonButton_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
                return;

            bool modelTrained = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                modelTrained = ((BinaryClassificationTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                modelTrained = ((MulticlassClassificationTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                modelTrained = ((RegressionTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                modelTrained = ((ClusteringTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(PCATask))
                modelTrained = ((PCATask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                modelTrained = ((DATask)ActiveMdiChild).IsModelTrained;

            if (!modelTrained)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveCurrentModel();
        }

        public void SaveCurrentModel()
        {
            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string filePath = saveFileDialog.FileName;

            Control currentMdiChild = ActiveMdiChild;
            try
            {
                if (currentMdiChild.GetType() == typeof(BinaryClassificationTask))
                    ((BinaryClassificationTask)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(MulticlassClassificationTask))
                    ((MulticlassClassificationTask)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(RegressionTask))
                    ((RegressionTask)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(ClusteringTask))
                    ((ClusteringTask)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(PCATask))
                    ((PCATask)currentMdiChild).SaveModel(filePath);
                else if (currentMdiChild.GetType() == typeof(DATask))
                    ((DATask)currentMdiChild).SaveModel(filePath);
            }
            catch
            {
                MessageBox.Show(this, "Cannot save model!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeRibbonButton_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
                return;

            ActiveMdiChild.Close();
        }

        private void aboutRibbonButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        private void loadDatasetRibbonButton_Click(object sender, EventArgs e)
        {
            bool isDatasetLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                isDatasetLoaded = ((DATask)ActiveMdiChild).IsDatasetLoaded;

            if (isDatasetLoaded)
            {
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load dataset";
            openFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            openFileDialog.FileName = "*.csv";
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string filename = openFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".csv")
                {
                    CsvReader csvReader = new CsvReader(filename, datasetHasHeadersCheckBox.Checked);
                    DataTable dataset = csvReader.ToTable();

                    if (dataset.Columns.Count <= 1 || dataset.Rows.Count == 0)
                        throw new Exception("Invalid data!");

                    DataTable clonedDataset = dataset.DeepClone();
                    clonedDataset.Columns.RemoveAt(dataset.Columns.Count - 1);
                    clonedDataset.ToMatrix(); // will throw an exception if any data is not numeric

                    if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(DATask)) // Check number of classes
                    {
                        string[] classLabels = dataset.Columns[dataset.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
                        if (classLabels.Length == 1)
                            throw new Exception("Dataset contains only 1 class!");
                        if ((ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) && classLabels.Length > 2) || classLabels.Length > 10)
                            throw new Exception("Dataset contains too many classes!");
                    }

                    if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                        ((BinaryClassificationTask)ActiveMdiChild).LoadDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                        ((MulticlassClassificationTask)ActiveMdiChild).LoadDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                        ((RegressionTask)ActiveMdiChild).LoadDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(DATask))
                        ((DATask)ActiveMdiChild).LoadDataset(dataset);
                }
                else
                {
                    throw new Exception("Cannot open the selected file!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void activeMdiChild_DatasetLoaded(DatasetLoadedEventArgs e)
        {
            splitDatasetRibbonButton.Enabled = true;
        }

        private void splitDatasetRibbonButton_Click(object sender, EventArgs e)
        {
            bool isTrainingDatasetLoaded = false;
            bool isTestingDatasetLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
            {
                isTrainingDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsTrainingDatasetLoaded;
                isTestingDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsTestingDatasetLoaded;
            }
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
            {
                isTrainingDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsTrainingDatasetLoaded;
                isTestingDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsTestingDatasetLoaded;
            }
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
            {
                isTrainingDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsTrainingDatasetLoaded;
                isTestingDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsTestingDatasetLoaded;
            }
            else if (ActiveMdiChild.GetType() == typeof(DATask))
            {
                isTrainingDatasetLoaded = ((DATask)ActiveMdiChild).IsTrainingDatasetLoaded;
                isTestingDatasetLoaded = ((DATask)ActiveMdiChild).IsTestingDatasetLoaded;
            }

            if (isTrainingDatasetLoaded || isTestingDatasetLoaded)
            {
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            SplitDatasetDialog splitDatasetDialog = new SplitDatasetDialog();
            splitDatasetDialog.ShowDialog(this);

            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
            {
                if (((BinaryClassificationTask)ActiveMdiChild).SplitDataset(splitDatasetDialog.PercentageOfTrainingDataset))
                    loadModelRibbonButton.Enabled = true;
            }
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
            {
                if (((MulticlassClassificationTask)ActiveMdiChild).SplitDataset(splitDatasetDialog.PercentageOfTrainingDataset))
                    loadModelRibbonButton.Enabled = true;
            }
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
            {
                if (((RegressionTask)ActiveMdiChild).SplitDataset(splitDatasetDialog.PercentageOfTrainingDataset))
                    loadModelRibbonButton.Enabled = true;
            }
            else if (ActiveMdiChild.GetType() == typeof(DATask))
            {
                if (((DATask)ActiveMdiChild).SplitDataset(splitDatasetDialog.PercentageOfTrainingDataset))
                    loadModelRibbonButton.Enabled = false;
            }
        }

        private void loadTrainingDatasetRibbonButton_Click(object sender, EventArgs e)
        {
            bool isTrainingDatasetLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isTrainingDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isTrainingDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isTrainingDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                isTrainingDatasetLoaded = ((ClusteringTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(PCATask))
                isTrainingDatasetLoaded = ((PCATask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                isTrainingDatasetLoaded = ((DATask)ActiveMdiChild).IsTrainingDatasetLoaded;

            if (isTrainingDatasetLoaded)
            {
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load training dataset";
            openFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            openFileDialog.FileName = "*.csv";
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string filename = openFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".csv")
                {
                    CsvReader csvReader = new CsvReader(filename, datasetHasHeadersCheckBox.Checked);
                    DataTable dataset = csvReader.ToTable();

                    if (dataset.Columns.Count <= 1 || dataset.Rows.Count == 0)
                        throw new Exception("Invalid data!");

                    if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(RegressionTask) || ActiveMdiChild.GetType() == typeof(DATask))
                    {
                        DataTable clonedDataset = dataset.DeepClone();
                        clonedDataset.Columns.RemoveAt(dataset.Columns.Count - 1);
                        clonedDataset.ToMatrix(); // will throw an exception if any data is not numeric

                        if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(DATask)) // Check number of classes
                        {
                            string[] classLabels = dataset.Columns[dataset.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
                            if (classLabels.Length == 1)
                                throw new Exception("Dataset contains only 1 class!");
                            if (classLabels.Length > 10)
                                throw new Exception("Dataset contains too many classes!");
                        }
                    }
                    else // Clustering + PCA
                    {
                        DataTable clonedDataset = dataset.DeepClone();
                        clonedDataset.ToMatrix(); // will throw an exception if any data is not numeric
                    }

                    if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                        ((BinaryClassificationTask)ActiveMdiChild).LoadTrainingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                        ((MulticlassClassificationTask)ActiveMdiChild).LoadTrainingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                        ((RegressionTask)ActiveMdiChild).LoadTrainingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                        ((ClusteringTask)ActiveMdiChild).LoadTrainingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(PCATask))
                        ((PCATask)ActiveMdiChild).LoadTrainingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(DATask))
                        ((DATask)ActiveMdiChild).LoadTrainingDataset(dataset);
                }
                else
                {
                    throw new Exception("Cannot open the selected file!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void activeMdiChild_TrainingDatasetLoaded(DatasetLoadedEventArgs e)
        {
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(RegressionTask) || ActiveMdiChild.GetType() == typeof(ClusteringTask))
                loadModelRibbonButton.Enabled = true;
        }

        private void loadTestingDatasetRibbonButton_Click(object sender, EventArgs e)
        {
            bool isTestingDatasetLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isTestingDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsTestingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isTestingDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsTestingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isTestingDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsTestingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                isTestingDatasetLoaded = ((DATask)ActiveMdiChild).IsTestingDatasetLoaded;

            if (isTestingDatasetLoaded)
            {
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load testing dataset";
            openFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            openFileDialog.FileName = "*.csv";
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string filename = openFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".csv")
                {
                    CsvReader csvReader = new CsvReader(filename, datasetHasHeadersCheckBox.Checked);
                    DataTable dataset = csvReader.ToTable();

                    if (dataset.Columns.Count <= 1 || dataset.Rows.Count == 0)
                        throw new Exception("Invalid data!");

                    DataTable clonedDataset = dataset.DeepClone();
                    clonedDataset.Columns.RemoveAt(dataset.Columns.Count - 1);
                    clonedDataset.ToMatrix(); // will throw an exception if any data is not numeric

                    if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(DATask)) // Check number of classes
                    {
                        string[] classLabels = dataset.Columns[dataset.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();
                        if (classLabels.Length == 1)
                            throw new Exception("Dataset contains only 1 class!");
                        if (classLabels.Length > 10)
                            throw new Exception("Dataset contains too many classes!");
                    }

                    if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                        ((BinaryClassificationTask)ActiveMdiChild).LoadTestingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                        ((MulticlassClassificationTask)ActiveMdiChild).LoadTestingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                        ((RegressionTask)ActiveMdiChild).LoadTestingDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(DATask))
                        ((DATask)ActiveMdiChild).LoadTestingDataset(dataset);
                }
                else
                {
                    throw new Exception("Cannot open the selected file!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadModelRibbonButton_Click(object sender, EventArgs e)
        {
            bool isModelLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isModelLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isModelLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isModelLoaded = ((RegressionTask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                isModelLoaded = ((ClusteringTask)ActiveMdiChild).IsModelLoaded;

            if (isModelLoaded)
            {
                if (MessageBox.Show(this, "Do you want to override the current model?", "Override model", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
            {
                ChooseBinaryClassificationModelDialog chooseBinaryClassificationModelDialog = new ChooseBinaryClassificationModelDialog();
                if (chooseBinaryClassificationModelDialog.ShowDialog() != DialogResult.OK)
                    return;

                ((BinaryClassificationTask)ActiveMdiChild).LoadModel(chooseBinaryClassificationModelDialog.modelComboBox.SelectedIndex);   
            }
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
            {
                ChooseMulticlassClassificationModelDialog chooseMulticlassClassificationModel = new ChooseMulticlassClassificationModelDialog();
                if (chooseMulticlassClassificationModel.ShowDialog() != DialogResult.OK)
                    return;

                ((MulticlassClassificationTask)ActiveMdiChild).LoadModel(chooseMulticlassClassificationModel.modelComboBox.SelectedIndex);
            }
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
            {
                ChooseRegressionModelDialog chooseRegressionModelDialog = new ChooseRegressionModelDialog();
                if (chooseRegressionModelDialog.ShowDialog() != DialogResult.OK)
                    return;

                ((RegressionTask)ActiveMdiChild).LoadModel(chooseRegressionModelDialog.modelComboBox.SelectedIndex);
            }
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
            {
                ChooseClusteringModelDialog chooseClusteringModelDialog = new ChooseClusteringModelDialog();
                if (chooseClusteringModelDialog.ShowDialog() != DialogResult.OK)
                    return;

                ((ClusteringTask)ActiveMdiChild).LoadModel(chooseClusteringModelDialog.modelComboBox.SelectedIndex);
            }
        }

        private void activeMdiChild_ModelLoaded(EventArgs e)
        {
            trainRibbonButton.Enabled = true;
        }

        private void trainRibbonButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                ((BinaryClassificationTask)ActiveMdiChild).TrainModel();
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                ((MulticlassClassificationTask)ActiveMdiChild).TrainModel();
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                ((RegressionTask)ActiveMdiChild).TrainModel();
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                ((ClusteringTask)ActiveMdiChild).TrainModel();
            else if (ActiveMdiChild.GetType() == typeof(PCATask))
                ((PCATask)ActiveMdiChild).TrainModel();
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                ((DATask)ActiveMdiChild).TrainModel();
        }

        private void activeMdiChild_ModelTrained(ModelTrainedEventArgs e)
        {
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(RegressionTask) || ActiveMdiChild.GetType() == typeof(DATask))
                testRibbonButton.Enabled = true;
            makePredictionRibbonButton.Enabled = true;
        }

        private void testRibbonButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                ((BinaryClassificationTask)ActiveMdiChild).TestModel();
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                ((MulticlassClassificationTask)ActiveMdiChild).TestModel();
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                ((RegressionTask)ActiveMdiChild).TestModel();
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                ((DATask)ActiveMdiChild).TestModel();
        }

        private void loadPredictionDatasetRibbonButton_Click(object sender, EventArgs e)
        {
            bool isPredictionDatasetLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isPredictionDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsPredictionDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isPredictionDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsPredictionDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isPredictionDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsPredictionDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                isPredictionDatasetLoaded = ((ClusteringTask)ActiveMdiChild).IsPredictionDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(PCATask))
                isPredictionDatasetLoaded = ((PCATask)ActiveMdiChild).IsPredictionDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                isPredictionDatasetLoaded = ((DATask)ActiveMdiChild).IsPredictionDatasetLoaded;

            if (isPredictionDatasetLoaded)
            {
                if (MessageBox.Show(this, "Do you want to override the current data?", "Override data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load prediction dataset";
            openFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            openFileDialog.FileName = "*.csv";
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                string filename = openFileDialog.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".csv")
                {
                    CsvReader csvReader = new CsvReader(filename, datasetHasHeadersCheckBox.Checked);
                    DataTable dataset = csvReader.ToTable();

                    if (dataset.Columns.Count == 0 || dataset.Rows.Count == 0)
                        throw new Exception("Invalid data!");

                    DataTable clonedDataset = dataset.DeepClone();
                    clonedDataset.ToMatrix(); // will throw an exception if any data is not numeric

                    if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                        ((BinaryClassificationTask)ActiveMdiChild).LoadPredictionDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                        ((MulticlassClassificationTask)ActiveMdiChild).LoadPredictionDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                        ((RegressionTask)ActiveMdiChild).LoadPredictionDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                        ((ClusteringTask)ActiveMdiChild).LoadPredictionDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(PCATask))
                        ((PCATask)ActiveMdiChild).LoadPredictionDataset(dataset);
                    else if (ActiveMdiChild.GetType() == typeof(DATask))
                        ((DATask)ActiveMdiChild).LoadPredictionDataset(dataset);
                }
                else
                {
                    throw new Exception("Cannot open the selected file!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void makePredictionRibbonButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                ((BinaryClassificationTask)ActiveMdiChild).MakeDatasetPrediction();
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                ((MulticlassClassificationTask)ActiveMdiChild).MakeDatasetPrediction();
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                ((RegressionTask)ActiveMdiChild).MakeDatasetPrediction();
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                ((ClusteringTask)ActiveMdiChild).MakeDatasetPrediction();
            else if (ActiveMdiChild.GetType() == typeof(PCATask))
                ((PCATask)ActiveMdiChild).MakeDatasetPrediction();
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                ((DATask)ActiveMdiChild).MakeDatasetPrediction();
        }

        // Mdi children
        private void mdiChildClosed(object sender, FormClosedEventArgs e)
        {
            if (MdiChildren.Length == 1)
            {
                saveRibbonButton.Enabled = false;
                closeRibbonButton.Enabled = false;
                datasetHasHeadersCheckBox.Enabled = false;
                loadDatasetRibbonButton.Enabled = false;
                splitDatasetRibbonButton.Enabled = false;
                loadTrainingDatasetRibbonButton.Enabled = false;
                loadModelRibbonButton.Enabled = false;
                trainRibbonButton.Enabled = false;
                loadTestingDatasetRibbonButton.Enabled = false;
                testRibbonButton.Enabled = false;
                loadPredictionDatasetRibbonButton.Enabled = false;
                makePredictionRibbonButton.Enabled = false;
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            saveRibbonButton.Enabled = true;
            closeRibbonButton.Enabled = true;
            datasetHasHeadersCheckBox.Enabled = true;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(RegressionTask) || ActiveMdiChild.GetType() == typeof(DATask))
            {
                loadDatasetRibbonButton.Enabled = true;
                loadTestingDatasetRibbonButton.Enabled = true;
            }
            else
            {
                loadDatasetRibbonButton.Enabled = false;
                loadTestingDatasetRibbonButton.Enabled = false;
            }
            splitDatasetRibbonButton.Enabled = false;
            loadTrainingDatasetRibbonButton.Enabled = true;
            loadModelRibbonButton.Enabled = false;
            trainRibbonButton.Enabled = false;
            testRibbonButton.Enabled = false;
            loadPredictionDatasetRibbonButton.Enabled = true;
            makePredictionRibbonButton.Enabled = false;

            bool isDatasetLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                isDatasetLoaded = ((DATask)ActiveMdiChild).IsDatasetLoaded;
            splitDatasetRibbonButton.Enabled = isDatasetLoaded;

            bool isTrainingDatasetLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isTrainingDatasetLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isTrainingDatasetLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isTrainingDatasetLoaded = ((RegressionTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                isTrainingDatasetLoaded = ((ClusteringTask)ActiveMdiChild).IsTrainingDatasetLoaded;
            loadModelRibbonButton.Enabled = isTrainingDatasetLoaded;

            bool isModelLoaded = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isModelLoaded = ((BinaryClassificationTask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isModelLoaded = ((MulticlassClassificationTask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isModelLoaded = ((RegressionTask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                isModelLoaded = ((ClusteringTask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(PCATask))
                isModelLoaded = ((PCATask)ActiveMdiChild).IsModelLoaded;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                isModelLoaded = ((DATask)ActiveMdiChild).IsModelLoaded;
            trainRibbonButton.Enabled = isModelLoaded;

            bool isModelTrained = false;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask))
                isModelTrained = ((BinaryClassificationTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask))
                isModelTrained = ((MulticlassClassificationTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(RegressionTask))
                isModelTrained = ((RegressionTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(ClusteringTask))
                isModelTrained = ((ClusteringTask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(PCATask))
                isModelTrained = ((PCATask)ActiveMdiChild).IsModelTrained;
            else if (ActiveMdiChild.GetType() == typeof(DATask))
                isModelTrained = ((DATask)ActiveMdiChild).IsModelTrained;
            if (ActiveMdiChild.GetType() == typeof(BinaryClassificationTask) || ActiveMdiChild.GetType() == typeof(MulticlassClassificationTask) || ActiveMdiChild.GetType() == typeof(RegressionTask) || ActiveMdiChild.GetType() == typeof(DATask))
                testRibbonButton.Enabled = isModelTrained;
            makePredictionRibbonButton.Enabled = isModelTrained;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                newTaskRibbonButton_Click(newTaskRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                openRibbonButton_Click(openRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.S && saveRibbonButton.Enabled)
            {
                saveRibbonButton_Click(saveRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.X && closeRibbonButton.Enabled)
            {
                closeRibbonButton_Click(closeRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.H)
            {
                aboutRibbonButton_Click(aboutRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.L && loadDatasetRibbonButton.Enabled)
            {
                loadDatasetRibbonButton_Click(loadDatasetRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.P && splitDatasetRibbonButton.Enabled)
            {
                splitDatasetRibbonButton_Click(splitDatasetRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.R && loadTrainingDatasetRibbonButton.Enabled)
            {
                loadTrainingDatasetRibbonButton_Click(loadTrainingDatasetRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.M && loadModelRibbonButton.Enabled)
            {
                loadModelRibbonButton_Click(loadModelRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.T && trainRibbonButton.Enabled)
            {
                trainRibbonButton_Click(trainRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.D && loadTestingDatasetRibbonButton.Enabled)
            {
                loadTestingDatasetRibbonButton_Click(loadTestingDatasetRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.E && testRibbonButton.Enabled)
            {
                testRibbonButton_Click(testRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.I && loadPredictionDatasetRibbonButton.Enabled)
            {
                loadPredictionDatasetRibbonButton_Click(loadPredictionDatasetRibbonButton, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.I && makePredictionRibbonButton.Enabled)
            {
                makePredictionRibbonButton_Click(makePredictionRibbonButton, EventArgs.Empty);
            }
        }
    }
}
