using System;
using System.Collections.Generic;
using CardGames.Classes;
using CardGames.src.Classes;

namespace CardGames
{
    class Program
    {
        static void DisplayBanner()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++
        |C|a|r|d| | | |G|a|m|e|s|
        +-++-++-++-++-++-++-++-++");
            Console.WriteLine();
        }

        static void GameInit(Game game)
        {

            Console.WriteLine("1. Black Jack");
            Console.WriteLine();

            Console.WriteLine("Choose a Game");
            Console.Write("> ");
            string gameOption = Console.ReadLine();

            if (gameOption == "1")
            {
                DisplayBanner();
                game.StartingNumberOfCards = 2;
            }

            Console.WriteLine("Number of Players");
            Console.Write("> ");
            string playerNumber = Console.ReadLine();
            game.NumberOfPlayers = int.Parse(playerNumber);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            DisplayBanner();
            Game game = new Game();
            GameInit(game);

            DeckActions deckActions = new DeckActions();
            Deck newDeck = deckActions.CreateDeck();

            List<Player> playerList = deckActions.CreatePlayers(game);

            Console.WriteLine("First Deal");
            deckActions.Deal(game, newDeck, playerList);

            Console.WriteLine("Second Deal");
            deckActions.Deal(game, newDeck, playerList);


            Console.Write("Press Enter To Return To Main Menu");
            Console.ReadLine();
        }


    }
}
