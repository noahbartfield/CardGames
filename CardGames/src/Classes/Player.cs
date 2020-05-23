using System;
using System.Collections.Generic;
using System.Linq;
using CardGames.Classes;

namespace CardGames.src.Classes
{
    public class Player
    {
        public Player()
        {
            IsWinner = false;
        }
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public List<Card> CardsInPlay { get; set; }
        public int PointsInPlay
        {
            get
            {
                return CardsInPlay.Sum(card => card.Value);
            }
        }
        public bool IsWinner { get; set; }
    }
}
