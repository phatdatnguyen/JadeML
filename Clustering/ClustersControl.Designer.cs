namespace JadeML.Clustering
{
    partial class ClustersControl
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
            this.showClustersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showClustersButton
            // 
            this.showClustersButton.Location = new System.Drawing.Point(41, 38);
            this.showClustersButton.Name = "showClustersButton";
            this.showClustersButton.Size = new System.Drawing.Size(120, 23);
            this.showClustersButton.TabIndex = 0;
            this.showClustersButton.Text = "Show clusters...";
            this.showClustersButton.UseVisualStyleBackColor = true;
            this.showClustersButton.Click += new System.EventHandler(this.showClustersButton_Click);
            // 
            // ClustersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showClustersButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClustersControl";
            this.Size = new System.Drawing.Size(200, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showClustersButton;
    }
}
