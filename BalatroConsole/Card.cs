using System;
using System.Collections.Generic;
using System.Text;

namespace BalatroConsole
{
     class Card
    {
        public Suit Suit;
        public Rank Rank;
        public Card(Suit suit, Rank rank)
        {

            Suit = suit;
            Rank = rank;
        }
       
    }
}
