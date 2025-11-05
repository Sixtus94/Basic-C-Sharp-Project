using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int AddNum1 = 4;
            //int AddNum2 = 5; // Two integer numbers
            //int sum = AddNum1 + AddNum2; // Addition of two numbers
            //Console.WriteLine(sum); // Output

            //int SubNum1 = 4;
            //int SubNum2 = 5; // Two integer numbers
            //int difference = SubNum1 - SubNum2; // subtraction of two numbers
            //Console.WriteLine(difference);      

            //int MultNum1 = 6;
            //int MultNum2 = 4; // Two integer numbers
            //int total = MultNum1 * MultNum2; // Multiplication of two numbers
            //Console.WriteLine(total);

            //int DivNum1 = 8;
            //int DivNum2 = 2; // Two integer Numbers
            //int quotient = DivNum1 / DivNum2; // Division of Two Integer Numbers
            //Console.WriteLine(quotient); // Output in the console

            //  Remainder ( Modulus Operator)
            //int ModNum1 = 7;
            //int ModNum2 = 2; // Two integer Numbers
            //int remainder = ModNum1 % ModNum2;
            //Console.WriteLine(remainder); // Output 

            //Determinne if a number is even or Odd number
            //int number = 7; // Integer Number
            //int result = number % 2;
            //Console.WriteLine(result); // Output 

            // Math Casting 
            double num1 = 7.03230923;
            float num2 = 5.9f;
            double total = num1 + num2; //compile
            Console.WriteLine(total);

            double num3 = 7.03230923;
            float num4 = 5.9f;
            float total2 = (float)num3 + num4; // Explicit casting
            Console.WriteLine(total2);

            //Implicit casting from integer to a decimal
            decimal num5 = 7.03230923m;
            int num6 = 5;
            decimal total3 = num5 + num6;
            Console.WriteLine(total3);

            //Or
            decimal num7 = 7.03230923m;
            sbyte num8 = 5;
            decimal total4 = num7 + num8;
            Console.WriteLine(total4);

            // Math with string concatenation
            string firstName = "Jesse";
            string lastName = "Smith";
            Console.WriteLine(firstName + lastName); // output Jesse Smith

            string name = "Mark";
            int number = 7;
            Console.WriteLine(name + number);






        }
    }

}
