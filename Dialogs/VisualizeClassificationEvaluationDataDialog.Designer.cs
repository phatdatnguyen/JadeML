namespace JadeChem.Dialogs
{
    partial class VisualizeClassificationEvaluationDataDialog
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
            input1ColumnNameComboBox = new ComboBox();
            xLabel = new Label();
            yLabel = new Label();
            input2ColumnNameComboBox = new ComboBox();
            visualizeTableLayoutPanel = new TableLayoutPanel();
            dataPlotView = new OxyPlot.WindowsForms.PlotView();
            panel1 = new Panel();
            panel2 = new Panel();
            visualizeTableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.DialogResult = DialogResult.Cancel;
            closeButton.Location = new Point(232, 10);
            closeButton.Margin = new Padding(4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // input1ColumnNameComboBox
            // 
            input1ColumnNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            input1ColumnNameComboBox.FormattingEnabled = true;
            input1ColumnNameComboBox.Location = new Point(30, 9);
            input1ColumnNameComboBox.Margin = new Padding(4);
            input1ColumnNameComboBox.Name = "input1ColumnNameComboBox";
            input1ColumnNameComboBox.Size = new Size(116, 23);
            input1ColumnNameComboBox.TabIndex = 0;
            input1ColumnNameComboBox.SelectedIndexChanged += ColumnNameComboBox_SelectedIndexChanged;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(9, 12);
            xLabel.Margin = new Padding(4, 0, 4, 0);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(13, 15);
            xLabel.TabIndex = 0;
            xLabel.Text = "x";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(170, 12);
            yLabel.Margin = new Padding(4, 0, 4, 0);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(13, 15);
            yLabel.TabIndex = 0;
            yLabel.Text = "y";
            // 
            // input2ColumnNameComboBox
            // 
            input2ColumnNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            input2ColumnNameComboBox.FormattingEnabled = true;
            input2ColumnNameComboBox.Location = new Point(191, 9);
            input2ColumnNameComboBox.Margin = new Padding(4);
            input2ColumnNameComboBox.Name = "input2ColumnNameComboBox";
            input2ColumnNameComboBox.Size = new Size(116, 23);
            input2ColumnNameComboBox.TabIndex = 1;
            input2ColumnNameComboBox.SelectedIndexChanged += ColumnNameComboBox_SelectedIndexChanged;
            // 
            // visualizeTableLayoutPanel
            // 
            visualizeTableLayoutPanel.ColumnCount = 1;
            visualizeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            visualizeTableLayoutPanel.Controls.Add(panel1, 0, 0);
            visualizeTableLayoutPanel.Controls.Add(dataPlotView, 0, 1);
            visualizeTableLayoutPanel.Controls.Add(panel2, 0, 2);
            visualizeTableLayoutPanel.Dock = DockStyle.Fill;
            visualizeTableLayoutPanel.Location = new Point(0, 0);
            visualizeTableLayoutPanel.Margin = new Padding(4);
            visualizeTableLayoutPanel.Name = "visualizeTableLayoutPanel";
            visualizeTableLayoutPanel.RowCount = 3;
            visualizeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            visualizeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            visualizeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            visualizeTableLayoutPanel.Size = new Size(324, 361);
            visualizeTableLayoutPanel.TabIndex = 11;
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
            // panel1
            // 
            panel1.Controls.Add(input1ColumnNameComboBox);
            panel1.Controls.Add(xLabel);
            panel1.Controls.Add(input2ColumnNameComboBox);
            panel1.Controls.Add(yLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 42);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(closeButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 315);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 42);
            panel2.TabIndex = 2;
            // 
            // VisualizeClassificationEvaluationDataDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(324, 361);
            Controls.Add(visualizeTableLayoutPanel);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(340, 400);
            Name = "VisualizeClassificationEvaluationDataDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualize Classification Data";
            Load += VisualizeClassificationDataDialog_Load;
            visualizeTableLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button closeButton;
        private ComboBox input1ColumnNameComboBox;
        private Label xLabel;
        private Label yLabel;
        private ComboBox input2ColumnNameComboBox;
        private TableLayoutPanel visualizeTableLayoutPanel;
        private OxyPlot.WindowsForms.PlotView dataPlotView;
        private Panel panel1;
        private Panel panel2;
    }
}