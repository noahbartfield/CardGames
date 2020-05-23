using System;
using System.Collections.Generic;
using CardGames.Classes;
using CardGames.src.Classes;

namespace CardGames
{
    public class DeckActions
    {
        //Create Deck
        public Deck CreateDeck()
        {
            Console.WriteLine("CreateDeck");

            Deck deck = new Deck();
            Card two = new Card()
            {
                Name = "two",
                Value = 2
            };

            //Create Number Cards 2-10 of All Suits
            List<Card> createNumberCards()
            {
                List<Card> cards = new List<Card>();
                for (int i = 0; i < 9; i++)
                {
                    Card card = new Card()
                    {
                        Suit = "Spades",
                        Value = i + 2
                    };
                    card.Name = card.Value.ToString();
                    cards.Add(card);
                }
                for (int i = 0; i < 9; i++)
                {
                    Card card = new Card()
                    {
                        Suit = "Clubs",
                        Value = i + 2
                    };
                    card.Name = card.Value.ToString();
                    cards.Add(card);
                }
                for (int i = 0; i < 9; i++)
                {
                    Card card = new Card()
                    {
                        Suit = "Hearts",
                        Value = i + 2
                    };
                    card.Name = card.Value.ToString();
                    cards.Add(card);
                }
                for (int i = 0; i < 9; i++)
                {
                    Card card = new Card()
                    {
                        Suit = "Diamonds",
                        Value = i + 2
                    };
                    card.Name = card.Value.ToString();
                    cards.Add(card);
                }
                return cards;
            }

            //Create Picture Cards and Aces of All Suits
            List<Card> createPicturesAndAces()
            {
                List<Card> picturesAndAces = new List<Card>();
                for (int i = 0; i < 4; i++)
                {
                    Card ace = new Card()
                    {
                        Name = "Ace",
                        Value = 1
                    };
                    Card king = new Card()
                    {
                        Name = "King",
                        Value = 10
                    };
                    Card queen = new Card()
                    {
                        Name = "Queen",
                        Value = 10
                    };
                    Card jack = new Card()
                    {
                        Name = "Jack",
                        Value = 10
                    };
                    picturesAndAces.Add(ace);
                    picturesAndAces.Add(king);
                    picturesAndAces.Add(queen);
                    picturesAndAces.Add(jack);
                }

                for (int i = 0; i < picturesAndAces.Count; i++)
                {
                    if (i < 4)
                    {
                        picturesAndAces[i].Suit = "Spades";
                    }
                    else if (i < 8)
                    {
                        picturesAndAces[i].Suit = "Clubs";
                    }
                    else if (i < 12)
                    {
                        picturesAndAces[i].Suit = "Hearts";
                    }
                    else if (i < 16)
                    {
                        picturesAndAces[i].Suit = "Diamonds";
                    }
                };

                return picturesAndAces;
            }

            //Put It All Together
            deck.Cards = createNumberCards();
            createPicturesAndAces().ForEach(card =>
            {
                deck.Cards.Add(card);
            });
            return deck;
        }

        //Shuffle Deck
        public Deck Shuffle(Deck deck)
        {
            Console.WriteLine("Shuffle");

            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(52, 300); i++)
            {
                int random = rnd.Next(52);
                Card randomCard = deck.Cards[random];
                deck.Cards.Remove(randomCard);
                deck.Cards.Add(randomCard);
            }

            return deck;
        }

        //Create Players
        public List<Player> CreatePlayers(Game game)
        {
            Console.WriteLine("CreatePlayers");

            List<Player> playerList = new List<Player>();

            for (int i = 0; i < game.NumberOfPlayers; i++)
            {
                Player player = new Player()
                {
                    Name = $"Player {i + 1}"
                };
                playerList.Add(player);
            }
            return playerList;
        }

        //Deal Cards
        public void Deal(Game game, Deck deck, List<Player> playerList)
        {
            Console.WriteLine("Deal");

            Deck shuffledDeck = deck.Cards.Count == 52 ? Shuffle(deck) : deck;

            playerList.ForEach(player =>
            {
                for (int i = 0; i < game.StartingNumberOfCards; i++)
                {
                    Card index0 = shuffledDeck.Cards[0];
                    shuffledDeck.Cards.Remove(index0);
                    if (player.Hand == null)
                    {
                        player.Hand = new List<Card>();
                    }
                    player.Hand.Add(index0);
                }
            });

            playerList.ForEach(player =>
            {
                player.Hand.ForEach(card =>
                {
                    Console.WriteLine(card.Name);
                    Console.WriteLine(card.Color);
                    Console.WriteLine(card.Suit);
                    Console.WriteLine(player.Name);
                });
            });

            Console.WriteLine(shuffledDeck.Cards.Count);
        }
    }
}
