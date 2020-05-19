using System;
using System.Collections.Generic;
using CardGames.Classes;

namespace CardGames
{
    public class Deck
    {
        public Deck()
        {
            StartingNumberOfCards = 52;
        }
        public int StartingNumberOfCards { get; private set; }
        public List<Card> Cards { get; set; }
    }

}
