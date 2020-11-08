using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmPractice.PrimeNumber
{
    public class PrimeNumbers
    {

      
        private readonly Random _random = new Random();

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public void PrimeNumberString(int number)
        {
            var result = IsPrimeNumber(number);

            if (result)
            {
                Console.WriteLine($"{number} is a prime number");

            } else
            {
                Console.WriteLine($"{number} is not a prime number");

            }

        }

        //Create a function named isPrime. 
        //This function should accept a single integer as an argument 
        //and return true if it is a prime number or return false if it is not
        public bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;

        }

       
    }
}
