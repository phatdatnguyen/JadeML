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
    public partial class VisualizeRegressionDataDialog : Form
    {
        // Fields
        private DataTable dataTable = null;
        private string[] features = null;
        private string target = "";
        
        private bool graphCreated = false;

        // Constructor
        public VisualizeRegressionDataDialog(DataTable dataTable, string title)
        {
            InitializeComponent();

            Text = title;

            this.dataTable = dataTable;
            features = new string[dataTable.Columns.Count - 1];
            for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                features[i] = dataTable.Columns[i].ColumnName;
            target = dataTable.Columns[dataTable.Columns.Count - 1].ColumnName;

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

            double[] xValues = dataTable.Columns[xComboBox.SelectedIndex].ToArray();
            double[] yValues = dataTable.Columns[dataTable.Columns.Count - 1].ToArray();
            double[] sortedXValues = (double[])xValues.Clone();
            sortedXValues.Sort<double>(out int[] sortedIndexes);

            LineSeries series = new LineSeries()
            {
                MarkerType = MarkerType.Circle,
                Title = target
            };
            plotModel.Series.Add(series);

            for (int i = 0; i < sortedIndexes.Length; i++)
                ((LineSeries)plotModel.Series[0]).Points.Add(new DataPoint(xValues[sortedIndexes[i]], yValues[sortedIndexes[i]]));

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
