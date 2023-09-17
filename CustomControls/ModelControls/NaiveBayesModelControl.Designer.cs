namespace JadeChem.CustomControls.ModelControls
{
    partial class NaiveBayesModelControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            naiveBayerLabel = new Label();
            trainButton = new Button();
            normalDistributionGroupBox = new GroupBox();
            normalDistributionDataGridView = new DataGridView();
            normalDistributionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)normalDistributionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // naiveBayerLabel
            // 
            naiveBayerLabel.AutoSize = true;
            naiveBayerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            naiveBayerLabel.Location = new Point(20, 20);
            naiveBayerLabel.Name = "naiveBayerLabel";
            naiveBayerLabel.Size = new Size(74, 15);
            naiveBayerLabel.TabIndex = 0;
            naiveBayerLabel.Text = "Naïve Bayes";
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 50);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 0;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // normalDistributionGroupBox
            // 
            normalDistributionGroupBox.Controls.Add(normalDistributionDataGridView);
            normalDistributionGroupBox.Location = new Point(101, 50);
            normalDistributionGroupBox.Name = "normalDistributionGroupBox";
            normalDistributionGroupBox.Size = new Size(664, 150);
            normalDistributionGroupBox.TabIndex = 3;
            normalDistributionGroupBox.TabStop = false;
            normalDistributionGroupBox.Text = "Normal distribution";
            normalDistributionGroupBox.Visible = false;
            // 
            // normalDistributionDataGridView
            // 
            normalDistributionDataGridView.AllowUserToAddRows = false;
            normalDistributionDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            normalDistributionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            normalDistributionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            normalDistributionDataGridView.Dock = DockStyle.Fill;
            normalDistributionDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            normalDistributionDataGridView.Location = new Point(3, 19);
            normalDistributionDataGridView.Name = "normalDistributionDataGridView";
            normalDistributionDataGridView.ReadOnly = true;
            normalDistributionDataGridView.RowHeadersVisible = false;
            normalDistributionDataGridView.RowTemplate.Height = 25;
            normalDistributionDataGridView.Size = new Size(658, 128);
            normalDistributionDataGridView.TabIndex = 0;
            normalDistributionDataGridView.CellFormatting += NormalDistributionDataGridView_CellFormatting;
            // 
            // NaiveBayesModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(normalDistributionGroupBox);
            Controls.Add(trainButton);
            Controls.Add(naiveBayerLabel);
            Name = "NaiveBayesModelControl";
            Size = new Size(790, 350);
            normalDistributionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)normalDistributionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label naiveBayerLabel;
        private Button trainButton;
        private GroupBox normalDistributionGroupBox;
        private DataGridView normalDistributionDataGridView;
    }
}
