//Assignment 5, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Banana : Fruit
    {
        //declare private variable
        private double length;

        //create Length property
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        //create Banana default contructor
        public Banana(double length)
        {
            this.length = length;
        }
    }
}
