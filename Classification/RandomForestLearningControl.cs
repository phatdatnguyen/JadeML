using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JadeML.Classification
{
    public partial class RandomForestLearningControl : UserControl
    {
        // Constructor
        public RandomForestLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public string GetLearningParameters()
        {
            Dictionary<string, string> learningParameters = new Dictionary<string, string>();

            learningParameters.Add("number of trees", NumberOfTreesNumericUpDown.Value.ToString());
            learningParameters.Add("sample ratio", SampleRatioNumericUpDown.Value.ToString());

            return JsonConvert.SerializeObject(learningParameters);
        }

        public void SetLearningParameters(string serializedLearningParameters)
        {
            Dictionary<string, string> learningParameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedLearningParameters);
            NumberOfTreesNumericUpDown.Value = Convert.ToDecimal(learningParameters["number of trees"]);
            SampleRatioNumericUpDown.Value = Convert.ToDecimal(learningParameters["sample ratio"]);
        }
    }
}
