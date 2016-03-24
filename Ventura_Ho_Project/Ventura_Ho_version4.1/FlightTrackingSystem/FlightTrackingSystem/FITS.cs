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
    class FITS
    {
        //declaring class variables
        private Flight[] flightsAvailable = new Flight[20];
        private int flightCount;
        private bool temp = false;
        private int optionNumber;

        //main method
        static void Main(string[] args)
        {
            FITS myTrackingSystem = new FITS();
            myTrackingSystem.LoadTempData(); // load flight data when program starts

            do //run system while temp remains false, or as long as user doesn't enter in 5
            {
                Console.Clear();
                Utilities.DisplayHeader();
                myTrackingSystem.DisplayMenu();
                myTrackingSystem.MenuOptions();
            } while(myTrackingSystem.temp == false);
        } // End of Main Method

        //creating Flight objects and putting them into flightsAvailable array
        private void AddFlight(int flightnumber, string origin, string destination)
        {
            Flight tempFlight = new Flight(flightnumber, origin, destination);
            flightsAvailable[flightCount] = tempFlight;
            flightCount++;
        } // End of AddFlight

        //create a new flight and calling the AddFlight method to add it to the array
        private void CreateFlight()
        {
            int numberOfErrors = 0;
            bool repeatInput = false;
            int flightNum;
            string orig;
            string dest;

            Console.Clear();
            Utilities.DisplayHeader();
            string header = "Add New Flight";
            Console.WriteLine("{0," + Utilities.WriteCenteredLine(header) + "}\n\n", header);

            do
            {
                try
                {
                    Console.Write("Enter flight number: ");
                    flightNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Origin: ");
                    orig = Console.ReadLine();
                    Console.Write("Enter Destination: ");
                    dest = Console.ReadLine();

                    AddFlight(flightNum, orig, dest);
                    repeatInput = false;
                }
                catch (Exception)
                {
                    if (numberOfErrors == 2)
                    {
                        Utilities.ExceptionHandling();
                    }
                    else if (numberOfErrors < 2)
                    {
                        Console.WriteLine("\nInvalid number. Try again.\n");
                        repeatInput = true;
                        numberOfErrors++;
                    }  
                }

            } while (repeatInput == true);
            
        } // End of CreateFlight

        //clear window and display header and current flights in array
        public void DisplayFlights()
        {
            Console.Clear();
            Utilities.DisplayHeader();
            string header = "Current Flights";
            Console.WriteLine("{0," + Utilities.WriteCenteredLine(header) + "}\n\n", header);

            for (int i = 0; i < flightCount; i++)
            {
                Console.WriteLine("\t{0}. {1,-10}{2,-15} -->\t{3}\n", i + 1, flightsAvailable[i].FlightNumber, flightsAvailable[i].Origin, flightsAvailable[i].Destination);
            }
        } // End of DisplayFlights

        //Main Menu
        private void DisplayMenu()
        {
            Console.WriteLine("\n\n1. Display Flight List");
            Console.WriteLine("2. Add New Flight");
            Console.WriteLine("3. Select Flight");
            Console.WriteLine("4. Search by Passenger");
            Console.WriteLine("5. Exit");
        } // End of DisplayMenu

        //Method allows users to search for passenger and it will display the flights each passenger has
        public void FindPassenger()
        {
            string header = "Find Passenger";
            string passengerFN;
            string passengerLN;
            int passengerCount = 0;

            Console.Clear();
            Utilities.DisplayHeader();
            Console.WriteLine("{0," + Utilities.WriteCenteredLine(header) + "}\n\n", header);
            Console.Write("Enter Passenger First Name: ");
            passengerFN = Console.ReadLine();
            Console.Write("Enter Passenger Last Name: ");
            passengerLN = Console.ReadLine();
            Console.WriteLine("\n");
                
            for (int i = 0; i < flightCount; i++)
            {
                for (int j = 0; j < flightsAvailable[i].PassengerCount; j++)
                {
                    try
                    {
                        if (passengerFN == flightsAvailable[i].ListOfPassengers[j].FirstName && passengerLN == flightsAvailable[i].ListOfPassengers[j].LastName)
                        {
                            Console.WriteLine("Flight {0}\t{1}\t\t{2}\t\t{3}", flightsAvailable[i].FlightNumber, flightsAvailable[i].ListOfPassengers[j].FirstName, flightsAvailable[i].ListOfPassengers[j].LastName, flightsAvailable[i].ListOfPassengers[j].LoyaltyNumber);
                                passengerCount++;
                        }
                    }
                    catch (NullReferenceException)
                    {
                    }
                }
            }

            if (passengerCount == 0)
            {
                Console.WriteLine("404 Passenger Not Found.");
            }
        } // End of FindPassenger

        // loads information for 3 flights into your array of flights
        private void LoadTempData()
        {
            AddFlight(210, "Denver", "Juneau");
            AddFlight(738, "Paris", "Florence");
            AddFlight(404, "Oakland", "North Pole");

            flightsAvailable[0].AddPassenger("Rachel", "Green", "43581");
            flightsAvailable[0].AddPassenger("Phoebe", "Bouffe", "45644");
            flightsAvailable[0].AddPassenger("Joey", "Tribiani", "94335");
            flightsAvailable[0].AddPassenger("Chandler", "Bing", "12345");
            flightsAvailable[0].AddPassenger("Kurt", "Knapp", "74200");

            flightsAvailable[1].AddPassenger("Ross", "Gueller", "5787");
            flightsAvailable[1].AddPassenger("Monica", "Gueller", "9999");
            flightsAvailable[1].AddPassenger("Hau", "Mulan", "1998");
            flightsAvailable[1].AddPassenger("Lilo", "Stitch", "2004");
            flightsAvailable[1].AddPassenger("John", "Cena", "10101");

            flightsAvailable[2].AddPassenger("Taylor", "Swift", "48593");
            flightsAvailable[2].AddPassenger("Albus", "Dumbledore", "77777");
            flightsAvailable[2].AddPassenger("Leonardo", "DiCaprio", "111174");
            flightsAvailable[2].AddPassenger("Harry", "But", "34584");
            flightsAvailable[2].AddPassenger("John", "Cena", "10101");

        } // End of LoadTempData

        private void MenuOptions()
        {
            string menuSelection;
            Console.Write("\n\nSelect Menu Option: ");
            menuSelection = Console.ReadLine();
            
            //switch statement for user Main Menu selection
            switch(menuSelection)
            {
                case "1":
                    DisplayFlights();
                    Utilities.Pause();
                    break;
                case "2":
                    CreateFlight();
                    break;
                case "3":
                    DisplayFlights();
                    SelectFlightOptions();
                    break;
                case "4":
                    FindPassenger();
                    Utilities.Pause();
                    break;
                case "5":
                    temp = true;
                    break;
            }
        } // End of MenuOptions

        // SelectFlightOptions verifies that the users actually selected a valid flight number
        private void SelectFlightOptions()
        {
            int numberOfErrors = 0;
            bool repeatInput = false;

            do
            {
                try
                {
                    Console.Write("\nEnter Option Number: ");
                    optionNumber = Convert.ToInt32(Console.ReadLine());

                    if (flightsAvailable[optionNumber - 1] == null)
                    {
                        Console.WriteLine("\nInvalid Choice.");
                        Utilities.Pause();
                        return;
                    }

                    flightsAvailable[optionNumber - 1].FlightSubMenu();
                    repeatInput = false;
                }
                catch (FormatException)
                {
                    if (numberOfErrors == 2)
                    {
                        Utilities.ExceptionHandling();
                    }
                    else if (numberOfErrors < 2)
                    {
                        Console.WriteLine("\nInvalid number. Try again.\n");
                        repeatInput = true;
                        numberOfErrors++;
                    }  
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\nInvalid choice.");
                    Utilities.Pause();
                }
            } while (repeatInput == true);
            
        } // End of SelectFlightOptions

    } // End of FITS class
}
