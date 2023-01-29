using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadeML
{
    partial class AboutBox : Form
    {
        // Constructor
        public AboutBox()
        {
            InitializeComponent();

            string softwareName = "DN Machine Learning";
            Text = "About " + softwareName;
            labelProductName.Text = softwareName;
            labelVersion.Text = "Version: 1.0";
            labelCopyright.Text = "Copyright © " + DateTime.Now.Year.ToString();
            labelCompanyName.Text = "Author: Dat Nguyen";
        }
    }
}
