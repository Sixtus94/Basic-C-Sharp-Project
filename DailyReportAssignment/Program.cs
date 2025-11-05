using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DailyReportProgram
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
          //Daily Report Assignment for students of Academy of Learning Career College.

            Console.WriteLine("Academy of Learning Career college"); //Header of the program
            Console.WriteLine("Student Daily Report"); // Title of the program
            Console.WriteLine("what is your name?"); //promp user for name
            string name = Console.ReadLine(); //Read user input
            Console.WriteLine("what course are you on?"); //Prompt user for course name
            string course = Console.ReadLine(); //Read user input
            Console.WriteLine("what page number?"); // Prompt user for page number
            int pageNum = Convert.ToInt32(Console.ReadLine()); // Read user input and convert to integer
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"."); // Prompt user for help
            string needHelp = Console.ReadLine(); // Read user input
            bool needHelpBool = bool.Parse(needHelp); // Convert user input to Boolean
            Console.WriteLine("were there any positive experiences you 'd like to share? please give specifics."); // Prompt user for positive experience
            string posiveExperience = Console.ReadLine(); // Read user input
            Console.WriteLine("Is there any other feedback you'd like to share? Please be specifics."); // prompt user for feedback
            string feedback = Console.ReadLine(); // Read user input
            Console.WriteLine("How many hours did you study today? "); // Prompt user for hours studied
            string hoursStudy = Console.ReadLine(); // Read user input
            int hoursStudyNum = Convert.ToInt32(hoursStudy); // convert user input to integer
            Console.WriteLine("Thank you for your answers. An instructor will respond to you shortly. Have a great day!"); // Thank user for their time  


        }
    }
}
