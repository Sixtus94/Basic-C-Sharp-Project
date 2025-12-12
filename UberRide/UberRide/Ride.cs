using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberRide
{
    public abstract class Ride
    {
        public double Distance { get; set; }

        public Ride(double distance)
        {
            Distance = distance;
        }
        // Polymorphic method
        public abstract double CalculateFare();

        public virtual void Start()
        {
            Console.WriteLine("Ride started");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Ride ended");
        }
    }
}
