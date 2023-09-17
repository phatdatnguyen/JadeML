namespace JadeChem.CustomControls.EvaluationControls
{
    partial class MulticlassClassificationEvaluationControl
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
            confusionMatrixDataGridView = new DataGridView();
            metricsListView = new ListView();
            metricColumnHeader = new ColumnHeader();
            valueColumnHeader = new ColumnHeader();
            tableLayoutPanel = new TableLayoutPanel();
            confusionMatrixPanel = new Panel();
            confusionMatrixLabel = new Label();
            evaluationMetricsPanel = new Panel();
            evaluationMetricsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)confusionMatrixDataGridView).BeginInit();
            tableLayoutPanel.SuspendLayout();
            confusionMatrixPanel.SuspendLayout();
            evaluationMetricsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // confusionMatrixDataGridView
            // 
            confusionMatrixDataGridView.AllowUserToAddRows = false;
            confusionMatrixDataGridView.AllowUserToDeleteRows = false;
            confusionMatrixDataGridView.ColumnHeadersVisible = false;
            confusionMatrixDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            confusionMatrixDataGridView.Location = new Point(3, 43);
            confusionMatrixDataGridView.Name = "confusionMatrixDataGridView";
            confusionMatrixDataGridView.ReadOnly = true;
            confusionMatrixDataGridView.RowHeadersVisible = false;
            confusionMatrixDataGridView.RowTemplate.Height = 25;
            confusionMatrixDataGridView.Size = new Size(328, 145);
            confusionMatrixDataGridView.TabIndex = 1;
            // 
            // metricsListView
            // 
            metricsListView.Columns.AddRange(new ColumnHeader[] { metricColumnHeader, valueColumnHeader });
            metricsListView.Dock = DockStyle.Fill;
            metricsListView.Location = new Point(3, 243);
            metricsListView.Name = "metricsListView";
            metricsListView.Size = new Size(334, 104);
            metricsListView.TabIndex = 3;
            metricsListView.UseCompatibleStateImageBehavior = false;
            metricsListView.View = View.Details;
            // 
            // metricColumnHeader
            // 
            metricColumnHeader.Text = "Metric";
            metricColumnHeader.Width = 200;
            // 
            // valueColumnHeader
            // 
            valueColumnHeader.Text = "Value";
            valueColumnHeader.Width = 100;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(confusionMatrixPanel, 0, 0);
            tableLayoutPanel.Controls.Add(confusionMatrixDataGridView, 0, 1);
            tableLayoutPanel.Controls.Add(evaluationMetricsPanel, 0, 2);
            tableLayoutPanel.Controls.Add(metricsListView, 0, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(340, 350);
            tableLayoutPanel.TabIndex = 0;
            // 
            // confusionMatrixPanel
            // 
            confusionMatrixPanel.Controls.Add(confusionMatrixLabel);
            confusionMatrixPanel.Dock = DockStyle.Fill;
            confusionMatrixPanel.Location = new Point(3, 3);
            confusionMatrixPanel.Name = "confusionMatrixPanel";
            confusionMatrixPanel.Size = new Size(334, 34);
            confusionMatrixPanel.TabIndex = 0;
            // 
            // confusionMatrixLabel
            // 
            confusionMatrixLabel.AutoSize = true;
            confusionMatrixLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            confusionMatrixLabel.Location = new Point(10, 10);
            confusionMatrixLabel.Name = "confusionMatrixLabel";
            confusionMatrixLabel.Size = new Size(100, 13);
            confusionMatrixLabel.TabIndex = 0;
            confusionMatrixLabel.Text = "Confusion matrix";
            // 
            // evaluationMetricsPanel
            // 
            evaluationMetricsPanel.Controls.Add(evaluationMetricsLabel);
            evaluationMetricsPanel.Dock = DockStyle.Fill;
            evaluationMetricsPanel.Location = new Point(3, 203);
            evaluationMetricsPanel.Name = "evaluationMetricsPanel";
            evaluationMetricsPanel.Size = new Size(334, 34);
            evaluationMetricsPanel.TabIndex = 2;
            // 
            // evaluationMetricsLabel
            // 
            evaluationMetricsLabel.AutoSize = true;
            evaluationMetricsLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            evaluationMetricsLabel.Location = new Point(10, 10);
            evaluationMetricsLabel.Name = "evaluationMetricsLabel";
            evaluationMetricsLabel.Size = new Size(111, 13);
            evaluationMetricsLabel.TabIndex = 1;
            evaluationMetricsLabel.Text = "Evaluation metrics";
            // 
            // MulticlassClassificationEvaluationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "MulticlassClassificationEvaluationControl";
            Size = new Size(340, 350);
            ((System.ComponentModel.ISupportInitialize)confusionMatrixDataGridView).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            confusionMatrixPanel.ResumeLayout(false);
            confusionMatrixPanel.PerformLayout();
            evaluationMetricsPanel.ResumeLayout(false);
            evaluationMetricsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView confusionMatrixDataGridView;
        private ListView metricsListView;
        private ColumnHeader metricColumnHeader;
        private ColumnHeader valueColumnHeader;
        private TableLayoutPanel tableLayoutPanel;
        private Panel confusionMatrixPanel;
        private Label confusionMatrixLabel;
        private Panel evaluationMetricsPanel;
        private Label evaluationMetricsLabel;
    }
}
