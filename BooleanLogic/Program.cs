using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
     class Program
    {
        static void Main(string[] args)
        {
            //// Boolean Logic Operators
            //Console.WriteLine(true && true && true || false); // true
            //Console.WriteLine(true && false); // false
            //Console.WriteLine(true && true); // true
            //Console.WriteLine(false && false); // false

            //Console.WriteLine(true || true); //true
            //Console.WriteLine(true || false); // true
            //Console.WriteLine(false || false); // false

            //Console.WriteLine(true == true); // true
            //Console.WriteLine(true == false); // false
            //Console.WriteLine(false == false); // true

            //Console.WriteLine(true != true); // false
            //Console.WriteLine(true != false); // true
            //Console.WriteLine(false != false); // false

            //Console.WriteLine(true ^ true); // false
            //Console.WriteLine(true ^ false); // true
            //Console.WriteLine(false ^ false); // false

            //Console.ReadLine();

            ////Vehicle Insurance Application program
            //Console.WriteLine("Vehicle Insurance Application");
            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Have you ever had a DUI? (Yes or No) ");
            //string response = Console.ReadLine();
            //bool dui = response.ToLower() == "yes";
            //Console.WriteLine("How many speeding tickets do you have?");
            //int tickets = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Qualified for insurance?");
            //bool qualified = (age > 15) && !dui && (tickets <= 3);
            //Console.WriteLine(qualified);

            //// Branching statements
            //if (true)
            //{
            //    Console.WriteLine("This is true");
            //}

            //// If/ Else statements
            //if (2 == 2)
            //{
            //    Console.WriteLine("2 is equal to 2");
            //}
            //else
            //{
            //    Console.WriteLine("2 is not equal to 2");
            //}

            ////Else Statements 2
            //string name = "Alice";
            //if (name == "Dorcas")
            //{
            //    Console.WriteLine("Your name is Dorcas");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not Dorcas");
            //}

            //// Else statements 3
            //int number = 4;
            //if (number == 5)
            //{
            //    Console.WriteLine("The number is 5");
            //}
            //else if (number == 8)
            //{
            //    Console.WriteLine("The number is not 5");
            //}
            //else
            //{
            //    Console.WriteLine("The number is neither 5 nor 8.");
            //}

            //// Else statements 4, several conditions:
            //string color = "red";
            //if (color == "black")
            //{
            //    Console.WriteLine("The color is black");
            //}
            //else if (color == "blue")
            //{
            //    Console.WriteLine("The color is not black");
            //}
            //else if (color == "Green")
            //{
            //    Console.WriteLine("The color is green");    
            //}

            //// Once the expression inside the parentheses evaluate true,the rest are skipped
            //string fruit = "Apple";
            //if (fruit == "Carrot")
            //{
            //    Console.WriteLine("The fruit name is carrot");
            //}
            //if (fruit == "Banana")
            //{
            //    Console.WriteLine("The fruit is not carrot");
            //}
            //if (fruit == "Apple")
            //{
            //    Console.WriteLine("The fruit is Apple");
            //}

            // using != opretor (value on the left not equal to value on the right
            string name = "Bob";
            if (name != "Malley") ;
            {
                Console.WriteLine("your name is not Malley");
            }

            if (5 != 10)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }

            //Greater than Operator
            int height = 15;
            int minHeight = 10;
            if (height > minHeight)
            {
                Console.WriteLine("You are tall enough to ride");
            }
            else
            {
                Console.WriteLine("You are not tall enough to ride");
            }
            //less than operator
            int weight = 10;
            int minWeight = 5;
            if (weight < minWeight)
            {
                Console.WriteLine("You are strong enough");
            }
            else
            {
                Console.WriteLine("You are not strong enough");
            }
            // Lesser Than or Equal to Operator
            int speed = 60;

            if (speed <= 60)
            {
                Console.WriteLine(" Safe Drive");
            }
            else
            {
                Console.WriteLine("Unsafe Drive");
            }

            // Greater Than or Equal to 
            int speedLimit = 30;
            if (speedLimit >= 35)
            {
                Console.WriteLine("You are fine");
            }
            else
            {
                Console.WriteLine("You will get a ticket of 50 eur penalty.");
            }

            // AND Operator specific condition to if statement
            int age1 = 20;
            int age2 = 25;
            int age3 = 22;
            if (age2 > age1 && age3 < age2)
            {
                Console.WriteLine("Age2 is the oldest");
            }
            //AND Expression on the left & right must be true
            int age4 = 20;
            if (true && true && true && age4 == 20)
            {
                Console.WriteLine("All conditions are true");
            }
            else
            {
                Console.WriteLine("One condition is false");
            }
            // In real-life business 
            int packageWeight = 50;
            int packageLenght = 20;
            if (packageWeight > 40 && packageLenght > 18)
            {
                Console.WriteLine("package is too heavy for shippment.");
            }
            else
            {
                Console.WriteLine("package is acceptable for shipment, additional fees may apply.");
            }
            //  OR Operator
            int voteAge = 10;
            if (voteAge < 12 || voteAge == 18)  // either one must be true
            {
                Console.WriteLine("Atleast One value is true.");
            }
            if (voteAge == 18 || voteAge == 22)
            {
                Console.WriteLine("Atleast one value is true.");
            }
            else
            {
                Console.WriteLine("Both values are false.");
            }
            if (voteAge == 12 || voteAge == 18 || voteAge == 22 || voteAge == 10)
            {
                Console.WriteLine("one must be true.");
            }
            // OR Real-Life Scenario:
            string role = "admin";
            if (role == "admin" || role == "administrator")
            {
                Console.WriteLine("You may have access to the entire software system.");
             }

            //OR
            int books = 5;
            if (books < 10 && ((books == 5) || books == 2) && ((books == 7 && books > 15) || (books < 20 && books > 2)))
            {
                Console.WriteLine("Hey! it confusing");
            }




        }
    }
}
