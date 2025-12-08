using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Program entry point demonstrating polymorphism
    //Goal Here: Define an interface "IQuitable" with Quit(),
    //Implementing it in Employee, and call Quit() via an IQuitable
    class Program
    {  
        public static void Main()
        {
            // Instantiate an Employee and initialize properties
            Employee employ = new Employee { FirstName = "John", LastName = "Kelly", Id = 10 };

            // Using polymorphism: reference the Employee object through the IQuittable interface
            IQuitable quitter = employ;  // This is allowed because Employee implements IQuittable

            // Call Quit via the interface reference — the Employee implementation runs
            quitter.Quit();  // Output: Employee Jane Doe (ID: 10) has quit.
        }

    }
}

