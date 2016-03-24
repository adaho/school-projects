//Assignment 7, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageCalculator
{
    public partial class AverageCalculator : Form
    {
        //declare private class variables
        private TextBox[] scoreTextBoxArray;

        public AverageCalculator()
        {
            InitializeComponent();
        }

        //load event handler for avg calculator form
        private void AverageCalculator_Load(object sender, EventArgs e)
        {
            calculateButton.Visible = false;
            numberofScoresLabel.Text = "How many scores would you like to enter?";
            scoresLabel.Text = "";
        }

        //click event handler for the OK button
        private void okButton_Click(object sender, EventArgs e)
        {
            int numberOfTextBoxes;
            numberOfTextBoxes = Convert.ToInt32(numberofScoresTextBox.Text);
            this.Height = 500;
            calculateButton.Visible = true;
            okButton.Enabled = false;
            CreateTextBoxes(numberOfTextBoxes);
        }

        //instantiating textbox array, assigning user input into array, and formatting spacing around each textbox
        private void CreateTextBoxes(int number)
        {
            scoreTextBoxArray = new TextBox[number];
            int verticalTopPosition = 150;

            for (int i = 0; i < scoreTextBoxArray.Length; i++)
            {
                scoreTextBoxArray[i] = new TextBox();
                scoreTextBoxArray[i].Left = 20;
                scoreTextBoxArray[i].Top = verticalTopPosition;
                verticalTopPosition += 50;
                this.Controls.Add(scoreTextBoxArray[i]);
            }
        }

        //Calculate button click event handler
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double total = 0.0;
            double average = 0.0;

            for (int i = 0; i < scoreTextBoxArray.Length; i++)
            {
                total += Convert.ToInt32(scoreTextBoxArray[i].Text);
            }

            average = total / scoreTextBoxArray.Length;
            scoresLabel.Text = "The average of the following scores is " + average;
        }
    }
}
