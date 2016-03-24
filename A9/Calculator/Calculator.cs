//Assignment 9, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //declare variables
        string number1 = "";
        string number2 = "";
        string mathOperator = "";

        public Calculator()
        {
            InitializeComponent();
        }

        //load calculator event handler; clears the label
        private void Calculator_Load(object sender, EventArgs e)
        {
            displayLabel.Text = "";
        }

        //the click event handlers for 0 through 9 all do the same thing
        //whichever number you clicked will add the corresponding number to the displayLabel and display it
        private void zeroButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "9";
        }

        //The plus, minus, multiply and divide button click event handlers essentially do the same thing as well.
        //When you click on a math operator, it stores that operator in the string variable mathOperator
        //and will store the number currently shown in displayLabel as number1. Then it resets displayLabel back to having nothing in it again.
        private void plusButton_Click(object sender, EventArgs e)
        {
            mathOperator = "+";
            number1 = displayLabel.Text;
            displayLabel.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            mathOperator = "-";
            number1 = displayLabel.Text;
            displayLabel.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            mathOperator = "*";
            number1 = displayLabel.Text;
            displayLabel.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            mathOperator = "/";
            number1 = displayLabel.Text;
            displayLabel.Text = "";
        }

        //the clear button click event handler clears out the variables and the displayLabel text
        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "";
            number1 = "";
            number2 = "";
            mathOperator = "";
        }

        //When the equal button is clicked, a series of events happen
        //The 2nd number the user entered will be stored in number2. Then both number1 and number2 will be converted to double.
        //Using a switch statement, we can solve for the answer the user seeks and display it in the window after converting it to a string.
        private void equalButton_Click(object sender, EventArgs e)
        {
            number2 = displayLabel.Text;
            double firstNum = Convert.ToDouble(number1);
            double secondNum = Convert.ToDouble(number2);
            double numResult = 0;

            switch (mathOperator)
            {
                case "+":
                    numResult = firstNum + secondNum;
                    break;
                case "-":
                    numResult = firstNum - secondNum;
                    break;
                case "*":
                    numResult = firstNum * secondNum;
                    break;
                case "/":
                    numResult = firstNum / secondNum;
                    break;
            }

            displayLabel.Text = Convert.ToString(numResult);
        }

        //the decimal button click event handler simply adds a decimal to the displayLabel text
        private void decimalButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += ".";
        }
    }
}
