namespace JadeML.Regression
{
    partial class TestRegressionControl
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
            this.testDatasetSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.testDatasetDataGridView = new System.Windows.Forms.DataGridView();
            this.visualizePanel = new System.Windows.Forms.Panel();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.metricsPanel = new System.Windows.Forms.Panel();
            this.rSquareValueLabel = new System.Windows.Forms.Label();
            this.rootMeanSquareErrorValueLabel = new System.Windows.Forms.Label();
            this.meanSquareErrorValueLabel = new System.Windows.Forms.Label();
            this.meanAbsoluteErrorValueLabel = new System.Windows.Forms.Label();
            this.meanSquareErrorLabel = new System.Windows.Forms.Label();
            this.rSquareLabel = new System.Windows.Forms.Label();
            this.rootMeanSquareErrorLabel = new System.Windows.Forms.Label();
            this.meanAbsoluteErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetSplitContainer)).BeginInit();
            this.testDatasetSplitContainer.Panel1.SuspendLayout();
            this.testDatasetSplitContainer.Panel2.SuspendLayout();
            this.testDatasetSplitContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).BeginInit();
            this.visualizePanel.SuspendLayout();
            this.metricsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // testDatasetSplitContainer
            // 
            this.testDatasetSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDatasetSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.testDatasetSplitContainer.Name = "testDatasetSplitContainer";
            // 
            // testDatasetSplitContainer.Panel1
            // 
            this.testDatasetSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.testDatasetSplitContainer.Panel1MinSize = 250;
            // 
            // testDatasetSplitContainer.Panel2
            // 
            this.testDatasetSplitContainer.Panel2.Controls.Add(this.metricsPanel);
            this.testDatasetSplitContainer.Panel2MinSize = 250;
            this.testDatasetSplitContainer.Size = new System.Drawing.Size(600, 325);
            this.testDatasetSplitContainer.SplitterDistance = 300;
            this.testDatasetSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.testDatasetDataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.visualizePanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 325);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // testDatasetDataGridView
            // 
            this.testDatasetDataGridView.AllowUserToAddRows = false;
            this.testDatasetDataGridView.AllowUserToDeleteRows = false;
            this.testDatasetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDatasetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDatasetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.testDatasetDataGridView.Location = new System.Drawing.Point(3, 44);
            this.testDatasetDataGridView.Name = "testDatasetDataGridView";
            this.testDatasetDataGridView.ReadOnly = true;
            this.testDatasetDataGridView.RowHeadersWidth = 51;
            this.testDatasetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testDatasetDataGridView.Size = new System.Drawing.Size(294, 278);
            this.testDatasetDataGridView.TabIndex = 1;
            // 
            // visualizePanel
            // 
            this.visualizePanel.Controls.Add(this.visualizeButton);
            this.visualizePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizePanel.Location = new System.Drawing.Point(2, 2);
            this.visualizePanel.Margin = new System.Windows.Forms.Padding(2);
            this.visualizePanel.Name = "visualizePanel";
            this.visualizePanel.Size = new System.Drawing.Size(296, 37);
            this.visualizePanel.TabIndex = 0;
            // 
            // visualizeButton
            // 
            this.visualizeButton.Location = new System.Drawing.Point(5, 7);
            this.visualizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(75, 23);
            this.visualizeButton.TabIndex = 10;
            this.visualizeButton.Text = "Visualize...";
            this.visualizeButton.UseVisualStyleBackColor = true;
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // metricsPanel
            // 
            this.metricsPanel.Controls.Add(this.rSquareValueLabel);
            this.metricsPanel.Controls.Add(this.rootMeanSquareErrorValueLabel);
            this.metricsPanel.Controls.Add(this.meanSquareErrorValueLabel);
            this.metricsPanel.Controls.Add(this.meanAbsoluteErrorValueLabel);
            this.metricsPanel.Controls.Add(this.meanSquareErrorLabel);
            this.metricsPanel.Controls.Add(this.rSquareLabel);
            this.metricsPanel.Controls.Add(this.rootMeanSquareErrorLabel);
            this.metricsPanel.Controls.Add(this.meanAbsoluteErrorLabel);
            this.metricsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metricsPanel.Location = new System.Drawing.Point(0, 0);
            this.metricsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.metricsPanel.Name = "metricsPanel";
            this.metricsPanel.Size = new System.Drawing.Size(296, 325);
            this.metricsPanel.TabIndex = 4;
            // 
            // rSquareValueLabel
            // 
            this.rSquareValueLabel.AutoSize = true;
            this.rSquareValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSquareValueLabel.Location = new System.Drawing.Point(144, 221);
            this.rSquareValueLabel.Name = "rSquareValueLabel";
            this.rSquareValueLabel.Size = new System.Drawing.Size(13, 13);
            this.rSquareValueLabel.TabIndex = 0;
            this.rSquareValueLabel.Text = "0";
            // 
            // rootMeanSquareErrorValueLabel
            // 
            this.rootMeanSquareErrorValueLabel.AutoSize = true;
            this.rootMeanSquareErrorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootMeanSquareErrorValueLabel.Location = new System.Drawing.Point(144, 160);
            this.rootMeanSquareErrorValueLabel.Name = "rootMeanSquareErrorValueLabel";
            this.rootMeanSquareErrorValueLabel.Size = new System.Drawing.Size(13, 13);
            this.rootMeanSquareErrorValueLabel.TabIndex = 0;
            this.rootMeanSquareErrorValueLabel.Text = "0";
            // 
            // meanSquareErrorValueLabel
            // 
            this.meanSquareErrorValueLabel.AutoSize = true;
            this.meanSquareErrorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanSquareErrorValueLabel.Location = new System.Drawing.Point(144, 99);
            this.meanSquareErrorValueLabel.Name = "meanSquareErrorValueLabel";
            this.meanSquareErrorValueLabel.Size = new System.Drawing.Size(13, 13);
            this.meanSquareErrorValueLabel.TabIndex = 7;
            this.meanSquareErrorValueLabel.Text = "0";
            // 
            // meanAbsoluteErrorValueLabel
            // 
            this.meanAbsoluteErrorValueLabel.AutoSize = true;
            this.meanAbsoluteErrorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanAbsoluteErrorValueLabel.Location = new System.Drawing.Point(144, 38);
            this.meanAbsoluteErrorValueLabel.Name = "meanAbsoluteErrorValueLabel";
            this.meanAbsoluteErrorValueLabel.Size = new System.Drawing.Size(13, 13);
            this.meanAbsoluteErrorValueLabel.TabIndex = 0;
            this.meanAbsoluteErrorValueLabel.Text = "0";
            // 
            // meanSquareErrorLabel
            // 
            this.meanSquareErrorLabel.AutoSize = true;
            this.meanSquareErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanSquareErrorLabel.Location = new System.Drawing.Point(8, 68);
            this.meanSquareErrorLabel.Name = "meanSquareErrorLabel";
            this.meanSquareErrorLabel.Size = new System.Drawing.Size(211, 20);
            this.meanSquareErrorLabel.TabIndex = 0;
            this.meanSquareErrorLabel.Text = "Mean square error (MSE)";
            // 
            // rSquareLabel
            // 
            this.rSquareLabel.AutoSize = true;
            this.rSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSquareLabel.Location = new System.Drawing.Point(8, 190);
            this.rSquareLabel.Name = "rSquareLabel";
            this.rSquareLabel.Size = new System.Drawing.Size(265, 20);
            this.rSquareLabel.TabIndex = 0;
            this.rSquareLabel.Tag = "";
            this.rSquareLabel.Text = "coefficient of determination (R²)";
            // 
            // rootMeanSquareErrorLabel
            // 
            this.rootMeanSquareErrorLabel.AutoSize = true;
            this.rootMeanSquareErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootMeanSquareErrorLabel.Location = new System.Drawing.Point(8, 129);
            this.rootMeanSquareErrorLabel.Name = "rootMeanSquareErrorLabel";
            this.rootMeanSquareErrorLabel.Size = new System.Drawing.Size(268, 20);
            this.rootMeanSquareErrorLabel.TabIndex = 0;
            this.rootMeanSquareErrorLabel.Text = "Root mean square error (RMSE)";
            // 
            // meanAbsoluteErrorLabel
            // 
            this.meanAbsoluteErrorLabel.AutoSize = true;
            this.meanAbsoluteErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanAbsoluteErrorLabel.Location = new System.Drawing.Point(8, 7);
            this.meanAbsoluteErrorLabel.Name = "meanAbsoluteErrorLabel";
            this.meanAbsoluteErrorLabel.Size = new System.Drawing.Size(225, 20);
            this.meanAbsoluteErrorLabel.TabIndex = 0;
            this.meanAbsoluteErrorLabel.Text = "Mean absolute error (MAE)";
            // 
            // TestRegressionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testDatasetSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestRegressionControl";
            this.Size = new System.Drawing.Size(600, 325);
            this.testDatasetSplitContainer.Panel1.ResumeLayout(false);
            this.testDatasetSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetSplitContainer)).EndInit();
            this.testDatasetSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDatasetDataGridView)).EndInit();
            this.visualizePanel.ResumeLayout(false);
            this.metricsPanel.ResumeLayout(false);
            this.metricsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer testDatasetSplitContainer;
        private System.Windows.Forms.DataGridView testDatasetDataGridView;
        private System.Windows.Forms.Panel metricsPanel;
        private System.Windows.Forms.Label rSquareValueLabel;
        private System.Windows.Forms.Label rootMeanSquareErrorValueLabel;
        private System.Windows.Forms.Label meanSquareErrorValueLabel;
        private System.Windows.Forms.Label meanAbsoluteErrorValueLabel;
        private System.Windows.Forms.Label meanSquareErrorLabel;
        private System.Windows.Forms.Label rSquareLabel;
        private System.Windows.Forms.Label rootMeanSquareErrorLabel;
        private System.Windows.Forms.Label meanAbsoluteErrorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel visualizePanel;
        private System.Windows.Forms.Button visualizeButton;
    }
}
