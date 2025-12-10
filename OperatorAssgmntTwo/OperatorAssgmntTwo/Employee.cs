using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssgmntTwo
{
    class Employee
    { 
        // The Employee class represents a worker with an Id, FirstName, and LastName
        public int Id { get; set; }   // This Property store the employee's unique identifier: Id
        public string FirstName { get; set; }  // This Property store the employee's first name
        public string LastName { get; set; }  // This Property store the employee's last name

        // Overloading the == operator to compare two Employee objects by their Id
        public static bool operator ==(Employee employ1, Employee employ2)
        {
            // If both references are null, they are considered equal
            if (ReferenceEquals(employ1, employ2))
                return true;

            // If one is null but not the other, they are not equal
            if (employ1 is null || employ2 is null)
                return false;

            // Compare employees by their Id property
            return employ1.Id == employ2.Id;
        }

        // Overloading the != operator to match the == operator
        public static bool operator !=(Employee employ1, Employee employ2)
        {
            return !(employ1 == employ2);
        }

        // Override Equals and  match operator overloads
        public override bool Equals(Object obj)
        {
            if (obj is Employee other)
                return this == other;
            return false;
        }
    }
}
