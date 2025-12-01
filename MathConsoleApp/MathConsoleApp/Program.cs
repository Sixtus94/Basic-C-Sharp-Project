using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method, passing in two integers positions
            mathOps.ProcessNumbers(5, 10);

            // Call the method again, specifying the parameter names
            mathOps.ProcessNumbers(firstNumber: 7, secondNumber: 20);

            // Prevent the console window from closing immediately
            Console.WriteLine("Press any key to exit..."); 
            Console.ReadKey();

        }
    }
}
