//Assignment 5, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class FruitBasket
    {
        //declare private class variables
        private Apple apple;
        private Banana banana;
        private string basketName;

        //create BasketName property
        public string BasketName
        {
            get { return basketName; }
            set { basketName = value; }
        }

        //create MakeFruits method; creating instances of apple and banana
        public void MakeFruits()
        {
            apple = new Apple(1.5);
            banana = new Banana(3.5);

            apple.PeelThickness = 1;
            banana.PeelThickness = 4;
        }

        //ask user %-wise how much apple and banana they want eaten; print how much fruit is left
        public void EatFruits()
        {
            double amountToEat;

            Console.WriteLine("\t\t\t***{0}***", basketName.ToUpper());

            Console.WriteLine("\nYou have an apple and a banana in your {0} basket.", basketName);
            Console.Write("\nWhat percent of the apple would you like to eat? ");
            amountToEat = Convert.ToDouble(Console.ReadLine());
            apple.Eat(amountToEat);

            Console.Write("What percent of the banana would you like to eat? ");
            amountToEat = Convert.ToDouble(Console.ReadLine());
            banana.Eat(amountToEat);
            Console.WriteLine("\nYou have {0}% of your apple and {1}% of your banana left in your {2} basket.\n", apple.PercentLeft, banana.PercentLeft, basketName);
        }
    }
}
