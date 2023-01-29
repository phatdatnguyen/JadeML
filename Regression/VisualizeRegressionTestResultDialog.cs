using Accord.Math;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class VisualizeRegressionTestResultDialog : Form
    {
        // Fields
        private DataTable testDataTable = null;
        private string[] features = null;
        private string target = "";
        
        private bool graphCreated = false;

        // Constructor
        public VisualizeRegressionTestResultDialog(DataTable testDataTable, string title)
        {
            InitializeComponent();

            Text = title;

            this.testDataTable = testDataTable;
            features = new string[testDataTable.Columns.Count - 2];
            for (int i = 0; i < testDataTable.Columns.Count - 2; i++)
                features[i] = testDataTable.Columns[i].ColumnName;
            target = testDataTable.Columns[testDataTable.Columns.Count - 2].ColumnName;

            string[] outputColumn = testDataTable.Columns[testDataTable.Columns.Count - 2].ToArray<string>();
            string[] classLabels = outputColumn.Distinct().OrderBy(x => x).ToArray();
            
            foreach (string feature in features)
                xComboBox.Items.Add(feature);

            xComboBox.SelectedIndex = 0;

            updateChart();
            graphCreated = true;
        }

        // Methods
        private void axisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!graphCreated)
                return;

            updateChart();
        }

        private void updateChart()
        {
            PlotModel plotModel = new PlotModel();

            LineSeries targetSeries = new LineSeries()
            {
                MarkerType = MarkerType.Circle,
                Title = target
            };
            plotModel.Series.Add(targetSeries);
            LineSeries predictedTargetSeries = new LineSeries()
            {
                MarkerType = MarkerType.Circle,
                Title = target + " (predicted)"
            };
            plotModel.Series.Add(predictedTargetSeries);

            double[] xValues = testDataTable.Columns[xComboBox.SelectedIndex].ToArray();
            double[] yValues = testDataTable.Columns[testDataTable.Columns.Count - 2].ToArray();
            double[] predictedYValues = testDataTable.Columns[testDataTable.Columns.Count - 1].ToArray();
            double[] sortedXValues = (double[])xValues.Clone();
            sortedXValues.Sort<double>(out int[] sortedIndexes);

            for (int i = 0; i < xValues.Length; i++)
            {
                ((LineSeries)plotModel.Series[0]).Points.Add(new DataPoint(xValues[sortedIndexes[i]], yValues[sortedIndexes[i]]));
                ((LineSeries)plotModel.Series[1]).Points.Add(new DataPoint(xValues[sortedIndexes[i]], predictedYValues[sortedIndexes[i]]));
            }

            LinearAxis xAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Title = xComboBox.SelectedItem.ToString(),
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            LinearAxis yAxis = new LinearAxis()
            {
                Position = AxisPosition.Left,
                Title = target,
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.Legends.Add(new Legend()
            {
                LegendPlacement = LegendPlacement.Outside
            });
            dataPlotView.Model = plotModel;
        }
    }
}
