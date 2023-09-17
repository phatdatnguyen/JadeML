using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace JadeChem.Dialogs
{
    public partial class VisualizeLossesDialog : Form
    {
        #region Fields
        private readonly List<int> trainEpochs;
        private readonly List<float> trainLosses;
        private readonly List<int> validationEpoch;
        private readonly List<float> validationLosses;
        private readonly string lossFunctionName;
        #endregion

        #region Constructor
        public VisualizeLossesDialog(List<int> trainEpochs, List<float> trainLosses, List<int> validationEpochs, List<float> validationLosses, string lossFunctionName)
        {
            InitializeComponent();

            this.trainEpochs = trainEpochs;
            this.trainLosses = trainLosses;
            this.validationEpoch = validationEpochs;
            this.validationLosses = validationLosses;
            this.lossFunctionName = lossFunctionName;
        }
        #endregion

        #region Methods
        private void VisualizeLossesDialog_Load(object sender, EventArgs e)
        {
            PlotModel plotModel = new() { Title = "Losses" };

            LineSeries trainLossesLineSeries = new();
            for (int epochIndex = 0; epochIndex < trainEpochs.Count; epochIndex++)
            {
                double x = trainEpochs[epochIndex];
                double y = trainLosses[epochIndex];

                trainLossesLineSeries.Points.Add(new DataPoint(x, y));
            }
            trainLossesLineSeries.Title = "Train loss";

            plotModel.Series.Add(trainLossesLineSeries);

            if (validationEpoch.Count > 0)
            {
                LineSeries validationLossesLineSeries = new();
                for (int epochIndex = 0; epochIndex < validationEpoch.Count; epochIndex++)
                {
                    double x = validationEpoch[epochIndex];
                    double y = validationLosses[epochIndex];

                    validationLossesLineSeries.Points.Add(new DataPoint(x, y));
                }
                validationLossesLineSeries.Title = "Validation loss";

                plotModel.Series.Add(validationLossesLineSeries);
            }

            LinearAxis xAxis = new()
            {
                Position = AxisPosition.Bottom,
                Title = "Epoch",
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            LinearAxis yAxis = new()
            {
                Position = AxisPosition.Left,
                Title = lossFunctionName,
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.Legends.Add(new Legend()
            {
                LegendTitle = "Loss",
                LegendPlacement = LegendPlacement.Outside
            });

            dataPlotView.Model = plotModel;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
