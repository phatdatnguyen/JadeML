namespace JadeML
{
    partial class SplitDatasetDialog
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
            this.splitTrackBar = new System.Windows.Forms.TrackBar();
            this.trainingDatasetLabel = new System.Windows.Forms.Label();
            this.testingDatasetLabel = new System.Windows.Forms.Label();
            this.splitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitTrackBar
            // 
            this.splitTrackBar.Location = new System.Drawing.Point(12, 12);
            this.splitTrackBar.Maximum = 100;
            this.splitTrackBar.Name = "splitTrackBar";
            this.splitTrackBar.Size = new System.Drawing.Size(280, 45);
            this.splitTrackBar.TabIndex = 0;
            this.splitTrackBar.TickFrequency = 10;
            this.splitTrackBar.Value = 70;
            this.splitTrackBar.Scroll += new System.EventHandler(this.splitTrackBar_Scroll);
            // 
            // trainingDatasetLabel
            // 
            this.trainingDatasetLabel.AutoSize = true;
            this.trainingDatasetLabel.Location = new System.Drawing.Point(12, 60);
            this.trainingDatasetLabel.Name = "trainingDatasetLabel";
            this.trainingDatasetLabel.Size = new System.Drawing.Size(109, 13);
            this.trainingDatasetLabel.TabIndex = 0;
            this.trainingDatasetLabel.Text = "Training dataset: 70%";
            // 
            // testingDatasetLabel
            // 
            this.testingDatasetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testingDatasetLabel.AutoSize = true;
            this.testingDatasetLabel.Location = new System.Drawing.Point(186, 60);
            this.testingDatasetLabel.Name = "testingDatasetLabel";
            this.testingDatasetLabel.Size = new System.Drawing.Size(106, 13);
            this.testingDatasetLabel.TabIndex = 0;
            this.testingDatasetLabel.Text = "Testing dataset: 30%";
            // 
            // splitButton
            // 
            this.splitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.splitButton.Location = new System.Drawing.Point(136, 86);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 1;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(217, 86);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SplitDatasetDialog
            // 
            this.AcceptButton = this.splitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.testingDatasetLabel);
            this.Controls.Add(this.trainingDatasetLabel);
            this.Controls.Add(this.splitTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplitDatasetDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Split Dataset";
            ((System.ComponentModel.ISupportInitialize)(this.splitTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar splitTrackBar;
        private System.Windows.Forms.Label trainingDatasetLabel;
        private System.Windows.Forms.Label testingDatasetLabel;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}