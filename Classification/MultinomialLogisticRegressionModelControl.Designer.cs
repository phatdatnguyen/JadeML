namespace JadeML.Classification
{
    partial class MultinomialLogisticRegressionModelControl
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
            this.modelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fittingDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fittingFunctionLabel = new System.Windows.Forms.Label();
            this.modelTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fittingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 1;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.modelTableLayoutPanel.Controls.Add(this.fittingDataGridView, 0, 2);
            this.modelTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.modelTableLayoutPanel.Controls.Add(this.fittingFunctionLabel, 0, 1);
            this.modelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.modelTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.modelTableLayoutPanel.Name = "modelTableLayoutPanel";
            this.modelTableLayoutPanel.RowCount = 3;
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.Size = new System.Drawing.Size(600, 300);
            this.modelTableLayoutPanel.TabIndex = 0;
            // 
            // fittingDataGridView
            // 
            this.fittingDataGridView.AllowUserToAddRows = false;
            this.fittingDataGridView.AllowUserToDeleteRows = false;
            this.fittingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fittingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fittingDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fittingDataGridView.Location = new System.Drawing.Point(3, 84);
            this.fittingDataGridView.Name = "fittingDataGridView";
            this.fittingDataGridView.ReadOnly = true;
            this.fittingDataGridView.RowHeadersWidth = 51;
            this.fittingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fittingDataGridView.Size = new System.Drawing.Size(594, 213);
            this.fittingDataGridView.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(594, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Multinomial Logistic Regression - Fitting Function";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fittingFunctionLabel
            // 
            this.fittingFunctionLabel.AutoSize = true;
            this.fittingFunctionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fittingFunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fittingFunctionLabel.Location = new System.Drawing.Point(3, 49);
            this.fittingFunctionLabel.Name = "fittingFunctionLabel";
            this.fittingFunctionLabel.Size = new System.Drawing.Size(594, 32);
            this.fittingFunctionLabel.TabIndex = 0;
            this.fittingFunctionLabel.Text = "Fitting function: y = 1 / (1 + exp(-(b0 + sum(bi * xi))))";
            this.fittingFunctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultinomialLogisticRegressionModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelTableLayoutPanel);
            this.Name = "MultinomialLogisticRegressionModelControl";
            this.Size = new System.Drawing.Size(600, 300);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.modelTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fittingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel modelTableLayoutPanel;
        private System.Windows.Forms.DataGridView fittingDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fittingFunctionLabel;
    }
}
