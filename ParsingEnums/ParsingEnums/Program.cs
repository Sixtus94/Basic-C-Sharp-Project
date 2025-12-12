using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Prompt the user to enter the current day of the week
            Console.Write("Enter the current day of the week: ");
            string input = Console.ReadLine();

            try
            {
                // Parse the user's input into a DayOfWeek enum value
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, true);

                // If the parse is successful, print a success message
                Console.WriteLine($"You entered: {day}");
            }
            catch (ArgumentException)
            {
                // If the parse fails, print an error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open until the user presses a key
            Console.ReadKey();
        }
    }
}
