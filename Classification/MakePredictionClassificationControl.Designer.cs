namespace JadeML.Classification
{
    partial class MakePredictionClassificationControl
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
            this.components = new System.ComponentModel.Container();
            this.loadPredictDataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.singlePredictionGroupBox = new System.Windows.Forms.GroupBox();
            this.singlePredictionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.singlePredictionPanel = new System.Windows.Forms.Panel();
            this.predictButton = new System.Windows.Forms.Button();
            this.singlePredictionDataGridView = new System.Windows.Forms.DataGridView();
            this.datasetPredictionGroupBox = new System.Windows.Forms.GroupBox();
            this.datasetPredictionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.datasetPredictionPanel = new System.Windows.Forms.Panel();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.datasetPredictionDataGridView = new System.Windows.Forms.DataGridView();
            this.singlePredictionGroupBox.SuspendLayout();
            this.singlePredictionTableLayoutPanel.SuspendLayout();
            this.singlePredictionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singlePredictionDataGridView)).BeginInit();
            this.datasetPredictionGroupBox.SuspendLayout();
            this.datasetPredictionTableLayoutPanel.SuspendLayout();
            this.datasetPredictionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPredictionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPredictDataFileDialog
            // 
            this.loadPredictDataFileDialog.FileName = "*.csv";
            this.loadPredictDataFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            this.loadPredictDataFileDialog.Title = "Load Predict Data";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 10;
            this.toolTip.ReshowDelay = 100;
            // 
            // singlePredictionGroupBox
            // 
            this.singlePredictionGroupBox.Controls.Add(this.singlePredictionTableLayoutPanel);
            this.singlePredictionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.singlePredictionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePredictionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.singlePredictionGroupBox.Name = "singlePredictionGroupBox";
            this.singlePredictionGroupBox.Size = new System.Drawing.Size(600, 135);
            this.singlePredictionGroupBox.TabIndex = 1;
            this.singlePredictionGroupBox.TabStop = false;
            this.singlePredictionGroupBox.Text = "Single prediction";
            // 
            // singlePredictionTableLayoutPanel
            // 
            this.singlePredictionTableLayoutPanel.ColumnCount = 1;
            this.singlePredictionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.singlePredictionTableLayoutPanel.Controls.Add(this.singlePredictionPanel, 0, 0);
            this.singlePredictionTableLayoutPanel.Controls.Add(this.singlePredictionDataGridView, 0, 1);
            this.singlePredictionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singlePredictionTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.singlePredictionTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.singlePredictionTableLayoutPanel.Name = "singlePredictionTableLayoutPanel";
            this.singlePredictionTableLayoutPanel.RowCount = 2;
            this.singlePredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.singlePredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.singlePredictionTableLayoutPanel.Size = new System.Drawing.Size(594, 110);
            this.singlePredictionTableLayoutPanel.TabIndex = 1;
            // 
            // singlePredictionPanel
            // 
            this.singlePredictionPanel.Controls.Add(this.predictButton);
            this.singlePredictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singlePredictionPanel.Location = new System.Drawing.Point(2, 2);
            this.singlePredictionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.singlePredictionPanel.Name = "singlePredictionPanel";
            this.singlePredictionPanel.Size = new System.Drawing.Size(590, 36);
            this.singlePredictionPanel.TabIndex = 0;
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(5, 5);
            this.predictButton.Margin = new System.Windows.Forms.Padding(2);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(60, 23);
            this.predictButton.TabIndex = 0;
            this.predictButton.Text = "Predict";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // singlePredictionDataGridView
            // 
            this.singlePredictionDataGridView.AllowUserToAddRows = false;
            this.singlePredictionDataGridView.AllowUserToDeleteRows = false;
            this.singlePredictionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singlePredictionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singlePredictionDataGridView.Location = new System.Drawing.Point(2, 42);
            this.singlePredictionDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.singlePredictionDataGridView.Name = "singlePredictionDataGridView";
            this.singlePredictionDataGridView.RowHeadersWidth = 51;
            this.singlePredictionDataGridView.RowTemplate.Height = 24;
            this.singlePredictionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.singlePredictionDataGridView.Size = new System.Drawing.Size(590, 66);
            this.singlePredictionDataGridView.TabIndex = 1;
            // 
            // datasetPredictionGroupBox
            // 
            this.datasetPredictionGroupBox.Controls.Add(this.datasetPredictionTableLayoutPanel);
            this.datasetPredictionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPredictionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasetPredictionGroupBox.Location = new System.Drawing.Point(0, 135);
            this.datasetPredictionGroupBox.Name = "datasetPredictionGroupBox";
            this.datasetPredictionGroupBox.Size = new System.Drawing.Size(600, 190);
            this.datasetPredictionGroupBox.TabIndex = 2;
            this.datasetPredictionGroupBox.TabStop = false;
            this.datasetPredictionGroupBox.Text = "Dataset prediction";
            // 
            // datasetPredictionTableLayoutPanel
            // 
            this.datasetPredictionTableLayoutPanel.ColumnCount = 1;
            this.datasetPredictionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetPredictionTableLayoutPanel.Controls.Add(this.datasetPredictionPanel, 0, 0);
            this.datasetPredictionTableLayoutPanel.Controls.Add(this.datasetPredictionDataGridView, 0, 1);
            this.datasetPredictionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPredictionTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datasetPredictionTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.datasetPredictionTableLayoutPanel.Name = "datasetPredictionTableLayoutPanel";
            this.datasetPredictionTableLayoutPanel.RowCount = 2;
            this.datasetPredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.datasetPredictionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datasetPredictionTableLayoutPanel.Size = new System.Drawing.Size(594, 165);
            this.datasetPredictionTableLayoutPanel.TabIndex = 2;
            // 
            // datasetPredictionPanel
            // 
            this.datasetPredictionPanel.Controls.Add(this.visualizeButton);
            this.datasetPredictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPredictionPanel.Location = new System.Drawing.Point(2, 2);
            this.datasetPredictionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.datasetPredictionPanel.Name = "datasetPredictionPanel";
            this.datasetPredictionPanel.Size = new System.Drawing.Size(590, 36);
            this.datasetPredictionPanel.TabIndex = 0;
            // 
            // visualizeButton
            // 
            this.visualizeButton.Enabled = false;
            this.visualizeButton.Location = new System.Drawing.Point(5, 5);
            this.visualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(75, 23);
            this.visualizeButton.TabIndex = 2;
            this.visualizeButton.Text = "Visualize...";
            this.visualizeButton.UseVisualStyleBackColor = true;
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // datasetPredictionDataGridView
            // 
            this.datasetPredictionDataGridView.AllowUserToAddRows = false;
            this.datasetPredictionDataGridView.AllowUserToDeleteRows = false;
            this.datasetPredictionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasetPredictionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPredictionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datasetPredictionDataGridView.Location = new System.Drawing.Point(2, 42);
            this.datasetPredictionDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.datasetPredictionDataGridView.Name = "datasetPredictionDataGridView";
            this.datasetPredictionDataGridView.ReadOnly = true;
            this.datasetPredictionDataGridView.RowHeadersWidth = 51;
            this.datasetPredictionDataGridView.RowTemplate.Height = 24;
            this.datasetPredictionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasetPredictionDataGridView.Size = new System.Drawing.Size(590, 121);
            this.datasetPredictionDataGridView.TabIndex = 1;
            // 
            // MakePredictionClassificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datasetPredictionGroupBox);
            this.Controls.Add(this.singlePredictionGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MakePredictionClassificationControl";
            this.Size = new System.Drawing.Size(600, 325);
            this.singlePredictionGroupBox.ResumeLayout(false);
            this.singlePredictionTableLayoutPanel.ResumeLayout(false);
            this.singlePredictionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.singlePredictionDataGridView)).EndInit();
            this.datasetPredictionGroupBox.ResumeLayout(false);
            this.datasetPredictionTableLayoutPanel.ResumeLayout(false);
            this.datasetPredictionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasetPredictionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog loadPredictDataFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox singlePredictionGroupBox;
        private System.Windows.Forms.TableLayoutPanel singlePredictionTableLayoutPanel;
        private System.Windows.Forms.Panel singlePredictionPanel;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.DataGridView singlePredictionDataGridView;
        private System.Windows.Forms.GroupBox datasetPredictionGroupBox;
        private System.Windows.Forms.TableLayoutPanel datasetPredictionTableLayoutPanel;
        private System.Windows.Forms.Panel datasetPredictionPanel;
        private System.Windows.Forms.Button visualizeButton;
        private System.Windows.Forms.DataGridView datasetPredictionDataGridView;
    }
}
