namespace JadeChem.Dialogs
{
    partial class EditParametersDialog
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
            okButton = new Button();
            cancelButton = new Button();
            parametersDataGridView = new DataGridView();
            Parameter = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)parametersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(176, 106);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(257, 106);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // parametersDataGridView
            // 
            parametersDataGridView.AllowUserToAddRows = false;
            parametersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            parametersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            parametersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parametersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Parameter, Value });
            parametersDataGridView.Location = new Point(12, 7);
            parametersDataGridView.Name = "parametersDataGridView";
            parametersDataGridView.RowHeadersVisible = false;
            parametersDataGridView.RowHeadersWidth = 51;
            parametersDataGridView.RowTemplate.Height = 24;
            parametersDataGridView.Size = new Size(320, 93);
            parametersDataGridView.TabIndex = 0;
            // 
            // Parameter
            // 
            Parameter.HeaderText = "Parameter";
            Parameter.MinimumWidth = 6;
            Parameter.Name = "Parameter";
            Parameter.ReadOnly = true;
            Parameter.Width = 200;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            // 
            // EditParametersDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(344, 141);
            Controls.Add(parametersDataGridView);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditParametersDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Parameters";
            FormClosing += EditParametersDialog_FormClosing;
            Load += EditParametersDialog_Load;
            ((System.ComponentModel.ISupportInitialize)parametersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private DataGridView parametersDataGridView;
        private DataGridViewTextBoxColumn Parameter;
        private DataGridViewTextBoxColumn Value;
    }
}