using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberRide
{
    public class AutoRide : Ride
    {
        public AutoRide(double distance) : base(distance) { }
        public override double CalculateFare()
        {
            return 7 * Distance; //per km
        }
    }
}
