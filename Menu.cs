using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmPractice
{
    public static class MenuSelection
    {

        public static int Menu()
        {
            int selection = -1;

            while (selection < 0 || selection > 9)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine(" 1) Build a Deck of Cards & Shuffle them");
                Console.WriteLine(" 2) Generate Prime Numbers from a list");
                Console.WriteLine(" 3) Output only even numbers from a list");
                Console.WriteLine(" 4) Find most used character in a string");
                Console.WriteLine(" 5) Play Fizzbuzz");
                Console.WriteLine(" 0) Exit");

                Console.Write("> ");
                string choice = Console.ReadLine();
                try
                {
                    selection = int.Parse(choice);
                }
                catch
                {
                    Console.WriteLine("Invalid Selection. Please try again.");
                }
                Console.WriteLine();
            }

            return selection;
        }
    }
}
