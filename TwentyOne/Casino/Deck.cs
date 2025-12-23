using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {

            cards = new List<card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    card Card = new card();
                    Card.Face = (Face)i;
                    Card.suit = (Suit)j;
                    cards.Add(Card); // <-- Fix: use 'Card' (the variable), not 'card' (the type)
                }
            }
        }
        public List<card> cards { get; set; }

        public void shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<card> Templist = new List<card>();
                Random random = new Random();

                while (cards.Count > 0)
                {
                    int randomIndex = random.Next(0, cards.Count);
                    Templist.Add(cards[randomIndex]);
                    cards.RemoveAt(randomIndex);
                }
                cards = Templist;
            }
        }
    } 
}