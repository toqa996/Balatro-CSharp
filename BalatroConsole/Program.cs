using BalatroConsole;

Deck deck = new Deck();

deck.Shuffle();

Card card1 = deck.Draw();

Console.WriteLine($"{card1.Suit} {card1.Rank}");
Console.WriteLine(deck.Cards.Count);




