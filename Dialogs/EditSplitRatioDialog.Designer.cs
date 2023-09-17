namespace JadeChem.Dialogs
{
    partial class EditSplitRatioDialog
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
            splitButton = new Button();
            cancelButton = new Button();
            splitRatioTrackBar = new TrackBar();
            split1Label = new Label();
            split2Label = new Label();
            randomSeedLabel = new Label();
            randomSeedNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)splitRatioTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)randomSeedNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // splitButton
            // 
            splitButton.DialogResult = DialogResult.OK;
            splitButton.Location = new Point(179, 107);
            splitButton.Margin = new Padding(2);
            splitButton.Name = "splitButton";
            splitButton.Size = new Size(75, 23);
            splitButton.TabIndex = 2;
            splitButton.Text = "Split";
            splitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(258, 107);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // splitRatioTrackBar
            // 
            splitRatioTrackBar.Location = new Point(11, 11);
            splitRatioTrackBar.Margin = new Padding(2);
            splitRatioTrackBar.Maximum = 100;
            splitRatioTrackBar.Name = "splitRatioTrackBar";
            splitRatioTrackBar.Size = new Size(322, 45);
            splitRatioTrackBar.TabIndex = 0;
            splitRatioTrackBar.TickFrequency = 10;
            splitRatioTrackBar.Value = 70;
            splitRatioTrackBar.Scroll += SplitRatioTrackBar_Scroll;
            // 
            // split1Label
            // 
            split1Label.AutoSize = true;
            split1Label.Location = new Point(11, 58);
            split1Label.Margin = new Padding(2, 0, 2, 0);
            split1Label.Name = "split1Label";
            split1Label.Size = new Size(101, 15);
            split1Label.TabIndex = 0;
            split1Label.Text = "Train dataset: 70%";
            // 
            // split2Label
            // 
            split2Label.AutoSize = true;
            split2Label.Location = new Point(205, 58);
            split2Label.Margin = new Padding(2, 0, 2, 0);
            split2Label.Name = "split2Label";
            split2Label.Size = new Size(96, 15);
            split2Label.TabIndex = 0;
            split2Label.Text = "Test dataset: 30%";
            // 
            // randomSeedLabel
            // 
            randomSeedLabel.AutoSize = true;
            randomSeedLabel.Location = new Point(11, 81);
            randomSeedLabel.Name = "randomSeedLabel";
            randomSeedLabel.Size = new Size(79, 15);
            randomSeedLabel.TabIndex = 0;
            randomSeedLabel.Text = "Random seed";
            // 
            // randomSeedNumericUpDown
            // 
            randomSeedNumericUpDown.Location = new Point(96, 79);
            randomSeedNumericUpDown.Name = "randomSeedNumericUpDown";
            randomSeedNumericUpDown.Size = new Size(120, 23);
            randomSeedNumericUpDown.TabIndex = 6;
            // 
            // EditSplitRatioDialog
            // 
            AcceptButton = splitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(344, 141);
            Controls.Add(randomSeedNumericUpDown);
            Controls.Add(randomSeedLabel);
            Controls.Add(split2Label);
            Controls.Add(split1Label);
            Controls.Add(splitRatioTrackBar);
            Controls.Add(cancelButton);
            Controls.Add(splitButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditSplitRatioDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Split Dataset";
            FormClosing += EditSplitRatioDialog_FormClosing;
            ((System.ComponentModel.ISupportInitialize)splitRatioTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)randomSeedNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button splitButton;
        private Button cancelButton;
        private TrackBar splitRatioTrackBar;
        private Label split1Label;
        private Label split2Label;
        private Label randomSeedLabel;
        private NumericUpDown randomSeedNumericUpDown;
    }
}