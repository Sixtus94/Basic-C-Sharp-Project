using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberRide
{
    class Program
    {
        static void Main(string[] args)
        {

            RideManager manager = new RideManager();

            List<Ride> rides = new List<Ride>()
                {
                     new CarRide(12),
                     new BikeRide(8),
                     new AutoRide(15),
                     new PremiumRide(10)
                };

            foreach (var ride in rides)
            {
                manager.BookRide(ride);
            }

            Console.ReadLine();

        }
    }
}
    