using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CSharpAlgorithmPractice.Char
{
    class CharacterFunction
    {

        //Given a string, create a function that outputs the character that appears most often
        List<Character> characters = new List<Character>();

        public bool IsEnglishLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public string MostPopularCharacter(string String)
        {

            var lowercase = String.ToLower();

            List<string> StringCharacters = new List<string>();

            var count = 0; 
            for (int i = 0; i < lowercase.Length; i++)
            {
                if (IsEnglishLetter(lowercase[i]))
                {
                    StringCharacters.Add(lowercase[i].ToString());

                }

            }

            var uniqueCharacters = StringCharacters.Distinct().ToList();


            foreach (var letter in uniqueCharacters)
            {

                 count = StringCharacters.Count(x => x == letter);
                var Character = new Character()
                {
                    Count = count,
                    Char = letter
                };

                characters.Add(Character);


            }
            var Int = characters.Select(c => c.Count).Max();

            var IsIt= characters.FirstOrDefault(c => c.Count == Int);

            return IsIt.Char;


        }
    }
}
