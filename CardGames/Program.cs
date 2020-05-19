using System;
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
            Deck newDeck = deckActions.CreateDeck();

            deckActions.Shuffle(newDeck);

            int counter = 0;
            newDeck.Cards.ForEach(card =>
            {
                Console.WriteLine($"{card.Name}, {card.Suit}");
                counter += 1;
            });

            Console.WriteLine(counter);

            
                Console.Write("Press Enter To Return To Main Menu");
                Console.ReadLine();
            }
        }
    }
