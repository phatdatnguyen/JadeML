namespace JadeChem.Dialogs
{
    partial class VisualizeLossesDialog
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
            closeButton = new Button();
            dataPlotView = new OxyPlot.WindowsForms.PlotView();
            visualizeRegressionTableLayoutPanel = new TableLayoutPanel();
            panel = new Panel();
            visualizeRegressionTableLayoutPanel.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.DialogResult = DialogResult.Cancel;
            closeButton.Location = new Point(233, 11);
            closeButton.Margin = new Padding(4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // dataPlotView
            // 
            dataPlotView.Dock = DockStyle.Fill;
            dataPlotView.Location = new Point(4, 4);
            dataPlotView.Margin = new Padding(4);
            dataPlotView.Name = "dataPlotView";
            dataPlotView.PanCursor = Cursors.Hand;
            dataPlotView.Size = new Size(316, 303);
            dataPlotView.TabIndex = 0;
            dataPlotView.Text = "Data Plot View";
            dataPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            dataPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            dataPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // visualizeRegressionTableLayoutPanel
            // 
            visualizeRegressionTableLayoutPanel.ColumnCount = 1;
            visualizeRegressionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            visualizeRegressionTableLayoutPanel.Controls.Add(dataPlotView, 0, 0);
            visualizeRegressionTableLayoutPanel.Controls.Add(panel, 0, 1);
            visualizeRegressionTableLayoutPanel.Dock = DockStyle.Fill;
            visualizeRegressionTableLayoutPanel.Location = new Point(0, 0);
            visualizeRegressionTableLayoutPanel.Name = "visualizeRegressionTableLayoutPanel";
            visualizeRegressionTableLayoutPanel.RowCount = 2;
            visualizeRegressionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            visualizeRegressionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            visualizeRegressionTableLayoutPanel.Size = new Size(324, 361);
            visualizeRegressionTableLayoutPanel.TabIndex = 7;
            // 
            // panel
            // 
            panel.Controls.Add(closeButton);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(3, 314);
            panel.Name = "panel";
            panel.Size = new Size(318, 44);
            panel.TabIndex = 1;
            // 
            // VisualizeLossesDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(324, 361);
            Controls.Add(visualizeRegressionTableLayoutPanel);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(340, 400);
            Name = "VisualizeLossesDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualize Losses";
            Load += VisualizeLossesDialog_Load;
            visualizeRegressionTableLayoutPanel.ResumeLayout(false);
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button closeButton;
        private OxyPlot.WindowsForms.PlotView dataPlotView;
        private TableLayoutPanel visualizeRegressionTableLayoutPanel;
        private Panel panel;
    }
}