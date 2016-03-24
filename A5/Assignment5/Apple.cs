//Assignment 5, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Apple : Fruit
    {
        //declare private variable
        private double radius;

        //create Radius property
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //create Apple default constructor
        public Apple(double radius)
        {
            this.radius = radius;
        }
    }
}
