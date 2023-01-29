using Accord.IO;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Statistics.Distributions.DensityKernels;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Kernels;
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

namespace JadeML.Clustering
{
    public partial class ClusteringTask : Form
    {
        // Fields
        private object clusterer = null;
        private string[] features = null;
        private string target = "Cluster";

        private DataTable trainingDataset = null;
        private double[][] trainingInputColumns = null;
        private int[] clusterIndexColumn = null;
        private DataTable clusteredTrainingDataset = null;

        private DataTable predictionDataset = null;

        private string serializedLearningParameters = "";

        private bool modelTrained = false;

        // Property
        public bool IsTrainingDatasetLoaded { get { return trainingDataset != null; } }
        public bool IsPredictionDatasetLoaded { get { return predictionDataset != null; } }
        public bool IsModelLoaded { get { return modelTabPage.Controls.Count > 0; } }
        public bool IsModelTrained { get { return modelTrained; } }

        // Event
        public delegate void TrainingDataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event TrainingDataLoadedEventHandler TrainingDatasetLoaded;
        public delegate void PredictionDataLoadedEventHandler(DatasetLoadedEventArgs e);
        public event PredictionDataLoadedEventHandler PredictionDatasetLoaded;
        public delegate void ModelLoadedEventHandler(EventArgs e);
        public event ModelLoadedEventHandler ModelLoaded;
        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        // Constructors
        public ClusteringTask()
        {
            InitializeComponent();

            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += onModelLoaded;
            ModelTrained += onModelTrained;
        }

        public ClusteringTask(object model, DataTable trainingDataset, string serializedLearningParameters)
        {
            InitializeComponent();

            TrainingDatasetLoaded += OnTrainingDatasetLoaded;
            PredictionDatasetLoaded += OnPredictionDatasetLoaded;
            ModelLoaded += onModelLoaded;
            ModelTrained += onModelTrained;

            TrainingDatasetLoaded(new DatasetLoadedEventArgs { Dataset = trainingDataset });

            if (model.GetType() == typeof(KMeans))
            {
                modelTabPage.Controls.Add(new KMeansLearningControl());
                ((KMeansLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(KMedoids))
            {
                modelTabPage.Controls.Add(new KMedoidsLearningControl());
                ((KMedoidsLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(BinarySplit))
            {
                modelTabPage.Controls.Add(new BinarySplitLearningControl());
                ((BinarySplitLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(GaussianMixtureModel))
            {
                modelTabPage.Controls.Add(new GaussianMixtureLearningControl());
                ((GaussianMixtureLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }
            else if (model.GetType() == typeof(MeanShift))
            {
                modelTabPage.Controls.Add(new MeanShiftLearningControl());
                ((MeanShiftLearningControl)modelTabPage.Controls[0]).SetLearningParameters(serializedLearningParameters);
            }

            ModelTrained(new ModelTrainedEventArgs() { Model = model });
        }

        // Form event handlers
        private void BinaryClassificationTask_Load(object sender, EventArgs e)
        {
            ShapeNode trainingDatasetNode = taskDiagram.Factory.CreateShapeNode(5, 5, 20, 10, Shapes.Rectangle);
            trainingDatasetNode.Text = "Training dataset";
            trainingDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            ShapeNode modelNode = taskDiagram.Factory.CreateShapeNode(55, 5, 30, 10, Shapes.Cube);
            modelNode.Text = "Model";
            modelNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Cyan);
            modelNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link1 = taskDiagram.Factory.CreateDiagramLink(trainingDatasetNode, modelNode);
            link1.AllowMoveStart = false;
            link1.AllowMoveEnd = false;

            ShapeNode clustersNode = taskDiagram.Factory.CreateShapeNode(105, 5, 30, 10, Shapes.RoundRect);
            clustersNode.Text = "Clusters\n(training dataset)";
            clustersNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Magenta);
            clustersNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link2 = taskDiagram.Factory.CreateDiagramLink(modelNode, clustersNode);
            link2.AllowMoveStart = false;
            link2.AllowMoveEnd = false;

            ShapeNode predictionNode = taskDiagram.Factory.CreateShapeNode(55, 25, 30, 10, Shapes.RoundRect);
            predictionNode.Text = "Clusters\n(prediction dataset)";
            predictionNode.Brush = new MindFusion.Drawing.SolidBrush(Color.Magenta);
            predictionNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link3 = taskDiagram.Factory.CreateDiagramLink(modelNode, predictionNode);
            link3.AllowMoveStart = false;
            link3.AllowMoveEnd = false;

            ShapeNode predictionDatasetNode = taskDiagram.Factory.CreateShapeNode(5, 25, 20, 10, Shapes.Rectangle);
            predictionDatasetNode.Text = "Prediction dataset";
            predictionDatasetNode.EnabledHandles = AdjustmentHandles.Move;

            DiagramLink link4 = taskDiagram.Factory.CreateDiagramLink(predictionDatasetNode, predictionNode);
            link4.AllowMoveStart = false;
            link4.AllowMoveEnd = false;
        }

        private void BinaryClassificationTask_Resize(object sender, EventArgs e)
        {
            taskTableLayoutPanel.Height = Height - 64;
        }
        
        private void BinaryClassificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)MdiParent;

            if (clusterer != null && modelTrained)
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
            if (!modelTrained || clusterer == null)
                return;

            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8, false))
                {
                    byte taskIndex = 3; // clustering
                    byte modelIndex = 0;

                    byte[] serializedModel = null;
                    if (clusterer.GetType() == typeof(KMeans))
                    {
                        modelIndex = 0;
                        ((KMeans)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(KMedoids))
                    {
                        modelIndex = 2;
                        ((KMedoids)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(BinarySplit))
                    {
                        modelIndex = 3;
                        ((BinarySplit)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(GaussianMixtureModel))
                    {
                        modelIndex = 4;
                        ((GaussianMixtureModel)clusterer).Save(out serializedModel);
                    }
                    else if (clusterer.GetType() == typeof(MeanShift))
                    {
                        modelIndex = 5;
                        ((MeanShift)clusterer).Save(out serializedModel);
                    }
                    int modelSize = serializedModel.Length;

                    int dataSize = 0;

                    byte[] serializedTrainingDataset = null;
                    int trainingDatasetSize = 0;
                    if (trainingDataset != null)
                    {
                        trainingDataset.Save(out serializedTrainingDataset);
                        trainingDatasetSize = serializedTrainingDataset.Length;
                    }

                    int testDataSize = 0;

                    binaryWriter.Write(taskIndex);
                    binaryWriter.Write(modelIndex);
                    binaryWriter.Write(serializedLearningParameters);
                    binaryWriter.Write(modelSize);
                    binaryWriter.Write(serializedModel);
                    binaryWriter.Write(dataSize);
                    binaryWriter.Write(trainingDatasetSize);
                    binaryWriter.Write(serializedTrainingDataset);
                    binaryWriter.Write(testDataSize);
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
                case "Training dataset":
                    datasetLabel.Text = "Training dataset";
                    datasetDataGridView.DataSource = null;
                    if (trainingDataset != null)
                        datasetDataGridView.DataSource = trainingDataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Prediction dataset":
                    datasetLabel.Text = "Prediction dataset";
                    datasetDataGridView.DataSource = null;
                    if (predictionDataset != null)
                        datasetDataGridView.DataSource = predictionDataset;
                    taskTabControl.SelectTab(0);
                    break;
                case "Clusters\n(training dataset)":
                    datasetLabel.Text = "Clustered training dataset";
                    datasetDataGridView.DataSource = null;
                    if (clusteredTrainingDataset != null)
                        datasetDataGridView.DataSource = clusteredTrainingDataset;
                    else
                        return;
                    taskTabControl.SelectTab(0);
                    break;
                case "Model":
                    taskTabControl.SelectTab(1);
                    break;
                case "Clusters\n(prediction dataset)":
                    taskTabControl.SelectTab(2);
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
        public void LoadTrainingDataset(DataTable dataset)
        {
            TrainingDatasetLoaded(new DatasetLoadedEventArgs() { Dataset = dataset });
        }

        public void OnTrainingDatasetLoaded(DatasetLoadedEventArgs e)
        {
            trainingDataset = e.Dataset;

            DataTable trainingDataTable = e.Dataset.DeepClone();
            trainingInputColumns = trainingDataTable.ToMatrix().ToJagged();

            if (features == null)
            {
                features = new string[trainingDataset.Columns.Count];
                for (int i = 0; i < features.Length; i++)
                    features[i] = trainingDataset.Columns[i].ColumnName;
            }

            if (datasetLabel.Text == "Training dataset")
            {
                datasetDataGridView.Columns.Clear();
                datasetDataGridView.DataSource = trainingDataset;
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
            if (datasetLabel.Text == "Training dataset" && trainingDataset != null)
            {
                VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(trainingDataset, "Training dataset");
                visualizeDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Prediction dataset" && predictionDataset != null)
            {
                VisualizeDataDialog visualizeDataDialog = new VisualizeDataDialog(predictionDataset, "Prediction dataset");
                visualizeDataDialog.Show(this);
            }
            else if (datasetLabel.Text == "Clustered training dataset" && clusteredTrainingDataset != null)
            {
                int numberOfCluster = clusteredTrainingDataset.Columns[clusteredTrainingDataset.Columns.Count - 1].ToArray<string>().Distinct().Length;
                if (numberOfCluster > 10)
                {
                    MessageBox.Show(this, "Cannot visualize data with too many clusters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VisualizeClusteringDataDialog visualizeClusteringDataDialog = new VisualizeClusteringDataDialog(clusteredTrainingDataset, "Clustered training dataset", true);
                visualizeClusteringDataDialog.Show(this);
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
                    modelTabPage.Controls.Add(new KMeansLearningControl());

                    break;
                case 1:
                    modelTabPage.Controls.Add(new KMedoidsLearningControl());

                    break;
                case 2:
                    modelTabPage.Controls.Add(new BinarySplitLearningControl());

                    break;
                case 3:
                    modelTabPage.Controls.Add(new GaussianMixtureLearningControl());

                    break;
                case 4:
                    modelTabPage.Controls.Add(new MeanShiftLearningControl());

                    break;
            }

            ModelLoaded(EventArgs.Empty);
        }

        private void onModelLoaded(EventArgs e)
        {
            clusterer = null;
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
            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            try
            {
                object clusterer = null;

                if (modelTabPage.Controls[0].GetType() == typeof(KMeansLearningControl))
                {
                    KMeans kMeans = new KMeans(Convert.ToInt32(((KMeansLearningControl)modelTabPage.Controls[0]).KNumericUpDown.Value));
                    kMeans.Learn(trainingInputColumns);
                    clusterer = kMeans;
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(KMedoidsLearningControl))
                {
                    KMedoids kMedoids = new KMedoids(Convert.ToInt32(((KMedoidsLearningControl)modelTabPage.Controls[0]).KNumericUpDown.Value));
                    kMedoids.Learn(trainingInputColumns);
                    clusterer = kMedoids;
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(BinarySplitLearningControl))
                {
                    BinarySplit binarySplit = new BinarySplit(Convert.ToInt32(((BinarySplitLearningControl)modelTabPage.Controls[0]).KNumericUpDown.Value));
                    binarySplit.Learn(trainingInputColumns);
                    clusterer = binarySplit;
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(GaussianMixtureLearningControl))
                {
                    GaussianMixtureModel gaussianMixtureModel = new GaussianMixtureModel(Convert.ToInt32(((GaussianMixtureLearningControl)modelTabPage.Controls[0]).KNumericUpDown.Value))
                    {
                        Options = new NormalOptions()
                        {
                            Regularization = 1e-10
                        }
                    };
                    gaussianMixtureModel.Learn(trainingInputColumns);
                    clusterer = gaussianMixtureModel;
                }
                else if (modelTabPage.Controls[0].GetType() == typeof(MeanShiftLearningControl))
                {
                    GaussianKernel kernel = new GaussianKernel(2);
                    MeanShift meanShift = new MeanShift()
                    {
                        Kernel = kernel,
                        Bandwidth = Convert.ToDouble(((MeanShiftLearningControl)modelTabPage.Controls[0]).RadiusNumericUpDown.Value)
                    };
                    meanShift.Learn(trainingInputColumns);
                    clusterer = meanShift;
                }

                ModelTrained(new ModelTrainedEventArgs() { Model = clusterer });
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
            clusterer = e.Model;

            if (clusterer.GetType() == typeof(KMeans))
            {
                serializedLearningParameters = ((KMeansLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((KMeans)clusterer).Clusters.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(KMedoids))
            {
                serializedLearningParameters = ((KMedoidsLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((KMedoids)clusterer).Clusters.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(BinarySplit))
            {
                serializedLearningParameters = ((BinarySplitLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((BinarySplit)clusterer).Clusters.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(GaussianMixtureModel))
            {
                serializedLearningParameters = ((GaussianMixtureLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((GaussianMixtureModel)clusterer).Gaussians.Decide(trainingInputColumns);
            }
            else if (clusterer.GetType() == typeof(MeanShift))
            {
                serializedLearningParameters = ((MeanShiftLearningControl)modelTabPage.Controls[0]).GetLearningParameters();
                clusterIndexColumn = ((MeanShift)clusterer).Clusters.Decide(trainingInputColumns);
            }

            clusteredTrainingDataset = trainingDataset.DeepClone();
            clusteredTrainingDataset.Columns.Add("Cluster", typeof(string));
            for (int i = 0;i < clusteredTrainingDataset.Rows.Count; i++)
                clusteredTrainingDataset.Rows[i][clusteredTrainingDataset.Columns.Count - 1] = "Cluster " + clusterIndexColumn[i];

            modelTabPage.BackColor = Color.LightGreen;
            taskTabControl.SelectTab(1);

            makePredictionClusteringControl.Clusterer = clusterer;
            makePredictionClusteringControl.ColumnNames = features.Concatenate(target);
            makePredictionClusteringControl.Enabled = true;

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

        private void update2dVisualization()
        {
            //Get the ranges for each variable (X and Y)
            double[] xValues = trainingInputColumns.GetColumn(0);
            double[] yValues = trainingInputColumns.GetColumn(1);

            //Generate a map
            double[][] map = Matrix.Mesh(xValues.GetRange(), 200, yValues.GetRange(), 200);

            int[] clusterIndexColumn = new int[map.Length];

            if (clusterer.GetType() == typeof(KMeans))
                clusterIndexColumn = ((KMeans)clusterer).Clusters.Decide(map);
            else if (clusterer.GetType() == typeof(KMedoids))
                clusterIndexColumn = ((KMedoids)clusterer).Clusters.Decide(map);
            else if (clusterer.GetType() == typeof(BinarySplit))
                clusterIndexColumn = ((BinarySplit)clusterer).Clusters.Decide(map);
            else if (clusterer.GetType() == typeof(GaussianMixtureModel))
                clusterIndexColumn = ((GaussianMixtureModel)clusterer).Gaussians.Decide(map);
            else if (clusterer.GetType() == typeof(MeanShift))
                clusterIndexColumn = ((MeanShift)clusterer).Clusters.Decide(map);

            // Update plot
            PlotModel plotModel = new PlotModel();

            int[] clusters = clusterIndexColumn.Distinct().OrderBy(x => x).ToArray();
            for (int i = 0; i < clusters.Length; i++)
            {
                ScatterSeries series = new ScatterSeries()
                {
                    Title = "Cluster " + (i + 1).ToString(),
                    MarkerSize = 10
                };
                plotModel.Series.Add(series);
            }

            for (int i = 0; i < map.Length; i++)
                ((ScatterSeries)plotModel.Series[clusterIndexColumn[i]]).Points.Add(new ScatterPoint(map[i][0], map[i][1]));

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
                LegendTitle = "Clusters",
                LegendPlacement = LegendPlacement.Outside
            });
            modelVisualizationPlotView.Model = plotModel;
        }

        // Prediction
        public void MakeDatasetPrediction()
        {
            if (clusterer == null)
            {
                MessageBox.Show(this, "The model was not trained!", "Train model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (predictionDataset == null)
            {
                MessageBox.Show(this, "Prediction dataset cannot be empty!", "Prediction dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (predictionDataset.Columns.Count != trainingDataset.Columns.Count)
            {
                MessageBox.Show(this, "Prediction dataset does not match training dataset!", "Prediction dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            taskTabControl.SelectTab(2);
            Cursor = Cursors.WaitCursor;

            try
            {
                double[][] inputColumns = predictionDataset.ToMatrix().ToJagged();
                int[] clusterIndexColumn = new int[inputColumns.Length];
                if (clusterer.GetType() == typeof(KMeans))
                    clusterIndexColumn = ((KMeans)clusterer).Clusters.Decide(inputColumns);
                else if (clusterer.GetType() == typeof(KMedoids))
                    clusterIndexColumn = ((KMedoids)clusterer).Clusters.Decide(inputColumns);
                else if (clusterer.GetType() == typeof(BinarySplit))
                    clusterIndexColumn = ((BinarySplit)clusterer).Clusters.Decide(inputColumns);
                else if (clusterer.GetType() == typeof(GaussianMixtureModel))
                    clusterIndexColumn = ((GaussianMixtureModel)clusterer).Gaussians.Decide(inputColumns);
                else if (clusterer.GetType() == typeof(MeanShift))
                    clusterIndexColumn = ((MeanShift)clusterer).Clusters.Decide(inputColumns);

                makePredictionClusteringControl.UpdatePredictionResult(predictionDataset, clusterIndexColumn);

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
