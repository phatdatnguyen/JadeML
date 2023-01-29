namespace JadeML.Classification
{
    partial class TestMulticlassClassificationControl
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
            this.metricsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.testDatasetDataGridView = new System.Windows.Forms.DataGridView();
            this.visualizePanel = new System.Windows.Forms.Panel();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.classificationEvaluationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.confusionMatrixPanel = new System.Windows.Forms.Panel();
            this.confusionMatrixTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actualLabel = new System.Windows.Forms.Label();
            this.confusionMatrixLabel = new System.Windows.Forms.Label();
            this.predictedLabel = new System.Windows.Forms.Label();
            this.confusionMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.metricsPanel = new System.Windows.Forms.Panel();
            this.accuracyValueLabel = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetSplitContainer)).BeginInit();
            this.testDatasetSplitContainer.Panel1.SuspendLayout();
            this.testDatasetSplitContainer.Panel2.SuspendLayout();
            this.testDatasetSplitContainer.SuspendLayout();
            this.metricsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).BeginInit();
            this.visualizePanel.SuspendLayout();
            this.classificationEvaluationTableLayoutPanel.SuspendLayout();
            this.confusionMatrixPanel.SuspendLayout();
            this.confusionMatrixTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrixDataGridView)).BeginInit();
            this.metricsPanel.SuspendLayout();
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
            this.testDatasetSplitContainer.Panel1.Controls.Add(this.metricsTableLayoutPanel);
            this.testDatasetSplitContainer.Panel1MinSize = 250;
            // 
            // testDatasetSplitContainer.Panel2
            // 
            this.testDatasetSplitContainer.Panel2.Controls.Add(this.classificationEvaluationTableLayoutPanel);
            this.testDatasetSplitContainer.Panel2MinSize = 250;
            this.testDatasetSplitContainer.Size = new System.Drawing.Size(600, 320);
            this.testDatasetSplitContainer.SplitterDistance = 300;
            this.testDatasetSplitContainer.TabIndex = 0;
            // 
            // metricsTableLayoutPanel
            // 
            this.metricsTableLayoutPanel.ColumnCount = 1;
            this.metricsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.metricsTableLayoutPanel.Controls.Add(this.testDatasetDataGridView, 0, 1);
            this.metricsTableLayoutPanel.Controls.Add(this.visualizePanel, 0, 0);
            this.metricsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metricsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.metricsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.metricsTableLayoutPanel.Name = "metricsTableLayoutPanel";
            this.metricsTableLayoutPanel.RowCount = 2;
            this.metricsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.metricsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.metricsTableLayoutPanel.Size = new System.Drawing.Size(300, 320);
            this.metricsTableLayoutPanel.TabIndex = 9;
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
            this.testDatasetDataGridView.Size = new System.Drawing.Size(294, 273);
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
            this.classificationEvaluationTableLayoutPanel.Controls.Add(this.confusionMatrixPanel, 0, 1);
            this.classificationEvaluationTableLayoutPanel.Controls.Add(this.metricsPanel, 0, 0);
            this.classificationEvaluationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classificationEvaluationTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.classificationEvaluationTableLayoutPanel.Name = "classificationEvaluationTableLayoutPanel";
            this.classificationEvaluationTableLayoutPanel.RowCount = 2;
            this.classificationEvaluationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.classificationEvaluationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.classificationEvaluationTableLayoutPanel.Size = new System.Drawing.Size(296, 320);
            this.classificationEvaluationTableLayoutPanel.TabIndex = 2;
            // 
            // confusionMatrixPanel
            // 
            this.confusionMatrixPanel.Controls.Add(this.confusionMatrixTableLayoutPanel);
            this.confusionMatrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confusionMatrixPanel.Location = new System.Drawing.Point(2, 43);
            this.confusionMatrixPanel.Margin = new System.Windows.Forms.Padding(2);
            this.confusionMatrixPanel.Name = "confusionMatrixPanel";
            this.confusionMatrixPanel.Size = new System.Drawing.Size(292, 275);
            this.confusionMatrixPanel.TabIndex = 2;
            // 
            // confusionMatrixTableLayoutPanel
            // 
            this.confusionMatrixTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.confusionMatrixTableLayoutPanel.ColumnCount = 2;
            this.confusionMatrixTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.confusionMatrixTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.confusionMatrixTableLayoutPanel.Controls.Add(this.actualLabel, 0, 1);
            this.confusionMatrixTableLayoutPanel.Controls.Add(this.confusionMatrixLabel, 0, 0);
            this.confusionMatrixTableLayoutPanel.Controls.Add(this.predictedLabel, 1, 0);
            this.confusionMatrixTableLayoutPanel.Controls.Add(this.confusionMatrixDataGridView, 1, 1);
            this.confusionMatrixTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confusionMatrixTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.confusionMatrixTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.confusionMatrixTableLayoutPanel.Name = "confusionMatrixTableLayoutPanel";
            this.confusionMatrixTableLayoutPanel.RowCount = 2;
            this.confusionMatrixTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.confusionMatrixTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.confusionMatrixTableLayoutPanel.Size = new System.Drawing.Size(292, 275);
            this.confusionMatrixTableLayoutPanel.TabIndex = 4;
            // 
            // actualLabel
            // 
            this.actualLabel.AutoSize = true;
            this.actualLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualLabel.Location = new System.Drawing.Point(4, 52);
            this.actualLabel.Name = "actualLabel";
            this.actualLabel.Size = new System.Drawing.Size(94, 222);
            this.actualLabel.TabIndex = 0;
            this.actualLabel.Text = "Actual";
            this.actualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confusionMatrixLabel
            // 
            this.confusionMatrixLabel.AutoSize = true;
            this.confusionMatrixLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confusionMatrixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confusionMatrixLabel.Location = new System.Drawing.Point(4, 1);
            this.confusionMatrixLabel.Name = "confusionMatrixLabel";
            this.confusionMatrixLabel.Size = new System.Drawing.Size(94, 50);
            this.confusionMatrixLabel.TabIndex = 0;
            this.confusionMatrixLabel.Text = "Confusion Matrix";
            this.confusionMatrixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predictedLabel
            // 
            this.predictedLabel.AutoSize = true;
            this.predictedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedLabel.Location = new System.Drawing.Point(105, 1);
            this.predictedLabel.Name = "predictedLabel";
            this.predictedLabel.Size = new System.Drawing.Size(183, 50);
            this.predictedLabel.TabIndex = 0;
            this.predictedLabel.Text = "Predicted";
            this.predictedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confusionMatrixDataGridView
            // 
            this.confusionMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confusionMatrixDataGridView.ColumnHeadersVisible = false;
            this.confusionMatrixDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confusionMatrixDataGridView.Location = new System.Drawing.Point(104, 54);
            this.confusionMatrixDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.confusionMatrixDataGridView.Name = "confusionMatrixDataGridView";
            this.confusionMatrixDataGridView.ReadOnly = true;
            this.confusionMatrixDataGridView.RowHeadersVisible = false;
            this.confusionMatrixDataGridView.RowHeadersWidth = 51;
            this.confusionMatrixDataGridView.RowTemplate.Height = 24;
            this.confusionMatrixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.confusionMatrixDataGridView.Size = new System.Drawing.Size(185, 218);
            this.confusionMatrixDataGridView.TabIndex = 1;
            // 
            // metricsPanel
            // 
            this.metricsPanel.Controls.Add(this.accuracyValueLabel);
            this.metricsPanel.Controls.Add(this.accuracyLabel);
            this.metricsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metricsPanel.Location = new System.Drawing.Point(2, 2);
            this.metricsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.metricsPanel.Name = "metricsPanel";
            this.metricsPanel.Size = new System.Drawing.Size(292, 37);
            this.metricsPanel.TabIndex = 0;
            // 
            // accuracyValueLabel
            // 
            this.accuracyValueLabel.AutoSize = true;
            this.accuracyValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyValueLabel.Location = new System.Drawing.Point(196, 10);
            this.accuracyValueLabel.Name = "accuracyValueLabel";
            this.accuracyValueLabel.Size = new System.Drawing.Size(21, 13);
            this.accuracyValueLabel.TabIndex = 0;
            this.accuracyValueLabel.Text = "0%";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyLabel.Location = new System.Drawing.Point(91, 7);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(82, 20);
            this.accuracyLabel.TabIndex = 0;
            this.accuracyLabel.Text = "Accuracy";
            // 
            // TestMulticlassClassificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testDatasetSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestMulticlassClassificationControl";
            this.Size = new System.Drawing.Size(600, 320);
            this.testDatasetSplitContainer.Panel1.ResumeLayout(false);
            this.testDatasetSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetSplitContainer)).EndInit();
            this.testDatasetSplitContainer.ResumeLayout(false);
            this.metricsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).EndInit();
            this.visualizePanel.ResumeLayout(false);
            this.classificationEvaluationTableLayoutPanel.ResumeLayout(false);
            this.confusionMatrixPanel.ResumeLayout(false);
            this.confusionMatrixTableLayoutPanel.ResumeLayout(false);
            this.confusionMatrixTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrixDataGridView)).EndInit();
            this.metricsPanel.ResumeLayout(false);
            this.metricsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer testDatasetSplitContainer;
        private System.Windows.Forms.DataGridView testDatasetDataGridView;
        private System.Windows.Forms.Panel metricsPanel;
        private System.Windows.Forms.Label accuracyValueLabel;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Panel confusionMatrixPanel;
        private System.Windows.Forms.TableLayoutPanel confusionMatrixTableLayoutPanel;
        private System.Windows.Forms.Label actualLabel;
        private System.Windows.Forms.Label predictedLabel;
        private System.Windows.Forms.TableLayoutPanel metricsTableLayoutPanel;
        private System.Windows.Forms.Panel visualizePanel;
        private System.Windows.Forms.Button visualizeButton;
        private System.Windows.Forms.DataGridView confusionMatrixDataGridView;
        private System.Windows.Forms.Label confusionMatrixLabel;
        private System.Windows.Forms.TableLayoutPanel classificationEvaluationTableLayoutPanel;
    }
}
