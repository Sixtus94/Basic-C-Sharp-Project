using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberRide
{
    public class RideManager
    {
        public void BookRide(Ride ride)
        {
            ride.Start();

            // Polymorphism → the method CalculateFare() behaves differently
            double fare = ride.CalculateFare();

            ride.Stop();
            Console.WriteLine($"Total Fare: ₹{fare}\n");

        }
    }
}