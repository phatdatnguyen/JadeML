using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class MultinomialLogisticRegressionLearningControl : UserControl
    {
        // Constructor
        public MultinomialLogisticRegressionLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            int learningMethod = 0;
            if (ConjugateGradientRadioButton.Checked)
                learningMethod = 1;
            else if (GradientDescentRadioButton.Checked)
                learningMethod = 2;
            else if (BroydenFletcherGoldfarbShannoRadioButton.Checked)
                learningMethod = 3;
            learningParameters.Add("method", learningMethod.ToString());
            learningParameters.Add("tolerance", ToleranceNumericUpDown.Value.ToString());
            learningParameters.Add("max iteration", MaxIterationNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            int learningMethod = Convert.ToInt32(learningParameters["method"]);
            if (learningMethod == 1)
                ConjugateGradientRadioButton.Checked = true;
            else if (learningMethod == 2)
                GradientDescentRadioButton.Checked = true;
            else if (learningMethod == 3)
                BroydenFletcherGoldfarbShannoRadioButton.Checked = true;
            ToleranceNumericUpDown.Value = Convert.ToDecimal(learningParameters["tolerance"]);
            MaxIterationNumericUpDown.Value = Convert.ToDecimal(learningParameters["max iteration"]);
        }
    }
}
