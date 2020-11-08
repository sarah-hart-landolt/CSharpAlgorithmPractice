using CSharpAlgorithmPractice.CardDeck;
using CSharpAlgorithmPractice.EvenNumbers;
using CSharpAlgorithmPractice.PrimeNumber;
using CSharpAlgorithmPractice.FizzBuzzChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using CSharpAlgorithmPractice.Char;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;

namespace CSharpAlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the C# Algorithm Practice!");

            
                Console.WriteLine();

                int selection = MenuSelection.Menu();
                switch (selection)
                {
                    case 1:
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

                        break;
                    case 2:
                        var primeNumber = new PrimeNumbers();

                        var number = primeNumber.RandomNumber(0, 5000);

                        primeNumber.PrimeNumberString(number);


                        break;
                    case 3:
                        var evenNumber = new EvenNumber();

                        List<int> LstACValues = new List<int> { 1, 7, 2, 5, 10, 16 };


                        Console.WriteLine("Enter a list of numbers, separated by commas, e.g. 1,2,3,4");

                        string Numbers = Console.ReadLine();

                        var numbers = Numbers.Split(',')
                                      .Where(x => int.TryParse(x, out _))
                                      .Select(int.Parse);

                        foreach (int num in numbers)
                        {
                            LstACValues.Add(num);
                        }

                        var evenList = evenNumber.Even(LstACValues);

                        foreach (int even in evenList)
                        {
                            Console.WriteLine(even);
                        }

                        break;
                    case 4:
                        var character = new CharacterFunction();

                        string Character = character.MostPopularCharacter("Sarah is the most awesome junior coder that I've ever seen");
                        Console.WriteLine(Character);

                        var character1 = new CharacterFunction();

                        string Character1 = character1.MostPopularCharacter("I need to go to bed. I've been coding for too long. I've made this way too complicated.");
                        Console.WriteLine(Character1);


                        break;
                    case 5:

                        var FizzBuzz = new FizzBuzz();

                        var numberList = Enumerable.Range(1, 100).ToList();

                        FizzBuzz.FizzBuzzOutput(numberList);

                        break;
                    case 0:
                        Console.WriteLine("Goodbye");
                        return;
                    default:
                        throw new Exception("Something went wrong...invalid selection");
                }
            
        }

        


          


          


        
    }
}
