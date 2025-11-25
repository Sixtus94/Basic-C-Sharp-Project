using System;
using System.Collections.Generic;
using System.Text;


namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iterations Integer
            int[] testScores = { 68, 59, 90, 89, 70, 49, 85, 75, 94, 69 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 59)
                {
                    Console.WriteLine("passing test score: " + testScores[i]);
                }
            }
            Console.ReadLine();

            // Iterations Strings list
            string[] names = { "Mike", "Charity", "Collins", "Victory", "Monica", "Lopez" };
            for (int n = 0; n < names.Length; n++)
            {
                if (names[n] == "Victory")
                {
                    Console.WriteLine(names[n]);
                }
            }

            // Concatenate Three strings:
            string TextOne = "Please, thoroughly ";
            string TextTwo = "Comment ";
            string textThree = "your code.";

            //Concatenating the three strings:
            Console.WriteLine(TextOne + TextTwo + textThree);

            //A string to be Converted to Uppercase:
            string x = "make hey while the sunshine!";

            //converting the string to uppercase:
            Console.WriteLine(x.ToUpper());


            //Console App Assignment Part 1
            // 1. One-dimensional array of strings
            string[] messages = { "Hello!\t", "Welcome\t", "Goodbye\t" };

            // 2. This will ask the user to input some text
            Console.Write("Enter a name to append: ");
            string userInput = Console.ReadLine();

            // 3. First loop: append user text to each array element
            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] = messages[i] + userInput;
            }

            // 4. Second loop: print each updated string
            Console.WriteLine("\nUpdated strings:");
            foreach (string text in messages)
            {
                Console.WriteLine(text);
            }
            Console.ReadLine(); // pause the console

            //Console App Assignment Part 2
            int y = 0; // Initialize 
            do
            {
                Console.WriteLine(y); //An infinite While-Loop (Increment for the loop)
                y++; // This Fix the infinite loop
            }
            while (y < 5); //continue iterating as long as y is less 5
            {
                Console.WriteLine("Iteration " + y); //Print the current iteration
            }
            // Loop with "<=" operator
            Console.WriteLine("Loop with <= operator:");

            while (true)
            {
                Console.WriteLine("Iteration " + y);
                y++;
                if (y > 10) // Changed to > to make the loop run from 0 to 10
                {
                    break;
                }
            }

            // Console App Assignment Part3
            // Loop with "<" operator: This is to determine whether to continue iterating the loop}
            Console.WriteLine("\nLoop with < operator:");
            for (y = 0; y < 3; y++)
            {
                Console.WriteLine("Iteration " + y);
            }
            for (y = 0; y <= 4; y++)
            {
                Console.WriteLine("Iteration " + y);
            }

            //Console App Assignment Part4
            // List of unique strings
            List<string> uniqueStrings = new List<string> { "Apple", "Banana", "Tomatoes", "Orange", "Mango" };

            // Display the list
            Console.WriteLine("\nList of unique strings:");
            foreach (var list in uniqueStrings)
            {
                Console.WriteLine(list);
            }

            // Ask the user to input text to search for
            Console.Write("\nInput text to search for list: ");
            string inputText = Console.ReadLine();

            // This Loop iterates through the list to find a matching on the screen
            bool found = false;
            for (int index = 0; index < uniqueStrings.Count; index++)
            {
                if (uniqueStrings[index].ToLower().Contains(inputText.ToLower()))
                {
                    Console.WriteLine($"Match found at index {index}: {uniqueStrings[index]}");
                    found = true;
                    break; // Stop the loop once a match is found
                }
            }

            // Check if the user input is not found in the list
            if (!found)
            {
                Console.WriteLine("Sorry, your input is not in the list.");
            }

            //Console App Assignment Part 5
            //List of strings with duplicates
            List<string> strings = new List<string> { "Toyota", "Mazda", "Lexus", "Lemouzine", "Lexus" };

            // Display the list
            Console.WriteLine("\nList of strings:");
            foreach (var Cars in strings)
            {
                Console.WriteLine(Cars);
            }
            //Ask the user to input text to search
            Console.WriteLine("\nEnter text to search for:");
            string searchText = Console.ReadLine();

            //Loop through the list to find duplicate matches
            bool match = false;
            for (int index = 0; index < strings.Count; index++)
            {
                if (strings[index].ToLower().Contains(searchText.ToLower()))
                {
                    Console.WriteLine($"Match found at index {index}: {strings[index]}");
                    match = true;
                }
            }
            // This is to Check if the user input is not found in the list
            if (!found)
            {
                Console.WriteLine("Sorry, your input is not in the list.");
            }

            // Console App Assignment Part 6
            // Create a list of strings with at least one duplicate
            List<string> items = new List<string> { "A", "B", "C", "D", "C" };

            //HashSet to track seen items for fast lookup
            HashSet<string> seen = new HashSet<string>();

            //Iterate through each item in the list
            foreach (string item in items)
            {
                if (seen.Contains(item))
                {
                    Console.WriteLine($"{item} - duplicate item");
                }
                else
                {
                    Console.WriteLine($" {item} - unique item");
                    seen.Add(item); // Mark as seen
                }
            }
        }
    }
}
