using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
               // Console-based application for getting a shipping quote for a package
                Console.WriteLine("Shipping quote for a package"); // Header package
                Console.WriteLine("Welcome to Package Express.Please follow the instruction below"); // Customers instruction
                Console.WriteLine("Please enter the package weight: "); //Prompt user to enter the shipping weight
                double weight = Convert.ToDouble(Console.ReadLine()); 
                if (weight > 70) // conditional statement to follow / Branching
                {
                    Console.WriteLine("Package too heavy to be shipped via" +
                           " package Express. Have a good day.");
                }
                Console.WriteLine("Please enter the package width:"); //Prompt for package width
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:"); //Prompt for package Height
                double height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the package length: "); // Prompt for package lenght
                double length = Convert.ToDouble(Console.ReadLine());

                double dimensionsTotal = width + height + length;

                if (dimensionsTotal > 70)   //double dimentionalTotal branching statement
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                double quote = (height * width * length * weight) / 100; // Total shipping price quotes
                Console.WriteLine(string.Format("Your estimated total for shipping this package is: ${0:F2}", quote)); // price in $ format charset
                Console.WriteLine("Thank you!");
                Console.ReadLine();

            }
        }
}
