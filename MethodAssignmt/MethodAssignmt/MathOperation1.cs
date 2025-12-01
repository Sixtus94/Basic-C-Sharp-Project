using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmt
{
    class MathOperation1
    {    
        // Part one
        // Define a class to perform math operations
        // Method to add 5 to an integer
        public int Calculate(int num)

        {
            // Return the input number plus 5
            return num + 5;
        }

        // Method to multiply a decimal by 2 and round to the nearest integer
        public int Calculate(decimal num)
        {
            // Return the input number multiplied by 2 and rounded to the nearest integer
            return (int)Math.Round(num * 2);
        }

        // Method to square a string that can be converted to an integer
        public int Calculate(string numStr)

        {
            // Try to convert the input string to an integer
            if (int.TryParse(numStr, out int num))
            {
                // Return the input number squared
                return num * num;
            }
            else
            {
                // Throw an exception if the input string cannot be converted to an integer
                throw new FormatException("Input string is not a valid integer.");
            }
        }
        // Part Two
        //Creating a method that takes two integers as parameters
        //Make one parameter optional by providing a default value
        public int Calculate(int i, int a = 2)
        {
            int results = i * a;
            return results;
        }
    }
}
     