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
        public List<Rule> Rules { get; set; }

    }
}
