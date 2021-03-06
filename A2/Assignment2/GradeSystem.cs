﻿//Assignment2, Ada Ho, CIS345 3:00PM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class GradeSystem
    {
        static void Main(string[] args)
        {
            int[] scoreArray;
            string[] nameArray;
            string userInput;
            int studentPosition;
            string title = "Welcome to the Student Grade System!";


            scoreArray = new int[5];
            nameArray = new string[5];

            Console.WriteLine("{0," + GradeSystem.WriteCenteredLine(title) + "}\n", title);

            GradeSystem.PopulateNameArray(nameArray);
            GradeSystem.PopulateScoreArray(scoreArray, nameArray);
            Console.Clear();

            Console.Write("Please enter a name to look up his/her score: ");
            userInput = Console.ReadLine();

            studentPosition = GradeSystem.FindStudentPosition(userInput, nameArray);
            if (studentPosition == -1)
            {
                Console.WriteLine("\nSorry. Student by that name does not exist in the database.");
            }
            else
            {
                Console.WriteLine("\n{0}'s score is {1}.", nameArray[studentPosition], scoreArray[studentPosition]);
            }

            Console.ReadLine();
        }

        private static void PopulateNameArray(string[] names)
        {
            Console.WriteLine("Enter Student Names");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Student {0}: ", i + 1);
                names[i] = Console.ReadLine();
            }
            Console.WriteLine();
        }

        private static void PopulateScoreArray(int[] scores, string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter {0}'s score: ", names[i]);
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static int FindStudentPosition(string name, string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                if(name == stringArray[i])
                {
                    return i;
                }      
            }
            return -1;
        }

        private static int WriteCenteredLine(string text)
        {
            int x;
            x = (Console.WindowWidth + text.Length) / 2;
            return x;
        }
    }
}
