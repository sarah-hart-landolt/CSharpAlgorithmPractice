using CSharpAlgorithmPractice.CardDeck;
using CSharpAlgorithmPractice.Char;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmPractice.Programs
{
    class MostUsedCharacterProgram : IProgramExecute
    {
        public int SortOrder()
        {
            return 4;
        }

        public void Execute()
        {
            var character = new CharacterFunction();

            string Character = character.MostPopularCharacter("Sarah is the most awesome junior coder that I've ever seen");
            Console.WriteLine(Character);

            var character1 = new CharacterFunction();

            string Character1 = character1.MostPopularCharacter("I need to go to bed. I've been coding for too long. I've made this way too complicated.");
            Console.WriteLine(Character1);
        }

        public string GetMenuTitle()
        {
            return "Find most used character in a string";
        }
    }
}