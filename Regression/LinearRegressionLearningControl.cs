using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class LinearRegressionLearningControl : UserControl
    {
        // Constructor
        public LinearRegressionLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();
            learningParameters.Add("intercept", InterceptCheckBox.Checked.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            InterceptCheckBox.Checked = Convert.ToBoolean(learningParameters["intercept"]);
        }
    }
}