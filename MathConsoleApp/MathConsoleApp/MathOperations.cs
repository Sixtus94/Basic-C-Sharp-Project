using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApp
{
    // This class contains a method that performs a math operation and prints values.
    class MathOperations
    {
        // This method takes two integers.
        // It performs a math operation (doubling) on the first integer.
        // It then prints both the result of the operation and the second integer.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine("First number doubled: " + result);

            // Display the second integer unchanged
            Console.WriteLine("Second number: " + secondNumber);

        }
    }
}