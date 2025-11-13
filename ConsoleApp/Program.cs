using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Predict a number(1-7) for week day!"); // Prompt for number input
            int number = Convert.ToInt32(Console.ReadLine()); // conver to integer

            do // execute the switch statement
            {
                switch (number)
                {

                    // switch statements:
                    case 1:
                        Console.WriteLine("1 is Monday ");
                        break;

                    case 2:
                        Console.WriteLine("2 is Tuesday ");
                        break;

                    case 3:
                        Console.WriteLine("is Wednesday ");
                        break;

                    case 4:
                        Console.WriteLine("4 is Thursday");
                        break;

                    case 5:
                        Console.WriteLine("5 is Friday");
                        break;

                    case 6:
                        Console.WriteLine("6 is Saturday");
                        break;

                    case 7:
                        Console.WriteLine("7 is Sunday");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please try again."); //  Output invalid input when a wrong number is entered
                        Console.WriteLine("Predict a number (1-7): ");
                        number = Convert.ToInt32(Console.ReadLine());
                        continue;
                }
                break;
            } while (true);
            
                     // To do While loop
                    int count = 0;
                    do
                    {
                        Console.WriteLine("Inside the loop");
                        count++; // add +1 in every count time
                    }
                    while (count < 4); //countinue with the loop until it get to 4

                     //A while loop
                    int counting = 0;
                    while (counting < 3) ; //continue looping until it get 3
                   {
                      Console.WriteLine("counting the numbers");
                      counting++; //add 1 in every counting time
                   }
                      Console.ReadLine();

                    //Execute code block
                    int i = 0;
                    do
                    {
                       Console.WriteLine(i);
                       i++;
                    }
                    while (i < 5);

            

        }
    }
}
