using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct card
    {
        
        public Suit suit{ get; set; }
        public Face Face{ get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades,
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
