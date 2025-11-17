using System;
using System.Collections.Generic;

namespace ConsoleAppArraysAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of strings
            string[] appArray = { "Safari", "Google", "Edge", "YouTube", "WhatsApp", "Facebook", "Gmail" };
            //Ask the user for a number to display the string at the index
            Console.WriteLine("Select a number between 0 and 7    : ");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validstring = false;

            while (!validstring)
            {
                try
                {
                    Console.WriteLine("Your favorite app is " + appArray[stringSelect]);
                    validstring = true;
                }
                //This message is to display if the user pick an index which doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, the selected number is invalid. Please select a number between 0 and 7.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // List of Strings
            List<string> occupationList = new List<string>()
             {
             "Accountant",
             "Doctor",
             "Artist",
             "Lecturer",
             "Software Developer",
             "UX Designer",
             "Podcast Host",
             "QA Tester",
             "Lawyer"
             };

            //Ask the user for a number to display the string at a particular index
            Console.WriteLine("\nSelect another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)

            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }

                // Add a message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. select a number between 0 and 9.");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
                
            }
        }
    }
}
