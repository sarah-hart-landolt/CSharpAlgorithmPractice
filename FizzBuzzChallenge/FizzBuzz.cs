using System;
using System.Collections.Generic;


namespace CSharpAlgorithmPractice.FizzBuzzChallenge
{
    public class FizzBuzz
    {

        public static bool IsFizz(int num)
        {
            if (num % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsBuzz(int num)
        {
            if (num % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsFizzBuzz(int num)
        {
            if (IsFizz(num) && IsBuzz(num))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ConsoleOutput(int Number, string Variable)
        {
            Console.WriteLine($"{Number}: {Variable}");

        }

        public void FizzBuzzOutput(List<int> Numbers)
        {

            foreach (int Number in Numbers)
            {
                if (IsFizzBuzz(Number))
                {

                    ConsoleOutput(Number, "FizzBuzz");
                }
                else if (IsFizz(Number) && !IsBuzz(Number))
                {
                    ConsoleOutput(Number, "Fizz");

                }
                else if (IsBuzz(Number) && !IsFizz(Number))
                {
                    ConsoleOutput(Number, "Buzz");

                }
            }
        }


    }



}
