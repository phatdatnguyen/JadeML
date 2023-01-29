namespace JadeML
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainRibbon = new System.Windows.Forms.Ribbon();
            this.newTaskRibbonButton = new System.Windows.Forms.RibbonButton();
            this.openRibbonButton = new System.Windows.Forms.RibbonButton();
            this.saveRibbonButton = new System.Windows.Forms.RibbonButton();
            this.closeRibbonButton = new System.Windows.Forms.RibbonButton();
            this.aboutRibbonButton = new System.Windows.Forms.RibbonButton();
            this.taskRibbonTab = new System.Windows.Forms.RibbonTab();
            this.dataRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.datasetHasHeadersCheckBox = new System.Windows.Forms.RibbonCheckBox();
            this.loadDatasetRibbonButton = new System.Windows.Forms.RibbonButton();
            this.splitDatasetRibbonButton = new System.Windows.Forms.RibbonButton();
            this.modelRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.loadModelRibbonButton = new System.Windows.Forms.RibbonButton();
            this.trainingRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.loadTrainingDatasetRibbonButton = new System.Windows.Forms.RibbonButton();
            this.trainRibbonButton = new System.Windows.Forms.RibbonButton();
            this.testingRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.loadTestingDatasetRibbonButton = new System.Windows.Forms.RibbonButton();
            this.testRibbonButton = new System.Windows.Forms.RibbonButton();
            this.predictionRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.loadPredictionDatasetRibbonButton = new System.Windows.Forms.RibbonButton();
            this.makePredictionRibbonButton = new System.Windows.Forms.RibbonButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "*.mlt";
            this.saveFileDialog.Filter = "Machine learning task (*.mlt)|*.mlt";
            this.saveFileDialog.Title = "Save task";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.mlt";
            this.openFileDialog.Filter = "Machine learning task (*.mlt)|*.mlt";
            this.openFileDialog.Title = "Open task";
            // 
            // mainRibbon
            // 
            this.mainRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.Minimized = false;
            this.mainRibbon.Name = "mainRibbon";
            // 
            // 
            // 
            this.mainRibbon.OrbDropDown.BorderRoundness = 8;
            this.mainRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.OrbDropDown.Name = "";
            this.mainRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.mainRibbon.OrbDropDown.TabIndex = 0;
            this.mainRibbon.OrbImage = null;
            this.mainRibbon.OrbVisible = false;
            // 
            // 
            // 
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.newTaskRibbonButton);
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.openRibbonButton);
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.saveRibbonButton);
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.closeRibbonButton);
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.aboutRibbonButton);
            this.mainRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainRibbon.Size = new System.Drawing.Size(1008, 200);
            this.mainRibbon.TabIndex = 3;
            this.mainRibbon.Tabs.Add(this.taskRibbonTab);
            this.mainRibbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.mainRibbon.Text = "Menu";
            this.mainRibbon.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // newTaskRibbonButton
            // 
            this.newTaskRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("newTaskRibbonButton.Image")));
            this.newTaskRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.newTaskRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("newTaskRibbonButton.SmallImage")));
            this.newTaskRibbonButton.Text = "New task";
            this.newTaskRibbonButton.ToolTip = "New task (Ctrl + N)";
            this.newTaskRibbonButton.Click += new System.EventHandler(this.newTaskRibbonButton_Click);
            // 
            // openRibbonButton
            // 
            this.openRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("openRibbonButton.Image")));
            this.openRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.openRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("openRibbonButton.SmallImage")));
            this.openRibbonButton.Text = "Open task";
            this.openRibbonButton.ToolTip = "Open task (Ctrl + O)";
            this.openRibbonButton.Click += new System.EventHandler(this.openRibbonButton_Click);
            // 
            // saveRibbonButton
            // 
            this.saveRibbonButton.Enabled = false;
            this.saveRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("saveRibbonButton.Image")));
            this.saveRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.saveRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("saveRibbonButton.SmallImage")));
            this.saveRibbonButton.Text = "Save task";
            this.saveRibbonButton.ToolTip = "Save task (Ctrl + S)";
            this.saveRibbonButton.Click += new System.EventHandler(this.saveRibbonButton_Click);
            // 
            // closeRibbonButton
            // 
            this.closeRibbonButton.Enabled = false;
            this.closeRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("closeRibbonButton.Image")));
            this.closeRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.closeRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("closeRibbonButton.SmallImage")));
            this.closeRibbonButton.Text = "Close task";
            this.closeRibbonButton.ToolTip = "Close task (Ctrl + X)";
            this.closeRibbonButton.Click += new System.EventHandler(this.closeRibbonButton_Click);
            // 
            // aboutRibbonButton
            // 
            this.aboutRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutRibbonButton.Image")));
            this.aboutRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.aboutRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("aboutRibbonButton.SmallImage")));
            this.aboutRibbonButton.Text = "Help";
            this.aboutRibbonButton.ToolTip = "Help (Ctrl + H)";
            this.aboutRibbonButton.Click += new System.EventHandler(this.aboutRibbonButton_Click);
            // 
            // taskRibbonTab
            // 
            this.taskRibbonTab.Panels.Add(this.dataRibbonPanel);
            this.taskRibbonTab.Panels.Add(this.modelRibbonPanel);
            this.taskRibbonTab.Panels.Add(this.trainingRibbonPanel);
            this.taskRibbonTab.Panels.Add(this.testingRibbonPanel);
            this.taskRibbonTab.Panels.Add(this.predictionRibbonPanel);
            this.taskRibbonTab.Text = "Machine Learning Task";
            // 
            // dataRibbonPanel
            // 
            this.dataRibbonPanel.Items.Add(this.datasetHasHeadersCheckBox);
            this.dataRibbonPanel.Items.Add(this.loadDatasetRibbonButton);
            this.dataRibbonPanel.Items.Add(this.splitDatasetRibbonButton);
            this.dataRibbonPanel.Text = "Data";
            // 
            // datasetHasHeadersCheckBox
            // 
            this.datasetHasHeadersCheckBox.Checked = true;
            this.datasetHasHeadersCheckBox.Enabled = false;
            this.datasetHasHeadersCheckBox.Text = "Has header";
            // 
            // loadDatasetRibbonButton
            // 
            this.loadDatasetRibbonButton.Enabled = false;
            this.loadDatasetRibbonButton.Image = global::JadeML.Properties.Resources.load_dataset;
            this.loadDatasetRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("loadDatasetRibbonButton.SmallImage")));
            this.loadDatasetRibbonButton.Text = "Load dataset";
            this.loadDatasetRibbonButton.ToolTip = "Load dataset (Ctrl + L)";
            this.loadDatasetRibbonButton.Click += new System.EventHandler(this.loadDatasetRibbonButton_Click);
            // 
            // splitDatasetRibbonButton
            // 
            this.splitDatasetRibbonButton.Enabled = false;
            this.splitDatasetRibbonButton.Image = global::JadeML.Properties.Resources.split_dataset;
            this.splitDatasetRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("splitDatasetRibbonButton.SmallImage")));
            this.splitDatasetRibbonButton.Text = "Split dataset";
            this.splitDatasetRibbonButton.ToolTip = "Split dataset (Ctrl + P)";
            this.splitDatasetRibbonButton.Click += new System.EventHandler(this.splitDatasetRibbonButton_Click);
            // 
            // modelRibbonPanel
            // 
            this.modelRibbonPanel.Items.Add(this.loadModelRibbonButton);
            this.modelRibbonPanel.Text = "Model";
            // 
            // loadModelRibbonButton
            // 
            this.loadModelRibbonButton.Enabled = false;
            this.loadModelRibbonButton.Image = global::JadeML.Properties.Resources.load_model;
            this.loadModelRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("loadModelRibbonButton.SmallImage")));
            this.loadModelRibbonButton.Text = "Load model";
            this.loadModelRibbonButton.ToolTip = "Load model (Ctrl + M)";
            this.loadModelRibbonButton.Click += new System.EventHandler(this.loadModelRibbonButton_Click);
            // 
            // trainingRibbonPanel
            // 
            this.trainingRibbonPanel.Items.Add(this.loadTrainingDatasetRibbonButton);
            this.trainingRibbonPanel.Items.Add(this.trainRibbonButton);
            this.trainingRibbonPanel.Text = "Model training";
            // 
            // loadTrainingDatasetRibbonButton
            // 
            this.loadTrainingDatasetRibbonButton.Enabled = false;
            this.loadTrainingDatasetRibbonButton.Image = global::JadeML.Properties.Resources.load_training_dataset;
            this.loadTrainingDatasetRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("loadTrainingDatasetRibbonButton.SmallImage")));
            this.loadTrainingDatasetRibbonButton.Text = "Load training dataset";
            this.loadTrainingDatasetRibbonButton.Click += new System.EventHandler(this.loadTrainingDatasetRibbonButton_Click);
            // 
            // trainRibbonButton
            // 
            this.trainRibbonButton.Enabled = false;
            this.trainRibbonButton.Image = global::JadeML.Properties.Resources.train_model;
            this.trainRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("trainRibbonButton.SmallImage")));
            this.trainRibbonButton.Text = "Train model";
            this.trainRibbonButton.ToolTip = "Train (Ctrl + T)";
            this.trainRibbonButton.Click += new System.EventHandler(this.trainRibbonButton_Click);
            // 
            // testingRibbonPanel
            // 
            this.testingRibbonPanel.Items.Add(this.loadTestingDatasetRibbonButton);
            this.testingRibbonPanel.Items.Add(this.testRibbonButton);
            this.testingRibbonPanel.Text = "Model testing";
            // 
            // loadTestingDatasetRibbonButton
            // 
            this.loadTestingDatasetRibbonButton.Enabled = false;
            this.loadTestingDatasetRibbonButton.Image = global::JadeML.Properties.Resources.load_testing_dataset;
            this.loadTestingDatasetRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("loadTestingDatasetRibbonButton.SmallImage")));
            this.loadTestingDatasetRibbonButton.Text = "Load testing dataset";
            this.loadTestingDatasetRibbonButton.ToolTip = "Test (Ctrl + D)";
            this.loadTestingDatasetRibbonButton.Click += new System.EventHandler(this.loadTestingDatasetRibbonButton_Click);
            // 
            // testRibbonButton
            // 
            this.testRibbonButton.Enabled = false;
            this.testRibbonButton.Image = global::JadeML.Properties.Resources.test;
            this.testRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("testRibbonButton.SmallImage")));
            this.testRibbonButton.Text = "Test model";
            this.testRibbonButton.ToolTip = "Test (Ctrl + E)";
            this.testRibbonButton.Click += new System.EventHandler(this.testRibbonButton_Click);
            // 
            // predictionRibbonPanel
            // 
            this.predictionRibbonPanel.Items.Add(this.loadPredictionDatasetRibbonButton);
            this.predictionRibbonPanel.Items.Add(this.makePredictionRibbonButton);
            this.predictionRibbonPanel.Text = "Prediction";
            // 
            // loadPredictionDatasetRibbonButton
            // 
            this.loadPredictionDatasetRibbonButton.Enabled = false;
            this.loadPredictionDatasetRibbonButton.Image = global::JadeML.Properties.Resources.load_prediction_dataset;
            this.loadPredictionDatasetRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("loadPredictionDatasetRibbonButton.SmallImage")));
            this.loadPredictionDatasetRibbonButton.Text = "Load prediction dataset";
            this.loadPredictionDatasetRibbonButton.ToolTip = "Load prediction dataset (Ctrl + I)";
            this.loadPredictionDatasetRibbonButton.Click += new System.EventHandler(this.loadPredictionDatasetRibbonButton_Click);
            // 
            // makePredictionRibbonButton
            // 
            this.makePredictionRibbonButton.Enabled = false;
            this.makePredictionRibbonButton.Image = global::JadeML.Properties.Resources.predict;
            this.makePredictionRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("makePredictionRibbonButton.SmallImage")));
            this.makePredictionRibbonButton.Text = "Make prediction";
            this.makePredictionRibbonButton.ToolTip = "Make prediction (Ctrl + K)";
            this.makePredictionRibbonButton.Click += new System.EventHandler(this.makePredictionRibbonButton_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 137);
            this.toolStripButton3.Text = "Load data";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 137);
            this.toolStripButton4.Text = "Load training data";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton7.Text = "Binary";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton8.Text = "Multiclass";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Enabled = false;
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Load testing dataset";
            this.ribbonButton1.ToolTip = "Load testing dataset (Ctrl + D)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.mainRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "JadeML";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Ribbon mainRibbon;
        private System.Windows.Forms.RibbonTab taskRibbonTab;
        private System.Windows.Forms.RibbonPanel dataRibbonPanel;
        private System.Windows.Forms.RibbonButton loadDatasetRibbonButton;
        private System.Windows.Forms.RibbonButton splitDatasetRibbonButton;
        private System.Windows.Forms.RibbonPanel modelRibbonPanel;
        private System.Windows.Forms.RibbonButton loadModelRibbonButton;
        private System.Windows.Forms.RibbonPanel trainingRibbonPanel;
        private System.Windows.Forms.RibbonPanel testingRibbonPanel;
        private System.Windows.Forms.RibbonButton trainRibbonButton;
        private System.Windows.Forms.RibbonButton testRibbonButton;
        private System.Windows.Forms.RibbonButton newTaskRibbonButton;
        private System.Windows.Forms.RibbonButton openRibbonButton;
        private System.Windows.Forms.RibbonButton saveRibbonButton;
        private System.Windows.Forms.RibbonButton closeRibbonButton;
        private System.Windows.Forms.RibbonButton aboutRibbonButton;
        private System.Windows.Forms.RibbonCheckBox datasetHasHeadersCheckBox;
        private System.Windows.Forms.RibbonButton loadTestingDatasetRibbonButton;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel predictionRibbonPanel;
        private System.Windows.Forms.RibbonButton loadPredictionDatasetRibbonButton;
        private System.Windows.Forms.RibbonButton makePredictionRibbonButton;
        private System.Windows.Forms.RibbonButton loadTrainingDatasetRibbonButton;
    }
}

