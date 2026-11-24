using System;
using System.Collections.Generic;
using System.Text;

namespace BalatroConsole
{
    internal class Deck
    {
        public List<Card> Cards = new List<Card>();
        //constractor //
        public Deck()
        {
            foreach (Suit suit in Enum.GetValues<Suit>())
            {
                foreach (Rank rank in Enum.GetValues<Rank>())
                {
                    Cards.Add(new Card(suit, rank));
                }
            }
        }


        public void Shuffle()
        {
            Random random = new Random();

            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int index = random.Next(0, i + 1);

                Card temp = Cards[i];
                Cards[i] = Cards[index];
                Cards[index] = temp;
            }
        }

        public Card Draw()
        {
            if (Cards.Count == 0)
            {
                throw new InvalidOperationException("Deck is empty");
            }

            Card drawnCard = Cards[0];
            Cards.RemoveAt(0);
            return drawnCard;
        }

    }
}