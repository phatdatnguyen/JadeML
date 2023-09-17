using Accord.Math;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System.Data;

namespace JadeChem.Dialogs
{
    public partial class VisualizeClassificationDataDialog : Form
    {
        #region Fields
        private readonly string[] inputColumnNames;
        private readonly string outputColumnName;
        private readonly double[][] inputColumns;
        private readonly string[] outputColumn;
        private readonly string[] classLabels;
        #endregion

        #region Constructor
        public VisualizeClassificationDataDialog(string[] inputColumnNames, string outputColumnName, double[][] inputColumns, string[] outputColumn)
        {
            InitializeComponent();

            this.inputColumnNames = inputColumnNames;
            this.outputColumnName = outputColumnName;
            this.inputColumns = inputColumns;
            this.outputColumn = outputColumn;
            classLabels = outputColumn.Distinct().OrderBy(x => x).ToArray();

            input1ColumnNameComboBox.Items.Clear();
            foreach (string inputColumnName in inputColumnNames)
                input1ColumnNameComboBox.Items.Add(inputColumnName);

            input2ColumnNameComboBox.Items.Clear();
            foreach (string inputColumnName in inputColumnNames)
                input2ColumnNameComboBox.Items.Add(inputColumnName);
            ;
            input1ColumnNameComboBox.SelectedIndex = 0;
            if (inputColumnNames.Length == 1)
                input2ColumnNameComboBox.SelectedIndex = 0;
            else
                input2ColumnNameComboBox.SelectedIndex = 1;
        }
        #endregion

        #region Methods
        private void VisualizeClassificationDataDialog_Load(object sender, EventArgs e)
        {
            if (input1ColumnNameComboBox.Items.Count == 0 || input2ColumnNameComboBox.Items.Count == 0)
                return;

            if (inputColumnNames.Length == 1)
                UpdatePlot(0, 0);
            else
                UpdatePlot(0, 1);
        }

        private void ColumnNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (input1ColumnNameComboBox.SelectedIndex == -1 || input2ColumnNameComboBox.SelectedIndex == -1)
                return;

            UpdatePlot(input1ColumnNameComboBox.SelectedIndex, input2ColumnNameComboBox.SelectedIndex);
        }

        private void UpdatePlot(int input1ColumnIndex, int input2ColumnIndex)
        {
            PlotModel plotModel = new()
            {
                Title = outputColumnName
            };

            double[] xColumn = inputColumns.GetColumn(input1ColumnIndex);
            double[] yColumn = inputColumns.GetColumn(input2ColumnIndex);

            double[] clonedXColumn = (double[])xColumn.Clone();
            clonedXColumn.Sort(out int[] sortedIndices);

            Dictionary<string, ScatterSeries> scatterSeriesDictionary = new();
            for (int classIndex = 0; classIndex < classLabels.Length; classIndex++)
            {
                string classLabel = classLabels[classIndex];
                ScatterSeries scatterSeries = new()
                {
                    Title = classLabel,
                    MarkerType = MarkerType.Circle
                };
                scatterSeriesDictionary.Add(classLabel, scatterSeries);
            }

            for (int rowIndex = 0; rowIndex < inputColumns.Rows(); rowIndex++)
            {
                double x = xColumn[sortedIndices[rowIndex]];
                double y = yColumn[sortedIndices[rowIndex]];
                string classLabel = outputColumn[sortedIndices[rowIndex]];

                foreach (KeyValuePair<string, ScatterSeries> keyValuePair in scatterSeriesDictionary)
                {
                    if (keyValuePair.Key == classLabel)
                    {
                        ScatterSeries scatterSeries = keyValuePair.Value;
                        scatterSeries.Points.Add(new ScatterPoint(x, y));
                    }
                }
            }
            LinearAxis xAxis = new()
            {
                Position = AxisPosition.Bottom,
                Title = inputColumnNames[input1ColumnIndex],
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };
            LinearAxis yAxis = new()
            {
                Position = AxisPosition.Left,
                Title = inputColumnNames[input2ColumnIndex],
                MajorGridlineThickness = 1,
                MajorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.LightGray
            };

            foreach (ScatterSeries scatterSeries in scatterSeriesDictionary.Values)
                plotModel.Series.Add(scatterSeries);

            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.Legends.Add(new Legend()
            {
                LegendTitle = "Classes",
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
