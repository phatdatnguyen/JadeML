using Accord.Math;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace JadeChem.Dialogs
{
    public partial class VisualizeRegressionEvaluationDataDialog : Form
    {
        #region Fields
        private readonly string[] inputColumnNames;
        private readonly string outputColumnName;
        private readonly double[][] inputColumns;
        private readonly double[] predictedOutputColumn;
        private readonly double[] expectedOutputColumn;
        #endregion

        #region Constructor
        public VisualizeRegressionEvaluationDataDialog(string[] inputColumnNames, string outputColumnName, double[][] inputColumns, double[] predictedOutputColumn, double[] expectedOutputColumn)
        {
            InitializeComponent();

            this.inputColumnNames = inputColumnNames;
            this.outputColumnName = outputColumnName;
            this.inputColumns = inputColumns;
            this.predictedOutputColumn = predictedOutputColumn;
            this.expectedOutputColumn = expectedOutputColumn;

            inputColumnNameComboBox.Items.Clear();
            foreach (string inputColumnName in inputColumnNames)
                inputColumnNameComboBox.Items.Add(inputColumnName);

            inputColumnNameComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Methods
        private void VisualizeRegressionDataDialog_Load(object sender, EventArgs e)
        {
            if (inputColumnNameComboBox.Items.Count == 0)
                return;

            UpdateDataPlot(0);

            // Draw expected vs. predicted scatter plot
            PlotModel plotModel = new()
            {
                Title = "Predicted vs. Expected"
            };

            double[] xColumn = expectedOutputColumn;
            double[] yColumn = predictedOutputColumn;

            ScatterSeries scatterSeries = new()
            {
                MarkerType = MarkerType.Circle
            };
            for (int rowIndex = 0; rowIndex < inputColumns.Rows(); rowIndex++)
                scatterSeries.Points.Add(new ScatterPoint(xColumn[rowIndex], yColumn[rowIndex]));

            plotModel.Series.Add(scatterSeries);

            LinearAxis xAxis = new()
            {
                Position = AxisPosition.Bottom,
                Title = "Expected " + outputColumnName,
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            LinearAxis yAxis = new()
            {
                Position = AxisPosition.Left,
                Title = "Predicted " + outputColumnName,
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);

            scatterPlotView.Model = plotModel;
        }

        private void ColumnNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputColumnNameComboBox.SelectedIndex == -1)
                return;

            UpdateDataPlot(inputColumnNameComboBox.SelectedIndex);
        }

        private void UpdateDataPlot(int inputColumnIndex)
        {
            PlotModel plotModel = new()
            {
                Title = outputColumnName
            };

            LineSeries predictedLineSeries = new();
            LineSeries expectedLineSeries = new();
            double[] xColumn = inputColumns.GetColumn(inputColumnIndex);
            double[] y1Column = predictedOutputColumn;
            double[] y2Column = expectedOutputColumn;
            double[] clonedXColumn = (double[])xColumn.Clone();
            clonedXColumn.Sort(out int[] sortedIndices);

            for (int rowIndex = 0; rowIndex < inputColumns.Rows(); rowIndex++)
            {
                double x = xColumn[sortedIndices[rowIndex]];
                double y1 = y1Column[sortedIndices[rowIndex]];
                double y2 = y2Column[sortedIndices[rowIndex]];

                predictedLineSeries.Points.Add(new DataPoint(x, y1));
                expectedLineSeries.Points.Add(new DataPoint(x, y2));
            }
            predictedLineSeries.Title = "Predicted";
            expectedLineSeries.Title = "Expected";
            LinearAxis xAxis = new()
            {
                Position = AxisPosition.Bottom,
                Title = inputColumnNames[inputColumnIndex],
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            LinearAxis yAxis = new()
            {
                Position = AxisPosition.Left,
                Title = outputColumnName,
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };

            plotModel.Series.Add(predictedLineSeries);
            plotModel.Series.Add(expectedLineSeries);
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.Legends.Add(new Legend() { LegendPlacement = LegendPlacement.Outside });

            dataPlotView.Model = plotModel;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
