using System;
namespace CardGames.Classes
{
    public class Card
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public string Color
        {
            get
            {
                if (Suit == "Spades" || Suit == "Clubs")
                {
                    return "Black";
                }
                else
                {
                    return "Red";
                }
            }
        }
        public int Value { get; set; }

    }
}
