namespace JadeML
{
    partial class NewTaskDialog
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
            this.binaryClassificationLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.multiclassClassificationLabel = new System.Windows.Forms.Label();
            this.regressionLabel = new System.Windows.Forms.Label();
            this.daLabel = new System.Windows.Forms.Label();
            this.pcaLabel = new System.Windows.Forms.Label();
            this.clusteringLabel = new System.Windows.Forms.Label();
            this.daButton = new System.Windows.Forms.Button();
            this.regressionButton = new System.Windows.Forms.Button();
            this.pcaButton = new System.Windows.Forms.Button();
            this.clusteringButton = new System.Windows.Forms.Button();
            this.multiclassClassificationButton = new System.Windows.Forms.Button();
            this.binaryClassificationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binaryClassificationLabel
            // 
            this.binaryClassificationLabel.AutoSize = true;
            this.binaryClassificationLabel.Location = new System.Drawing.Point(22, 135);
            this.binaryClassificationLabel.Name = "binaryClassificationLabel";
            this.binaryClassificationLabel.Size = new System.Drawing.Size(100, 13);
            this.binaryClassificationLabel.TabIndex = 0;
            this.binaryClassificationLabel.Text = "Binary Classification";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(377, 326);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // multiclassClassificationLabel
            // 
            this.multiclassClassificationLabel.AutoSize = true;
            this.multiclassClassificationLabel.Location = new System.Drawing.Point(174, 135);
            this.multiclassClassificationLabel.Name = "multiclassClassificationLabel";
            this.multiclassClassificationLabel.Size = new System.Drawing.Size(117, 13);
            this.multiclassClassificationLabel.TabIndex = 0;
            this.multiclassClassificationLabel.Text = "Multiclass Classification";
            // 
            // regressionLabel
            // 
            this.regressionLabel.AutoSize = true;
            this.regressionLabel.Location = new System.Drawing.Point(362, 135);
            this.regressionLabel.Name = "regressionLabel";
            this.regressionLabel.Size = new System.Drawing.Size(60, 13);
            this.regressionLabel.TabIndex = 0;
            this.regressionLabel.Text = "Regression";
            // 
            // daLabel
            // 
            this.daLabel.AutoSize = true;
            this.daLabel.Location = new System.Drawing.Point(340, 294);
            this.daLabel.Name = "daLabel";
            this.daLabel.Size = new System.Drawing.Size(104, 13);
            this.daLabel.TabIndex = 0;
            this.daLabel.Text = "Discriminant analysis";
            // 
            // pcaLabel
            // 
            this.pcaLabel.AutoSize = true;
            this.pcaLabel.Location = new System.Drawing.Point(160, 294);
            this.pcaLabel.Name = "pcaLabel";
            this.pcaLabel.Size = new System.Drawing.Size(143, 13);
            this.pcaLabel.TabIndex = 0;
            this.pcaLabel.Text = "Principal component analysis";
            // 
            // clusteringLabel
            // 
            this.clusteringLabel.AutoSize = true;
            this.clusteringLabel.Location = new System.Drawing.Point(46, 294);
            this.clusteringLabel.Name = "clusteringLabel";
            this.clusteringLabel.Size = new System.Drawing.Size(53, 13);
            this.clusteringLabel.TabIndex = 0;
            this.clusteringLabel.Text = "Clustering";
            // 
            // daButton
            // 
            this.daButton.BackgroundImage = global::JadeML.Properties.Resources.da;
            this.daButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.daButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.daButton.Location = new System.Drawing.Point(332, 171);
            this.daButton.Name = "daButton";
            this.daButton.Size = new System.Drawing.Size(120, 120);
            this.daButton.TabIndex = 5;
            this.daButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.daButton.UseVisualStyleBackColor = true;
            this.daButton.Click += new System.EventHandler(this.daButton_Click);
            // 
            // regressionButton
            // 
            this.regressionButton.BackgroundImage = global::JadeML.Properties.Resources.regression;
            this.regressionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regressionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.regressionButton.Location = new System.Drawing.Point(332, 12);
            this.regressionButton.Name = "regressionButton";
            this.regressionButton.Size = new System.Drawing.Size(120, 120);
            this.regressionButton.TabIndex = 2;
            this.regressionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.regressionButton.UseVisualStyleBackColor = true;
            this.regressionButton.Click += new System.EventHandler(this.regressionButton_Click);
            // 
            // pcaButton
            // 
            this.pcaButton.BackgroundImage = global::JadeML.Properties.Resources.pca;
            this.pcaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcaButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pcaButton.Location = new System.Drawing.Point(172, 171);
            this.pcaButton.Name = "pcaButton";
            this.pcaButton.Size = new System.Drawing.Size(120, 120);
            this.pcaButton.TabIndex = 4;
            this.pcaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pcaButton.UseVisualStyleBackColor = true;
            this.pcaButton.Click += new System.EventHandler(this.pcaButton_Click);
            // 
            // clusteringButton
            // 
            this.clusteringButton.BackgroundImage = global::JadeML.Properties.Resources.clustering;
            this.clusteringButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clusteringButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.clusteringButton.Location = new System.Drawing.Point(12, 171);
            this.clusteringButton.Name = "clusteringButton";
            this.clusteringButton.Size = new System.Drawing.Size(120, 120);
            this.clusteringButton.TabIndex = 3;
            this.clusteringButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clusteringButton.UseVisualStyleBackColor = true;
            this.clusteringButton.Click += new System.EventHandler(this.clusteringButton_Click);
            // 
            // multiclassClassificationButton
            // 
            this.multiclassClassificationButton.BackgroundImage = global::JadeML.Properties.Resources.multiclass_classification;
            this.multiclassClassificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiclassClassificationButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.multiclassClassificationButton.Location = new System.Drawing.Point(172, 12);
            this.multiclassClassificationButton.Name = "multiclassClassificationButton";
            this.multiclassClassificationButton.Size = new System.Drawing.Size(120, 120);
            this.multiclassClassificationButton.TabIndex = 1;
            this.multiclassClassificationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.multiclassClassificationButton.UseVisualStyleBackColor = true;
            this.multiclassClassificationButton.Click += new System.EventHandler(this.multiclassClassificationButton_Click);
            // 
            // binaryClassificationButton
            // 
            this.binaryClassificationButton.BackgroundImage = global::JadeML.Properties.Resources.binary_classification;
            this.binaryClassificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.binaryClassificationButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.binaryClassificationButton.Location = new System.Drawing.Point(12, 12);
            this.binaryClassificationButton.Name = "binaryClassificationButton";
            this.binaryClassificationButton.Size = new System.Drawing.Size(120, 120);
            this.binaryClassificationButton.TabIndex = 0;
            this.binaryClassificationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.binaryClassificationButton.UseVisualStyleBackColor = true;
            this.binaryClassificationButton.Click += new System.EventHandler(this.binaryClassificationButton_Click);
            // 
            // NewTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.daLabel);
            this.Controls.Add(this.pcaLabel);
            this.Controls.Add(this.clusteringLabel);
            this.Controls.Add(this.regressionLabel);
            this.Controls.Add(this.multiclassClassificationLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.binaryClassificationLabel);
            this.Controls.Add(this.daButton);
            this.Controls.Add(this.regressionButton);
            this.Controls.Add(this.pcaButton);
            this.Controls.Add(this.clusteringButton);
            this.Controls.Add(this.multiclassClassificationButton);
            this.Controls.Add(this.binaryClassificationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTaskDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New machine learning task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button binaryClassificationButton;
        private System.Windows.Forms.Button multiclassClassificationButton;
        private System.Windows.Forms.Button regressionButton;
        private System.Windows.Forms.Label binaryClassificationLabel;
        private System.Windows.Forms.Button clusteringButton;
        private System.Windows.Forms.Button pcaButton;
        private System.Windows.Forms.Button daButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label multiclassClassificationLabel;
        private System.Windows.Forms.Label regressionLabel;
        private System.Windows.Forms.Label daLabel;
        private System.Windows.Forms.Label pcaLabel;
        private System.Windows.Forms.Label clusteringLabel;
    }
}