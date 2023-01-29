namespace JadeML.Classification
{
    partial class SVMClassificationModelControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.modelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.supportVectorsDataGridView = new System.Windows.Forms.DataGridView();
            this.modelTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportVectorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(4, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(792, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Support Vectors";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 1;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.Controls.Add(this.supportVectorsDataGridView, 0, 1);
            this.modelTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.modelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.modelTableLayoutPanel.Name = "modelTableLayoutPanel";
            this.modelTableLayoutPanel.RowCount = 2;
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.Size = new System.Drawing.Size(800, 400);
            this.modelTableLayoutPanel.TabIndex = 0;
            // 
            // supportVectorsDataGridView
            // 
            this.supportVectorsDataGridView.AllowUserToAddRows = false;
            this.supportVectorsDataGridView.AllowUserToDeleteRows = false;
            this.supportVectorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supportVectorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supportVectorsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.supportVectorsDataGridView.Location = new System.Drawing.Point(4, 64);
            this.supportVectorsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.supportVectorsDataGridView.Name = "supportVectorsDataGridView";
            this.supportVectorsDataGridView.ReadOnly = true;
            this.supportVectorsDataGridView.RowHeadersWidth = 51;
            this.supportVectorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supportVectorsDataGridView.Size = new System.Drawing.Size(792, 332);
            this.supportVectorsDataGridView.TabIndex = 0;
            // 
            // SVMModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SVMModelControl";
            this.Size = new System.Drawing.Size(800, 400);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.modelTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportVectorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel modelTableLayoutPanel;
        private System.Windows.Forms.DataGridView supportVectorsDataGridView;
    }
}
