using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssgmntTwo
{
    class Program
    {
            // The entry point of the console application
            static void Main(string[] args)
            {
               
                // Create first Employee object and assign its properties
                Employee employ1 = new Employee { Id = 1, FirstName = "John", LastName = "Mark" };

                // Create second Employee object with the same Id (This is considered equal)
                Employee employ2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Kelly" };

                // Create third Employee object with a different Id (so it is not equal to employee1)
                Employee employ3 = new Employee { Id = 2, FirstName = "Bob", LastName = "Brown" };

                // Compare employee1 and employee2 using the overloaded == operator
                Console.WriteLine("Output :" + (employ1 == employ2));

                // Compare emp1 and emp3 using the overloaded == operator
                Console.WriteLine("Output : " + (employ1 == employ3));
                Console.ReadKey();

            }
    }
}
