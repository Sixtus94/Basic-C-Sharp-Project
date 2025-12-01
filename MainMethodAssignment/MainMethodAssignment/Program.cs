using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main MathMethod part 2
            // Instantiating MathMethod.MathMethods class
            MathMethod.MathMethods math1 = new MathMethod.MathMethods();

            // Call the Method with an integer and display the result
            Console.WriteLine(math1.Method(2));

            // Call the Method with a decimal and display the result
            Console.WriteLine(math1.Method(3.2m));

            // Call the Method with a string and display the result
            Console.WriteLine(math1.Method("5"));
        }
    }


}
    

