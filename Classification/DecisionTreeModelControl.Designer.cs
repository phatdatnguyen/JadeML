namespace JadeML.Classification
{
    partial class DecisionTreeModelControl
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
            this.decisionTreeDiagramViewPanel = new System.Windows.Forms.Panel();
            this.decisionTreeDiagramView = new MindFusion.Diagramming.WinForms.DiagramView();
            this.decisionTreeDiagram = new MindFusion.Diagramming.Diagram();
            this.decisionTreeDiagramViewZoomControl = new MindFusion.Common.WinForms.ZoomControl();
            this.treePruningLabel = new System.Windows.Forms.Label();
            this.treePruningPanel = new System.Windows.Forms.Panel();
            this.pruningMethodComboBox = new System.Windows.Forms.ComboBox();
            this.pruneButton = new System.Windows.Forms.Button();
            this.pruningThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pruningMethodLabel = new System.Windows.Forms.Label();
            this.pruningThresholdLabel = new System.Windows.Forms.Label();
            this.decisionTreeLayout = new MindFusion.Diagramming.Layout.TreeLayout();
            this.modelTableLayoutPanel.SuspendLayout();
            this.decisionTreeDiagramViewPanel.SuspendLayout();
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
            this.treeViewLabel.Size = new System.Drawing.Size(569, 49);
            this.treeViewLabel.TabIndex = 0;
            this.treeViewLabel.Text = "Tree View";
            this.treeViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelTableLayoutPanel
            // 
            this.modelTableLayoutPanel.ColumnCount = 2;
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.modelTableLayoutPanel.Controls.Add(this.decisionTreeDiagramViewPanel, 0, 1);
            this.modelTableLayoutPanel.Controls.Add(this.treePruningLabel, 1, 0);
            this.modelTableLayoutPanel.Controls.Add(this.treeViewLabel, 0, 0);
            this.modelTableLayoutPanel.Controls.Add(this.treePruningPanel, 1, 1);
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
            // decisionTreeDiagramViewPanel
            // 
            this.decisionTreeDiagramViewPanel.Controls.Add(this.decisionTreeDiagramView);
            this.decisionTreeDiagramViewPanel.Controls.Add(this.decisionTreeDiagramViewZoomControl);
            this.decisionTreeDiagramViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeDiagramViewPanel.Location = new System.Drawing.Point(3, 52);
            this.decisionTreeDiagramViewPanel.Name = "decisionTreeDiagramViewPanel";
            this.decisionTreeDiagramViewPanel.Size = new System.Drawing.Size(569, 345);
            this.decisionTreeDiagramViewPanel.TabIndex = 0;
            // 
            // decisionTreeDiagramView
            // 
            this.decisionTreeDiagramView.Behavior = MindFusion.Diagramming.Behavior.Modify;
            this.decisionTreeDiagramView.Diagram = this.decisionTreeDiagram;
            this.decisionTreeDiagramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionTreeDiagramView.LicenseKey = null;
            this.decisionTreeDiagramView.Location = new System.Drawing.Point(0, 0);
            this.decisionTreeDiagramView.Name = "decisionTreeDiagramView";
            this.decisionTreeDiagramView.Size = new System.Drawing.Size(509, 345);
            this.decisionTreeDiagramView.TabIndex = 0;
            this.decisionTreeDiagramView.Text = "diagramView1";
            // 
            // decisionTreeDiagram
            // 
            this.decisionTreeDiagram.TouchThreshold = 0F;
            this.decisionTreeDiagram.LinkDeleting += new System.EventHandler<MindFusion.Diagramming.LinkValidationEventArgs>(this.decisionTreeDiagram_LinkDeleting);
            this.decisionTreeDiagram.NodeDeleting += new System.EventHandler<MindFusion.Diagramming.NodeValidationEventArgs>(this.decisionTreeDiagram_NodeDeleting);
            // 
            // decisionTreeDiagramViewZoomControl
            // 
            this.decisionTreeDiagramViewZoomControl.BackColor = System.Drawing.Color.Transparent;
            this.decisionTreeDiagramViewZoomControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.decisionTreeDiagramViewZoomControl.Location = new System.Drawing.Point(509, 0);
            this.decisionTreeDiagramViewZoomControl.Name = "decisionTreeDiagramViewZoomControl";
            this.decisionTreeDiagramViewZoomControl.Padding = new System.Windows.Forms.Padding(5);
            this.decisionTreeDiagramViewZoomControl.Size = new System.Drawing.Size(60, 345);
            this.decisionTreeDiagramViewZoomControl.TabIndex = 1;
            this.decisionTreeDiagramViewZoomControl.Target = this.decisionTreeDiagramView;
            this.decisionTreeDiagramViewZoomControl.TickPosition = MindFusion.Common.WinForms.TickPosition.Left;
            // 
            // treePruningLabel
            // 
            this.treePruningLabel.AutoSize = true;
            this.treePruningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePruningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePruningLabel.Location = new System.Drawing.Point(578, 0);
            this.treePruningLabel.Name = "treePruningLabel";
            this.treePruningLabel.Size = new System.Drawing.Size(219, 49);
            this.treePruningLabel.TabIndex = 0;
            this.treePruningLabel.Text = "Decision Tree Pruning";
            this.treePruningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treePruningPanel
            // 
            this.treePruningPanel.Controls.Add(this.pruningMethodComboBox);
            this.treePruningPanel.Controls.Add(this.pruneButton);
            this.treePruningPanel.Controls.Add(this.pruningThresholdNumericUpDown);
            this.treePruningPanel.Controls.Add(this.pruningMethodLabel);
            this.treePruningPanel.Controls.Add(this.pruningThresholdLabel);
            this.treePruningPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePruningPanel.Location = new System.Drawing.Point(578, 52);
            this.treePruningPanel.Name = "treePruningPanel";
            this.treePruningPanel.Size = new System.Drawing.Size(219, 345);
            this.treePruningPanel.TabIndex = 1;
            // 
            // pruningMethodComboBox
            // 
            this.pruningMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pruningMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningMethodComboBox.FormattingEnabled = true;
            this.pruningMethodComboBox.Items.AddRange(new object[] {
            "Error-Based Pruning",
            "Reduced Error Pruning"});
            this.pruningMethodComboBox.Location = new System.Drawing.Point(56, 14);
            this.pruningMethodComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pruningMethodComboBox.Name = "pruningMethodComboBox";
            this.pruningMethodComboBox.Size = new System.Drawing.Size(151, 21);
            this.pruningMethodComboBox.TabIndex = 0;
            // 
            // pruneButton
            // 
            this.pruneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruneButton.Location = new System.Drawing.Point(131, 61);
            this.pruneButton.Margin = new System.Windows.Forms.Padding(2);
            this.pruneButton.Name = "pruneButton";
            this.pruneButton.Size = new System.Drawing.Size(75, 23);
            this.pruneButton.TabIndex = 2;
            this.pruneButton.Text = "Prune";
            this.pruneButton.UseVisualStyleBackColor = true;
            this.pruneButton.Click += new System.EventHandler(this.pruneButton_Click);
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
            this.pruningThresholdNumericUpDown.Location = new System.Drawing.Point(131, 38);
            this.pruningThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.pruningThresholdNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pruningThresholdNumericUpDown.Name = "pruningThresholdNumericUpDown";
            this.pruningThresholdNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.pruningThresholdNumericUpDown.TabIndex = 1;
            this.pruningThresholdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // pruningMethodLabel
            // 
            this.pruningMethodLabel.AutoSize = true;
            this.pruningMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningMethodLabel.Location = new System.Drawing.Point(9, 17);
            this.pruningMethodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pruningMethodLabel.Name = "pruningMethodLabel";
            this.pruningMethodLabel.Size = new System.Drawing.Size(43, 13);
            this.pruningMethodLabel.TabIndex = 0;
            this.pruningMethodLabel.Text = "Method";
            // 
            // pruningThresholdLabel
            // 
            this.pruningThresholdLabel.AutoSize = true;
            this.pruningThresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pruningThresholdLabel.Location = new System.Drawing.Point(73, 40);
            this.pruningThresholdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pruningThresholdLabel.Name = "pruningThresholdLabel";
            this.pruningThresholdLabel.Size = new System.Drawing.Size(54, 13);
            this.pruningThresholdLabel.TabIndex = 0;
            this.pruningThresholdLabel.Text = "Threshold";
            // 
            // DecisionTreeModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelTableLayoutPanel);
            this.Name = "DecisionTreeModelControl";
            this.Size = new System.Drawing.Size(800, 400);
            this.modelTableLayoutPanel.ResumeLayout(false);
            this.modelTableLayoutPanel.PerformLayout();
            this.decisionTreeDiagramViewPanel.ResumeLayout(false);
            this.treePruningPanel.ResumeLayout(false);
            this.treePruningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pruningThresholdNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label treeViewLabel;
        private System.Windows.Forms.TableLayoutPanel modelTableLayoutPanel;
        private MindFusion.Diagramming.Layout.TreeLayout decisionTreeLayout;
        private MindFusion.Diagramming.Diagram decisionTreeDiagram;
        private MindFusion.Diagramming.WinForms.DiagramView decisionTreeDiagramView;
        private System.Windows.Forms.Label treePruningLabel;
        private System.Windows.Forms.Panel treePruningPanel;
        private System.Windows.Forms.ComboBox pruningMethodComboBox;
        private System.Windows.Forms.Button pruneButton;
        private System.Windows.Forms.NumericUpDown pruningThresholdNumericUpDown;
        private System.Windows.Forms.Label pruningMethodLabel;
        private System.Windows.Forms.Label pruningThresholdLabel;
        private System.Windows.Forms.Panel decisionTreeDiagramViewPanel;
        private MindFusion.Common.WinForms.ZoomControl decisionTreeDiagramViewZoomControl;
    }
}
