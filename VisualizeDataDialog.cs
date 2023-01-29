using Accord.Math;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JadeML
{
    public partial class VisualizeDataDialog : Form
    {
        // Fields
        private DataTable dataTable = null;
        private string[] features = null;

        private bool graphCreated = false;

        // Constructor
        public VisualizeDataDialog(DataTable dataTable, string title)
        {
            InitializeComponent();

            Text = title;

            this.dataTable = dataTable;

            features = new string[dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Columns.Count; i++)
                features[i] = dataTable.Columns[i].ColumnName;

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

            ScatterSeries series = new ScatterSeries()
            {
                MarkerType = MarkerType.Circle,
                Title = "Data"
            };
            plotModel.Series.Add(series);
            for (int i = 0; i < dataTable.Rows.Count; i++)
                ((ScatterSeries)plotModel.Series[0]).Points.Add(new ScatterPoint(xValues[i], yValues[i]));

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
            dataPlotView.Model = plotModel;
        }
    }
}
