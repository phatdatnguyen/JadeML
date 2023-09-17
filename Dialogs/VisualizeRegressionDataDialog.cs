using Accord.Math;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace JadeChem.Dialogs
{
    public partial class VisualizeRegressionDataDialog : Form
    {
        #region Fields
        private readonly string[] inputColumnNames;
        private readonly string outputColumnName;
        private readonly double[][] inputColumns;
        private readonly double[] outputColumn;
        #endregion

        #region Constructor
        public VisualizeRegressionDataDialog(string[] inputColumnNames, string outputColumnName, double[][] inputColumns, double[] outputColumn)
        {
            InitializeComponent();

            this.inputColumnNames = inputColumnNames;
            this.outputColumnName = outputColumnName;
            this.inputColumns = inputColumns;
            this.outputColumn = outputColumn;

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

            UpdatePlot(0);
        }

        private void ColumnNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputColumnNameComboBox.SelectedIndex == -1)
                return;

            UpdatePlot(inputColumnNameComboBox.SelectedIndex);
        }

        private void UpdatePlot(int inputColumnIndex)
        {
            PlotModel plotModel = new()
            {
                Title = outputColumnName
            };

            LineSeries lineSeries = new();
            double[] xColumn = inputColumns.GetColumn(inputColumnIndex);
            double[] yColumn = outputColumn;
            double[] clonedXColumn = (double[])xColumn.Clone();
            clonedXColumn.Sort(out int[] sortedIndices);

            for (int rowIndex = 0; rowIndex < inputColumns.Rows(); rowIndex++)
            {
                double x = xColumn[sortedIndices[rowIndex]];
                double y = yColumn[sortedIndices[rowIndex]];

                lineSeries.Points.Add(new DataPoint(x, y));
            }
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
            lineSeries.LegendKey = outputColumnName;

            plotModel.Series.Add(lineSeries);
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
