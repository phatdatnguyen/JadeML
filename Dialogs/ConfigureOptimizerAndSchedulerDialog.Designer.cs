namespace JadeChem.Dialogs
{
    partial class ConfigureOptimizerAndSchedulerDialog
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            okButton = new Button();
            cancelButton = new Button();
            optimizerParametersDataGridView = new DataGridView();
            Parameter = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            optimizerGroupBox = new GroupBox();
            optimizerNameTextBox = new TextBox();
            optimizerLabel = new Label();
            groupBox1 = new GroupBox();
            lrSchedulerNameTextBox = new TextBox();
            schedulerLabel = new Label();
            lrSchedulerParametersDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)optimizerParametersDataGridView).BeginInit();
            optimizerGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lrSchedulerParametersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(516, 276);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(597, 276);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // optimizerParametersDataGridView
            // 
            optimizerParametersDataGridView.AllowUserToAddRows = false;
            optimizerParametersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            optimizerParametersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            optimizerParametersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            optimizerParametersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Parameter, Value });
            optimizerParametersDataGridView.Dock = DockStyle.Bottom;
            optimizerParametersDataGridView.Location = new Point(3, 51);
            optimizerParametersDataGridView.Name = "optimizerParametersDataGridView";
            optimizerParametersDataGridView.RowHeadersVisible = false;
            optimizerParametersDataGridView.RowHeadersWidth = 51;
            optimizerParametersDataGridView.RowTemplate.Height = 24;
            optimizerParametersDataGridView.Size = new Size(314, 204);
            optimizerParametersDataGridView.TabIndex = 1;
            // 
            // Parameter
            // 
            Parameter.HeaderText = "Parameter";
            Parameter.MinimumWidth = 6;
            Parameter.Name = "Parameter";
            Parameter.ReadOnly = true;
            Parameter.Width = 160;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            // 
            // optimizerGroupBox
            // 
            optimizerGroupBox.Controls.Add(optimizerNameTextBox);
            optimizerGroupBox.Controls.Add(optimizerLabel);
            optimizerGroupBox.Controls.Add(optimizerParametersDataGridView);
            optimizerGroupBox.Location = new Point(12, 12);
            optimizerGroupBox.Name = "optimizerGroupBox";
            optimizerGroupBox.Size = new Size(320, 258);
            optimizerGroupBox.TabIndex = 0;
            optimizerGroupBox.TabStop = false;
            optimizerGroupBox.Text = "Optimizer";
            // 
            // optimizerNameTextBox
            // 
            optimizerNameTextBox.Location = new Point(71, 22);
            optimizerNameTextBox.Name = "optimizerNameTextBox";
            optimizerNameTextBox.ReadOnly = true;
            optimizerNameTextBox.Size = new Size(198, 23);
            optimizerNameTextBox.TabIndex = 0;
            optimizerNameTextBox.Text = "Adam";
            // 
            // optimizerLabel
            // 
            optimizerLabel.AutoSize = true;
            optimizerLabel.Location = new Point(6, 25);
            optimizerLabel.Name = "optimizerLabel";
            optimizerLabel.Size = new Size(59, 15);
            optimizerLabel.TabIndex = 0;
            optimizerLabel.Text = "Optimizer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lrSchedulerNameTextBox);
            groupBox1.Controls.Add(schedulerLabel);
            groupBox1.Controls.Add(lrSchedulerParametersDataGridView);
            groupBox1.Location = new Point(338, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 258);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Learning rate scheduler";
            // 
            // lrSchedulerNameTextBox
            // 
            lrSchedulerNameTextBox.Location = new Point(71, 22);
            lrSchedulerNameTextBox.Name = "lrSchedulerNameTextBox";
            lrSchedulerNameTextBox.ReadOnly = true;
            lrSchedulerNameTextBox.Size = new Size(202, 23);
            lrSchedulerNameTextBox.TabIndex = 0;
            lrSchedulerNameTextBox.Text = "None";
            // 
            // schedulerLabel
            // 
            schedulerLabel.AutoSize = true;
            schedulerLabel.Location = new Point(6, 25);
            schedulerLabel.Name = "schedulerLabel";
            schedulerLabel.Size = new Size(59, 15);
            schedulerLabel.TabIndex = 0;
            schedulerLabel.Text = "Scheduler";
            // 
            // lrSchedulerParametersDataGridView
            // 
            lrSchedulerParametersDataGridView.AllowUserToAddRows = false;
            lrSchedulerParametersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            lrSchedulerParametersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            lrSchedulerParametersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lrSchedulerParametersDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            lrSchedulerParametersDataGridView.Dock = DockStyle.Bottom;
            lrSchedulerParametersDataGridView.Location = new Point(3, 51);
            lrSchedulerParametersDataGridView.Name = "lrSchedulerParametersDataGridView";
            lrSchedulerParametersDataGridView.RowHeadersVisible = false;
            lrSchedulerParametersDataGridView.RowHeadersWidth = 51;
            lrSchedulerParametersDataGridView.RowTemplate.Height = 24;
            lrSchedulerParametersDataGridView.Size = new Size(328, 204);
            lrSchedulerParametersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Parameter";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Value";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ConfigureOptimizerAndSchedulerDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(684, 311);
            Controls.Add(groupBox1);
            Controls.Add(optimizerGroupBox);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfigureOptimizerAndSchedulerDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Parameters";
            FormClosing += EditParametersDialog_FormClosing;
            ((System.ComponentModel.ISupportInitialize)optimizerParametersDataGridView).EndInit();
            optimizerGroupBox.ResumeLayout(false);
            optimizerGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lrSchedulerParametersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private DataGridView optimizerParametersDataGridView;
        private GroupBox optimizerGroupBox;
        private DataGridViewTextBoxColumn Parameter;
        private DataGridViewTextBoxColumn Value;
        private TextBox optimizerNameTextBox;
        private Label optimizerLabel;
        private GroupBox groupBox1;
        private TextBox lrSchedulerNameTextBox;
        private Label schedulerLabel;
        private DataGridView lrSchedulerParametersDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}