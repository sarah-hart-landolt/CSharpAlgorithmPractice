using CSharpAlgorithmPractice.CardDeck;
using CSharpAlgorithmPractice.PrimeNumber;
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

            var primeNumber = new PrimeNumbers();

            var number = primeNumber.RandomNumber(0, 5000);

            primeNumber.PrimeNumberString(number);
            



        }
    }
}
