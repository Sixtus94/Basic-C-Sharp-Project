using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParametersAssignment.GenericEmployee;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee whose Things are strings
            var stringEmployee = new Employee<string>();                     // instantiate Employee<string>
            stringEmployee.Things = new List<string> { "Justina", "Trump" };     // assign a List<string> to Things

            // Create an Employee whose Things are ints
            var intEmployee = new Employee<int>();                           // instantiate Employee<int>
            intEmployee.Things = new List<int> { 5, 10, 20 };               // assign a List<int> to Things

            // Print stringEmployee Things to the console
            Console.WriteLine("String employee things:");                    // head for read
            foreach (var item in stringEmployee.Things)                      // iterate over List<string>
            {
                Console.WriteLine(item);                                     // print each string
            }

            // Print intEmployee Things to the console
            Console.WriteLine("\nInt employee things:");                     // header for read
            foreach (var item in intEmployee.Things)                         // iterate over List<int>
            {
                Console.WriteLine(item);                                     // print each int
            }

            // Wait for user to press a key before exiting (so console stays open)
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
