using CSharpAlgorithmPractice.CardDeck;
using System;

namespace CSharpAlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.Shuffle();

            foreach (var card in deck.Cards)
            {
                string String = $"{card.CardNumber} of {card.Suit}s";
                if(card.Suit== Suit.Spades)
                {
                    string SansS = String.Remove(String.Length - 1, 1);

                    Console.WriteLine(SansS);
                }
                else
                {
                    Console.WriteLine(String);
                }

            }

            Console.WriteLine(deck.Cards.Count);



        }
    }
}
