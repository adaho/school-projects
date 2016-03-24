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
    public class Flight
    {
        //declare private class variables
        private int flightNumber;
        private string origin;
        private string destination;
        private int passengerCount;
        private bool exitSubMenu = false;

        Passenger[] passengerList = new Passenger[20];

        //passenger array property
        public Passenger[] ListOfPassengers
        {
            get { return passengerList; }
        }

        //get/set property for destination
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        //get/set property for flight number
        public int FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        //get/set property for origin
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        //get/set property for passengerCount
        public int PassengerCount
        {
            get { return passengerCount; }
            set { passengerCount = value; }
        }

        //default constructor
        public Flight()
        {

        }

        //overloaded flight constructor
        public Flight(int flightNumber, string origin, string destination)
        {
            this.flightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
        }

        //method for creating passenger objects and adding them to passengerList array
        public void AddPassenger(string firstName, string lastName, string loyaltyNumber)
        {
            Passenger tempPassenger = new Passenger(firstName, lastName, loyaltyNumber);
            passengerList[passengerCount] = tempPassenger;
            passengerCount++;
        } // End of AddPassenger

        //create a new passenger and calling the AddPassenger method to add it to the array
        private void CreatePassenger()
        {
            Console.Clear();
            Utilities.DisplayHeader();
            string header = "Add Passenger - Flight " + this.FlightNumber;
            Console.WriteLine("{0," + Utilities.WriteCenteredLine(header) + "}\n\n", header);

            Console.Write("Enter Passenger First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Passenger Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Passenger Loyalty Program Number: ");
            string loyaltyNumb = Console.ReadLine();

            AddPassenger(firstName, lastName, loyaltyNumb);

            Console.WriteLine("Passenger Created...");
        } // End of CreatePassenger

        // Displays passenger manifest with a constraint of flagged or not based on the RunSecurityCheck in HomelandSecurity
        public void DisplayPassengerManifest()
        {
            string flag = "";

            Console.Clear();
            Utilities.DisplayHeader();
            string flightMenuTitle = "Manifest for Flight " + this.FlightNumber;
            Console.WriteLine("{0," + Utilities.WriteCenteredLine(flightMenuTitle) + "}\n", flightMenuTitle);

            Console.WriteLine("Number \tFirstName \tLastName \tLoyalty Number \tFlagged \n");

            for (int i = 0; i < this.passengerCount; i++)
            {
                if (passengerList[i].SecurityFlag == true)
                {
                    flag = "!!!";
                }
                else
                {
                    flag = "";
                }
                Console.WriteLine("{0} \t{1,-10} \t{2,-10} \t{3, -10} \t{4}", i + 1, passengerList[i].FirstName, passengerList[i].LastName, passengerList[i].LoyaltyNumber, flag);
            }

        } // End of DisplayPassengerManifest

        // EditFlight allows the user to edit the flight that is currently selected
        public void EditFlight()
        {
            int numberOfErrors = 0;
            bool repeatInput = false;
            int newFlightNum;
            string newOrigin;
            string newDestination;

            Console.Clear();
            Utilities.DisplayHeader();
            string flightMenuTitle = "Edit Flight Information - Flight " + this.FlightNumber;
            Console.WriteLine("{0," + Utilities.WriteCenteredLine(flightMenuTitle) + "}", flightMenuTitle);
            Console.WriteLine("\n\n{0}\t{1}\t\t-->\t{2}\n", this.FlightNumber, this.Origin, this.Destination);

            do
            {
                try
                {
                    Console.Write("\nEnter new Flight Number: ");
                    newFlightNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter new Origin: ");
                    newOrigin = Console.ReadLine();
                    Console.Write("Enter new Destination: ");
                    newDestination = Console.ReadLine();

                    this.FlightNumber = newFlightNum;
                    this.Origin = newOrigin;
                    this.Destination = newDestination;

                    Console.WriteLine("Flight information updated...");
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
  
        } // End of EditFlights

        // FlightSubmenu that is shown once the user picks 'Selects' a flight, it then calls the SubMenuOptions method
        public void FlightSubMenu()
        {
            do
            {
                Console.Clear();
                Utilities.DisplayHeader();
                string flightMenuTitle = "Flight Menu - Flight " + this.FlightNumber;
                Console.WriteLine("{0," + Utilities.WriteCenteredLine(flightMenuTitle) + "}", flightMenuTitle);
                Console.WriteLine("\n\t\t{0}\t{1}\t\t-->\t{2}", this.FlightNumber, this.Origin, this.Destination);

                Console.WriteLine("\n\n1. Display Passenger Manifest");
                Console.WriteLine("2. Edit Flight Information");
                Console.WriteLine("3. Add New Passenger to Manifest");
                Console.WriteLine("4. Run Passenger Security Check");
                Console.WriteLine("5. Exit to FITS");

                SubMenuOptions();
            } while (exitSubMenu == false);
            
        } // End of FlightSubMenu

        // SubMenu calls the different methods based on the option the user selected in FlightSubMenu
        public void SubMenuOptions()
        {
            string subMenuSelection;
            Console.Write("\n\nSelect Option: ");
            subMenuSelection = Console.ReadLine();
            
            switch (subMenuSelection)
            {
                case "1":
                    DisplayPassengerManifest();
                    Utilities.Pause();
                    break;
                case "2":
                    EditFlight();
                    Utilities.Pause();
                    break;
                case "3":
                    CreatePassenger();
                    Utilities.Pause();
                    break;
                case "4":
                    TSACheck();
                    Console.WriteLine("Security Check Complete");
                    Utilities.Pause();
                    break;
                case "5":
                    // Exit option - goes back to Main Menu
                    exitSubMenu = true;
                    break;
            }
        } // End of SubMenuOptions

        // TSACheck method runs the RunSecurityCheck method from HomelandSecurity and flags the SecurityFlag in passenger array
        private void TSACheck()
        {
            TSA newTSA = new TSA();

            FlaggedPassenger[] flaggedArray = newTSA.RunSecurityCheck(passengerList, passengerCount);

            for (int i = 0; i < passengerCount; i++)
            {
                passengerList[i].SecurityFlag = false;
            }
            
            for (int i = 0; i < flaggedArray.Length; i++)
            {
                for (int j = 0; j < this.passengerCount; j++)
                {
                    if ((flaggedArray[i].FirstName == passengerList[i].FirstName) && (flaggedArray[i].LastName == passengerList[i].LastName))
                    {
                        passengerList[i].SecurityFlag = true;
                    }
                }
            }
        } // End of TASCheck

    } // End of Flights class
} 
