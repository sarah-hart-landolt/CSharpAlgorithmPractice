using CSharpAlgorithmPractice.CardDeck;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmPractice.Programs
{
    class ShuffleCardsProgram : IProgramExecute
    {
        public int SortOrder()
        {
            return 1;
        }

        public void Execute()
        {
            var deck = new Deck();
            deck.Shuffle();

            foreach (var card in deck.Cards)
            {
                string String = $"{card.CardNumber} of {card.Suit}s";
                if (card.Suit == Suit.Spades)
                {
                    string SansS = String.Remove(String.Length - 1, 1);

                    Console.WriteLine(SansS);
                }
                else
                {
                    Console.WriteLine(String);
                }

            }
        }

        public string GetMenuTitle()
        {
            return "Build a Deck of Cards & Shuffle them";
        }
    }
}