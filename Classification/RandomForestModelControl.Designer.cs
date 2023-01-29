namespace JadeML.Classification
{
    partial class RandomForestModelControl
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
            this.treeViewLabel = new System.Windows.Forms.Label();
            this.modelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.decisionTreeDiagramViewPanel = new System.Windows.Forms.Panel();
            this.decisionTreeDiagramView = new MindFusion.Diagramming.WinForms.DiagramView();
            this.decisionTreeDiagram = new MindFusion.Diagramming.Diagram();
            this.decisionTreeDiagramZoomControl = new MindFusion.Common.WinForms.ZoomControl();
            this.treePanel = new System.Windows.Forms.Panel();
            this.treeComboBox = new System.Windows.Forms.ComboBox();
            this.treeLabel = new System.Windows.Forms.Label();
            this.treePruningPanel = new System.Windows.Forms.Panel();
            this.selectedTreeRadioButton = new System.Windows.Forms.RadioButton();
            this.wholeForestRadioButton = new System.Windows.Forms.RadioButton();
            this.pruningThresholdLabel = new System.Windows.Forms.Label();
            this.pruningMethodLabel = new System.Windows.Forms.Label();
            this.pruningMethodComboBox = new System.Windows.Forms.ComboBox();
            this.pruningThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pruneButton = new System.Windows.Forms.Button();
            this.treePruningLabel = new System.Windows.Forms.Label();
            this.decisionTreeLayout = new MindFusion.Diagramming.Layout.TreeLayout();
            this.modelTableLayoutPanel.SuspendLayout();
            this.treeViewTableLayoutPanel.SuspendLayout();
            this.decisionTreeDiagramViewPanel.SuspendLayout();
            this.treePanel.SuspendLayout();
            this.treePruningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruningThresholdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewLabel
            // 
            this.treeViewLabel.AutoSize = true;
            this.treeViewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewLabel.Location = new System.Drawing.Point(3, 0);
            this.treeViewLabel.Name = "treeViewLabel";
            this.treeViewLabel.Size = new System.Drawing.Size(532, 49);
            this.treeViewLabel.TabIndex = 0;
            this.treeViewLabel.Text = "Tree View";
            this.treeViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 2;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.modelTableLayoutPanel.Controls.Add(this.treeViewTableLayoutPanel, 0, 1);
            this.modelTableLayoutPanel.Controls.Add(this.treePruningPanel, 1, 1);
            this.modelTableLayoutPanel.Controls.Add(this.treePruningLabel, 1, 0);
            this.modelTableLayoutPanel.Controls.Add(this.treeViewLabel, 0, 0);
            this.modelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.modelTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.modelTableLayoutPanel.Name = "modelTableLayoutPanel";
            this.modelTableLayoutPanel.RowCount = 2;
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.modelTableLayoutPanel.Size = new System.Drawing.Size(800, 400);
            this.modelTableLayoutPanel.TabIndex = 0;
            // 
            // treeViewTableLayoutPanel
            // 
            this.treeViewTableLayoutPanel.ColumnCount = 1;
            this.treeViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.treeViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.treeViewTableLayoutPanel.Controls.Add(this.decisionTreeDiagramViewPanel, 0, 1);
            this.treeViewTableLayoutPanel.Controls.Add(this.treePanel, 0, 0);
            this.treeViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTableLayoutPanel.Location = new System.Drawing.Point(2, 51);
            this.treeViewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewTableLayoutPanel.Name = "treeViewTableLayoutPanel";
            this.treeViewTableLayoutPanel.RowCount = 2;
            this.treeViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.treeViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.treeViewTableLayoutPanel.Size = new System.Drawing.Size(534, 347);
            this.treeViewTableLayoutPanel.TabIndex = 7;
            // 
            // decisionTreeDiagramViewPanel
            // 
            this.decisionTreeDiagramViewPanel.Controls.Add(this.decisionTreeDiagramView);
            this.decisionTreeDiagramViewPanel.Controls.Add(this.decisionTreeDiagramZoomControl);
            this.decisionTreeDiagramViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeDiagramViewPanel.Location = new System.Drawing.Point(3, 35);
            this.decisionTreeDiagramViewPanel.Name = "decisionTreeDiagramViewPanel";
            this.decisionTreeDiagramViewPanel.Size = new System.Drawing.Size(528, 309);
            this.decisionTreeDiagramViewPanel.TabIndex = 1;
            // 
            // decisionTreeDiagramView
            // 
            this.decisionTreeDiagramView.Behavior = MindFusion.Diagramming.Behavior.Modify;
            this.decisionTreeDiagramView.Diagram = this.decisionTreeDiagram;
            this.decisionTreeDiagramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeDiagramView.LicenseKey = null;
            this.decisionTreeDiagramView.Location = new System.Drawing.Point(0, 0);
            this.decisionTreeDiagramView.Name = "decisionTreeDiagramView";
            this.decisionTreeDiagramView.Size = new System.Drawing.Size(468, 309);
            this.decisionTreeDiagramView.TabIndex = 0;
            this.decisionTreeDiagramView.Text = "diagramView1";
            // 
            // decisionTreeDiagram
            // 
            this.decisionTreeDiagram.TouchThreshold = 0F;
            // 
            // decisionTreeDiagramZoomControl
            // 
            this.decisionTreeDiagramZoomControl.BackColor = System.Drawing.Color.Transparent;
            this.decisionTreeDiagramZoomControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.decisionTreeDiagramZoomControl.Location = new System.Drawing.Point(468, 0);
            this.decisionTreeDiagramZoomControl.Name = "decisionTreeDiagramZoomControl";
            this.decisionTreeDiagramZoomControl.Padding = new System.Windows.Forms.Padding(5);
            this.decisionTreeDiagramZoomControl.Size = new System.Drawing.Size(60, 309);
            this.decisionTreeDiagramZoomControl.TabIndex = 1;
            this.decisionTreeDiagramZoomControl.Target = this.decisionTreeDiagramView;
            this.decisionTreeDiagramZoomControl.TickPosition = MindFusion.Common.WinForms.TickPosition.Left;
            // 
            // treePanel
            // 
            this.treePanel.Controls.Add(this.treeComboBox);
            this.treePanel.Controls.Add(this.treeLabel);
            this.treePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePanel.Location = new System.Drawing.Point(2, 2);
            this.treePanel.Margin = new System.Windows.Forms.Padding(2);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(530, 28);
            this.treePanel.TabIndex = 0;
            // 
            // treeComboBox
            // 
            this.treeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeComboBox.FormattingEnabled = true;
            this.treeComboBox.Location = new System.Drawing.Point(35, 2);
            this.treeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.treeComboBox.Name = "treeComboBox";
            this.treeComboBox.Size = new System.Drawing.Size(114, 21);
            this.treeComboBox.TabIndex = 0;
            this.treeComboBox.SelectedIndexChanged += new System.EventHandler(this.treeComboBox_SelectedIndexChanged);
            // 
            // treeLabel
            // 
            this.treeLabel.AutoSize = true;
            this.treeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeLabel.Location = new System.Drawing.Point(2, 5);
            this.treeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.treeLabel.Name = "treeLabel";
            this.treeLabel.Size = new System.Drawing.Size(29, 13);
            this.treeLabel.TabIndex = 0;
            this.treeLabel.Text = "Tree";
            // 
            // treePruningPanel
            // 
            this.treePruningPanel.Controls.Add(this.selectedTreeRadioButton);
            this.treePruningPanel.Controls.Add(this.wholeForestRadioButton);
            this.treePruningPanel.Controls.Add(this.pruningThresholdLabel);
            this.treePruningPanel.Controls.Add(this.pruningMethodLabel);
            this.treePruningPanel.Controls.Add(this.pruningMethodComboBox);
            this.treePruningPanel.Controls.Add(this.pruningThresholdNumericUpDown);
            this.treePruningPanel.Controls.Add(this.pruneButton);
            this.treePruningPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePruningPanel.Location = new System.Drawing.Point(541, 52);
            this.treePruningPanel.Name = "treePruningPanel";
            this.treePruningPanel.Size = new System.Drawing.Size(256, 345);
            this.treePruningPanel.TabIndex = 6;
            // 
            // selectedTreeRadioButton
            // 
            this.selectedTreeRadioButton.AutoSize = true;
            this.selectedTreeRadioButton.Checked = true;
            this.selectedTreeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTreeRadioButton.Location = new System.Drawing.Point(12, 11);
            this.selectedTreeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectedTreeRadioButton.Name = "selectedTreeRadioButton";
            this.selectedTreeRadioButton.Size = new System.Drawing.Size(124, 17);
            this.selectedTreeRadioButton.TabIndex = 0;
            this.selectedTreeRadioButton.TabStop = true;
            this.selectedTreeRadioButton.Text = "Selected tree (tree 1)";
            this.selectedTreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // wholeForestRadioButton
            // 
            this.wholeForestRadioButton.AutoSize = true;
            this.wholeForestRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeForestRadioButton.Location = new System.Drawing.Point(153, 11);
            this.wholeForestRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.wholeForestRadioButton.Name = "wholeForestRadioButton";
            this.wholeForestRadioButton.Size = new System.Drawing.Size(85, 17);
            this.wholeForestRadioButton.TabIndex = 1;
            this.wholeForestRadioButton.Text = "Whole forest";
            this.wholeForestRadioButton.UseVisualStyleBackColor = true;
            // 
            // pruningThresholdLabel
            // 
            this.pruningThresholdLabel.AutoSize = true;
            this.pruningThresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningThresholdLabel.Location = new System.Drawing.Point(89, 78);
            this.pruningThresholdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pruningThresholdLabel.Name = "pruningThresholdLabel";
            this.pruningThresholdLabel.Size = new System.Drawing.Size(54, 13);
            this.pruningThresholdLabel.TabIndex = 0;
            this.pruningThresholdLabel.Text = "Threshold";
            // 
            // pruningMethodLabel
            // 
            this.pruningMethodLabel.AutoSize = true;
            this.pruningMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningMethodLabel.Location = new System.Drawing.Point(24, 54);
            this.pruningMethodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pruningMethodLabel.Name = "pruningMethodLabel";
            this.pruningMethodLabel.Size = new System.Drawing.Size(43, 13);
            this.pruningMethodLabel.TabIndex = 0;
            this.pruningMethodLabel.Text = "Method";
            // 
            // pruningMethodComboBox
            // 
            this.pruningMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pruningMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningMethodComboBox.FormattingEnabled = true;
            this.pruningMethodComboBox.Items.AddRange(new object[] {
            "Error-Based Pruning",
            "Reduced Error Pruning"});
            this.pruningMethodComboBox.Location = new System.Drawing.Point(71, 51);
            this.pruningMethodComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pruningMethodComboBox.Name = "pruningMethodComboBox";
            this.pruningMethodComboBox.Size = new System.Drawing.Size(151, 21);
            this.pruningMethodComboBox.TabIndex = 2;
            // 
            // pruningThresholdNumericUpDown
            // 
            this.pruningThresholdNumericUpDown.DecimalPlaces = 2;
            this.pruningThresholdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningThresholdNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pruningThresholdNumericUpDown.Location = new System.Drawing.Point(147, 76);
            this.pruningThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.pruningThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pruningThresholdNumericUpDown.Name = "pruningThresholdNumericUpDown";
            this.pruningThresholdNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.pruningThresholdNumericUpDown.TabIndex = 3;
            this.pruningThresholdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // pruneButton
            // 
            this.pruneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruneButton.Location = new System.Drawing.Point(147, 99);
            this.pruneButton.Margin = new System.Windows.Forms.Padding(2);
            this.pruneButton.Name = "pruneButton";
            this.pruneButton.Size = new System.Drawing.Size(75, 23);
            this.pruneButton.TabIndex = 4;
            this.pruneButton.Text = "Prune";
            this.pruneButton.UseVisualStyleBackColor = true;
            this.pruneButton.Click += new System.EventHandler(this.pruneButton_Click);
            // 
            // treePruningLabel
            // 
            this.treePruningLabel.AutoSize = true;
            this.treePruningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePruningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePruningLabel.Location = new System.Drawing.Point(541, 0);
            this.treePruningLabel.Name = "treePruningLabel";
            this.treePruningLabel.Size = new System.Drawing.Size(256, 49);
            this.treePruningLabel.TabIndex = 2;
            this.treePruningLabel.Text = "Tree Pruning";
            this.treePruningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomForestModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelTableLayoutPanel);
            this.Name = "RandomForestModelControl";
            this.Size = new System.Drawing.Size(800, 400);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.modelTableLayoutPanel.PerformLayout();
            this.treeViewTableLayoutPanel.ResumeLayout(false);
            this.decisionTreeDiagramViewPanel.ResumeLayout(false);
            this.treePanel.ResumeLayout(false);
            this.treePanel.PerformLayout();
            this.treePruningPanel.ResumeLayout(false);
            this.treePruningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruningThresholdNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label treeViewLabel;
        private System.Windows.Forms.TableLayoutPanel modelTableLayoutPanel;
        private System.Windows.Forms.Label treePruningLabel;
        private System.Windows.Forms.TableLayoutPanel treeViewTableLayoutPanel;
        private System.Windows.Forms.Panel treePanel;
        private System.Windows.Forms.ComboBox treeComboBox;
        private System.Windows.Forms.Label treeLabel;
        private System.Windows.Forms.Panel treePruningPanel;
        private System.Windows.Forms.RadioButton selectedTreeRadioButton;
        private System.Windows.Forms.RadioButton wholeForestRadioButton;
        private System.Windows.Forms.Label pruningThresholdLabel;
        private System.Windows.Forms.Label pruningMethodLabel;
        private System.Windows.Forms.ComboBox pruningMethodComboBox;
        private System.Windows.Forms.NumericUpDown pruningThresholdNumericUpDown;
        private System.Windows.Forms.Button pruneButton;
        private MindFusion.Diagramming.Diagram decisionTreeDiagram;
        private MindFusion.Diagramming.Layout.TreeLayout decisionTreeLayout;
        private System.Windows.Forms.Panel decisionTreeDiagramViewPanel;
        private MindFusion.Diagramming.WinForms.DiagramView decisionTreeDiagramView;
        private MindFusion.Common.WinForms.ZoomControl decisionTreeDiagramZoomControl;
    }
}
