using BalatroConsole;

Deck deck = new Deck();
Hand hand = new Hand();

deck.Shuffle();

for(int i = 0; i < 5; i++)
{
    Card card1 = deck.Draw();
    hand.AddCard(card1);
}
foreach(Card card in hand.Cards)
{
    Console.WriteLine($"{card.Suit} {card.Rank}");
}







