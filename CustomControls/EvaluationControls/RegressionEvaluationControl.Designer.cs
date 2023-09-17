namespace JadeChem.CustomControls.EvaluationControls
{
    partial class RegressionEvaluationControl
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
            metricsListView = new ListView();
            metricColumnHeader = new ColumnHeader();
            valueColumnHeader = new ColumnHeader();
            tableLayoutPanel = new TableLayoutPanel();
            evaluationMetricsPanel = new Panel();
            evaluationMetricsPabel = new Label();
            tableLayoutPanel.SuspendLayout();
            evaluationMetricsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // metricsListView
            // 
            metricsListView.Columns.AddRange(new ColumnHeader[] { metricColumnHeader, valueColumnHeader });
            metricsListView.Dock = DockStyle.Fill;
            metricsListView.Location = new Point(3, 43);
            metricsListView.Name = "metricsListView";
            metricsListView.Size = new Size(334, 304);
            metricsListView.TabIndex = 1;
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
            tableLayoutPanel.Controls.Add(evaluationMetricsPanel, 0, 0);
            tableLayoutPanel.Controls.Add(metricsListView, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutPanel.Size = new Size(340, 350);
            tableLayoutPanel.TabIndex = 0;
            // 
            // evaluationMetricsPanel
            // 
            evaluationMetricsPanel.Controls.Add(evaluationMetricsPabel);
            evaluationMetricsPanel.Dock = DockStyle.Fill;
            evaluationMetricsPanel.Location = new Point(3, 3);
            evaluationMetricsPanel.Name = "evaluationMetricsPanel";
            evaluationMetricsPanel.Size = new Size(334, 34);
            evaluationMetricsPanel.TabIndex = 0;
            // 
            // evaluationMetricsPabel
            // 
            evaluationMetricsPabel.AutoSize = true;
            evaluationMetricsPabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            evaluationMetricsPabel.Location = new Point(10, 10);
            evaluationMetricsPabel.Name = "evaluationMetricsPabel";
            evaluationMetricsPabel.Size = new Size(111, 13);
            evaluationMetricsPabel.TabIndex = 0;
            evaluationMetricsPabel.Text = "Evaluation metrics";
            // 
            // RegressionEvaluationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "RegressionEvaluationControl";
            Size = new Size(340, 350);
            tableLayoutPanel.ResumeLayout(false);
            evaluationMetricsPanel.ResumeLayout(false);
            evaluationMetricsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView metricsListView;
        private ColumnHeader metricColumnHeader;
        private ColumnHeader valueColumnHeader;
        private TableLayoutPanel tableLayoutPanel;
        private Panel evaluationMetricsPanel;
        private Label evaluationMetricsPabel;
    }
}
