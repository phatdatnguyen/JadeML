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
    public partial class VisualizeClusteringDataDialog : Form
    {
        // Fields
        private DataTable dataTable = null;
        private string[] features = null;
        private bool clustered = false;

        private bool graphCreated = false;

        // Constructor
        public VisualizeClusteringDataDialog(DataTable dataTable, string title, bool clustered)
        {
            InitializeComponent();

            Text = title;

            this.dataTable = dataTable;
            this.clustered = clustered;

            if (!clustered)
            {
                features = new string[dataTable.Columns.Count];
                for (int i = 0; i < dataTable.Columns.Count; i++)
                    features[i] = dataTable.Columns[i].ColumnName;
            }
            else
            {
                features = new string[dataTable.Columns.Count - 1];
                for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                    features[i] = dataTable.Columns[i].ColumnName;
            }

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

            if (!clustered)
            {
                double[] xValues = dataTable.Columns[xComboBox.SelectedIndex].ToArray();
                double[] yValues = dataTable.Columns[yComboBox.SelectedIndex].ToArray();

                ScatterSeries series = new ScatterSeries()
                {
                    MarkerType = MarkerType.Circle,
                    Title = "Unclustered"
                };
                plotModel.Series.Add(series);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    ((ScatterSeries)plotModel.Series[0]).Points.Add(new ScatterPoint(xValues[i], yValues[i]));
            }
            else
            {
                double[] xValues = dataTable.Columns[xComboBox.SelectedIndex].ToArray();
                double[] yValues = dataTable.Columns[yComboBox.SelectedIndex].ToArray();
                string[] clusterLabels = dataTable.Columns[dataTable.Columns.Count - 1].ToArray<string>().Distinct().OrderBy(x => x).ToArray();

                for (int i = 0; i < clusterLabels.Length; i++)
                {
                    ScatterSeries series = new ScatterSeries()
                    {
                        MarkerType = MarkerType.Circle,
                        Title = "Cluster " + (i + 1).ToString()
                    };
                    plotModel.Series.Add(series);
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    int clusterIndex = clusterLabels.IndexOf(dataTable.Rows[i][dataTable.Columns.Count - 1].ToString());
                    ((ScatterSeries)plotModel.Series[clusterIndex]).Points.Add(new ScatterPoint(xValues[i], yValues[i]));
                }
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
            dataPlotView.Model = plotModel;
        }
    }
}
