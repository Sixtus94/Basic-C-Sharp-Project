using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberRide
{
    public class BikeRide : Ride
    {
        public BikeRide(double distance) : base(distance) { }

        public override double CalculateFare()
        {
            return 5 * Distance; //5 per km
        }


    }
}
