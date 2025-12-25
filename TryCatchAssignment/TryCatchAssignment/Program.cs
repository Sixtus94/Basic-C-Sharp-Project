using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the program
            Console.WriteLine("Try/Catch ");

            // Call the method to get the user's age and display the birth year
            GetUserAgeAndDisplayBirthYear();
        }

        public static void GetUserAgeAndDisplayBirthYear()
        {
            try
            {
                // Ask the user for their age
                Console.Write("Please enter your age: ");
                string inputAge = Console.ReadLine();

                // Convert the input to an integer
                int age = Convert.ToInt32(inputAge);

                // Check if the age is zero or negative
                if (age <= 0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }

                // Calculate the birth year
                int birthYear = DateTime.Now.Year - age;

                // Display the birth year
                Console.WriteLine($"You were born in {birthYear}.");
            }
            catch (FormatException)
            {
                // Handle the case where the input is not a valid integer
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
            catch (ArgumentException ex)
            {
                // Handle the case where the age is zero or negative
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}