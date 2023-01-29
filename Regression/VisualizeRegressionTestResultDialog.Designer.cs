namespace JadeML.Regression
{
    partial class VisualizeRegressionTestResultDialog
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
            this.visualizationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.xPanel = new System.Windows.Forms.Panel();
            this.xLabel = new System.Windows.Forms.Label();
            this.xComboBox = new System.Windows.Forms.ComboBox();
            this.dataPlotView = new OxyPlot.WindowsForms.PlotView();
            this.visualizationTableLayoutPanel.SuspendLayout();
            this.xPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualizationTableLayoutPanel
            // 
            this.visualizationTableLayoutPanel.ColumnCount = 1;
            this.visualizationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.visualizationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.visualizationTableLayoutPanel.Controls.Add(this.xPanel, 0, 0);
            this.visualizationTableLayoutPanel.Controls.Add(this.dataPlotView, 0, 1);
            this.visualizationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizationTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.visualizationTableLayoutPanel.Name = "visualizationTableLayoutPanel";
            this.visualizationTableLayoutPanel.RowCount = 2;
            this.visualizationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.visualizationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.visualizationTableLayoutPanel.Size = new System.Drawing.Size(484, 406);
            this.visualizationTableLayoutPanel.TabIndex = 0;
            // 
            // xPanel
            // 
            this.xPanel.Controls.Add(this.xLabel);
            this.xPanel.Controls.Add(this.xComboBox);
            this.xPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel.Location = new System.Drawing.Point(3, 3);
            this.xPanel.Name = "xPanel";
            this.xPanel.Size = new System.Drawing.Size(478, 34);
            this.xPanel.TabIndex = 0;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(3, 8);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "x";
            // 
            // xComboBox
            // 
            this.xComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xComboBox.FormattingEnabled = true;
            this.xComboBox.Location = new System.Drawing.Point(21, 5);
            this.xComboBox.Name = "xComboBox";
            this.xComboBox.Size = new System.Drawing.Size(100, 21);
            this.xComboBox.TabIndex = 0;
            this.xComboBox.SelectedIndexChanged += new System.EventHandler(this.axisComboBox_SelectedIndexChanged);
            // 
            // dataPlotView
            // 
            this.visualizationTableLayoutPanel.SetColumnSpan(this.dataPlotView, 2);
            this.dataPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPlotView.Location = new System.Drawing.Point(3, 43);
            this.dataPlotView.Name = "dataPlotView";
            this.dataPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.dataPlotView.Size = new System.Drawing.Size(478, 360);
            this.dataPlotView.TabIndex = 1;
            this.dataPlotView.Text = "plotView1";
            this.dataPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.dataPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.dataPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // VisualizeRegressionTestResultDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 406);
            this.Controls.Add(this.visualizationTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 445);
            this.Name = "VisualizeRegressionTestResultDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualize Classification Test Result";
            this.visualizationTableLayoutPanel.ResumeLayout(false);
            this.xPanel.ResumeLayout(false);
            this.xPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel visualizationTableLayoutPanel;
        private System.Windows.Forms.Panel xPanel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.ComboBox xComboBox;
        private OxyPlot.WindowsForms.PlotView dataPlotView;
    }
}