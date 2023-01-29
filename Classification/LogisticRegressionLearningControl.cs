using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class LogisticRegressionLearningControl : UserControl
    {
        // Constructor
        public LogisticRegressionLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            int learningMethod = 0;
            if (IterativeReweightedLeastSquaresRadioButton.Checked)
                learningMethod = 1;
            learningParameters.Add("learning method", learningMethod.ToString());
            learningParameters.Add("learning rate", LearningRateNumericUpDown.Value.ToString());
            learningParameters.Add("stochastic", StochasticCheckBox.Checked.ToString());
            learningParameters.Add("regularization", RegularizationNumericUpDown.Value.ToString());
            learningParameters.Add("tolerance", ToleranceNumericUpDown.Value.ToString());
            learningParameters.Add("max iteration", MaxIterationNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            int learningMethod = Convert.ToInt32(learningParameters["learning method"]);
            if (learningMethod == 1)
                IterativeReweightedLeastSquaresRadioButton.Checked = true;
            LearningRateNumericUpDown.Value = Convert.ToDecimal(learningParameters["learning rate"]);
            StochasticCheckBox.Checked = Convert.ToBoolean(learningParameters["stochastic"]);
            RegularizationNumericUpDown.Value = Convert.ToDecimal(learningParameters["regularization"]);
            ToleranceNumericUpDown.Value = Convert.ToDecimal(learningParameters["tolerance"]);
            MaxIterationNumericUpDown.Value = Convert.ToDecimal(learningParameters["max iteration"]);
        }
    }
}
