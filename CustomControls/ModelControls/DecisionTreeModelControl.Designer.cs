namespace JadeChem.CustomControls.ModelControls
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
            decisionTreeLabel = new Label();
            trainButton = new Button();
            decisionTreeViewControl = new DiagramControls.DecisionTreeViewControl();
            treeViewGroupBox = new GroupBox();
            treeViewGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // decisionTreeLabel
            // 
            decisionTreeLabel.AutoSize = true;
            decisionTreeLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            decisionTreeLabel.Location = new Point(20, 20);
            decisionTreeLabel.Margin = new Padding(2, 0, 2, 0);
            decisionTreeLabel.Name = "decisionTreeLabel";
            decisionTreeLabel.Size = new Size(109, 17);
            decisionTreeLabel.TabIndex = 0;
            decisionTreeLabel.Text = "Decision Tree";
            // 
            // trainButton
            // 
            trainButton.Location = new Point(20, 50);
            trainButton.Margin = new Padding(2);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(75, 23);
            trainButton.TabIndex = 0;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += TrainButton_Click;
            // 
            // decisionTreeViewControl
            // 
            decisionTreeViewControl.AutoScroll = true;
            decisionTreeViewControl.Dock = DockStyle.Fill;
            decisionTreeViewControl.Location = new Point(3, 19);
            decisionTreeViewControl.Name = "decisionTreeViewControl";
            decisionTreeViewControl.Size = new Size(274, 258);
            decisionTreeViewControl.TabIndex = 0;
            // 
            // treeViewGroupBox
            // 
            treeViewGroupBox.Controls.Add(decisionTreeViewControl);
            treeViewGroupBox.Location = new Point(100, 50);
            treeViewGroupBox.Name = "treeViewGroupBox";
            treeViewGroupBox.Size = new Size(280, 280);
            treeViewGroupBox.TabIndex = 1;
            treeViewGroupBox.TabStop = false;
            treeViewGroupBox.Text = "Tree view";
            treeViewGroupBox.Visible = false;
            // 
            // DecisionTreeModelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeViewGroupBox);
            Controls.Add(trainButton);
            Controls.Add(decisionTreeLabel);
            Margin = new Padding(2);
            Name = "DecisionTreeModelControl";
            Size = new Size(790, 350);
            treeViewGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label decisionTreeLabel;
        private Button trainButton;
        private DiagramControls.DecisionTreeViewControl decisionTreeViewControl;
        private GroupBox treeViewGroupBox;
    }
}
