using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Regression
{
    public partial class PolynomialRegressionLearningControl : UserControl
    {
        // Constructor
        public PolynomialRegressionLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();
            learningParameters.Add("degree", DegreeNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            DegreeNumericUpDown.Value = Convert.ToDecimal(learningParameters["degree"]);
        }
    }
}
