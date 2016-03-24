namespace AverageCalculator
{
    partial class AverageCalculator
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
            this.numberofScoresLabel = new System.Windows.Forms.Label();
            this.numberofScoresTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberofScoresLabel
            // 
            this.numberofScoresLabel.AutoSize = true;
            this.numberofScoresLabel.Location = new System.Drawing.Point(12, 26);
            this.numberofScoresLabel.Name = "numberofScoresLabel";
            this.numberofScoresLabel.Size = new System.Drawing.Size(35, 13);
            this.numberofScoresLabel.TabIndex = 0;
            this.numberofScoresLabel.Text = "label1";
            // 
            // numberofScoresTextBox
            // 
            this.numberofScoresTextBox.Location = new System.Drawing.Point(233, 23);
            this.numberofScoresTextBox.Name = "numberofScoresTextBox";
            this.numberofScoresTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberofScoresTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(233, 65);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(340, 65);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // scoresLabel
            // 
            this.scoresLabel.AutoSize = true;
            this.scoresLabel.Location = new System.Drawing.Point(12, 99);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(35, 13);
            this.scoresLabel.TabIndex = 4;
            this.scoresLabel.Text = "label2";
            // 
            // AverageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 111);
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.numberofScoresTextBox);
            this.Controls.Add(this.numberofScoresLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AverageCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Calculator";
            this.Load += new System.EventHandler(this.AverageCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberofScoresLabel;
        private System.Windows.Forms.TextBox numberofScoresTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label scoresLabel;
    }
}

