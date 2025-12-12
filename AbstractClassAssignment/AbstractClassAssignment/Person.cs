using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    { // Create an abstract class called "Person" with two string properties:
      // string 1: firstName and string2: lastName.
        public string firstName { get; set; }
        public string lastName { get; set; }
        // Given the Method SayName().
        public abstract void SayName(); 
        
    }
}
