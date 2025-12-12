using System;
using System.Collections.Generic;


namespace AbstractClassAssignment
{
    //Create another class called Employee and have it inherit from the person class
    public class Employee : Person
     
    {
        //Give the Employee class a property called Id and have it to be of data type int
        public int Id { get; set; }
        //Implementing the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
