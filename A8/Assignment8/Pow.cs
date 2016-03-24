//Assignment 8, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Assignment8
{
    public partial class Pow : Form
    {
        //declaring class variables
        private Random r;
        private int targetSpeed;
        private int totalScore;
        private int secondsLeft;
        private SoundPlayer soundPlayer;

        public Pow()
        {
            InitializeComponent();
        }

        // start the game and reset all the properties to an initial state; starts timers
        private void startButton_Click(object sender, EventArgs e)
        {
            r = new Random();
            targetSpeed = r.Next(4, 15);
            targetTimer.Interval = 20;
            gameTimer.Interval = 1000;
            bulletTimer.Interval = 10;
            powTimer.Interval = 5;
            targetPictureBox.Left = 0;
            bulletPictureBox.Top = 250;
            totalScore = 0;
            powPrefixLabel.Text = Convert.ToString(totalScore);
            statusLabel.Visible = true;
            targetPictureBox.Visible = true;
            bulletPictureBox.Visible = true;
            powSuffixLabel.Visible = true;
            powPrefixLabel.Visible = true;
            fireButton.Visible = true;
            fireButton.Enabled = true;
            secondsLeft = 60;
            statusLabel.Text = Convert.ToString(secondsLeft);
            targetTimer.Start();
            gameTimer.Start();
        }

        //moves the target bullet to the right; selects a new random speed when bullet appears on the left
        private void targetTimer_Tick(object sender, EventArgs e)
        {
            targetPictureBox.Left += targetSpeed;

            if (targetPictureBox.Left >= this.Width)
            {
                targetPictureBox.Location = new Point(0, 34);
                targetSpeed = r.Next(4, 15); 
            }
        }

        //updates the game timer by changing the label text and updating the secondsLeft variable
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;

            if (secondsLeft > 0)
            {
                statusLabel.Text = Convert.ToString(secondsLeft);
            }
            else
            {
                gameTimer.Stop();
                bulletTimer.Stop();
                targetTimer.Stop();
                fireButton.Enabled = false;
                statusLabel.Text = "Game over";
            }
        }

        //fires bullet when the bullet timer starts
        private void fireButton_Click(object sender, EventArgs e)
        {
            bulletPictureBox.Visible = true;
            bulletTimer.Start();
        }

        //moves the bullet; calls Collided method to test for collision; if there is, show animation
        private void bulletTimer_Tick(object sender, EventArgs e)
        {
            bulletPictureBox.Top -= 7;

            if (Collided() == true)
            {
                totalScore++;
                powPrefixLabel.Text = Convert.ToString(totalScore);
                bulletTimer.Stop();
                targetTimer.Stop();
                targetPictureBox.ImageLocation = "pow.png"; 
                targetPictureBox.Height = 0;
                targetPictureBox.Width = 0;
                bulletPictureBox.Visible = false;
                powTimer.Start();
            }

            if (bulletPictureBox.Top <= 0)
            {
                bulletTimer.Stop();
                bulletPictureBox.Visible = true;
                bulletPictureBox.Top = 250;
            }
        }

        // tests if the target bullet and the fired bullet have collided; returns true if there is overlap, returns false if not
        private bool Collided()
        {
            if((bulletPictureBox.Left >= targetPictureBox.Left && bulletPictureBox.Left <= targetPictureBox.Right)
                && (bulletPictureBox.Top <= targetPictureBox.Bottom && bulletPictureBox.Top >= targetPictureBox.Top))
            {
                return true;
            }

            if((bulletPictureBox.Right >= targetPictureBox.Left && bulletPictureBox.Right <= targetPictureBox.Right)
                && (bulletPictureBox.Top < targetPictureBox.Bottom && bulletPictureBox.Top >= targetPictureBox.Top))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //adds a Pow! animation once the bullet and target have collided
        private void powTimer_Tick(object sender, EventArgs e)
        {
            targetPictureBox.Height++;
            targetPictureBox.Width++;

            if (targetPictureBox.Width == 25)
            {
                powTimer.Stop();
                bulletPictureBox.Top = 250;
                bulletPictureBox.Visible = true;
                targetPictureBox.Height = 40;
                targetPictureBox.Width = 40;
                targetPictureBox.Location = new Point(0, 34); 
                targetPictureBox.ImageLocation = "ship.png"; 
                targetSpeed = r.Next(4, 15); 
                targetTimer.Start();
            }
        }
        
        //form load event handler; plays audio file when the app starts and continues looping
        private void Pow_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("s2.wav");
            soundPlayer.Load();
            soundPlayer.PlayLooping();
        }
    }
}
