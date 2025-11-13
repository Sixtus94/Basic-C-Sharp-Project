using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            int x = 5; // variable to be used in boolean comparisons
            int y = 10; // variable to be used in boolean comparisons
            bool isValid = true; // flag to control the loop

            // While loop with boolean comparison
            Console.WriteLine("While Loop:");
            while (x < y) // loop will continue as long as x is less than y
            {
                Console.WriteLine($"x ({x}) is less than y ({y})"); // print the current values of x and y
                x++; // increment x by 1
            }

               // Do-While loop with boolean comparison
               Console.WriteLine("\nDo-While Loop:");
            do
            {
                Console.WriteLine($"x ({x}) is greater than or equal to y ({y})"); // print the current values of x and y
                y++; // increment y by 1
            } while (x > y); // loop will continue as long as x is greater than y

            // Do-While loop with flag variable
                Console.WriteLine("\nDo-While Loop with Flag:");
                isValid = true; // reset the flag
            do
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                int input = Convert.ToInt32(Console.ReadLine()); // get user input
                if (input >= 1 && input <= 10) // check if input is within the valid range
                {
                    Console.WriteLine("Valid input!");
                    isValid = false; // set the flag to false to exit the loop
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (isValid); // loop will continue as long as isValid is true
              

        }
    }
}
