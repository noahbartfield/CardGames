using System;
namespace CardGames.Classes
{
    public class Card
    {
        public Card()
        {
            if (Suit == "Spades" || Suit == "Clubs")
            {
                Color = "Black";
            }
            else
            {
                Color = "Red";
            }
        }
        public string Name { get; set; }
        public string Suit { get; set; }
        public string Color { get; private set; }
        public int Value { get; set; }

    }
}
