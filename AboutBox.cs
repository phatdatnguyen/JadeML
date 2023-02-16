using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
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

            string softwareName = "JadeML";
            Text = "About " + softwareName;
            productNameLabel.Text = softwareName;
            versionLabel.Text = "Version: 1.0";
            copyrightLabel.Text = "Copyright © " + DateTime.Now.Year.ToString();
            authorLabel.Text = "Author: Dat Nguyen\n" +
                "Ho Chi Minh City University of Technology and Education\n" +
                "Faculty of Chemical and Food Technology";
            contactLinkLabel.Text = "Contact: datnp@hcmute.edu.vn";
        }

        private void contactLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:datnp@hcmute.edu.vn");
        }
    }
}
