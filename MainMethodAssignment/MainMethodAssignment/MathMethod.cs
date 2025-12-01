using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathMethod
    {       // The MathMethods Class

        //This code defines a MathMethod with three over loaded MathOp that take an integer, a decimal and a string as input
        //Each method performs different math operation and returns the result as an integer.

        // Define a class to perform math operations
        public class MathMethods
        {
            // This First method takes an integer
            public int Method(int num)
            {
                // Return the input number 
                return num + 5;
            }

            // Second Method triple a decimal and round to the nearest integer
            public int Method(decimal num)
            {
                // convert the decimal to an int to perform math operation
                int newnum = Convert.ToInt32(num);
                return newnum * 10;
            }

            // Method to add 5 to a string that can be converted to an integer
            public int Method(string numStr)
            {
                // convert the string to int and perform math operation
                int newnum = Convert.ToInt32(numStr);
                return newnum % 7;
            
            }
            
        }
    }
 } 
