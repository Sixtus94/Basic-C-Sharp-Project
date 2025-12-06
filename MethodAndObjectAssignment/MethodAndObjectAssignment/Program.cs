using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee object with a
            //first name of “Sample” and a last name of “Student”.
            Employee mike = new Employee() { FirstName = "Sample", LastName = "Student" };
            //call the superclass method SayName() on Employee object
            mike.sayName();
            Console.ReadLine();
        }
    }
}

