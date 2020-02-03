using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritms_and_DataStructures.StringAlgorythms
{
    public static class CustomStringAlgorythms
    {
        public static bool AreAllSymbolsUnique(string input)
        {
            int inputLength = input.Length;
            for (int i = 0; i < inputLength - 1; i++)
            {
                for (int j = i + 1; j < inputLength; j++)
                {
                    if (input[i] == input[j])
                        return false;
                }
            }
            return true;
        }

        public static bool IsPermutation(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                return false;

            int length = input1.Length;

            List<char> firstString = input1.ToList();
            List<char> secondString = input2.ToList();

            firstString.Sort();
            secondString.Sort();

            for (int i = 0; i < length; i++)
            {
                if (firstString[i] != secondString[i])
                    return false;
            }

            return true;
        }

        public static string StringCompress(string input)
        {
            StringBuilder myStrBuilder = new StringBuilder();
            int strLength = input.Length;
            int counter = 0;

            for (int i = 0; i < strLength; i++)
            {
                counter++;

                if (i + 1 >= strLength || input[i] != input[i + 1])
                {
                    myStrBuilder.Append(input[i]);
                    myStrBuilder.Append(counter);
                    counter = 0;
                }
            }

            string retStr = myStrBuilder.ToString();
            if (retStr.Length >= input.Length)
                return input;

            return retStr;
        }
    }
}
