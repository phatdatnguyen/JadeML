using Accord.Math;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Clustering
{
    public partial class VisualizeClustersDialog : Form
    {
        // Fields
        private double[][] inputColumns = null;
        private int[] clusterIndexColumn = null;

        private bool graphCreated = false;

        // Constructor
        public VisualizeClustersDialog(double[][] inputColumns, int[] clusterIndexColumn, string[] features)
        {
            InitializeComponent();

            this.inputColumns = inputColumns;
            this.clusterIndexColumn = clusterIndexColumn;

            foreach (string feature in features)
            {
                xComboBox.Items.Add(feature);
                yComboBox.Items.Add(feature);
            }

            xComboBox.SelectedIndex = 0;
            if (features.Length > 1)
                yComboBox.SelectedIndex = 1;
            else
                yComboBox.SelectedIndex = 0;

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

            double[] xValues = inputColumns.GetColumn(xComboBox.SelectedIndex);
            double[] yValues = inputColumns.GetColumn(yComboBox.SelectedIndex);

            int[] clusterIndexes = clusterIndexColumn.Distinct().OrderBy(x => x).ToArray();
            for (int i = 0; i < clusterIndexes.Length; i++)
            {
                ScatterSeries series = new ScatterSeries()
                {
                    MarkerType = MarkerType.Circle,
                    Title = "Cluster " + (clusterIndexes[i] + 1).ToString()
                };
                plotModel.Series.Add(series);
            }

            for (int i = 0; i < xValues.Length; i++)
            {
                int clusterIndex = clusterIndexColumn[i];
                ((ScatterSeries)plotModel.Series[clusterIndex]).Points.Add(new ScatterPoint(xValues[i], yValues[i]));
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
                Title = yComboBox.SelectedItem.ToString(),
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.Legends.Add(new Legend()
            {
                LegendTitle = "Clusters",
                LegendPlacement = LegendPlacement.Outside
            });
            clustersPlotView.Model = plotModel;
        }
    }
}
