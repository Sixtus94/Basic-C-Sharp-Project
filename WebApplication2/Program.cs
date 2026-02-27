using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentTime = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + currentTime);
        DateTime specificDate = new DateTime(DateTime.Now.Year, 12, 25);
        Console.WriteLine("Specific Date (christmas): " + specificDate);
        Console.ReadKey();
    }
}
