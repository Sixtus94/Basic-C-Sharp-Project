using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary Operator
            int num1 = 7;
            int num2 = 10;
            string result = num1 > num2 ? "num1 is greater than num2 " : "num1 is not greater than num2";
            Console.WriteLine(result);


            int x = 5;
            int y = 10;

            string result2 = (x > y) ? "x is greater" : "x is not greater than y";
            Console.WriteLine(result2); // Output: y is greater or equal

            // The ternary operator is a concise way to write simple
            // if-else statements

            int time = 12;
            if (time < 11)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int time1 = 20;
            string output = (time1 >= 18) ? "Good day." : "Good evening.";
            Console.WriteLine(output);

            // Branching
            int time2 = 20;
            Console.WriteLine("Hey! What is Your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi!," + name + "\nWHat says your time? \n");
            Convert.ToInt32(Console.ReadLine());
              
            // using temperature
            int currentTemperature = 60;
            int roomTemperature = 30;
            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is not exactly room temperature");
            }

            else if (roomTemperature <= currentTemperature)
            {
                Console.WriteLine("The Temperature is conducieve to stay");
            }
            Console.ReadLine();

        }

    }
}
