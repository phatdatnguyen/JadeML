namespace JadeChem.CustomControls.DiagramControls
{
    partial class WorkflowDiagramControl
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
            this.diagramPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // diagramPanel
            // 
            this.diagramPanel.Location = new System.Drawing.Point(0, 0);
            this.diagramPanel.Name = "diagramPanel";
            this.diagramPanel.Size = new System.Drawing.Size(794, 134);
            this.diagramPanel.TabIndex = 1;
            this.diagramPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DiagramPanel_Paint);
            this.diagramPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiagramPanel_MouseClick);
            this.diagramPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DiagramPanel_MouseMove);
            // 
            // DiagramControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.diagramPanel);
            this.Name = "DiagramControl";
            this.Size = new System.Drawing.Size(795, 135);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel diagramPanel;
    }
}
