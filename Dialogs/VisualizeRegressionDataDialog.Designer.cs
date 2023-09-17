namespace JadeChem.Dialogs
{
    partial class VisualizeRegressionDataDialog
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
            inputColumnNameComboBox = new ComboBox();
            inputColumnNameLabel = new Label();
            visualizeRegressionTableLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            visualizeRegressionTableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            dataPlotView.Location = new Point(4, 54);
            dataPlotView.Margin = new Padding(4);
            dataPlotView.Name = "dataPlotView";
            dataPlotView.PanCursor = Cursors.Hand;
            dataPlotView.Size = new Size(316, 253);
            dataPlotView.TabIndex = 1;
            dataPlotView.Text = "Data Plot View";
            dataPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            dataPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            dataPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // inputColumnNameComboBox
            // 
            inputColumnNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inputColumnNameComboBox.FormattingEnabled = true;
            inputColumnNameComboBox.Location = new Point(31, 10);
            inputColumnNameComboBox.Margin = new Padding(4);
            inputColumnNameComboBox.Name = "inputColumnNameComboBox";
            inputColumnNameComboBox.Size = new Size(116, 23);
            inputColumnNameComboBox.TabIndex = 0;
            inputColumnNameComboBox.SelectedIndexChanged += ColumnNameComboBox_SelectedIndexChanged;
            // 
            // inputColumnNameLabel
            // 
            inputColumnNameLabel.AutoSize = true;
            inputColumnNameLabel.Location = new Point(10, 13);
            inputColumnNameLabel.Margin = new Padding(4, 0, 4, 0);
            inputColumnNameLabel.Name = "inputColumnNameLabel";
            inputColumnNameLabel.Size = new Size(13, 15);
            inputColumnNameLabel.TabIndex = 0;
            inputColumnNameLabel.Text = "x";
            // 
            // visualizeRegressionTableLayoutPanel
            // 
            visualizeRegressionTableLayoutPanel.ColumnCount = 1;
            visualizeRegressionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            visualizeRegressionTableLayoutPanel.Controls.Add(panel1, 0, 0);
            visualizeRegressionTableLayoutPanel.Controls.Add(dataPlotView, 0, 1);
            visualizeRegressionTableLayoutPanel.Controls.Add(panel2, 0, 2);
            visualizeRegressionTableLayoutPanel.Dock = DockStyle.Fill;
            visualizeRegressionTableLayoutPanel.Location = new Point(0, 0);
            visualizeRegressionTableLayoutPanel.Name = "visualizeRegressionTableLayoutPanel";
            visualizeRegressionTableLayoutPanel.RowCount = 3;
            visualizeRegressionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            visualizeRegressionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            visualizeRegressionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            visualizeRegressionTableLayoutPanel.Size = new Size(324, 361);
            visualizeRegressionTableLayoutPanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(inputColumnNameComboBox);
            panel1.Controls.Add(inputColumnNameLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(closeButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 44);
            panel2.TabIndex = 2;
            // 
            // VisualizeRegressionDataDialog
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
            Name = "VisualizeRegressionDataDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualize Regression Data";
            Load += VisualizeRegressionDataDialog_Load;
            visualizeRegressionTableLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button closeButton;
        private OxyPlot.WindowsForms.PlotView dataPlotView;
        private ComboBox inputColumnNameComboBox;
        private Label inputColumnNameLabel;
        private TableLayoutPanel visualizeRegressionTableLayoutPanel;
        private Panel panel1;
        private Panel panel2;
    }
}