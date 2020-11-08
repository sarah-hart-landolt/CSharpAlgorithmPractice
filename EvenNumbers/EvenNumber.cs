using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgorithmPractice.EvenNumbers
{
    //Given a list of numbers, output only the ones that are even

    class EvenNumber
    {

        public bool isEven(int num)
        {
            return num % 2 == 0;
        }
        public List<int> Even(List<int> numbersList)

        {
            return (from n in numbersList
                   where isEven(n)
                          select n).ToList();

        }

    }
}
