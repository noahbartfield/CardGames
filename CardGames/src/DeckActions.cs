﻿using System;
using System.Collections.Generic;
using CardGames.Classes;

namespace CardGames
{
    public class DeckActions
    {
        public Deck CreateDeck()
        {
            Deck deck = new Deck();
            Card two = new Card()
            {
                Name = "two",
                Value = 2
            };

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

            deck.Cards = createNumberCards();

            createPicturesAndAces().ForEach(card =>
            {
                deck.Cards.Add(card);
            });
            return deck;
        }
        public Deck Shuffle(Deck deck)
        {
            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(52, 300); i++)
            {
                int fiftyTwo = rnd.Next(52);
                Card randomCard = deck.Cards[fiftyTwo];
                deck.Cards.Remove(randomCard);
                deck.Cards.Add(randomCard);
            }

            return deck;
        }
    }
}
