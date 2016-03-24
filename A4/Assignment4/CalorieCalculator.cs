//Assignment 4, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class CalorieCalculator
    {
        //declare constant class variables
        const double CALORIE_COEFFICIENT = 0.167;
        const double POUNDKG_COEFFICIENT = 0.453592;

        static void Main(string[] args)
        {
            //declare local variables
            double weight;
            int minutes;
            int seconds;
            double totalTime;
            double kilos;
            string title = "Running Calorie Calculator";

            Console.WriteLine("{0," + CalorieCalculator.WriteCenteredLine(title) + "}\n\n", title);
            Console.WriteLine("This application can calculate calories based on running mileage.\n");

            //getting the user's weight, and minutes and seconds run
            weight = CalorieCalculator.ReadInteger("Enter your weight (lbs): ");
            minutes = CalorieCalculator.ReadInteger("Enter minutes run: ");
            seconds = CalorieCalculator.ReadInteger("Enter seconds run: ");

            totalTime = minutes + (seconds / 60);
            kilos = CalorieCalculator.PoundsToKilos(weight);

            Console.WriteLine("\nIf you run {0} minutes and {1} seconds at 6mph,\nthe calories burned are approximately {2:f2}", minutes, seconds, CalorieCalculator.CaloriesSpentRunning(kilos,totalTime));
            Console.ReadLine();
        }

        //converting user entered pounds value to kilograms
        static double PoundsToKilos(double poundsValue)
        {
            double kilosValue = poundsValue * POUNDKG_COEFFICIENT;
            return kilosValue;
        }

        //calculating how many calories user spent while running
        static double CaloriesSpentRunning(double weightInKilos, double minutes)
        {
            double calories = weightInKilos * minutes * CALORIE_COEFFICIENT;
            return calories;
        }

        //exception handling for when prompting user to enter an integer
        public static int ReadInteger(string displayString)
        {
            int numberOfErrors = 0;
            int number = 0;
            bool repeatInput = false;

            do
            {
                try
                {
                    Console.Write(displayString);
                    number = Convert.ToInt32(Console.ReadLine());

                    repeatInput = false;
                }
                catch (FormatException)
                {
                    if (numberOfErrors == 2)
                    {
                        Console.WriteLine("\nYou seem to be having issues. The application will now exit.");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    else if (numberOfErrors < 2)
                    {
                        Console.WriteLine("\nInput must be numeric. Try again.\n");
                        repeatInput = true;
                        numberOfErrors++;
                    }
                }
                catch (OverflowException)
                {
                    if (numberOfErrors == 2)
                    {
                        Console.WriteLine("\nYou seem to be having issues. The application will now exit.");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    else if (numberOfErrors < 2)
                    {
                        Console.WriteLine("\nInput number is waaay too big. Try again.\n");
                        repeatInput = true;
                        numberOfErrors++;
                    }
                }
            } while (repeatInput == true);

            return number;
        }//end of ReadInteger method

        //method for centering the first line/title 
        private static int WriteCenteredLine(string text)
        {
            int x;
            x = (Console.WindowWidth + text.Length) / 2;
            return x;
        }
    }
}
