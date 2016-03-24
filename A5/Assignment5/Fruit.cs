//Assignment 5, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Fruit
    {
        //declaring protected class variables
        protected double fruitPercentLeft;
        protected int peelThickness;

        //creating PercentLeft property
        public double PercentLeft
        {
            get { return fruitPercentLeft; }
        }

        //creating PeelThickness property
        public int PeelThickness
        {
            get { return peelThickness; }
            set { peelThickness = value; }
        }

        //creating Fruit default constructor
        public Fruit()
        {
            fruitPercentLeft = 100.0;
        }

        //creating Eat method
        public void Eat(double eatenAmount)
        {
            fruitPercentLeft -= eatenAmount;
        }
    }
  
}
