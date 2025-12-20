using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Define the namespace the input console application
namespace InputAssignment
{    
    //Define the program class
    class Program
    {   
        // Define the main entry point for the console input application
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Please enter a number: ");

            // Read the user's input and store it in a string variable
            string userInput = Console.ReadLine();

            // Log the number to a text file
            LogNumberToFile(userInput, @"C:\Users\sixte\logs\log.txt");

            // Print the text file back to the user
            PrintFileContents();
        }
        // Method to log the number to a text file
        static void LogNumberToFile(string number, string filePath)
        {
            try
            {
               
                // Use StreamWriter to write to the file, overwriting any existing content
                using (StreamWriter writer = new StreamWriter("number.txt"))
                {
                    // Write the number to the file
                    writer.WriteLine(number);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during file writing
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }
        }
            // Method to print the text file contents
            static void PrintFileContents()
            {
                try
                {
                    // Specify the file path and name
                    string filePath = "number.txt";

                    // Check if the file exists
                    if (File.Exists(filePath))
                    {
                        // Read all lines from the file
                        string[] lines = File.ReadAllLines(filePath);

                        // Print each line to the console
                        foreach (string line in lines)
                        {
                            Console.WriteLine("You entered: " + line);
                        }
                    }
                    else
                    {
                        // Handle the case where the file does not exist
                        Console.WriteLine("The file does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during file reading
                    Console.WriteLine("An error occurred while reading the file: " + ex.Message);
                }
            }
        
    }
}
