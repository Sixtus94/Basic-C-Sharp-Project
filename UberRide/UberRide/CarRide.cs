using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberRide
{
    public class CarRide : Ride
    {
        public CarRide(double distance) : base(distance) { }

        public override double CalculateFare()
        {
            return 10 * Distance; // ₹10 per km
        }

    }
}
