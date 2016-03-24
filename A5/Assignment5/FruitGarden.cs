//Assignment 5, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class FruitGarden
    {
        //Main method
        static void Main(string[] args)
        {
            //create an instance of the outermost class
            FruitGarden myFruitGarden = new FruitGarden();
            myFruitGarden.MakeFruitBaskets();
            Console.ReadLine();
        }

        //creating 2 FruitBasket objects and calling over FruitBasket methods
        private void MakeFruitBaskets()
        {
            FruitBasket basket1 = new FruitBasket();
            FruitBasket basket2 = new FruitBasket();

            basket1.BasketName = "Weekend";
            basket2.BasketName = "Weekday";

            basket1.MakeFruits();
            basket2.MakeFruits();

            basket1.EatFruits();
            basket2.EatFruits();
        }
    }
}
