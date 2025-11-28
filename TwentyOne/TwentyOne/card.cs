using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class card
    {
        public card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public String Suit{ get; set; }
        public String Face{ get; set; }
    }
}
