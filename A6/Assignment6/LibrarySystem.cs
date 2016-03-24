//Assignment 6, Ada Ho, CIS345 3:00pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class LibrarySystem
    {
        //declaring private class variables
        private Book[] newLibrary;
        private string bookTitle;
        private int bookYear;
        private int bookCount;

        static void Main(string[] args)
        {
            LibrarySystem myLibrary = new LibrarySystem();
            myLibrary.LoadLibrarySystem();
            Console.ReadLine();
        }

        //default constructor
        public LibrarySystem()
        {
            
        }

        public void DisplayHeader()
        {
            Console.Clear();
            string title = "New Library System";
            Console.WriteLine("{0," + WriteCenteredLine(title) + "}\n\n", title);
        }

        //method for centering the Header
        private static int WriteCenteredLine(string text)
        {
            int x;
            x = (Console.WindowWidth + text.Length) / 2;
            return x;
        }

        //getting info from user and using that info to add a book to the newLibrary array
        public void AddBook()
        {
            Console.Write("\nEnter Book title: ");
            bookTitle = Console.ReadLine();
            Console.Write("Enter Book year: ");
            bookYear = Convert.ToInt32(Console.ReadLine());

            Book newBook = new Book(bookTitle, bookYear);
            newLibrary[bookCount] = newBook;
            bookCount++;
        }

        //going through the newLibrary array using a loop and displaying each new book's title and year
        public void DisplayBookList()
        {
            Console.WriteLine("{0,-50}{1}", "Title", "Year\n");

            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine("{0,-50}{1}", newLibrary[i].title, newLibrary[i].year);
            }
        }

        //new library transactions
        public void LoadLibrarySystem()
        {
            Console.Write("How many new books do you want to add to the Library? ");
            int bookSize = Convert.ToInt32(Console.ReadLine());
            newLibrary = new Book[bookSize];

            for (int i = 0; i < bookSize; i++)
            {
                AddBook();
            }
            
            Console.WriteLine("\n\nAdding books complete. Press enter to continue.");
            Console.ReadLine();

            DisplayHeader();
            DisplayBookList();
        }
   
    }
}
