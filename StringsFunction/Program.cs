using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsFunction
{
     class Program
    {
        static void Main(string[] args)
        {   
            //concatenate first and second name
            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            // string concatenate with datestring
             string userName = "Morris";
            string dateString = DateTime.Today.ToShortDateString();

            // Use the + and += operators for one-time concatenations.
            string str = "Hello " + userName + ". Today is " + dateString + ".";
            Console.WriteLine(str);

            str = " How are you today?";
            Console.WriteLine(str);

            // String concatenation (interpolation + +)
            string first = "Hello";
            string second = "sixtus";
            string concatenated1 = first + " " + second;              // using +
            string concatenated2 = string.Concat(first, " ", second); // using string.Concat
            string concatenated3 = $"{first} {second}!";              // using interpolation

            // Convert to uppercase
            string UpperCase = concatenated3.ToUpper(); // prefer ToUpperInvariant for culture-safe transforms

            // Buildis a paragraph with StringBuilder
            var sb = new StringBuilder();
            sb.AppendLine("This is my first sentence.");
            sb.Append("My second sentence continues the thought. ");
            sb.Append("Finally, my paragraph is closed.");
            string paragraph = sb.ToString();

            // Output
            Console.WriteLine(concatenated1);
            Console.WriteLine(concatenated2);
            Console.WriteLine(concatenated3);
            Console.WriteLine(UpperCase);
            Console.WriteLine();
            Console.WriteLine("Paragraph:");
            Console.WriteLine(paragraph);
        }
    }
}


