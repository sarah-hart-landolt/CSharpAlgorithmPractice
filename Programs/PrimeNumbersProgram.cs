using CSharpAlgorithmPractice.CardDeck;
using CSharpAlgorithmPractice.PrimeNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmPractice.Programs
{
    class PrimeNumbersProgram : IProgramExecute
    {
        public int SortOrder()
        {
            return 2;
        }
        public void Execute()
        {
            var primeNumber = new PrimeNumbers();

            var number = primeNumber.RandomNumber(0, 5000);

            primeNumber.PrimeNumberString(number);
        }

        public string GetMenuTitle()
        {
            return "Generate Prime Numbers from a list";
        }
    }
}