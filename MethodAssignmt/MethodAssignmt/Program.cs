using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmt
{
    class Program
    {
        static void Main()
        {    
            //MathOperation Part One
            //  Instantiating MathOperations class
            MathOperation1 mathOps = new MathOperation1();

            // Call the Calculate method with an integer and display the result
            int intResult = mathOps.Calculate(7);
            Console.WriteLine("10 + 5 = " + intResult);

            // Call the Calculate method with a decimal and display the result
            int decimalResult = mathOps.Calculate(3.5m);
            Console.WriteLine("3.5 * 10 = " + decimalResult);

            // Call the Calculate method with a string and display the result
            int stringResult = mathOps.Calculate("5");
            Console.WriteLine("4 squared = " + stringResult);

            //MathOperation Part Two
            //Instantiate class
            MathOperation1 mathOp = new MathOperation1();
            //Asking the user to input first parameter
            Console.WriteLine("Input an integer:\t ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Asking the user to provide a second parameter or Press enter
            Console.WriteLine("Input second integer, or just press enter: ");
            try
            {
                //call method with 2 parameters if both parameters are provided
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.Calculate(num1, num2);
                Console.WriteLine(num1 + " X " + num2 + " = " + results);


            }
            catch 
            {
                // Call the method with one parameter if only one is provided
                int results = mathOp.Calculate(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);

            }
            Console.ReadLine();
        }
    }

}
