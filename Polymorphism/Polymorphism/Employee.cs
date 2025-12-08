using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Employee Class Implemnting :IQuitable
    public class Employee : IQuitable 
    {
        public string FirstName { get; set; } //first name
        public string LastName { get; set; } //last name
        public int Id { get; set; }  //employee id

        // Implement the Quit method from IQuittable
        public void Quit()
        {
            // Implementation choice: write a message including the employee's name and id
            Console.WriteLine($"Employee: {FirstName} {LastName} (ID: {Id}) has quit.");
        }
    }
}
