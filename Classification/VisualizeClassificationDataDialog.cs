using Accord.Math;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class VisualizeClassificationDataDialog : Form
    {
        // Fields
        private DataTable dataTable = null;
        private string[] features = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();

        private bool graphCreated = false;

        // Constructor
        public VisualizeClassificationDataDialog(DataTable dataTable, string title)
        {
            InitializeComponent();

            Text = title;

            this.dataTable = dataTable;
            features = new string[dataTable.Columns.Count - 1];
            for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                features[i] = dataTable.Columns[i].ColumnName;
            
            string[] outputColumn = dataTable.Columns[dataTable.Columns.Count - 1].ToArray<string>();
            string[] classLabels = outputColumn.Distinct().OrderBy(x => x).ToArray();
            classes = new Dictionary<int, string>();
            for (int i = 0; i < classLabels.Length; i++)
                classes.Add(i, classLabels[i]);

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

            double[] xValues = dataTable.Columns[xComboBox.SelectedIndex].ToArray();
            double[] yValues = dataTable.Columns[yComboBox.SelectedIndex].ToArray();

            for (int i = 0; i < classes.Count; i++)
            {
                ScatterSeries series = new ScatterSeries()
                {
                    MarkerType = MarkerType.Circle,
                    Title = classes[i]
                };
                plotModel.Series.Add(series);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int classIndex = classes.FirstOrDefault(x => x.Value == dataTable.Rows[i][dataTable.Columns.Count - 1].ToString()).Key;
               ((ScatterSeries)plotModel.Series[classIndex]).Points.Add(new ScatterPoint(xValues[i], yValues[i]));
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
                LegendTitle = "Classes",
                LegendPlacement = LegendPlacement.Outside
            });
            dataPlotView.Model = plotModel;
        }
    }
}
