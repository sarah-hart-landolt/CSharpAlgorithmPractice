using CSharpAlgorithmPractice.CardDeck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpAlgorithmPractice.FizzBuzzChallenge;

namespace CSharpAlgorithmPractice.Programs
{
    class FizzBuzzProgram : IProgramExecute
    {
        public int SortOrder()
        {
            return 5;
        }

        public void Execute()
        {
            var FizzBuzz = new FizzBuzz();

            var numberList = Enumerable.Range(1, 100).ToList();

            FizzBuzz.FizzBuzzOutput(numberList);
        }

        public string GetMenuTitle()
        {
            return "Play Fizzbuzz";
        }
    }
}