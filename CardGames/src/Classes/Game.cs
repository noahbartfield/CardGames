using System;
using System.Collections.Generic;

namespace CardGames.Classes
{
    public class Game
    {
        public Game()
        {
        }
        public string Name { get; set; }
        public int NumberOfPlayers { get; set; }
        public int StartingNumberOfCards { get; set; }
    }
}
