using Accord;
using Accord.Statistics.Kernels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class SVMClassificationLearningControl : UserControl
    {
        // Field
        private double[][] trainingInputColumns = null;

        // Constructor
        public SVMClassificationLearningControl(double[][] trainingInputColumns)
        {
            InitializeComponent();

            this.trainingInputColumns = trainingInputColumns;
        }

        // Methods
        public IKernel CreateKernel()
        {
            if (gaussianKernelRadioButton.Checked)
                return new Gaussian((double)gaussianSigmaNumericUpDown.Value);
            else if (polynomialKernelRadioButton.Checked)
            {
                if (polynomialDegreeNumericUpDown.Value == 1)
                    return new Linear((double)polynomialConstantNumericUpDown.Value);
                return new Polynomial((int)polynomialDegreeNumericUpDown.Value, (double)polynomialConstantNumericUpDown.Value);
            }
            else if (laplacianKernelRadioButton.Checked)
                return new Laplacian((double)laplacianSigmaNumericUpDown.Value);
            else // sigmoidKernelRadioButton.Checked
                return new Sigmoid((double)sigmoidAlphaNumericUpDown.Value, (double)sigmoidConstantNumericUpDown.Value);
        }

        private void complexityEstimateButton_Click(object sender, EventArgs e)
        {
            IKernel kernel = CreateKernel();
            ComplexityNumericUpDown.Value = (decimal)kernel.EstimateComplexity(trainingInputColumns);
        }

        private void gaussianEstimateButton_Click(object sender, EventArgs e)
        {
            Gaussian gaussian = Gaussian.Estimate(trainingInputColumns, trainingInputColumns.Length);
            gaussianSigmaNumericUpDown.Value = (decimal)gaussian.Sigma;
        }

        private void laplacianEstimateButton_Click(object sender, EventArgs e)
        {
            Laplacian laplacian = Laplacian.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);
            laplacianSigmaNumericUpDown.Value = (decimal)laplacian.Sigma;
        }

        private void sigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            Sigmoid sigmoid = Sigmoid.Estimate(trainingInputColumns, trainingInputColumns.Length, out DoubleRange range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                sigmoidAlphaNumericUpDown.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                sigmoidConstantNumericUpDown.Value = (decimal)sigmoid.Constant;
        }

        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            int learningMethod = 0;
            if (LeastSquaresRadioButton.Checked)
                learningMethod = 1;
            else if (LinearCoordinateDescentRadioButton.Checked)
                learningMethod = 2;
            else if (LinearDualCoordinateDescentRadioButton.Checked)
                learningMethod = 3;
            else if (LinearNewtonRadioButton.Checked)
                learningMethod = 4;
            else if (ProbabilisticCoordinateDescentRadioButton.Checked)
                learningMethod = 5;
            else if (ProbabilisticDualCoordinateDescentRadioButton.Checked)
                learningMethod = 6;
            else if (ProbabilisticNewtonRadioButton.Checked)
                learningMethod = 7;
            else if (StochasticGradientDescentRadioButton.Checked)
                learningMethod = 8;
            else if (AveragedStochasticGradientDescentRadioButton.Checked)
                learningMethod = 9;
            learningParameters.Add("method", learningMethod.ToString());
            learningParameters.Add("complexity", ComplexityNumericUpDown.Value.ToString());
            learningParameters.Add("positive weight", PositiveWeightNumericUpDown.Value.ToString());
            learningParameters.Add("negative weight", NegativeWeightNumericUpDown.Value.ToString());
            learningParameters.Add("tolerance", ToleranceNumericUpDown.Value.ToString());
            int kernel = 0;
            if (gaussianKernelRadioButton.Checked)
                kernel = 1;
            else if (laplacianKernelRadioButton.Checked)
                kernel = 2;
            else if (sigmoidKernelRadioButton.Checked)
                kernel = 3;
            learningParameters.Add("kernel", kernel.ToString());
            learningParameters.Add("polynomial degree", polynomialDegreeNumericUpDown.Value.ToString());
            learningParameters.Add("polynomial constant", polynomialConstantNumericUpDown.Value.ToString());
            learningParameters.Add("gaussian sigma", gaussianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("laplacian sigma", laplacianSigmaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid alpha", sigmoidAlphaNumericUpDown.Value.ToString());
            learningParameters.Add("sigmoid constant", sigmoidConstantNumericUpDown.Value.ToString());
            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            int learningMethod = Convert.ToInt32(learningParameters["method"]);
            if (learningMethod == 1)
                LeastSquaresRadioButton.Checked = true;
            else if (learningMethod == 2)
                LinearCoordinateDescentRadioButton.Checked = true;
            else if (learningMethod == 3)
                LinearDualCoordinateDescentRadioButton.Checked = true;
            else if (learningMethod == 4)
                LinearNewtonRadioButton.Checked = true;
            else if (learningMethod == 5)
                ProbabilisticCoordinateDescentRadioButton.Checked = true;
            else if (learningMethod == 6)
                ProbabilisticDualCoordinateDescentRadioButton.Checked = true;
            else if (learningMethod == 7)
                ProbabilisticNewtonRadioButton.Checked = true;
            else if (learningMethod == 8)
                StochasticGradientDescentRadioButton.Checked = true;
            else if (learningMethod == 9)
                AveragedStochasticGradientDescentRadioButton.Checked = true;
            ComplexityNumericUpDown.Value = Convert.ToDecimal(learningParameters["complexity"]);
            PositiveWeightNumericUpDown.Value = Convert.ToDecimal(learningParameters["positive weight"]);
            NegativeWeightNumericUpDown.Value = Convert.ToDecimal(learningParameters["negative weight"]);
            ToleranceNumericUpDown.Value = Convert.ToDecimal(learningParameters["tolerance"]);
            int kernel = Convert.ToInt32(learningParameters["kernel"]);
            if (kernel == 1)
                gaussianKernelRadioButton.Checked = true;
            else if (kernel == 2)
                laplacianKernelRadioButton.Checked = true;
            else if (kernel == 3)
                sigmoidKernelRadioButton.Checked = true;
            polynomialDegreeNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial degree"]);
            polynomialConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["polynomial constant"]);
            gaussianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["gaussian sigma"]);
            laplacianSigmaNumericUpDown.Value = Convert.ToDecimal(learningParameters["laplacian sigma"]);
            sigmoidAlphaNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid alpha"]);
            sigmoidConstantNumericUpDown.Value = Convert.ToDecimal(learningParameters["sigmoid constant"]);
        }
    }
}
