namespace JadeChem.Dialogs
{
    partial class DataProcessingDialog
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
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup3 = new ListViewGroup("Scaling", HorizontalAlignment.Left);
            ListViewGroup listViewGroup4 = new ListViewGroup("Dimensionality Reduction", HorizontalAlignment.Left);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Min-max scaling", "{ range=(0, 1) }" }, -1);
            ListViewItem listViewItem6 = new ListViewItem("Standardization");
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Variance threshold", "{ threshold=0.1 }" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Principle component analysis", "{ nComponents=32 }" }, -1);
            processingStepsLabel = new Label();
            columnLabel = new Label();
            processingStepsListView = new ListView();
            stepColumnHeader = new ColumnHeader();
            parametersColumnHeader = new ColumnHeader();
            columnListBox = new ListBox();
            okButton = new Button();
            cancelButton = new Button();
            toolTip = new ToolTip(components);
            editButton = new Button();
            SuspendLayout();
            // 
            // processingStepsLabel
            // 
            processingStepsLabel.AutoSize = true;
            processingStepsLabel.Location = new Point(168, 10);
            processingStepsLabel.Margin = new Padding(4, 0, 4, 0);
            processingStepsLabel.Name = "processingStepsLabel";
            processingStepsLabel.Size = new Size(94, 15);
            processingStepsLabel.TabIndex = 0;
            processingStepsLabel.Text = "Processing steps";
            // 
            // columnLabel
            // 
            columnLabel.AutoSize = true;
            columnLabel.Location = new Point(14, 10);
            columnLabel.Margin = new Padding(4, 0, 4, 0);
            columnLabel.Name = "columnLabel";
            columnLabel.Size = new Size(50, 15);
            columnLabel.TabIndex = 0;
            columnLabel.Text = "Column";
            // 
            // processingStepsListView
            // 
            processingStepsListView.CheckBoxes = true;
            processingStepsListView.Columns.AddRange(new ColumnHeader[] { stepColumnHeader, parametersColumnHeader });
            listViewGroup3.Header = "Scaling";
            listViewGroup3.Name = null;
            listViewGroup4.Header = "Dimensionality Reduction";
            listViewGroup4.Name = null;
            processingStepsListView.Groups.AddRange(new ListViewGroup[] { listViewGroup3, listViewGroup4 });
            processingStepsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem5.Group = listViewGroup3;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.Group = listViewGroup3;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.Group = listViewGroup4;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.Group = listViewGroup4;
            listViewItem8.StateImageIndex = 0;
            processingStepsListView.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            processingStepsListView.Location = new Point(173, 29);
            processingStepsListView.Margin = new Padding(4);
            processingStepsListView.MultiSelect = false;
            processingStepsListView.Name = "processingStepsListView";
            processingStepsListView.Size = new Size(378, 244);
            processingStepsListView.TabIndex = 1;
            processingStepsListView.UseCompatibleStateImageBehavior = false;
            processingStepsListView.View = View.Details;
            processingStepsListView.ItemChecked += ProcessingStepsView_ItemChecked;
            processingStepsListView.SelectedIndexChanged += ProcessingStepsListView_SelectedIndexChanged;
            // 
            // stepColumnHeader
            // 
            stepColumnHeader.Text = "Step";
            stepColumnHeader.Width = 180;
            // 
            // parametersColumnHeader
            // 
            parametersColumnHeader.Text = "Parameters";
            parametersColumnHeader.Width = 150;
            // 
            // columnListBox
            // 
            columnListBox.FormattingEnabled = true;
            columnListBox.ItemHeight = 15;
            columnListBox.Location = new Point(13, 29);
            columnListBox.Margin = new Padding(4);
            columnListBox.Name = "columnListBox";
            columnListBox.Size = new Size(147, 244);
            columnListBox.TabIndex = 0;
            columnListBox.SelectedIndexChanged += ColumnListBox_SelectedIndexChanged;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(393, 285);
            okButton.Margin = new Padding(4);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 3;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(476, 285);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Enabled = false;
            editButton.Location = new Point(310, 285);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 2;
            editButton.Text = "Edit...";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // DataProcessingDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(564, 321);
            Controls.Add(editButton);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(processingStepsLabel);
            Controls.Add(columnLabel);
            Controls.Add(processingStepsListView);
            Controls.Add(columnListBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DataProcessingDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data Processing";
            Load += DataProcessingDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label processingStepsLabel;
        private Label columnLabel;
        private ListView processingStepsListView;
        private ColumnHeader stepColumnHeader;
        private ColumnHeader parametersColumnHeader;
        private ListBox columnListBox;
        private Button okButton;
        private Button cancelButton;
        private ToolTip toolTip;
        private Button editButton;
    }
}