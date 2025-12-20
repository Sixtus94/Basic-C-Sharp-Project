using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "John", LastName = "Sean" },
            new Employee { Id = 2, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 3, FirstName = "Jane", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Williams" },
            new Employee { Id = 5, FirstName = "Bob", LastName = "Brown" },
            new Employee { Id = 6, FirstName = "Alice", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Mike", LastName = "Miller" },
            new Employee { Id = 8, FirstName = "Emma", LastName = "Wilson" },
            new Employee { Id = 9, FirstName = "Tom", LastName = "Anderson" },
            new Employee { Id = 10, FirstName = "Lily", LastName = "Thomas" },
            new Employee { Id = 11, FirstName = "David", LastName = "Jackson" },
        };

            // Using a foreach loop, create a new list of all employees with the first name “Joe”
            List<Employee> joesLoop = new List<Employee>();
            foreach (var employee in employees)
            {
                // Check if the employee's first name is "Joe"
                if (employee.FirstName == "Joe")
                {
                    // Add the employee to the list
                    joesLoop.Add(employee);
                }
            }

            // Display the list of Joes using the foreach loop
            Console.WriteLine("Joes (foreach loop):");
            foreach (var joe in joesLoop)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Using a lambda expression, create a new list of all employees with the first name “Joe”
            // The Where method filters the employees based on the condition
            var joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Display the list of Joes using the lambda expression
            Console.WriteLine("\nJoes (lambda expression):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Using a lambda expression, make a list of all employees with an Id number greater than 5
            // The Where method filters the employees based on the condition
            var highIds = employees.Where(e => e.Id > 5).ToList();

            // Display the list of employees with Id > 5
            Console.WriteLine("\nEmployees with Id > 5:");
            foreach (var employee in highIds)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

              
            // Define a lambda expression
            //Func<int, int> square = x => x * x;

            // Use the lambda expression
            //int result = square(5);
            //Console.WriteLine(result); // Outputs: 25

            // Use lambda with LINQ
            //int[] numbers = { 1, 2, 3, 4, 5 };
            // var squares = numbers.Select(x => x * x);
            //Console.WriteLine(string.Join(", ", squares)); // Outputs: 1, 4, 9, 16, 25
        }
    }
}
