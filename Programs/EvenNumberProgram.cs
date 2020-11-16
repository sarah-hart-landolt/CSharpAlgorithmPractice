using CSharpAlgorithmPractice.CardDeck;
using CSharpAlgorithmPractice.EvenNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgorithmPractice.Programs
{
    class EvenNumberProgram : IProgramExecute
    {
        public int SortOrder()
        {
            return 3;
        }
        public void Execute()
        {
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
        }

        public string GetMenuTitle()
        {
            return "Output only even numbers from a list";
        }
    }
}