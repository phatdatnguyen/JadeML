using Accord.MachineLearning.VectorMachines;
using Accord.Statistics.Kernels;
using JadeChem.Dialogs;

namespace JadeChem.CustomControls.ModelControls
{
    public partial class SVMModelControl : UserControl
    {
        #region Fields
        private readonly double[][] trainInputColumns;
        private string[] inputColumnNames;
        private object model;
        #endregion

        #region Property
        public Dictionary<string, double> Hyperparameters { get; set; }
        #endregion

        #region Event
        public delegate void TrainButtonClickedEventHandler(EventArgs e);
        public event TrainButtonClickedEventHandler? TrainButtonClicked;
        #endregion

        #region Constructor
        public SVMModelControl(double[][] trainInputColumns)
        {
            InitializeComponent();

            this.trainInputColumns = trainInputColumns;

            Hyperparameters = new Dictionary<string, double>
            {
                ["complexity"] = (double)complexityNumericUpDown.Value,
                ["tolerance"] = (double)toleranceNumericUpDown.Value,
                ["positive weight"] = (double)positiveWeightNumericUpDown.Value,
                ["negative weight"] = (double)negativeWeightNumericUpDown.Value,
                ["epsilon"] = (double)epsilonNumericUpDown.Value
            };

            learningMethodComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Methods
        public IKernel CreateKernel()
        {
            if (polynomialRadioButton.Checked)
            {
                if (polynomialDegreeNumericUpDown.Value == 1)
                    return new Linear((double)polynomialConstantNumericUpDown.Value);
                return new Polynomial((int)polynomialDegreeNumericUpDown.Value, (double)polynomialConstantNumericUpDown.Value);
            }
            else if (gaussianRadioButton.Checked)
                return new Gaussian((double)gaussianSigmaNumericUpDown.Value);
            else if (laplacianRadioButton.Checked)
                return new Laplacian((double)laplacianSigmaNumericUpDown.Value);
            else // sigmoidKernelRadioButton.Checked
                return new Sigmoid((double)sigmoidAlphaNumericUpDown.Value, (double)sigmoidConstantNumericUpDown.Value);
        }

        private void ComplexityEstimateButton_Click(object sender, EventArgs e)
        {
            IKernel kernel = CreateKernel();

            double complexity = kernel.EstimateComplexity(trainInputColumns);
            if (complexity < (double)complexityNumericUpDown.Minimum)
                complexityNumericUpDown.Value = complexityNumericUpDown.Minimum;
            else if (complexity > (double)complexityNumericUpDown.Maximum)
                complexityNumericUpDown.Value = complexityNumericUpDown.Maximum;
            else
                complexityNumericUpDown.Value = (decimal)complexity;
        }

        private void GaussianEstimateButton_Click(object sender, EventArgs e)
        {
            Gaussian gaussian = Gaussian.Estimate(trainInputColumns);

            double sigma = gaussian.Sigma;
            if (sigma < (double)gaussianSigmaNumericUpDown.Minimum)
                gaussianSigmaNumericUpDown.Value = gaussianSigmaNumericUpDown.Minimum;
            else if (sigma > (double)gaussianSigmaNumericUpDown.Maximum)
                gaussianSigmaNumericUpDown.Value = gaussianSigmaNumericUpDown.Maximum;
            else
                gaussianSigmaNumericUpDown.Value = (decimal)sigma;
        }

        private void LaplacianEstimateButton_Click(object sender, EventArgs e)
        {
            Laplacian laplacian = Laplacian.Estimate(trainInputColumns);

            double sigma = laplacian.Sigma;
            if (sigma < (double)laplacianSigmaNumericUpDown.Minimum)
                laplacianSigmaNumericUpDown.Value = laplacianSigmaNumericUpDown.Minimum;
            else if (sigma > (double)gaussianSigmaNumericUpDown.Maximum)
                laplacianSigmaNumericUpDown.Value = laplacianSigmaNumericUpDown.Maximum;
            else
                laplacianSigmaNumericUpDown.Value = (decimal)sigma;
        }

        private void SigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            Sigmoid sigmoid = Sigmoid.Estimate(trainInputColumns);

            double alpha = sigmoid.Alpha;
            if (alpha < (double)sigmoidAlphaNumericUpDown.Minimum)
                sigmoidAlphaNumericUpDown.Value = sigmoidAlphaNumericUpDown.Minimum;
            else if (alpha > (double)sigmoidAlphaNumericUpDown.Maximum)
                sigmoidAlphaNumericUpDown.Value = sigmoidAlphaNumericUpDown.Maximum;
            else
                sigmoidAlphaNumericUpDown.Value = (decimal)alpha;

            double constant = sigmoid.Constant;
            if (constant < (double)sigmoidConstantNumericUpDown.Minimum)
                sigmoidConstantNumericUpDown.Value = sigmoidConstantNumericUpDown.Minimum;
            else if (constant > (double)sigmoidConstantNumericUpDown.Maximum)
                sigmoidConstantNumericUpDown.Value = sigmoidConstantNumericUpDown.Maximum;
            else
                sigmoidConstantNumericUpDown.Value = (decimal)constant;
        }

        private void ComplexityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["complexity"] = (double)complexityNumericUpDown.Value;
        }

        private void ToleranceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["tolerance"] = (double)toleranceNumericUpDown.Value;
        }

        private void PositiveWeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["positive weight"] = (double)positiveWeightNumericUpDown.Value;
        }

        private void NegativeWeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["negative weight"] = (double)negativeWeightNumericUpDown.Value;
        }

        private void EpsilonNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Hyperparameters["epsilon"] = (double)epsilonNumericUpDown.Value;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            // Raise the event
            TrainButtonClicked?.Invoke(new EventArgs());
        }

        public void EnableViewSupportVectors(object model, string[] inputColumnNames)
        {
            this.model = model;
            this.inputColumnNames = inputColumnNames;
            viewSupportVectorsButton.Enabled = true;
        }

        private void ViewSupportVectorsButton_Click(object sender, EventArgs e)
        {
            if (model == null)
                return;

            if (model.GetType() == typeof(SupportVectorMachine<IKernel>))
            {
                SupportVectorsDialog supportVectorsDialog = new((SupportVectorMachine<IKernel>)model, inputColumnNames);
                supportVectorsDialog.ShowDialog(ParentForm);
            }
            else if (model.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
            {
                MulticlassSupportVectorsDialog multiclassSupportVectorsDialog = new((MulticlassSupportVectorMachine<IKernel>)model, inputColumnNames);
                multiclassSupportVectorsDialog.ShowDialog(ParentForm);
            }
        }
        #endregion
    }
}
