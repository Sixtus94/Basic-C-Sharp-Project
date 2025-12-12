using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberRide
{
    public class PremiumRide : Ride
    {
        public PremiumRide(double distance) : base(distance) { }

        public override double CalculateFare()
        {
            return 20 * Distance + 50; //Extra charge
        }

    }
}
