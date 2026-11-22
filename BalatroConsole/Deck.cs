using System;
using System.Collections.Generic;
using System.Text;

namespace BalatroConsole
{
    internal class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck()
        {
            foreach (Suit suit in Enum.GetValues<Suit>())
            {
                foreach (Rank rank in Enum.GetValues<Rank>())
                {
                    Cards.Add(new Card(suit , rank));
                }
            }
        }
    }
}
