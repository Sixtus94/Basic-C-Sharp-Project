using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;


namespace Iterations2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Create a one - dimentational Array of strings.
            string[] wordstart = {
                "Welcome to ",
                "I'm the principal, ",
                "Our mission is to provide our students with a "
            };
            string[] wordend =
            {
                ",Tech Academy.",
                ".",
                " learning experience."
            };
            List<string> responses = new List<string>();
            //Ask the user to input some text.
            Console.WriteLine("Please enter a noun:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter the name of someone infamous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective");
            responses.Add(Console.ReadLine());

            //A loop that goes through each string in the Array, adding the user's text to the string.
            for (int i = 0; i < wordstart.Length; i++)
            {
                wordstart[i] += responses[i];
                Console.WriteLine(wordstart[i] + wordend[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The strings is used:");
            //This loop print off each string in the Array on a separate line.
            for (int i = 0; i < wordstart.Length; i++)
            {
                Console.WriteLine(wordstart[i] + wordend[i]);

                //part2
                //Creating an infinite loop (uncomment line "i--" for infinite loop.
                //Fix the infinite loop.
                //i--;
            }
            Console.WriteLine();

            //Part 3
            Console.WriteLine("Is that a monster?!");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            //Creating a loop where the comparison is used to determine whether to continue iterating the loop is:  "<" operator.
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine(boo);
            Console.ReadLine();
            StringBuilder hey = new StringBuilder();
            hey.Append("A");
            //Adding a loop where the comparison is used to determine whether to continue iterating the loop is a "<=" operator.
            while (hey.Length <= 10)
            {
                hey.Append("K");
            }
            hey.Append("!");
            Console.WriteLine(hey);
            Console.ReadLine();

            //Part 4
            // Creating a List of strings where each item in the list is unique
            List<string> teams = new List<string>() { "Bucks", "Raptors", "Celtics", "Heat", "Pacers",
            "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers" };
            Console.WriteLine("NBA Eastern Conference standings");
            //Ask the user to input text to search for the list.
            Console.WriteLine("Enter team name:");
            int standing = 0;
            bool isvalid = false;
            int index = 0;
            //Creating a loop that iterates through the list and then displays the index of the array with matching terms on the screen.
            while (!isvalid)
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                // Adding this code to the above loop, tells the users that the input text isn't in the list
                if (standing == 0)
                {
                    Console.WriteLine("That is not a valid team name. Enter again:");
                }
                //This code stop the loop from executing once a match has been found.
                else
                {
                    isvalid = true;
                }
            }
            Console.WriteLine("Processing... Index is: " + index + ". so...");
            Console.WriteLine("standing is: " + standing);
            Console.ReadLine();

            // Part 5
            // Creating a List of strings with two identical strings in the list.
            List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "vacant", "vacant", "Reserved", "Taken" };
            Console.WriteLine("Welcome to swell Taco! \nDue to COVID-19 we have a computerized check-in.\nIf you have a reservation type " + "" +
                 "\"Reserved\".\nIf you are joining a party that is already here type \"Taken\". \nOtherwise type \"vacant\".");
            //Asking the user input search text from the List.
            Console.WriteLine("Enter selection: ");
            string selection = Console.ReadLine();
            while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
            {
                //This code tells a user if they put in text that isn't in the list.
                Console.WriteLine("Please enter one of the 3 choices:");
                selection = Console.ReadLine();
            }
            Console.WriteLine("The tables that match your selection are numbered:");
            //Creating a loop that iterates through the loop and then displays the indices the Array
            //that contain matching text on the screen.
            for (int i3 = 0; i3 < tables.Count; i3++)
                if (selection == tables[i3])
                {
                    Console.WriteLine(i3);
                }

            Console.ReadLine();
            //Part 6
            //Creating a List of strings that has at two identical strings in the List.
            List<string> names = new List<string>() { "Dan", "Mascot", "Katrina", "Bob", "John", "James", "John", "Katrina", "Bob" };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Class Roaster:");
            //Creating a loop foreach to evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name has been repeated. \nUse last name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
            
        }
    } 
}
