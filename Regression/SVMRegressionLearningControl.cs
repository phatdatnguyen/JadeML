using Accord;
using Accord.Statistics.Kernels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class SVMRegressionLearningControl : UserControl
    {
        // Field
        private double[][] inputColumns = null;

        // Property
        public double[][] InputColumns
        {
            set
            {
                inputColumns = value;

                complexityEstimateButton.Enabled = true;
                gaussianEstimateButton.Enabled = true;
                laplacianEstimateButton.Enabled = true;
                sigmoidEstimateButton.Enabled = true;
            }
        }

        // Constructor
        public SVMRegressionLearningControl()
        {
            InitializeComponent();
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
            ComplexityNumericUpDown.Value = (decimal)kernel.EstimateComplexity(inputColumns);
        }

        private void gaussianEstimateButton_Click(object sender, EventArgs e)
        {
            Gaussian gaussian = Gaussian.Estimate(inputColumns, inputColumns.Length);
            gaussianSigmaNumericUpDown.Value = (decimal)gaussian.Sigma;
        }

        private void laplacianEstimateButton_Click(object sender, EventArgs e)
        {
            Laplacian laplacian = Laplacian.Estimate(inputColumns, inputColumns.Length, out DoubleRange range);
            laplacianSigmaNumericUpDown.Value = (decimal)laplacian.Sigma;
        }

        private void sigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            Sigmoid sigmoid = Sigmoid.Estimate(inputColumns, inputColumns.Length, out DoubleRange range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                sigmoidAlphaNumericUpDown.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                sigmoidConstantNumericUpDown.Value = (decimal)sigmoid.Constant;
        }

        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            int learningMethod = 0;
            if (LinearRegressionCoordinateDescentRadioButton.Checked)
                learningMethod = 1;
            else if (LinearRegressionNewtonRadioButton.Checked)
                learningMethod = 2;
            learningParameters.Add("method", learningMethod.ToString());
            learningParameters.Add("complexity", ComplexityNumericUpDown.Value.ToString());
            learningParameters.Add("epsilon", EpsilonNumericUpDown.Value.ToString());
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
                LinearRegressionCoordinateDescentRadioButton.Checked = true;
            else if (learningMethod == 2)
                LinearRegressionNewtonRadioButton.Checked = true;
            ComplexityNumericUpDown.Value = Convert.ToDecimal(learningParameters["complexity"]);
            EpsilonNumericUpDown.Value = Convert.ToDecimal(learningParameters["epsilon"]);
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
