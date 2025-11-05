using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousOperatorAssignment
{
     class program
    {
        static void Main()
        {
            var salesData = new List<Product> // list of products with sales data
            {
               new Product { Id = 1, Name = "Laptop", Quantity = 5, Price = 200.0 }, // Product 1
               new Product { Id = 2, Name = "Smartphone", Quantity = 8, Price = 300.0 }, // product 2
               new Product { Id = 3, Name = "Tablet", Quantity = 15, Price = 720.0 } // product3
            };
            var totalSales = salesData.Select(p => new // anonymous type to hold total sales info
            {
                productName = p.Name, // product name
                TotalRevenue = p.Quantity * p.Price // total revenue calculation
            });

            foreach (var item in totalSales) // iterate through total sales
            {
                Console.WriteLine($"Product: {item.productName},  TotalRevenue:"); // output product name and total revenue
                Console.WriteLine(item.productName + ": " + item.TotalRevenue); // detailed output
                Console.ReadKey(); // wait for user input
            }

        }
    }
}
