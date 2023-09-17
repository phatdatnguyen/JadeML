namespace JadeChem.Dialogs
{
    partial class MulticlassSupportVectorsDialog
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
            panel1 = new Panel();
            svmComboBox = new ComboBox();
            supportVectorsLabel = new Label();
            panel2 = new Panel();
            closeButton = new Button();
            supportVectorsDataGridView = new DataGridView();
            tableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supportVectorsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(panel1, 0, 0);
            tableLayoutPanel.Controls.Add(panel2, 0, 2);
            tableLayoutPanel.Controls.Add(supportVectorsDataGridView, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(584, 361);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(svmComboBox);
            panel1.Controls.Add(supportVectorsLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 74);
            panel1.TabIndex = 0;
            // 
            // svmComboBox
            // 
            svmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            svmComboBox.FormattingEnabled = true;
            svmComboBox.Location = new Point(9, 9);
            svmComboBox.Name = "svmComboBox";
            svmComboBox.Size = new Size(200, 23);
            svmComboBox.TabIndex = 0;
            svmComboBox.SelectedIndexChanged += SVMComboBox_SelectedIndexChanged;
            // 
            // supportVectorsLabel
            // 
            supportVectorsLabel.AutoSize = true;
            supportVectorsLabel.Location = new Point(9, 45);
            supportVectorsLabel.Name = "supportVectorsLabel";
            supportVectorsLabel.Size = new Size(90, 15);
            supportVectorsLabel.TabIndex = 0;
            supportVectorsLabel.Text = "Support vectors";
            // 
            // panel2
            // 
            panel2.Controls.Add(closeButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 34);
            panel2.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.DialogResult = DialogResult.Cancel;
            closeButton.Location = new Point(494, 8);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // supportVectorsDataGridView
            // 
            supportVectorsDataGridView.AllowUserToAddRows = false;
            supportVectorsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            supportVectorsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            supportVectorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            supportVectorsDataGridView.Dock = DockStyle.Fill;
            supportVectorsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            supportVectorsDataGridView.Location = new Point(3, 83);
            supportVectorsDataGridView.Name = "supportVectorsDataGridView";
            supportVectorsDataGridView.ReadOnly = true;
            supportVectorsDataGridView.RowTemplate.Height = 25;
            supportVectorsDataGridView.Size = new Size(578, 235);
            supportVectorsDataGridView.TabIndex = 1;
            // 
            // MulticlassSupportVectorsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(584, 361);
            Controls.Add(tableLayoutPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "MulticlassSupportVectorsDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Support vectors";
            tableLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supportVectorsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label supportVectorsLabel;
        private Panel panel1;
        private Panel panel2;
        private Button closeButton;
        private DataGridView supportVectorsDataGridView;
        private ComboBox svmComboBox;
    }
}