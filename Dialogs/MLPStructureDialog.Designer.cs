namespace JadeChem.Dialogs
{
    partial class MLPStructureDialog
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel = new TableLayoutPanel();
            networkTreeView = new TreeView();
            layerGroupBox = new GroupBox();
            numberOfNeuronsTextBox = new TextBox();
            numberOfNeuronsLabel = new Label();
            layerNameTextBox = new TextBox();
            activationFunctionTextBox = new TextBox();
            layerLabel = new Label();
            activationFunctionLabel = new Label();
            numberOfInputsLabel = new Label();
            numberOfInputsTextBox = new TextBox();
            neuronGroupBox = new GroupBox();
            weightsAndBiasLabel = new Label();
            weightsAndBiasDataGridView = new DataGridView();
            neuronEquationLabel = new Label();
            panel = new Panel();
            closeButton = new Button();
            tableLayoutPanel.SuspendLayout();
            layerGroupBox.SuspendLayout();
            neuronGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndBiasDataGridView).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(networkTreeView, 0, 0);
            tableLayoutPanel.Controls.Add(layerGroupBox, 1, 0);
            tableLayoutPanel.Controls.Add(neuronGroupBox, 1, 1);
            tableLayoutPanel.Controls.Add(panel, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(664, 361);
            tableLayoutPanel.TabIndex = 0;
            // 
            // networkTreeView
            // 
            networkTreeView.Dock = DockStyle.Fill;
            networkTreeView.Location = new Point(3, 3);
            networkTreeView.Name = "networkTreeView";
            tableLayoutPanel.SetRowSpan(networkTreeView, 2);
            networkTreeView.Size = new Size(194, 315);
            networkTreeView.TabIndex = 0;
            networkTreeView.AfterSelect += NetworkTreeView_AfterSelect;
            // 
            // layerGroupBox
            // 
            layerGroupBox.Controls.Add(numberOfNeuronsTextBox);
            layerGroupBox.Controls.Add(numberOfNeuronsLabel);
            layerGroupBox.Controls.Add(layerNameTextBox);
            layerGroupBox.Controls.Add(activationFunctionTextBox);
            layerGroupBox.Controls.Add(layerLabel);
            layerGroupBox.Controls.Add(activationFunctionLabel);
            layerGroupBox.Controls.Add(numberOfInputsLabel);
            layerGroupBox.Controls.Add(numberOfInputsTextBox);
            layerGroupBox.Dock = DockStyle.Fill;
            layerGroupBox.Location = new Point(203, 3);
            layerGroupBox.Name = "layerGroupBox";
            layerGroupBox.Size = new Size(458, 94);
            layerGroupBox.TabIndex = 1;
            layerGroupBox.TabStop = false;
            layerGroupBox.Text = "Layer";
            // 
            // numberOfNeuronsTextBox
            // 
            numberOfNeuronsTextBox.Location = new Point(128, 56);
            numberOfNeuronsTextBox.Name = "numberOfNeuronsTextBox";
            numberOfNeuronsTextBox.ReadOnly = true;
            numberOfNeuronsTextBox.Size = new Size(100, 23);
            numberOfNeuronsTextBox.TabIndex = 4;
            // 
            // numberOfNeuronsLabel
            // 
            numberOfNeuronsLabel.AutoSize = true;
            numberOfNeuronsLabel.Location = new Point(13, 59);
            numberOfNeuronsLabel.Name = "numberOfNeuronsLabel";
            numberOfNeuronsLabel.Size = new Size(111, 15);
            numberOfNeuronsLabel.TabIndex = 3;
            numberOfNeuronsLabel.Text = "Number of neurons";
            // 
            // layerNameTextBox
            // 
            layerNameTextBox.Location = new Point(128, 22);
            layerNameTextBox.Name = "layerNameTextBox";
            layerNameTextBox.ReadOnly = true;
            layerNameTextBox.Size = new Size(100, 23);
            layerNameTextBox.TabIndex = 0;
            // 
            // activationFunctionTextBox
            // 
            activationFunctionTextBox.Location = new Point(349, 56);
            activationFunctionTextBox.Name = "activationFunctionTextBox";
            activationFunctionTextBox.ReadOnly = true;
            activationFunctionTextBox.Size = new Size(100, 23);
            activationFunctionTextBox.TabIndex = 2;
            // 
            // layerLabel
            // 
            layerLabel.AutoSize = true;
            layerLabel.Location = new Point(87, 25);
            layerLabel.Name = "layerLabel";
            layerLabel.Size = new Size(35, 15);
            layerLabel.TabIndex = 0;
            layerLabel.Text = "Layer";
            // 
            // activationFunctionLabel
            // 
            activationFunctionLabel.AutoSize = true;
            activationFunctionLabel.Location = new Point(234, 59);
            activationFunctionLabel.Name = "activationFunctionLabel";
            activationFunctionLabel.Size = new Size(109, 15);
            activationFunctionLabel.TabIndex = 0;
            activationFunctionLabel.Text = "Activation function";
            // 
            // numberOfInputsLabel
            // 
            numberOfInputsLabel.AutoSize = true;
            numberOfInputsLabel.Location = new Point(242, 25);
            numberOfInputsLabel.Name = "numberOfInputsLabel";
            numberOfInputsLabel.Size = new Size(101, 15);
            numberOfInputsLabel.TabIndex = 0;
            numberOfInputsLabel.Text = "Number of inputs";
            // 
            // numberOfInputsTextBox
            // 
            numberOfInputsTextBox.Location = new Point(349, 22);
            numberOfInputsTextBox.Name = "numberOfInputsTextBox";
            numberOfInputsTextBox.ReadOnly = true;
            numberOfInputsTextBox.Size = new Size(100, 23);
            numberOfInputsTextBox.TabIndex = 1;
            // 
            // neuronGroupBox
            // 
            neuronGroupBox.Controls.Add(weightsAndBiasLabel);
            neuronGroupBox.Controls.Add(weightsAndBiasDataGridView);
            neuronGroupBox.Controls.Add(neuronEquationLabel);
            neuronGroupBox.Dock = DockStyle.Fill;
            neuronGroupBox.Location = new Point(203, 103);
            neuronGroupBox.Name = "neuronGroupBox";
            neuronGroupBox.Size = new Size(458, 215);
            neuronGroupBox.TabIndex = 2;
            neuronGroupBox.TabStop = false;
            neuronGroupBox.Text = "Neuron";
            // 
            // weightsAndBiasLabel
            // 
            weightsAndBiasLabel.AutoSize = true;
            weightsAndBiasLabel.Location = new Point(6, 44);
            weightsAndBiasLabel.Name = "weightsAndBiasLabel";
            weightsAndBiasLabel.Size = new Size(97, 15);
            weightsAndBiasLabel.TabIndex = 0;
            weightsAndBiasLabel.Text = "Weights and bias";
            // 
            // weightsAndBiasDataGridView
            // 
            weightsAndBiasDataGridView.AllowUserToAddRows = false;
            weightsAndBiasDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            weightsAndBiasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            weightsAndBiasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weightsAndBiasDataGridView.Dock = DockStyle.Bottom;
            weightsAndBiasDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            weightsAndBiasDataGridView.Location = new Point(3, 62);
            weightsAndBiasDataGridView.Name = "weightsAndBiasDataGridView";
            weightsAndBiasDataGridView.ReadOnly = true;
            weightsAndBiasDataGridView.RowTemplate.Height = 25;
            weightsAndBiasDataGridView.Size = new Size(452, 150);
            weightsAndBiasDataGridView.TabIndex = 0;
            // 
            // neuronEquationLabel
            // 
            neuronEquationLabel.AutoSize = true;
            neuronEquationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            neuronEquationLabel.Location = new Point(173, 19);
            neuronEquationLabel.Name = "neuronEquationLabel";
            neuronEquationLabel.Size = new Size(111, 15);
            neuronEquationLabel.TabIndex = 0;
            neuronEquationLabel.Text = "y = f(∑(wi * xi) + b)";
            // 
            // panel
            // 
            tableLayoutPanel.SetColumnSpan(panel, 2);
            panel.Controls.Add(closeButton);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(3, 324);
            panel.Name = "panel";
            panel.Size = new Size(658, 34);
            panel.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.DialogResult = DialogResult.Cancel;
            closeButton.Location = new Point(574, 8);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // MLPStructureDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(664, 361);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(680, 400);
            Name = "MLPStructureDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MLP network structure";
            tableLayoutPanel.ResumeLayout(false);
            layerGroupBox.ResumeLayout(false);
            layerGroupBox.PerformLayout();
            neuronGroupBox.ResumeLayout(false);
            neuronGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightsAndBiasDataGridView).EndInit();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel panel;
        private Button closeButton;
        private TreeView networkTreeView;
        private Label neuronEquationLabel;
        private GroupBox layerGroupBox;
        private TextBox layerNameTextBox;
        private TextBox activationFunctionTextBox;
        private Label layerLabel;
        private Label activationFunctionLabel;
        private Label numberOfInputsLabel;
        private TextBox numberOfInputsTextBox;
        private GroupBox neuronGroupBox;
        private Label weightsAndBiasLabel;
        private DataGridView weightsAndBiasDataGridView;
        private TextBox numberOfNeuronsTextBox;
        private Label numberOfNeuronsLabel;
    }
}