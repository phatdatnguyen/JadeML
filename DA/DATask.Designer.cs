using JadeML.Classification;
using JadeML.Clustering;

namespace JadeML.DA
{
    partial class DATask
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskDiagram = new MindFusion.Diagramming.Diagram();
            this.taskDiagramPanel = new System.Windows.Forms.Panel();
            this.taskDiagramView = new MindFusion.Diagramming.WinForms.DiagramView();
            this.taskDiagramZoomControl = new MindFusion.Common.WinForms.ZoomControl();
            this.taskTabControl = new System.Windows.Forms.TabControl();
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.datasetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.datasetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.datasetVisualizeButton = new System.Windows.Forms.Button();
            this.datasetLabel = new System.Windows.Forms.Label();
            this.modelTabPage = new System.Windows.Forms.TabPage();
            this.modelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.kernelGroupBox = new System.Windows.Forms.GroupBox();
            this.sigmoidEstimateButton = new System.Windows.Forms.Button();
            this.laplacianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianEstimateButton = new System.Windows.Forms.Button();
            this.gaussianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaLabel = new System.Windows.Forms.Label();
            this.gaussianSigmaLabel = new System.Windows.Forms.Label();
            this.sigmoidConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidAlphaLabel = new System.Windows.Forms.Label();
            this.sigmoidAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialConstantLabel = new System.Windows.Forms.Label();
            this.polynomialDegreeLabel = new System.Windows.Forms.Label();
            this.polynomialConstantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.polynomialDegreeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sigmoidConstantLabel = new System.Windows.Forms.Label();
            this.sigmoidKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.polynomialKernelRadioButton = new System.Windows.Forms.RadioButton();
            this.laplacianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussianSigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.analysisGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfDiscriminantsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfDiscriminantsLabel = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.discriminantsGroupBox = new System.Windows.Forms.GroupBox();
            this.EigenvectorLabel = new System.Windows.Forms.Label();
            this.proportionTextBox = new System.Windows.Forms.TextBox();
            this.proportionLabel = new System.Windows.Forms.Label();
            this.eigenvalueTextBox = new System.Windows.Forms.TextBox();
            this.eigenvalueLabel = new System.Windows.Forms.Label();
            this.eigenvectorDataGridView = new System.Windows.Forms.DataGridView();
            this.discriminantLabel = new System.Windows.Forms.Label();
            this.discriminentComboBox = new System.Windows.Forms.ComboBox();
            this.evaluationTabPage = new System.Windows.Forms.TabPage();
            this.testMulticlassClassificationControl = new JadeML.Classification.TestMulticlassClassificationControl();
            this.projectionTabPage = new System.Windows.Forms.TabPage();
            this.datasetProjectionGroupBox = new System.Windows.Forms.GroupBox();
            this.datasetProjectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.datasetProjectionDataGridView = new System.Windows.Forms.DataGridView();
            this.datasetProjectionPanel = new System.Windows.Forms.Panel();
            this.visualizeProjectedDataButton = new System.Windows.Forms.Button();
            this.singleProjectionGroupBox = new System.Windows.Forms.GroupBox();
            this.singleProjectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.singleProjectionPCDataGridView = new System.Windows.Forms.DataGridView();
            this.singleProjectionInputDataGridView = new System.Windows.Forms.DataGridView();
            this.singleProjectionPanel = new System.Windows.Forms.Panel();
            this.projectButton = new System.Windows.Forms.Button();
            this.taskSplitContainer = new System.Windows.Forms.SplitContainer();
            this.eigenvectorPanel = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.taskDiagramPanel.SuspendLayout();
            this.taskTabControl.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.datasetTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetDataGridView)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.modelTabPage.SuspendLayout();
            this.modelTableLayoutPanel.SuspendLayout();
            this.kernelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).BeginInit();
            this.analysisGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiscriminantsNumericUpDown)).BeginInit();
            this.discriminantsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).BeginInit();
            this.evaluationTabPage.SuspendLayout();
            this.projectionTabPage.SuspendLayout();
            this.datasetProjectionGroupBox.SuspendLayout();
            this.datasetProjectionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetProjectionDataGridView)).BeginInit();
            this.datasetProjectionPanel.SuspendLayout();
            this.singleProjectionGroupBox.SuspendLayout();
            this.singleProjectionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionPCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionInputDataGridView)).BeginInit();
            this.singleProjectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskSplitContainer)).BeginInit();
            this.taskSplitContainer.Panel1.SuspendLayout();
            this.taskSplitContainer.Panel2.SuspendLayout();
            this.taskSplitContainer.SuspendLayout();
            this.eigenvectorPanel.SuspendLayout();
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
            // taskDiagramPanel
            // 
            this.taskDiagramPanel.Controls.Add(this.taskDiagramView);
            this.taskDiagramPanel.Controls.Add(this.taskDiagramZoomControl);
            this.taskDiagramPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDiagramPanel.Location = new System.Drawing.Point(0, 0);
            this.taskDiagramPanel.Name = "taskDiagramPanel";
            this.taskDiagramPanel.Size = new System.Drawing.Size(684, 248);
            this.taskDiagramPanel.TabIndex = 0;
            // 
            // taskDiagramView
            // 
            this.taskDiagramView.Behavior = MindFusion.Diagramming.Behavior.Modify;
            this.taskDiagramView.Diagram = this.taskDiagram;
            this.taskDiagramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDiagramView.LicenseKey = null;
            this.taskDiagramView.Location = new System.Drawing.Point(0, 0);
            this.taskDiagramView.Name = "taskDiagramView";
            this.taskDiagramView.Size = new System.Drawing.Size(624, 248);
            this.taskDiagramView.TabIndex = 0;
            this.taskDiagramView.Text = "diagramView1";
            // 
            // taskDiagramZoomControl
            // 
            this.taskDiagramZoomControl.BackColor = System.Drawing.Color.Transparent;
            this.taskDiagramZoomControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.taskDiagramZoomControl.Location = new System.Drawing.Point(624, 0);
            this.taskDiagramZoomControl.Name = "taskDiagramZoomControl";
            this.taskDiagramZoomControl.Padding = new System.Windows.Forms.Padding(5);
            this.taskDiagramZoomControl.Size = new System.Drawing.Size(60, 248);
            this.taskDiagramZoomControl.TabIndex = 1;
            this.taskDiagramZoomControl.Target = this.taskDiagramView;
            this.taskDiagramZoomControl.TickPosition = MindFusion.Common.WinForms.TickPosition.Left;
            // 
            // taskTabControl
            // 
            this.taskTabControl.Controls.Add(this.dataTabPage);
            this.taskTabControl.Controls.Add(this.modelTabPage);
            this.taskTabControl.Controls.Add(this.evaluationTabPage);
            this.taskTabControl.Controls.Add(this.projectionTabPage);
            this.taskTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTabControl.Location = new System.Drawing.Point(0, 0);
            this.taskTabControl.Name = "taskTabControl";
            this.taskTabControl.SelectedIndex = 0;
            this.taskTabControl.Size = new System.Drawing.Size(684, 244);
            this.taskTabControl.TabIndex = 1;
            // 
            // dataTabPage
            // 
            this.dataTabPage.Controls.Add(this.datasetTableLayoutPanel);
            this.dataTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataTabPage.Size = new System.Drawing.Size(676, 218);
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
            this.datasetTableLayoutPanel.Size = new System.Drawing.Size(670, 212);
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
            this.datasetDataGridView.Size = new System.Drawing.Size(664, 166);
            this.datasetDataGridView.TabIndex = 1;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.datasetVisualizeButton);
            this.dataPanel.Controls.Add(this.datasetLabel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 3);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(664, 34);
            this.dataPanel.TabIndex = 0;
            // 
            // datasetVisualizeButton
            // 
            this.datasetVisualizeButton.Location = new System.Drawing.Point(250, 6);
            this.datasetVisualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.datasetVisualizeButton.Name = "datasetVisualizeButton";
            this.datasetVisualizeButton.Size = new System.Drawing.Size(75, 23);
            this.datasetVisualizeButton.TabIndex = 0;
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
            this.datasetLabel.TabIndex = 0;
            this.datasetLabel.Text = "Dataset";
            // 
            // modelTabPage
            // 
            this.modelTabPage.AutoScroll = true;
            this.modelTabPage.Controls.Add(this.modelTableLayoutPanel);
            this.modelTabPage.Location = new System.Drawing.Point(4, 22);
            this.modelTabPage.Name = "modelTabPage";
            this.modelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelTabPage.Size = new System.Drawing.Size(676, 218);
            this.modelTabPage.TabIndex = 1;
            this.modelTabPage.Text = "DA Model";
            this.modelTabPage.UseVisualStyleBackColor = true;
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 2;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.modelTableLayoutPanel.Controls.Add(this.kernelGroupBox, 0, 1);
            this.modelTableLayoutPanel.Controls.Add(this.analysisGroupBox, 0, 0);
            this.modelTableLayoutPanel.Controls.Add(this.discriminantsGroupBox, 1, 0);
            this.modelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelTableLayoutPanel.Enabled = false;
            this.modelTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.modelTableLayoutPanel.Name = "modelTableLayoutPanel";
            this.modelTableLayoutPanel.RowCount = 2;
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.Size = new System.Drawing.Size(653, 422);
            this.modelTableLayoutPanel.TabIndex = 0;
            // 
            // kernelGroupBox
            // 
            this.kernelGroupBox.Controls.Add(this.sigmoidEstimateButton);
            this.kernelGroupBox.Controls.Add(this.laplacianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.gaussianEstimateButton);
            this.kernelGroupBox.Controls.Add(this.gaussianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidAlphaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeLabel);
            this.kernelGroupBox.Controls.Add(this.polynomialConstantNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.polynomialDegreeNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.sigmoidConstantLabel);
            this.kernelGroupBox.Controls.Add(this.sigmoidKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.polynomialKernelRadioButton);
            this.kernelGroupBox.Controls.Add(this.laplacianSigmaNumericUpDown);
            this.kernelGroupBox.Controls.Add(this.gaussianSigmaNumericUpDown);
            this.kernelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kernelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kernelGroupBox.Location = new System.Drawing.Point(2, 62);
            this.kernelGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.kernelGroupBox.Name = "kernelGroupBox";
            this.kernelGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.kernelGroupBox.Size = new System.Drawing.Size(322, 358);
            this.kernelGroupBox.TabIndex = 1;
            this.kernelGroupBox.TabStop = false;
            this.kernelGroupBox.Text = "Kernel";
            // 
            // sigmoidEstimateButton
            // 
            this.sigmoidEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidEstimateButton.Location = new System.Drawing.Point(192, 297);
            this.sigmoidEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidEstimateButton.Name = "sigmoidEstimateButton";
            this.sigmoidEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.sigmoidEstimateButton.TabIndex = 12;
            this.sigmoidEstimateButton.Text = "Estimate";
            this.sigmoidEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sigmoidEstimateButton.UseVisualStyleBackColor = true;
            this.sigmoidEstimateButton.Click += new System.EventHandler(this.sigmoidEstimateButton_Click);
            // 
            // laplacianEstimateButton
            // 
            this.laplacianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianEstimateButton.Location = new System.Drawing.Point(192, 225);
            this.laplacianEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianEstimateButton.Name = "laplacianEstimateButton";
            this.laplacianEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.laplacianEstimateButton.TabIndex = 8;
            this.laplacianEstimateButton.Text = "Estimate";
            this.laplacianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.laplacianEstimateButton.UseVisualStyleBackColor = true;
            this.laplacianEstimateButton.Click += new System.EventHandler(this.laplacianEstimateButton_Click);
            // 
            // gaussianEstimateButton
            // 
            this.gaussianEstimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianEstimateButton.Location = new System.Drawing.Point(192, 148);
            this.gaussianEstimateButton.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianEstimateButton.Name = "gaussianEstimateButton";
            this.gaussianEstimateButton.Size = new System.Drawing.Size(75, 23);
            this.gaussianEstimateButton.TabIndex = 5;
            this.gaussianEstimateButton.Text = "Estimate";
            this.gaussianEstimateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gaussianEstimateButton.UseVisualStyleBackColor = true;
            this.gaussianEstimateButton.Click += new System.EventHandler(this.gaussianEstimateButton_Click);
            // 
            // gaussianKernelRadioButton
            // 
            this.gaussianKernelRadioButton.AutoSize = true;
            this.gaussianKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianKernelRadioButton.Location = new System.Drawing.Point(27, 123);
            this.gaussianKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianKernelRadioButton.Name = "gaussianKernelRadioButton";
            this.gaussianKernelRadioButton.Size = new System.Drawing.Size(102, 17);
            this.gaussianKernelRadioButton.TabIndex = 3;
            this.gaussianKernelRadioButton.Text = "Gaussian Kernel";
            this.gaussianKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianSigmaLabel
            // 
            this.laplacianSigmaLabel.AutoSize = true;
            this.laplacianSigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianSigmaLabel.Location = new System.Drawing.Point(95, 230);
            this.laplacianSigmaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laplacianSigmaLabel.Name = "laplacianSigmaLabel";
            this.laplacianSigmaLabel.Size = new System.Drawing.Size(14, 13);
            this.laplacianSigmaLabel.TabIndex = 0;
            this.laplacianSigmaLabel.Text = "σ";
            // 
            // gaussianSigmaLabel
            // 
            this.gaussianSigmaLabel.AutoSize = true;
            this.gaussianSigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianSigmaLabel.Location = new System.Drawing.Point(95, 153);
            this.gaussianSigmaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gaussianSigmaLabel.Name = "gaussianSigmaLabel";
            this.gaussianSigmaLabel.Size = new System.Drawing.Size(14, 13);
            this.gaussianSigmaLabel.TabIndex = 0;
            this.gaussianSigmaLabel.Text = "σ";
            // 
            // sigmoidConstantNumericUpDown
            // 
            this.sigmoidConstantNumericUpDown.DecimalPlaces = 4;
            this.sigmoidConstantNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidConstantNumericUpDown.Location = new System.Drawing.Point(113, 323);
            this.sigmoidConstantNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidConstantNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sigmoidConstantNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.sigmoidConstantNumericUpDown.Name = "sigmoidConstantNumericUpDown";
            this.sigmoidConstantNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.sigmoidConstantNumericUpDown.TabIndex = 11;
            this.sigmoidConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sigmoidAlphaLabel
            // 
            this.sigmoidAlphaLabel.AutoSize = true;
            this.sigmoidAlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidAlphaLabel.Location = new System.Drawing.Point(95, 302);
            this.sigmoidAlphaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sigmoidAlphaLabel.Name = "sigmoidAlphaLabel";
            this.sigmoidAlphaLabel.Size = new System.Drawing.Size(14, 13);
            this.sigmoidAlphaLabel.TabIndex = 0;
            this.sigmoidAlphaLabel.Text = "α";
            // 
            // sigmoidAlphaNumericUpDown
            // 
            this.sigmoidAlphaNumericUpDown.DecimalPlaces = 4;
            this.sigmoidAlphaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidAlphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.sigmoidAlphaNumericUpDown.Location = new System.Drawing.Point(113, 300);
            this.sigmoidAlphaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidAlphaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sigmoidAlphaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.sigmoidAlphaNumericUpDown.Name = "sigmoidAlphaNumericUpDown";
            this.sigmoidAlphaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.sigmoidAlphaNumericUpDown.TabIndex = 10;
            this.sigmoidAlphaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sigmoidAlphaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // polynomialConstantLabel
            // 
            this.polynomialConstantLabel.AutoSize = true;
            this.polynomialConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialConstantLabel.Location = new System.Drawing.Point(60, 81);
            this.polynomialConstantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polynomialConstantLabel.Name = "polynomialConstantLabel";
            this.polynomialConstantLabel.Size = new System.Drawing.Size(49, 13);
            this.polynomialConstantLabel.TabIndex = 0;
            this.polynomialConstantLabel.Text = "Constant";
            // 
            // polynomialDegreeLabel
            // 
            this.polynomialDegreeLabel.AutoSize = true;
            this.polynomialDegreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialDegreeLabel.Location = new System.Drawing.Point(67, 58);
            this.polynomialDegreeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polynomialDegreeLabel.Name = "polynomialDegreeLabel";
            this.polynomialDegreeLabel.Size = new System.Drawing.Size(42, 13);
            this.polynomialDegreeLabel.TabIndex = 0;
            this.polynomialDegreeLabel.Text = "Degree";
            // 
            // polynomialConstantNumericUpDown
            // 
            this.polynomialConstantNumericUpDown.DecimalPlaces = 4;
            this.polynomialConstantNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialConstantNumericUpDown.Location = new System.Drawing.Point(113, 79);
            this.polynomialConstantNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialConstantNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.polynomialConstantNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.polynomialConstantNumericUpDown.Name = "polynomialConstantNumericUpDown";
            this.polynomialConstantNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.polynomialConstantNumericUpDown.TabIndex = 2;
            this.polynomialConstantNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // polynomialDegreeNumericUpDown
            // 
            this.polynomialDegreeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialDegreeNumericUpDown.Location = new System.Drawing.Point(113, 56);
            this.polynomialDegreeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialDegreeNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.polynomialDegreeNumericUpDown.Name = "polynomialDegreeNumericUpDown";
            this.polynomialDegreeNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.polynomialDegreeNumericUpDown.TabIndex = 1;
            this.polynomialDegreeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.polynomialDegreeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sigmoidConstantLabel
            // 
            this.sigmoidConstantLabel.AutoSize = true;
            this.sigmoidConstantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidConstantLabel.Location = new System.Drawing.Point(60, 325);
            this.sigmoidConstantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sigmoidConstantLabel.Name = "sigmoidConstantLabel";
            this.sigmoidConstantLabel.Size = new System.Drawing.Size(49, 13);
            this.sigmoidConstantLabel.TabIndex = 0;
            this.sigmoidConstantLabel.Text = "Constant";
            // 
            // sigmoidKernelRadioButton
            // 
            this.sigmoidKernelRadioButton.AutoSize = true;
            this.sigmoidKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoidKernelRadioButton.Location = new System.Drawing.Point(27, 271);
            this.sigmoidKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.sigmoidKernelRadioButton.Name = "sigmoidKernelRadioButton";
            this.sigmoidKernelRadioButton.Size = new System.Drawing.Size(95, 17);
            this.sigmoidKernelRadioButton.TabIndex = 9;
            this.sigmoidKernelRadioButton.Text = "Sigmoid Kernel";
            this.sigmoidKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianKernelRadioButton
            // 
            this.laplacianKernelRadioButton.AutoSize = true;
            this.laplacianKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianKernelRadioButton.Location = new System.Drawing.Point(27, 199);
            this.laplacianKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianKernelRadioButton.Name = "laplacianKernelRadioButton";
            this.laplacianKernelRadioButton.Size = new System.Drawing.Size(104, 17);
            this.laplacianKernelRadioButton.TabIndex = 6;
            this.laplacianKernelRadioButton.Text = "Laplacian Kernel";
            this.laplacianKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // polynomialKernelRadioButton
            // 
            this.polynomialKernelRadioButton.AutoSize = true;
            this.polynomialKernelRadioButton.Checked = true;
            this.polynomialKernelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polynomialKernelRadioButton.Location = new System.Drawing.Point(27, 27);
            this.polynomialKernelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.polynomialKernelRadioButton.Name = "polynomialKernelRadioButton";
            this.polynomialKernelRadioButton.Size = new System.Drawing.Size(108, 17);
            this.polynomialKernelRadioButton.TabIndex = 0;
            this.polynomialKernelRadioButton.TabStop = true;
            this.polynomialKernelRadioButton.Text = "Polynomial Kernel";
            this.polynomialKernelRadioButton.UseVisualStyleBackColor = true;
            // 
            // laplacianSigmaNumericUpDown
            // 
            this.laplacianSigmaNumericUpDown.DecimalPlaces = 4;
            this.laplacianSigmaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.laplacianSigmaNumericUpDown.Location = new System.Drawing.Point(113, 228);
            this.laplacianSigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.laplacianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.laplacianSigmaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.laplacianSigmaNumericUpDown.Name = "laplacianSigmaNumericUpDown";
            this.laplacianSigmaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.laplacianSigmaNumericUpDown.TabIndex = 7;
            this.laplacianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.laplacianSigmaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // gaussianSigmaNumericUpDown
            // 
            this.gaussianSigmaNumericUpDown.DecimalPlaces = 4;
            this.gaussianSigmaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussianSigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.gaussianSigmaNumericUpDown.Location = new System.Drawing.Point(113, 151);
            this.gaussianSigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianSigmaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.gaussianSigmaNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.gaussianSigmaNumericUpDown.Name = "gaussianSigmaNumericUpDown";
            this.gaussianSigmaNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.gaussianSigmaNumericUpDown.TabIndex = 4;
            this.gaussianSigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gaussianSigmaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // analysisGroupBox
            // 
            this.analysisGroupBox.Controls.Add(this.numberOfDiscriminantsNumericUpDown);
            this.analysisGroupBox.Controls.Add(this.numberOfDiscriminantsLabel);
            this.analysisGroupBox.Controls.Add(this.analyzeButton);
            this.analysisGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisGroupBox.Location = new System.Drawing.Point(3, 3);
            this.analysisGroupBox.Name = "analysisGroupBox";
            this.analysisGroupBox.Size = new System.Drawing.Size(320, 54);
            this.analysisGroupBox.TabIndex = 0;
            this.analysisGroupBox.TabStop = false;
            this.analysisGroupBox.Text = "Analysis";
            // 
            // numberOfDiscriminantsNumericUpDown
            // 
            this.numberOfDiscriminantsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDiscriminantsNumericUpDown.Location = new System.Drawing.Point(176, 21);
            this.numberOfDiscriminantsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfDiscriminantsNumericUpDown.Name = "numberOfDiscriminantsNumericUpDown";
            this.numberOfDiscriminantsNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.numberOfDiscriminantsNumericUpDown.TabIndex = 0;
            this.numberOfDiscriminantsNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numberOfDiscriminantsLabel
            // 
            this.numberOfDiscriminantsLabel.AutoSize = true;
            this.numberOfDiscriminantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDiscriminantsLabel.Location = new System.Drawing.Point(49, 23);
            this.numberOfDiscriminantsLabel.Name = "numberOfDiscriminantsLabel";
            this.numberOfDiscriminantsLabel.Size = new System.Drawing.Size(121, 13);
            this.numberOfDiscriminantsLabel.TabIndex = 0;
            this.numberOfDiscriminantsLabel.Text = "Number of Discriminants";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeButton.Location = new System.Drawing.Point(123, 146);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 3;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            // 
            // discriminantsGroupBox
            // 
            this.discriminantsGroupBox.Controls.Add(this.eigenvectorPanel);
            this.discriminantsGroupBox.Controls.Add(this.EigenvectorLabel);
            this.discriminantsGroupBox.Controls.Add(this.proportionTextBox);
            this.discriminantsGroupBox.Controls.Add(this.proportionLabel);
            this.discriminantsGroupBox.Controls.Add(this.eigenvalueTextBox);
            this.discriminantsGroupBox.Controls.Add(this.eigenvalueLabel);
            this.discriminantsGroupBox.Controls.Add(this.discriminantLabel);
            this.discriminantsGroupBox.Controls.Add(this.discriminentComboBox);
            this.discriminantsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discriminantsGroupBox.Enabled = false;
            this.discriminantsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriminantsGroupBox.Location = new System.Drawing.Point(329, 3);
            this.discriminantsGroupBox.Name = "discriminantsGroupBox";
            this.modelTableLayoutPanel.SetRowSpan(this.discriminantsGroupBox, 2);
            this.discriminantsGroupBox.Size = new System.Drawing.Size(321, 416);
            this.discriminantsGroupBox.TabIndex = 2;
            this.discriminantsGroupBox.TabStop = false;
            this.discriminantsGroupBox.Text = "Discriminants";
            // 
            // EigenvectorLabel
            // 
            this.EigenvectorLabel.AutoSize = true;
            this.EigenvectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EigenvectorLabel.Location = new System.Drawing.Point(55, 107);
            this.EigenvectorLabel.Name = "EigenvectorLabel";
            this.EigenvectorLabel.Size = new System.Drawing.Size(64, 13);
            this.EigenvectorLabel.TabIndex = 0;
            this.EigenvectorLabel.Text = "Eigenvector";
            // 
            // proportionTextBox
            // 
            this.proportionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proportionTextBox.Location = new System.Drawing.Point(125, 50);
            this.proportionTextBox.Name = "proportionTextBox";
            this.proportionTextBox.Size = new System.Drawing.Size(100, 20);
            this.proportionTextBox.TabIndex = 1;
            // 
            // proportionLabel
            // 
            this.proportionLabel.AutoSize = true;
            this.proportionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proportionLabel.Location = new System.Drawing.Point(64, 53);
            this.proportionLabel.Name = "proportionLabel";
            this.proportionLabel.Size = new System.Drawing.Size(55, 13);
            this.proportionLabel.TabIndex = 0;
            this.proportionLabel.Text = "Proportion";
            // 
            // eigenvalueTextBox
            // 
            this.eigenvalueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eigenvalueTextBox.Location = new System.Drawing.Point(125, 76);
            this.eigenvalueTextBox.Name = "eigenvalueTextBox";
            this.eigenvalueTextBox.Size = new System.Drawing.Size(100, 20);
            this.eigenvalueTextBox.TabIndex = 2;
            // 
            // eigenvalueLabel
            // 
            this.eigenvalueLabel.AutoSize = true;
            this.eigenvalueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eigenvalueLabel.Location = new System.Drawing.Point(59, 79);
            this.eigenvalueLabel.Name = "eigenvalueLabel";
            this.eigenvalueLabel.Size = new System.Drawing.Size(60, 13);
            this.eigenvalueLabel.TabIndex = 0;
            this.eigenvalueLabel.Text = "Eigenvalue";
            // 
            // eigenvectorDataGridView
            // 
            this.eigenvectorDataGridView.AllowUserToAddRows = false;
            this.eigenvectorDataGridView.AllowUserToDeleteRows = false;
            this.eigenvectorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eigenvectorDataGridView.ColumnHeadersVisible = false;
            this.eigenvectorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eigenvectorDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.eigenvectorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.eigenvectorDataGridView.Name = "eigenvectorDataGridView";
            this.eigenvectorDataGridView.ReadOnly = true;
            this.eigenvectorDataGridView.RowHeadersVisible = false;
            this.eigenvectorDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eigenvectorDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eigenvectorDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eigenvectorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eigenvectorDataGridView.Size = new System.Drawing.Size(190, 308);
            this.eigenvectorDataGridView.TabIndex = 0;
            // 
            // discriminantLabel
            // 
            this.discriminantLabel.AutoSize = true;
            this.discriminantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriminantLabel.Location = new System.Drawing.Point(55, 23);
            this.discriminantLabel.Name = "discriminantLabel";
            this.discriminantLabel.Size = new System.Drawing.Size(64, 13);
            this.discriminantLabel.TabIndex = 0;
            this.discriminantLabel.Text = "Discriminant";
            // 
            // discriminentComboBox
            // 
            this.discriminentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discriminentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriminentComboBox.FormattingEnabled = true;
            this.discriminentComboBox.Location = new System.Drawing.Point(125, 20);
            this.discriminentComboBox.Name = "discriminentComboBox";
            this.discriminentComboBox.Size = new System.Drawing.Size(100, 21);
            this.discriminentComboBox.TabIndex = 0;
            this.discriminentComboBox.SelectedIndexChanged += new System.EventHandler(this.discriminantComboBox_SelectedIndexChanged);
            // 
            // evaluationTabPage
            // 
            this.evaluationTabPage.AutoScroll = true;
            this.evaluationTabPage.Controls.Add(this.testMulticlassClassificationControl);
            this.evaluationTabPage.Location = new System.Drawing.Point(4, 22);
            this.evaluationTabPage.Name = "evaluationTabPage";
            this.evaluationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.evaluationTabPage.Size = new System.Drawing.Size(676, 218);
            this.evaluationTabPage.TabIndex = 5;
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
            this.testMulticlassClassificationControl.Size = new System.Drawing.Size(653, 320);
            this.testMulticlassClassificationControl.TabIndex = 0;
            // 
            // projectionTabPage
            // 
            this.projectionTabPage.AutoScroll = true;
            this.projectionTabPage.Controls.Add(this.datasetProjectionGroupBox);
            this.projectionTabPage.Controls.Add(this.singleProjectionGroupBox);
            this.projectionTabPage.Location = new System.Drawing.Point(4, 22);
            this.projectionTabPage.Name = "projectionTabPage";
            this.projectionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectionTabPage.Size = new System.Drawing.Size(676, 218);
            this.projectionTabPage.TabIndex = 4;
            this.projectionTabPage.Text = "Projection";
            this.projectionTabPage.UseVisualStyleBackColor = true;
            // 
            // datasetProjectionGroupBox
            // 
            this.datasetProjectionGroupBox.Controls.Add(this.datasetProjectionTableLayoutPanel);
            this.datasetProjectionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.datasetProjectionGroupBox.Enabled = false;
            this.datasetProjectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetProjectionGroupBox.Location = new System.Drawing.Point(3, 103);
            this.datasetProjectionGroupBox.Name = "datasetProjectionGroupBox";
            this.datasetProjectionGroupBox.Size = new System.Drawing.Size(653, 260);
            this.datasetProjectionGroupBox.TabIndex = 1;
            this.datasetProjectionGroupBox.TabStop = false;
            this.datasetProjectionGroupBox.Text = "Dataset projection";
            // 
            // datasetProjectionTableLayoutPanel
            // 
            this.datasetProjectionTableLayoutPanel.ColumnCount = 1;
            this.datasetProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.datasetProjectionTableLayoutPanel.Controls.Add(this.datasetProjectionDataGridView, 0, 1);
            this.datasetProjectionTableLayoutPanel.Controls.Add(this.datasetProjectionPanel, 0, 0);
            this.datasetProjectionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetProjectionTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetProjectionTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.datasetProjectionTableLayoutPanel.Name = "datasetProjectionTableLayoutPanel";
            this.datasetProjectionTableLayoutPanel.RowCount = 2;
            this.datasetProjectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.datasetProjectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetProjectionTableLayoutPanel.Size = new System.Drawing.Size(647, 235);
            this.datasetProjectionTableLayoutPanel.TabIndex = 0;
            // 
            // datasetProjectionDataGridView
            // 
            this.datasetProjectionDataGridView.AllowUserToAddRows = false;
            this.datasetProjectionDataGridView.AllowUserToDeleteRows = false;
            this.datasetProjectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetProjectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetProjectionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datasetProjectionDataGridView.Location = new System.Drawing.Point(2, 42);
            this.datasetProjectionDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.datasetProjectionDataGridView.Name = "datasetProjectionDataGridView";
            this.datasetProjectionDataGridView.ReadOnly = true;
            this.datasetProjectionDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetProjectionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datasetProjectionDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetProjectionDataGridView.RowTemplate.Height = 24;
            this.datasetProjectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasetProjectionDataGridView.Size = new System.Drawing.Size(643, 191);
            this.datasetProjectionDataGridView.TabIndex = 1;
            // 
            // datasetProjectionPanel
            // 
            this.datasetProjectionPanel.Controls.Add(this.visualizeProjectedDataButton);
            this.datasetProjectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetProjectionPanel.Location = new System.Drawing.Point(2, 2);
            this.datasetProjectionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.datasetProjectionPanel.Name = "datasetProjectionPanel";
            this.datasetProjectionPanel.Size = new System.Drawing.Size(643, 36);
            this.datasetProjectionPanel.TabIndex = 0;
            // 
            // visualizeProjectedDataButton
            // 
            this.visualizeProjectedDataButton.Enabled = false;
            this.visualizeProjectedDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizeProjectedDataButton.Location = new System.Drawing.Point(2, 5);
            this.visualizeProjectedDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeProjectedDataButton.Name = "visualizeProjectedDataButton";
            this.visualizeProjectedDataButton.Size = new System.Drawing.Size(75, 23);
            this.visualizeProjectedDataButton.TabIndex = 0;
            this.visualizeProjectedDataButton.Text = "Visualize...";
            this.visualizeProjectedDataButton.UseVisualStyleBackColor = true;
            this.visualizeProjectedDataButton.Click += new System.EventHandler(this.visualizeProjectedDataButton_Click);
            // 
            // singleProjectionGroupBox
            // 
            this.singleProjectionGroupBox.Controls.Add(this.singleProjectionTableLayoutPanel);
            this.singleProjectionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.singleProjectionGroupBox.Enabled = false;
            this.singleProjectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleProjectionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.singleProjectionGroupBox.Name = "singleProjectionGroupBox";
            this.singleProjectionGroupBox.Size = new System.Drawing.Size(653, 100);
            this.singleProjectionGroupBox.TabIndex = 0;
            this.singleProjectionGroupBox.TabStop = false;
            this.singleProjectionGroupBox.Text = "Single projection";
            // 
            // singleProjectionTableLayoutPanel
            // 
            this.singleProjectionTableLayoutPanel.ColumnCount = 3;
            this.singleProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.singleProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.singleProjectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.singleProjectionTableLayoutPanel.Controls.Add(this.singleProjectionPCDataGridView, 2, 0);
            this.singleProjectionTableLayoutPanel.Controls.Add(this.singleProjectionInputDataGridView, 0, 0);
            this.singleProjectionTableLayoutPanel.Controls.Add(this.singleProjectionPanel, 1, 0);
            this.singleProjectionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleProjectionTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.singleProjectionTableLayoutPanel.Name = "singleProjectionTableLayoutPanel";
            this.singleProjectionTableLayoutPanel.RowCount = 1;
            this.singleProjectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.singleProjectionTableLayoutPanel.Size = new System.Drawing.Size(647, 75);
            this.singleProjectionTableLayoutPanel.TabIndex = 0;
            // 
            // singleProjectionPCDataGridView
            // 
            this.singleProjectionPCDataGridView.AllowUserToAddRows = false;
            this.singleProjectionPCDataGridView.AllowUserToDeleteRows = false;
            this.singleProjectionPCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singleProjectionPCDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionPCDataGridView.Location = new System.Drawing.Point(365, 2);
            this.singleProjectionPCDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.singleProjectionPCDataGridView.Name = "singleProjectionPCDataGridView";
            this.singleProjectionPCDataGridView.ReadOnly = true;
            this.singleProjectionPCDataGridView.RowHeadersWidth = 51;
            this.singleProjectionPCDataGridView.RowTemplate.Height = 24;
            this.singleProjectionPCDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.singleProjectionPCDataGridView.Size = new System.Drawing.Size(280, 71);
            this.singleProjectionPCDataGridView.TabIndex = 2;
            // 
            // singleProjectionInputDataGridView
            // 
            this.singleProjectionInputDataGridView.AllowUserToAddRows = false;
            this.singleProjectionInputDataGridView.AllowUserToDeleteRows = false;
            this.singleProjectionInputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singleProjectionInputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionInputDataGridView.Location = new System.Drawing.Point(2, 2);
            this.singleProjectionInputDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.singleProjectionInputDataGridView.Name = "singleProjectionInputDataGridView";
            this.singleProjectionInputDataGridView.RowHeadersWidth = 51;
            this.singleProjectionInputDataGridView.RowTemplate.Height = 24;
            this.singleProjectionInputDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.singleProjectionInputDataGridView.Size = new System.Drawing.Size(279, 71);
            this.singleProjectionInputDataGridView.TabIndex = 0;
            // 
            // singleProjectionPanel
            // 
            this.singleProjectionPanel.Controls.Add(this.projectButton);
            this.singleProjectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectionPanel.Location = new System.Drawing.Point(286, 3);
            this.singleProjectionPanel.Name = "singleProjectionPanel";
            this.singleProjectionPanel.Size = new System.Drawing.Size(74, 69);
            this.singleProjectionPanel.TabIndex = 1;
            // 
            // projectButton
            // 
            this.projectButton.Location = new System.Drawing.Point(7, 2);
            this.projectButton.Margin = new System.Windows.Forms.Padding(2);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(60, 23);
            this.projectButton.TabIndex = 0;
            this.projectButton.Text = "Project";
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            // 
            // taskSplitContainer
            // 
            this.taskSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.taskSplitContainer.Name = "taskSplitContainer";
            this.taskSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // taskSplitContainer.Panel1
            // 
            this.taskSplitContainer.Panel1.Controls.Add(this.taskDiagramPanel);
            // 
            // taskSplitContainer.Panel2
            // 
            this.taskSplitContainer.Panel2.Controls.Add(this.taskTabControl);
            this.taskSplitContainer.Size = new System.Drawing.Size(684, 496);
            this.taskSplitContainer.SplitterDistance = 248;
            this.taskSplitContainer.TabIndex = 0;
            // 
            // eigenvectorPanel
            // 
            this.eigenvectorPanel.Controls.Add(this.eigenvectorDataGridView);
            this.eigenvectorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eigenvectorPanel.Location = new System.Drawing.Point(125, 102);
            this.eigenvectorPanel.Name = "eigenvectorPanel";
            this.eigenvectorPanel.Size = new System.Drawing.Size(190, 308);
            this.eigenvectorPanel.TabIndex = 3;
            // 
            // DATask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.taskSplitContainer);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(699, 558);
            this.Name = "DATask";
            this.ShowIcon = false;
            this.Text = "Disciminant Analysis Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BinaryClassificationForm_FormClosing);
            this.Load += new System.EventHandler(this.BinaryClassificationTask_Load);
            this.Resize += new System.EventHandler(this.BinaryClassificationTask_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.taskDiagramPanel.ResumeLayout(false);
            this.taskTabControl.ResumeLayout(false);
            this.dataTabPage.ResumeLayout(false);
            this.datasetTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasetDataGridView)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.modelTabPage.ResumeLayout(false);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.kernelGroupBox.ResumeLayout(false);
            this.kernelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmoidAlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialConstantNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialDegreeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laplacianSigmaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianSigmaNumericUpDown)).EndInit();
            this.analysisGroupBox.ResumeLayout(false);
            this.analysisGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDiscriminantsNumericUpDown)).EndInit();
            this.discriminantsGroupBox.ResumeLayout(false);
            this.discriminantsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenvectorDataGridView)).EndInit();
            this.evaluationTabPage.ResumeLayout(false);
            this.projectionTabPage.ResumeLayout(false);
            this.datasetProjectionGroupBox.ResumeLayout(false);
            this.datasetProjectionTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasetProjectionDataGridView)).EndInit();
            this.datasetProjectionPanel.ResumeLayout(false);
            this.singleProjectionGroupBox.ResumeLayout(false);
            this.singleProjectionTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionPCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleProjectionInputDataGridView)).EndInit();
            this.singleProjectionPanel.ResumeLayout(false);
            this.taskSplitContainer.Panel1.ResumeLayout(false);
            this.taskSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskSplitContainer)).EndInit();
            this.taskSplitContainer.ResumeLayout(false);
            this.eigenvectorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private MindFusion.Diagramming.Diagram taskDiagram;
        private MindFusion.Diagramming.WinForms.DiagramView taskDiagramView;
        private System.Windows.Forms.Panel taskDiagramPanel;
        private MindFusion.Common.WinForms.ZoomControl taskDiagramZoomControl;
        private System.Windows.Forms.TabControl taskTabControl;
        private System.Windows.Forms.TabPage dataTabPage;
        private System.Windows.Forms.TableLayoutPanel datasetTableLayoutPanel;
        private System.Windows.Forms.DataGridView datasetDataGridView;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button datasetVisualizeButton;
        private System.Windows.Forms.Label datasetLabel;
        private System.Windows.Forms.TabPage modelTabPage;
        private System.Windows.Forms.TableLayoutPanel modelTableLayoutPanel;
        private System.Windows.Forms.GroupBox kernelGroupBox;
        private System.Windows.Forms.Button sigmoidEstimateButton;
        private System.Windows.Forms.Button laplacianEstimateButton;
        private System.Windows.Forms.Button gaussianEstimateButton;
        private System.Windows.Forms.RadioButton gaussianKernelRadioButton;
        private System.Windows.Forms.Label laplacianSigmaLabel;
        private System.Windows.Forms.Label gaussianSigmaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidConstantNumericUpDown;
        private System.Windows.Forms.Label sigmoidAlphaLabel;
        private System.Windows.Forms.NumericUpDown sigmoidAlphaNumericUpDown;
        private System.Windows.Forms.Label polynomialConstantLabel;
        private System.Windows.Forms.Label polynomialDegreeLabel;
        private System.Windows.Forms.NumericUpDown polynomialConstantNumericUpDown;
        private System.Windows.Forms.NumericUpDown polynomialDegreeNumericUpDown;
        private System.Windows.Forms.Label sigmoidConstantLabel;
        private System.Windows.Forms.RadioButton sigmoidKernelRadioButton;
        private System.Windows.Forms.RadioButton laplacianKernelRadioButton;
        private System.Windows.Forms.RadioButton polynomialKernelRadioButton;
        private System.Windows.Forms.NumericUpDown laplacianSigmaNumericUpDown;
        private System.Windows.Forms.NumericUpDown gaussianSigmaNumericUpDown;
        private System.Windows.Forms.GroupBox analysisGroupBox;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.GroupBox discriminantsGroupBox;
        private System.Windows.Forms.TabPage projectionTabPage;
        private System.Windows.Forms.GroupBox datasetProjectionGroupBox;
        private System.Windows.Forms.GroupBox singleProjectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel singleProjectionTableLayoutPanel;
        private System.Windows.Forms.DataGridView singleProjectionPCDataGridView;
        private System.Windows.Forms.DataGridView singleProjectionInputDataGridView;
        private System.Windows.Forms.Panel singleProjectionPanel;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.TableLayoutPanel datasetProjectionTableLayoutPanel;
        private System.Windows.Forms.DataGridView datasetProjectionDataGridView;
        private System.Windows.Forms.Panel datasetProjectionPanel;
        private System.Windows.Forms.Button visualizeProjectedDataButton;
        private System.Windows.Forms.TabPage evaluationTabPage;
        private System.Windows.Forms.NumericUpDown numberOfDiscriminantsNumericUpDown;
        private System.Windows.Forms.Label numberOfDiscriminantsLabel;
        private System.Windows.Forms.Label discriminantLabel;
        private System.Windows.Forms.ComboBox discriminentComboBox;
        private System.Windows.Forms.Label EigenvectorLabel;
        private System.Windows.Forms.TextBox proportionTextBox;
        private System.Windows.Forms.Label proportionLabel;
        private System.Windows.Forms.TextBox eigenvalueTextBox;
        private System.Windows.Forms.Label eigenvalueLabel;
        private System.Windows.Forms.DataGridView eigenvectorDataGridView;
        private TestMulticlassClassificationControl testMulticlassClassificationControl;
        private System.Windows.Forms.SplitContainer taskSplitContainer;
        private System.Windows.Forms.Panel eigenvectorPanel;
    }
}