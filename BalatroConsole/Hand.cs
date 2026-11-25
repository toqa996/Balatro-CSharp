using System;
using System.Collections.Generic;
using System.Text;

namespace BalatroConsole
{
    class Hand
    {
        public List<Card> Cards = new List<Card> ();

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
