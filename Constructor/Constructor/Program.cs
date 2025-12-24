using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Constructor Assignment
namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a const variable
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite number is:";
            Console.WriteLine("Enter your name  or favorite number: ");
            // create a variable using the var keyword
            var userInput = Console.ReadLine();
            if (float.TryParse(userInput, out float x)) //if the user input is a number
            {
                Console.WriteLine(const2);    // print the favorite number message 
                Chain newChain = new Chain(x); // Create a new chain object using the number constructor
                Console.ReadLine();     // wait for the user to press enter before closing
            }
            else           //if the user input is a string
            {
                Console.WriteLine(const1);  // print the name messge to the console
                Chain newChain = new Chain(userInput); // Create a new chain object using the string constructor
                Console.ReadLine();
            }
        }
    }
}
