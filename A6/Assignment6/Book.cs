//Assignment 6, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Book
    {
        //declaring class variables
        public string title;
        public int year;

        //Title property
        private string Title
        {
            get { return title; }
            set { title = value; }
        }

        //Year property
        private int Year
        {
            get { return year; }
            set { year = value; }
        }

        //Book constructor
        public Book()
        {
            Console.WriteLine("A new book has been added to the library.");
        }

        //overloaded Book constructor
        public Book(string Title, int Year)
        {
            this.title = Title;

            if (Year < 2015 && Year > 1100)
            {
                this.year = Year;
            }
            else
            {
                year = 1900;
            }

            Console.WriteLine("Title '{0}' added to the library.", this.title);
        }
    }
}
