namespace JadeML.Classification
{
    partial class MulticlassClassificationTask
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskDiagram = new MindFusion.Diagramming.Diagram();
            this.taskTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.taskDiagramPanel = new System.Windows.Forms.Panel();
            this.taskDiagramView = new MindFusion.Diagramming.WinForms.DiagramView();
            this.taskDiagramZoomControl = new MindFusion.Common.WinForms.ZoomControl();
            this.modelVisualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.modelVisualizationPlotView = new OxyPlot.WindowsForms.PlotView();
            this.taskTabControl = new System.Windows.Forms.TabControl();
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.datasetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.datasetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.datasetVisualizeButton = new System.Windows.Forms.Button();
            this.datasetLabel = new System.Windows.Forms.Label();
            this.modelTabPage = new System.Windows.Forms.TabPage();
            this.evaluationTabPage = new System.Windows.Forms.TabPage();
            this.testMulticlassClassificationControl = new JadeML.Classification.TestMulticlassClassificationControl();
            this.predictionTabPage = new System.Windows.Forms.TabPage();
            this.makePredictionClassificationControl = new JadeML.Classification.MakePredictionClassificationControl();
            this.statusStrip.SuspendLayout();
            this.taskTableLayoutPanel.SuspendLayout();
            this.taskDiagramPanel.SuspendLayout();
            this.modelVisualizationGroupBox.SuspendLayout();
            this.taskTabControl.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.datasetTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetDataGridView)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.evaluationTabPage.SuspendLayout();
            this.predictionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 499);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Status:";
            // 
            // taskDiagram
            // 
            this.taskDiagram.TouchThreshold = 0F;
            this.taskDiagram.LinkDeleting += new System.EventHandler<MindFusion.Diagramming.LinkValidationEventArgs>(this.taskDiagram_LinkDeleting);
            this.taskDiagram.NodeDeleting += new System.EventHandler<MindFusion.Diagramming.NodeValidationEventArgs>(this.taskDiagram_NodeDeleting);
            this.taskDiagram.SelectionChanged += new System.EventHandler(this.taskDiagram_SelectionChanged);
            // 
            // taskTableLayoutPanel
            // 
            this.taskTableLayoutPanel.ColumnCount = 1;
            this.taskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taskTableLayoutPanel.Controls.Add(this.taskDiagramPanel, 0, 0);
            this.taskTableLayoutPanel.Controls.Add(this.taskTabControl, 0, 1);
            this.taskTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.taskTableLayoutPanel.Name = "taskTableLayoutPanel";
            this.taskTableLayoutPanel.RowCount = 2;
            this.taskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.taskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taskTableLayoutPanel.Size = new System.Drawing.Size(684, 496);
            this.taskTableLayoutPanel.TabIndex = 12;
            // 
            // taskDiagramPanel
            // 
            this.taskDiagramPanel.Controls.Add(this.taskDiagramView);
            this.taskDiagramPanel.Controls.Add(this.taskDiagramZoomControl);
            this.taskDiagramPanel.Controls.Add(this.modelVisualizationGroupBox);
            this.taskDiagramPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDiagramPanel.Location = new System.Drawing.Point(3, 3);
            this.taskDiagramPanel.Name = "taskDiagramPanel";
            this.taskDiagramPanel.Size = new System.Drawing.Size(678, 244);
            this.taskDiagramPanel.TabIndex = 5;
            // 
            // taskDiagramView
            // 
            this.taskDiagramView.Behavior = MindFusion.Diagramming.Behavior.Modify;
            this.taskDiagramView.Diagram = this.taskDiagram;
            this.taskDiagramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDiagramView.LicenseKey = null;
            this.taskDiagramView.Location = new System.Drawing.Point(0, 0);
            this.taskDiagramView.Name = "taskDiagramView";
            this.taskDiagramView.Size = new System.Drawing.Size(318, 244);
            this.taskDiagramView.TabIndex = 1;
            this.taskDiagramView.Text = "diagramView1";
            // 
            // taskDiagramZoomControl
            // 
            this.taskDiagramZoomControl.BackColor = System.Drawing.Color.Transparent;
            this.taskDiagramZoomControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.taskDiagramZoomControl.Location = new System.Drawing.Point(318, 0);
            this.taskDiagramZoomControl.Name = "taskDiagramZoomControl";
            this.taskDiagramZoomControl.Padding = new System.Windows.Forms.Padding(5);
            this.taskDiagramZoomControl.Size = new System.Drawing.Size(60, 244);
            this.taskDiagramZoomControl.TabIndex = 2;
            this.taskDiagramZoomControl.Target = this.taskDiagramView;
            this.taskDiagramZoomControl.TickPosition = MindFusion.Common.WinForms.TickPosition.Left;
            // 
            // modelVisualizationGroupBox
            // 
            this.modelVisualizationGroupBox.Controls.Add(this.modelVisualizationPlotView);
            this.modelVisualizationGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.modelVisualizationGroupBox.Location = new System.Drawing.Point(378, 0);
            this.modelVisualizationGroupBox.Name = "modelVisualizationGroupBox";
            this.modelVisualizationGroupBox.Size = new System.Drawing.Size(300, 244);
            this.modelVisualizationGroupBox.TabIndex = 4;
            this.modelVisualizationGroupBox.TabStop = false;
            this.modelVisualizationGroupBox.Text = "2D visualization";
            this.modelVisualizationGroupBox.Visible = false;
            // 
            // modelVisualizationPlotView
            // 
            this.modelVisualizationPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelVisualizationPlotView.Location = new System.Drawing.Point(3, 16);
            this.modelVisualizationPlotView.Name = "modelVisualizationPlotView";
            this.modelVisualizationPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.modelVisualizationPlotView.Size = new System.Drawing.Size(294, 225);
            this.modelVisualizationPlotView.TabIndex = 3;
            this.modelVisualizationPlotView.Text = "plotView1";
            this.modelVisualizationPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.modelVisualizationPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.modelVisualizationPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // taskTabControl
            // 
            this.taskTabControl.Controls.Add(this.dataTabPage);
            this.taskTabControl.Controls.Add(this.modelTabPage);
            this.taskTabControl.Controls.Add(this.evaluationTabPage);
            this.taskTabControl.Controls.Add(this.predictionTabPage);
            this.taskTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTabControl.Location = new System.Drawing.Point(3, 253);
            this.taskTabControl.Name = "taskTabControl";
            this.taskTabControl.SelectedIndex = 0;
            this.taskTabControl.Size = new System.Drawing.Size(678, 240);
            this.taskTabControl.TabIndex = 2;
            // 
            // dataTabPage
            // 
            this.dataTabPage.Controls.Add(this.datasetTableLayoutPanel);
            this.dataTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataTabPage.Size = new System.Drawing.Size(670, 214);
            this.dataTabPage.TabIndex = 0;
            this.dataTabPage.Text = "Data";
            this.dataTabPage.UseVisualStyleBackColor = true;
            // 
            // datasetTableLayoutPanel
            // 
            this.datasetTableLayoutPanel.ColumnCount = 1;
            this.datasetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetTableLayoutPanel.Controls.Add(this.datasetDataGridView, 0, 1);
            this.datasetTableLayoutPanel.Controls.Add(this.dataPanel, 0, 0);
            this.datasetTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.datasetTableLayoutPanel.Name = "datasetTableLayoutPanel";
            this.datasetTableLayoutPanel.RowCount = 2;
            this.datasetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.datasetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetTableLayoutPanel.Size = new System.Drawing.Size(664, 208);
            this.datasetTableLayoutPanel.TabIndex = 0;
            // 
            // datasetDataGridView
            // 
            this.datasetDataGridView.AllowUserToAddRows = false;
            this.datasetDataGridView.AllowUserToDeleteRows = false;
            this.datasetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datasetDataGridView.Location = new System.Drawing.Point(3, 43);
            this.datasetDataGridView.Name = "datasetDataGridView";
            this.datasetDataGridView.ReadOnly = true;
            this.datasetDataGridView.RowHeadersWidth = 51;
            this.datasetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasetDataGridView.Size = new System.Drawing.Size(658, 162);
            this.datasetDataGridView.TabIndex = 2;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.datasetVisualizeButton);
            this.dataPanel.Controls.Add(this.datasetLabel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 3);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(658, 34);
            this.dataPanel.TabIndex = 0;
            // 
            // datasetVisualizeButton
            // 
            this.datasetVisualizeButton.Location = new System.Drawing.Point(200, 6);
            this.datasetVisualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.datasetVisualizeButton.Name = "datasetVisualizeButton";
            this.datasetVisualizeButton.Size = new System.Drawing.Size(75, 23);
            this.datasetVisualizeButton.TabIndex = 3;
            this.datasetVisualizeButton.Text = "Visualize...";
            this.datasetVisualizeButton.UseVisualStyleBackColor = true;
            this.datasetVisualizeButton.Click += new System.EventHandler(this.datasetVisualizeButton_Click);
            // 
            // datasetLabel
            // 
            this.datasetLabel.AutoSize = true;
            this.datasetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetLabel.Location = new System.Drawing.Point(3, 9);
            this.datasetLabel.Name = "datasetLabel";
            this.datasetLabel.Size = new System.Drawing.Size(73, 20);
            this.datasetLabel.TabIndex = 1;
            this.datasetLabel.Text = "Dataset";
            // 
            // modelTabPage
            // 
            this.modelTabPage.AutoScroll = true;
            this.modelTabPage.Location = new System.Drawing.Point(4, 22);
            this.modelTabPage.Name = "modelTabPage";
            this.modelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelTabPage.Size = new System.Drawing.Size(670, 214);
            this.modelTabPage.TabIndex = 1;
            this.modelTabPage.Text = "Model";
            this.modelTabPage.UseVisualStyleBackColor = true;
            // 
            // evaluationTabPage
            // 
            this.evaluationTabPage.AutoScroll = true;
            this.evaluationTabPage.Controls.Add(this.testMulticlassClassificationControl);
            this.evaluationTabPage.Location = new System.Drawing.Point(4, 22);
            this.evaluationTabPage.Name = "evaluationTabPage";
            this.evaluationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.evaluationTabPage.Size = new System.Drawing.Size(670, 214);
            this.evaluationTabPage.TabIndex = 2;
            this.evaluationTabPage.Text = "Evaluation";
            this.evaluationTabPage.UseVisualStyleBackColor = true;
            // 
            // testMulticlassClassificationControl
            // 
            this.testMulticlassClassificationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.testMulticlassClassificationControl.Enabled = false;
            this.testMulticlassClassificationControl.Location = new System.Drawing.Point(3, 3);
            this.testMulticlassClassificationControl.Margin = new System.Windows.Forms.Padding(2);
            this.testMulticlassClassificationControl.Name = "testMulticlassClassificationControl";
            this.testMulticlassClassificationControl.Size = new System.Drawing.Size(647, 320);
            this.testMulticlassClassificationControl.TabIndex = 0;
            // 
            // predictionTabPage
            // 
            this.predictionTabPage.AutoScroll = true;
            this.predictionTabPage.Controls.Add(this.makePredictionClassificationControl);
            this.predictionTabPage.Location = new System.Drawing.Point(4, 22);
            this.predictionTabPage.Name = "predictionTabPage";
            this.predictionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.predictionTabPage.Size = new System.Drawing.Size(670, 214);
            this.predictionTabPage.TabIndex = 3;
            this.predictionTabPage.Text = "Prediction";
            this.predictionTabPage.UseVisualStyleBackColor = true;
            // 
            // makePredictionClassificationControl
            // 
            this.makePredictionClassificationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.makePredictionClassificationControl.Enabled = false;
            this.makePredictionClassificationControl.Location = new System.Drawing.Point(3, 3);
            this.makePredictionClassificationControl.Margin = new System.Windows.Forms.Padding(2);
            this.makePredictionClassificationControl.Name = "makePredictionClassificationControl";
            this.makePredictionClassificationControl.Size = new System.Drawing.Size(647, 400);
            this.makePredictionClassificationControl.TabIndex = 0;
            // 
            // MulticlassClassificationTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.taskTableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(699, 558);
            this.Name = "MulticlassClassificationTask";
            this.ShowIcon = false;
            this.Text = "Multiclass Classification Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BinaryClassificationForm_FormClosing);
            this.Load += new System.EventHandler(this.BinaryClassificationTask_Load);
            this.Resize += new System.EventHandler(this.BinaryClassificationTask_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.taskTableLayoutPanel.ResumeLayout(false);
            this.taskDiagramPanel.ResumeLayout(false);
            this.modelVisualizationGroupBox.ResumeLayout(false);
            this.taskTabControl.ResumeLayout(false);
            this.dataTabPage.ResumeLayout(false);
            this.datasetTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasetDataGridView)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.evaluationTabPage.ResumeLayout(false);
            this.predictionTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private MindFusion.Diagramming.Diagram taskDiagram;
        private System.Windows.Forms.TableLayoutPanel taskTableLayoutPanel;
        private System.Windows.Forms.TabControl taskTabControl;
        private System.Windows.Forms.TabPage dataTabPage;
        private System.Windows.Forms.TabPage modelTabPage;
        private System.Windows.Forms.TabPage evaluationTabPage;
        private MindFusion.Diagramming.WinForms.DiagramView taskDiagramView;
        private System.Windows.Forms.TableLayoutPanel datasetTableLayoutPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView datasetDataGridView;
        private System.Windows.Forms.Label datasetLabel;
        private System.Windows.Forms.Button datasetVisualizeButton;
        private System.Windows.Forms.TabPage predictionTabPage;
        private MakePredictionClassificationControl makePredictionClassificationControl;
        private System.Windows.Forms.Panel taskDiagramPanel;
        private MindFusion.Common.WinForms.ZoomControl taskDiagramZoomControl;
        private OxyPlot.WindowsForms.PlotView modelVisualizationPlotView;
        private System.Windows.Forms.GroupBox modelVisualizationGroupBox;
        private TestMulticlassClassificationControl testMulticlassClassificationControl;
    }
}