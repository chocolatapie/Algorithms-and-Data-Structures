using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritms_and_DataStructures.ReversLettersOnly
{
    public static class LettersReverser
    {
        public static string ReverseLettersOnly(string input)
        {
            List<char> allSymbols = input.ToList();
            List<char> reversedLetters = new List<char>();

            int inputLength = input.Length;
            for (int i = inputLength - 1; i > -1; i--)
            {
                if (char.IsLetter(input[i]))
                    reversedLetters.Add(input[i]);
            }

            int revLettersCounter = 0;
            for (int i = 0; i < inputLength; i++)
            {
                if (char.IsLetter(allSymbols[i]))
                {
                    allSymbols[i] = reversedLetters[revLettersCounter];
                    revLettersCounter++;
                }
            }

            StringBuilder result = new StringBuilder();
            foreach (char symbol in allSymbols)
            {
                result.Append(symbol);
            }

            return result.ToString();
        }
    }
}
