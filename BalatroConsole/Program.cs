using BalatroConsole;

Deck deck = new Deck();

deck.Shuffle();

foreach (Card card in deck.Cards)
{
    Console.WriteLine($"{card.Suit} {card.Rank}");
}


