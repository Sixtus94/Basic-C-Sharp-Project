 n    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anonymous Income Comparison Program
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine(" Hours Worked Per Week? ");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
            Console.WriteLine("person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine(" Hours worked per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
            Console.WriteLine("Annual salary of person 1: ");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of person 2: ");
            Console.WriteLine(salary2);
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            Console.ReadLine();
        
        }
    }
}
