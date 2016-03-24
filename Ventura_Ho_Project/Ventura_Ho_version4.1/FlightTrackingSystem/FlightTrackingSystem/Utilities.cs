//Jocelyn Ventura, Ada Ho
//Project 11-29-15, CIS340 3:00PM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomelandSecurity;

namespace FlightTrackingSystem
{
    class Utilities
    {
        //centered header
        public static void DisplayHeader()
        {
            string title = "Phoenix Air Flight Inventory and Tracking System";
            string title2 = "-- FITS --";
            Console.WriteLine("{0," + WriteCenteredLine(title) + "}", title);
            Console.WriteLine("{0," + WriteCenteredLine(title2) + "}\n", title2);
        }

        //method for when user keeps entering in invalid input
        public static void ExceptionHandling()
        {
            Console.WriteLine("\nGo home. You're drunk. The application will now exit.");
            Console.Write("\nPress Enter to continue...");
            Console.ReadKey();
            System.Environment.Exit(0);
        }

        //Method to pause the method once it is called and runned 
        public static void Pause()
        {
            Console.Write("\nPress Enter to continue...");
            Console.ReadLine();
        }

        //method for centering the Header
        public static int WriteCenteredLine(string text)
        {
            int x;
            x = (Console.WindowWidth + text.Length) / 2;
            return x;
        }
 
    }
}
