using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // This Create an instance of the MathOperations class on what each methods does.
            MathOperations mathOps = new MathOperations();

            // Asking the user for an integer input
            Console.Write("Enter an integer: ");
            // Read the user's input and convert it to an integer
            int input = Convert.ToInt32(Console.ReadLine());

            // Call the DoubleNumber method and store the result
            int doubled = mathOps.DoubleNumber(input);
            // Display the result to the console
            Console.WriteLine($"Double of {input}: {doubled}");

            // Call the SquareNumber method and store the result
            int squared = mathOps.SquareNumber(input);
            // Display the result to the console
            Console.WriteLine($"Square of {input}: {squared}");

            // Call the AddFive method and store the result
            int addedFive = mathOps.AddFive(input);
            // Display the result to the console
            Console.WriteLine($"{input} + 5: {addedFive}");


            // MathMethod 
            // This three methods take one integer parameter and return an integer
            Console.WriteLine("You've encountered Grozyi the Brigand and he launches a surprise attack. ");
            Console.WriteLine("Input your defense stat: "); //Take one integer parameter in and return an integer
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defense); //This method will do some math operations after taken an integer input.
            Console.WriteLine("You have taken " + enemy_damage + "HP OF damage.");
            Console.WriteLine("Your healer, serra is near by. She heals you with her staff.");
            Console.WriteLine("Input your healer's magic stat:"); //Take one integer parameter in andreturn an integer
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + "HP.");
            Console.WriteLine("How it's your turn to counter attack.");
            Console.WriteLine("Input your strenght stat: "); //Take one integer parameter in and return an integer
            int strenght = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strenght);
            Console.WriteLine("You have landed a critical attack and dealt " + damage + "HP worth of damage. ");
            Console.WriteLine();
        }
    }

}