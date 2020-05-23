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

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            DisplayBanner();

            DeckActions deckActions = new DeckActions();
            Game game = new Game();
            game.NumberOfPlayers = 4;
            game.StartingNumberOfCards = 2;
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
