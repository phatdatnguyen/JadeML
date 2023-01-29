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
    public partial class VisualizeClassificationTestResultDialog : Form
    {
        // Fields
        private DataTable testDataTable = null;
        private string[] features = null;
        private Dictionary<int, string> classes = new Dictionary<int, string>();

        private bool graphCreated = false;

        // Constructor
        public VisualizeClassificationTestResultDialog(DataTable testDataTable, string title)
        {
            InitializeComponent();

            Text = title;

            this.testDataTable = testDataTable;
            features = new string[testDataTable.Columns.Count - 2];
            for (int i = 0; i < testDataTable.Columns.Count - 2; i++)
                features[i] = testDataTable.Columns[i].ColumnName;

            string[] outputColumn = testDataTable.Columns[testDataTable.Columns.Count - 2].ToArray<string>();
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

            double[] xValues = testDataTable.Columns[xComboBox.SelectedIndex].ToArray();
            double[] yValues = testDataTable.Columns[yComboBox.SelectedIndex].ToArray();

            for (int i = 0; i < classes.Count; i++)
            {
                ScatterSeries series = new ScatterSeries()
                {
                    MarkerType = MarkerType.Circle,
                    Title = classes[i]
                };
                plotModel.Series.Add(series);
            }
            ScatterSeries missedSeries = new ScatterSeries()
            {
                MarkerType = MarkerType.Circle,
                Title = "Missed"
            };
            plotModel.Series.Add(missedSeries);

            for (int i = 0; i < testDataTable.Rows.Count; i++)
            {
                int classIndex = classes.FirstOrDefault(x => x.Value == testDataTable.Rows[i][testDataTable.Columns.Count - 2].ToString()).Key;
                if (testDataTable.Rows[i][testDataTable.Columns.Count - 2].ToString() == testDataTable.Rows[i][testDataTable.Columns.Count - 1].ToString())
                    ((ScatterSeries)plotModel.Series[classIndex]).Points.Add(new ScatterPoint(xValues[i], yValues[i]));
                else
                    ((ScatterSeries)plotModel.Series[plotModel.Series.Count - 1]).Points.Add(new ScatterPoint(xValues[i], yValues[i]));
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
