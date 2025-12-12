using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //nside the Main() method, instantiate an Employee object with firstName “Sample”
            //and lastName “Student”. Call the SayName() method on the object.
            Employee doris = new Employee() { firstName = "Sample", lastName = "student" };
            //Call the sayName() method on the Employee object
            doris.SayName();
            Console.ReadLine();
        }
    }
}
