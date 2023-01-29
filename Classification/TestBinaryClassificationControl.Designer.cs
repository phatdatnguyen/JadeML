namespace JadeML.Classification
{
    partial class TestBinaryClassificationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testDatasetSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.testDatasetDataGridView = new System.Windows.Forms.DataGridView();
            this.visualizePanel = new System.Windows.Forms.Panel();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.classificationEvaluationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.metricsPanel = new System.Windows.Forms.Panel();
            this.f1ScoreValueLabel = new System.Windows.Forms.Label();
            this.specificityValueLabel = new System.Windows.Forms.Label();
            this.f1ScoreLabel = new System.Windows.Forms.Label();
            this.recallValueLabel = new System.Windows.Forms.Label();
            this.precisionValueLabel = new System.Windows.Forms.Label();
            this.accuracyValueLabel = new System.Windows.Forms.Label();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.specificityLabel = new System.Windows.Forms.Label();
            this.recallLabel = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.confusionMatrixPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.falsePositiveLabel = new System.Windows.Forms.Label();
            this.trueNegativeLabel = new System.Windows.Forms.Label();
            this.truePositiveLabel = new System.Windows.Forms.Label();
            this.falseNegativeLabel = new System.Windows.Forms.Label();
            this.confusionMatrixLabel = new System.Windows.Forms.Label();
            this.positiveClassPanel = new System.Windows.Forms.Panel();
            this.class2RadioButton = new System.Windows.Forms.RadioButton();
            this.class1RadioButton = new System.Windows.Forms.RadioButton();
            this.positiveClassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetSplitContainer)).BeginInit();
            this.testDatasetSplitContainer.Panel1.SuspendLayout();
            this.testDatasetSplitContainer.Panel2.SuspendLayout();
            this.testDatasetSplitContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).BeginInit();
            this.visualizePanel.SuspendLayout();
            this.classificationEvaluationTableLayoutPanel.SuspendLayout();
            this.metricsPanel.SuspendLayout();
            this.confusionMatrixPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.positiveClassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // testDatasetSplitContainer
            // 
            this.testDatasetSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDatasetSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.testDatasetSplitContainer.Name = "testDatasetSplitContainer";
            // 
            // testDatasetSplitContainer.Panel1
            // 
            this.testDatasetSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.testDatasetSplitContainer.Panel1MinSize = 250;
            // 
            // testDatasetSplitContainer.Panel2
            // 
            this.testDatasetSplitContainer.Panel2.Controls.Add(this.classificationEvaluationTableLayoutPanel);
            this.testDatasetSplitContainer.Panel2MinSize = 250;
            this.testDatasetSplitContainer.Size = new System.Drawing.Size(600, 325);
            this.testDatasetSplitContainer.SplitterDistance = 300;
            this.testDatasetSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.testDatasetDataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.visualizePanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 325);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // testDatasetDataGridView
            // 
            this.testDatasetDataGridView.AllowUserToAddRows = false;
            this.testDatasetDataGridView.AllowUserToDeleteRows = false;
            this.testDatasetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDatasetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDatasetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.testDatasetDataGridView.Location = new System.Drawing.Point(3, 44);
            this.testDatasetDataGridView.Name = "testDatasetDataGridView";
            this.testDatasetDataGridView.ReadOnly = true;
            this.testDatasetDataGridView.RowHeadersWidth = 51;
            this.testDatasetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testDatasetDataGridView.Size = new System.Drawing.Size(294, 278);
            this.testDatasetDataGridView.TabIndex = 1;
            // 
            // visualizePanel
            // 
            this.visualizePanel.Controls.Add(this.visualizeButton);
            this.visualizePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizePanel.Location = new System.Drawing.Point(2, 2);
            this.visualizePanel.Margin = new System.Windows.Forms.Padding(2);
            this.visualizePanel.Name = "visualizePanel";
            this.visualizePanel.Size = new System.Drawing.Size(296, 37);
            this.visualizePanel.TabIndex = 0;
            // 
            // visualizeButton
            // 
            this.visualizeButton.Location = new System.Drawing.Point(5, 7);
            this.visualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(75, 23);
            this.visualizeButton.TabIndex = 10;
            this.visualizeButton.Text = "Visualize...";
            this.visualizeButton.UseVisualStyleBackColor = true;
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // classificationEvaluationTableLayoutPanel
            // 
            this.classificationEvaluationTableLayoutPanel.ColumnCount = 1;
            this.classificationEvaluationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.classificationEvaluationTableLayoutPanel.Controls.Add(this.metricsPanel, 0, 2);
            this.classificationEvaluationTableLayoutPanel.Controls.Add(this.confusionMatrixPanel, 0, 1);
            this.classificationEvaluationTableLayoutPanel.Controls.Add(this.positiveClassPanel, 0, 0);
            this.classificationEvaluationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classificationEvaluationTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.classificationEvaluationTableLayoutPanel.Name = "classificationEvaluationTableLayoutPanel";
            this.classificationEvaluationTableLayoutPanel.RowCount = 3;
            this.classificationEvaluationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.classificationEvaluationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.classificationEvaluationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.classificationEvaluationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.classificationEvaluationTableLayoutPanel.Size = new System.Drawing.Size(296, 325);
            this.classificationEvaluationTableLayoutPanel.TabIndex = 2;
            // 
            // metricsPanel
            // 
            this.metricsPanel.Controls.Add(this.f1ScoreValueLabel);
            this.metricsPanel.Controls.Add(this.specificityValueLabel);
            this.metricsPanel.Controls.Add(this.f1ScoreLabel);
            this.metricsPanel.Controls.Add(this.recallValueLabel);
            this.metricsPanel.Controls.Add(this.precisionValueLabel);
            this.metricsPanel.Controls.Add(this.accuracyValueLabel);
            this.metricsPanel.Controls.Add(this.precisionLabel);
            this.metricsPanel.Controls.Add(this.specificityLabel);
            this.metricsPanel.Controls.Add(this.recallLabel);
            this.metricsPanel.Controls.Add(this.accuracyLabel);
            this.metricsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metricsPanel.Location = new System.Drawing.Point(2, 164);
            this.metricsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.metricsPanel.Name = "metricsPanel";
            this.metricsPanel.Size = new System.Drawing.Size(292, 159);
            this.metricsPanel.TabIndex = 4;
            // 
            // f1ScoreValueLabel
            // 
            this.f1ScoreValueLabel.AutoSize = true;
            this.f1ScoreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1ScoreValueLabel.Location = new System.Drawing.Point(189, 135);
            this.f1ScoreValueLabel.Name = "f1ScoreValueLabel";
            this.f1ScoreValueLabel.Size = new System.Drawing.Size(13, 13);
            this.f1ScoreValueLabel.TabIndex = 0;
            this.f1ScoreValueLabel.Text = "0";
            // 
            // specificityValueLabel
            // 
            this.specificityValueLabel.AutoSize = true;
            this.specificityValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificityValueLabel.Location = new System.Drawing.Point(189, 104);
            this.specificityValueLabel.Name = "specificityValueLabel";
            this.specificityValueLabel.Size = new System.Drawing.Size(21, 13);
            this.specificityValueLabel.TabIndex = 0;
            this.specificityValueLabel.Text = "0%";
            // 
            // f1ScoreLabel
            // 
            this.f1ScoreLabel.AutoSize = true;
            this.f1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1ScoreLabel.Location = new System.Drawing.Point(8, 131);
            this.f1ScoreLabel.Name = "f1ScoreLabel";
            this.f1ScoreLabel.Size = new System.Drawing.Size(79, 20);
            this.f1ScoreLabel.TabIndex = 0;
            this.f1ScoreLabel.Text = "F1 score";
            // 
            // recallValueLabel
            // 
            this.recallValueLabel.AutoSize = true;
            this.recallValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recallValueLabel.Location = new System.Drawing.Point(189, 73);
            this.recallValueLabel.Name = "recallValueLabel";
            this.recallValueLabel.Size = new System.Drawing.Size(21, 13);
            this.recallValueLabel.TabIndex = 0;
            this.recallValueLabel.Text = "0%";
            // 
            // precisionValueLabel
            // 
            this.precisionValueLabel.AutoSize = true;
            this.precisionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precisionValueLabel.Location = new System.Drawing.Point(189, 43);
            this.precisionValueLabel.Name = "precisionValueLabel";
            this.precisionValueLabel.Size = new System.Drawing.Size(21, 13);
            this.precisionValueLabel.TabIndex = 7;
            this.precisionValueLabel.Text = "0%";
            // 
            // accuracyValueLabel
            // 
            this.accuracyValueLabel.AutoSize = true;
            this.accuracyValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyValueLabel.Location = new System.Drawing.Point(189, 12);
            this.accuracyValueLabel.Name = "accuracyValueLabel";
            this.accuracyValueLabel.Size = new System.Drawing.Size(21, 13);
            this.accuracyValueLabel.TabIndex = 0;
            this.accuracyValueLabel.Text = "0%";
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precisionLabel.Location = new System.Drawing.Point(8, 38);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(82, 20);
            this.precisionLabel.TabIndex = 0;
            this.precisionLabel.Text = "Precision";
            // 
            // specificityLabel
            // 
            this.specificityLabel.AutoSize = true;
            this.specificityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificityLabel.Location = new System.Drawing.Point(8, 100);
            this.specificityLabel.Name = "specificityLabel";
            this.specificityLabel.Size = new System.Drawing.Size(91, 20);
            this.specificityLabel.TabIndex = 0;
            this.specificityLabel.Text = "Specificity";
            // 
            // recallLabel
            // 
            this.recallLabel.AutoSize = true;
            this.recallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recallLabel.Location = new System.Drawing.Point(8, 69);
            this.recallLabel.Name = "recallLabel";
            this.recallLabel.Size = new System.Drawing.Size(145, 20);
            this.recallLabel.TabIndex = 0;
            this.recallLabel.Text = "Sensitivity/Recall";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyLabel.Location = new System.Drawing.Point(8, 7);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(82, 20);
            this.accuracyLabel.TabIndex = 0;
            this.accuracyLabel.Text = "Accuracy";
            // 
            // confusionMatrixPanel
            // 
            this.confusionMatrixPanel.Controls.Add(this.tableLayoutPanel1);
            this.confusionMatrixPanel.Controls.Add(this.confusionMatrixLabel);
            this.confusionMatrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confusionMatrixPanel.Location = new System.Drawing.Point(2, 67);
            this.confusionMatrixPanel.Margin = new System.Windows.Forms.Padding(2);
            this.confusionMatrixPanel.Name = "confusionMatrixPanel";
            this.confusionMatrixPanel.Size = new System.Drawing.Size(292, 93);
            this.confusionMatrixPanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.falsePositiveLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trueNegativeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.truePositiveLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.falseNegativeLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 50);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // falsePositiveLabel
            // 
            this.falsePositiveLabel.AutoSize = true;
            this.falsePositiveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.falsePositiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falsePositiveLabel.Location = new System.Drawing.Point(4, 25);
            this.falsePositiveLabel.Name = "falsePositiveLabel";
            this.falsePositiveLabel.Size = new System.Drawing.Size(127, 24);
            this.falsePositiveLabel.TabIndex = 0;
            this.falsePositiveLabel.Text = "FP =";
            this.falsePositiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trueNegativeLabel
            // 
            this.trueNegativeLabel.AutoSize = true;
            this.trueNegativeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trueNegativeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueNegativeLabel.Location = new System.Drawing.Point(138, 25);
            this.trueNegativeLabel.Name = "trueNegativeLabel";
            this.trueNegativeLabel.Size = new System.Drawing.Size(127, 24);
            this.trueNegativeLabel.TabIndex = 0;
            this.trueNegativeLabel.Text = "TN =";
            this.trueNegativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // truePositiveLabel
            // 
            this.truePositiveLabel.AutoSize = true;
            this.truePositiveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truePositiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truePositiveLabel.Location = new System.Drawing.Point(4, 1);
            this.truePositiveLabel.Name = "truePositiveLabel";
            this.truePositiveLabel.Size = new System.Drawing.Size(127, 23);
            this.truePositiveLabel.TabIndex = 0;
            this.truePositiveLabel.Text = "TP =";
            this.truePositiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // falseNegativeLabel
            // 
            this.falseNegativeLabel.AutoSize = true;
            this.falseNegativeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.falseNegativeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseNegativeLabel.Location = new System.Drawing.Point(138, 1);
            this.falseNegativeLabel.Name = "falseNegativeLabel";
            this.falseNegativeLabel.Size = new System.Drawing.Size(127, 23);
            this.falseNegativeLabel.TabIndex = 0;
            this.falseNegativeLabel.Text = "FN =";
            this.falseNegativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confusionMatrixLabel
            // 
            this.confusionMatrixLabel.AutoSize = true;
            this.confusionMatrixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confusionMatrixLabel.Location = new System.Drawing.Point(8, 9);
            this.confusionMatrixLabel.Name = "confusionMatrixLabel";
            this.confusionMatrixLabel.Size = new System.Drawing.Size(143, 20);
            this.confusionMatrixLabel.TabIndex = 0;
            this.confusionMatrixLabel.Text = "Confusion Matrix";
            // 
            // positiveClassPanel
            // 
            this.positiveClassPanel.Controls.Add(this.class2RadioButton);
            this.positiveClassPanel.Controls.Add(this.class1RadioButton);
            this.positiveClassPanel.Controls.Add(this.positiveClassLabel);
            this.positiveClassPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positiveClassPanel.Location = new System.Drawing.Point(2, 2);
            this.positiveClassPanel.Margin = new System.Windows.Forms.Padding(2);
            this.positiveClassPanel.Name = "positiveClassPanel";
            this.positiveClassPanel.Size = new System.Drawing.Size(292, 61);
            this.positiveClassPanel.TabIndex = 2;
            // 
            // class2RadioButton
            // 
            this.class2RadioButton.AutoSize = true;
            this.class2RadioButton.Location = new System.Drawing.Point(192, 33);
            this.class2RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.class2RadioButton.Name = "class2RadioButton";
            this.class2RadioButton.Size = new System.Drawing.Size(59, 17);
            this.class2RadioButton.TabIndex = 1;
            this.class2RadioButton.Text = "Class 2";
            this.class2RadioButton.UseVisualStyleBackColor = true;
            this.class2RadioButton.CheckedChanged += new System.EventHandler(this.positiveClassRadioButton_CheckedChanged);
            // 
            // class1RadioButton
            // 
            this.class1RadioButton.AutoSize = true;
            this.class1RadioButton.Checked = true;
            this.class1RadioButton.Location = new System.Drawing.Point(192, 10);
            this.class1RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.class1RadioButton.Name = "class1RadioButton";
            this.class1RadioButton.Size = new System.Drawing.Size(59, 17);
            this.class1RadioButton.TabIndex = 0;
            this.class1RadioButton.TabStop = true;
            this.class1RadioButton.Text = "Class 1";
            this.class1RadioButton.UseVisualStyleBackColor = true;
            this.class1RadioButton.CheckedChanged += new System.EventHandler(this.positiveClassRadioButton_CheckedChanged);
            // 
            // positiveClassLabel
            // 
            this.positiveClassLabel.AutoSize = true;
            this.positiveClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveClassLabel.Location = new System.Drawing.Point(8, 7);
            this.positiveClassLabel.Name = "positiveClassLabel";
            this.positiveClassLabel.Size = new System.Drawing.Size(120, 20);
            this.positiveClassLabel.TabIndex = 0;
            this.positiveClassLabel.Text = "Positive Class";
            // 
            // TestBinaryClassificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testDatasetSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestBinaryClassificationControl";
            this.Size = new System.Drawing.Size(600, 325);
            this.testDatasetSplitContainer.Panel1.ResumeLayout(false);
            this.testDatasetSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetSplitContainer)).EndInit();
            this.testDatasetSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).EndInit();
            this.visualizePanel.ResumeLayout(false);
            this.classificationEvaluationTableLayoutPanel.ResumeLayout(false);
            this.metricsPanel.ResumeLayout(false);
            this.metricsPanel.PerformLayout();
            this.confusionMatrixPanel.ResumeLayout(false);
            this.confusionMatrixPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.positiveClassPanel.ResumeLayout(false);
            this.positiveClassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer testDatasetSplitContainer;
        private System.Windows.Forms.DataGridView testDatasetDataGridView;
        private System.Windows.Forms.TableLayoutPanel classificationEvaluationTableLayoutPanel;
        private System.Windows.Forms.Panel metricsPanel;
        private System.Windows.Forms.Label f1ScoreValueLabel;
        private System.Windows.Forms.Label specificityValueLabel;
        private System.Windows.Forms.Label f1ScoreLabel;
        private System.Windows.Forms.Label recallValueLabel;
        private System.Windows.Forms.Label precisionValueLabel;
        private System.Windows.Forms.Label accuracyValueLabel;
        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Label specificityLabel;
        private System.Windows.Forms.Label recallLabel;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Panel confusionMatrixPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label falsePositiveLabel;
        private System.Windows.Forms.Label trueNegativeLabel;
        private System.Windows.Forms.Label truePositiveLabel;
        private System.Windows.Forms.Label falseNegativeLabel;
        private System.Windows.Forms.Label confusionMatrixLabel;
        private System.Windows.Forms.Panel positiveClassPanel;
        private System.Windows.Forms.RadioButton class2RadioButton;
        private System.Windows.Forms.RadioButton class1RadioButton;
        private System.Windows.Forms.Label positiveClassLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel visualizePanel;
        private System.Windows.Forms.Button visualizeButton;
    }
}
