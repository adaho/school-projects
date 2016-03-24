namespace Assignment8
{
    partial class Pow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pow));
            this.targetPictureBox = new System.Windows.Forms.PictureBox();
            this.bulletPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.fireButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.powPrefixLabel = new System.Windows.Forms.Label();
            this.powSuffixLabel = new System.Windows.Forms.Label();
            this.targetTimer = new System.Windows.Forms.Timer(this.components);
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.powTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // targetPictureBox
            // 
            this.targetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.targetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("targetPictureBox.Image")));
            this.targetPictureBox.Location = new System.Drawing.Point(24, 34);
            this.targetPictureBox.Name = "targetPictureBox";
            this.targetPictureBox.Size = new System.Drawing.Size(40, 40);
            this.targetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPictureBox.TabIndex = 0;
            this.targetPictureBox.TabStop = false;
            // 
            // bulletPictureBox
            // 
            this.bulletPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bulletPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bulletPictureBox.Image")));
            this.bulletPictureBox.Location = new System.Drawing.Point(416, 250);
            this.bulletPictureBox.Name = "bulletPictureBox";
            this.bulletPictureBox.Size = new System.Drawing.Size(40, 40);
            this.bulletPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletPictureBox.TabIndex = 1;
            this.bulletPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(24, 359);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // fireButton
            // 
            this.fireButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fireButton.BackgroundImage")));
            this.fireButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fireButton.Location = new System.Drawing.Point(407, 296);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(64, 66);
            this.fireButton.TabIndex = 3;
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Aqua;
            this.statusLabel.Location = new System.Drawing.Point(391, 365);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(112, 37);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "label1";
            // 
            // powPrefixLabel
            // 
            this.powPrefixLabel.AutoSize = true;
            this.powPrefixLabel.BackColor = System.Drawing.Color.Transparent;
            this.powPrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powPrefixLabel.ForeColor = System.Drawing.Color.Gold;
            this.powPrefixLabel.Location = new System.Drawing.Point(487, 286);
            this.powPrefixLabel.Name = "powPrefixLabel";
            this.powPrefixLabel.Size = new System.Drawing.Size(16, 16);
            this.powPrefixLabel.TabIndex = 5;
            this.powPrefixLabel.Text = "0";
            // 
            // powSuffixLabel
            // 
            this.powSuffixLabel.AutoSize = true;
            this.powSuffixLabel.BackColor = System.Drawing.Color.Transparent;
            this.powSuffixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powSuffixLabel.ForeColor = System.Drawing.Color.Gold;
            this.powSuffixLabel.Location = new System.Drawing.Point(509, 286);
            this.powSuffixLabel.Name = "powSuffixLabel";
            this.powSuffixLabel.Size = new System.Drawing.Size(49, 16);
            this.powSuffixLabel.TabIndex = 6;
            this.powSuffixLabel.Text = "Pows!";
            // 
            // targetTimer
            // 
            this.targetTimer.Tick += new System.EventHandler(this.targetTimer_Tick);
            // 
            // bulletTimer
            // 
            this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // powTimer
            // 
            this.powTimer.Tick += new System.EventHandler(this.powTimer_Tick);
            // 
            // Pow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 405);
            this.Controls.Add(this.powSuffixLabel);
            this.Controls.Add(this.powPrefixLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bulletPictureBox);
            this.Controls.Add(this.targetPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pow!";
            this.Load += new System.EventHandler(this.Pow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox targetPictureBox;
        private System.Windows.Forms.PictureBox bulletPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label powPrefixLabel;
        private System.Windows.Forms.Label powSuffixLabel;
        private System.Windows.Forms.Timer targetTimer;
        private System.Windows.Forms.Timer bulletTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer powTimer;
    }
}

