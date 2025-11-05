using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsAndComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //Console.WriteLine("five plus ten = " + total.ToString());
            //int otherTotal = 12 + 22;
            //int Combinend = total + otherTotal; 
            //Console.ReadLine();

            // Other ways
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int Combined = total + otherTotal; 
            //Console.WriteLine(Combined);
            //Console.ReadLine();

            //Difference
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //product
            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //quotient
            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //modulus 
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //Boolean comparison operators
            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //console.ReadLine();

            //Bool comparison operators: <, >, <=, >=, ==, != applications
            int roomTemperature = 70;
            int currentTemperature = 72;
            bool iswarm = currentTemperature != roomTemperature;
            Console.WriteLine(iswarm);
            Console.ReadLine();
        }
    }
}
