using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Magic_Exchangeable_Words
{
    public class Magic_Exchangeable_Words
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .ToArray();

            CompareWords(inputLine[0], inputLine[1]);
        }

        private static void CompareWords(string firstWord, string secondWord)
        {
            if (firstWord.Length >= secondWord.Length)
            {
                CheckIfWordsAreExchangeable(firstWord, secondWord);
            }
            else
            {
                CheckIfWordsAreExchangeable(secondWord, firstWord);
            }
        }

        private static void CheckIfWordsAreExchangeable(string firstWord, string secondWord)
        {
            var wordsDictionary = new Dictionary<char, char>();

            for (int i = 0; i < secondWord.Length; i++)
            {
                if (!wordsDictionary.ContainsKey(firstWord[i]))
                {
                    wordsDictionary[firstWord[i]] = secondWord[i];
                }
                else
                {
                    if (wordsDictionary[firstWord[i]] != secondWord[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            for (int i = secondWord.Length; i < firstWord.Length; i++)
            {
                if (!wordsDictionary.ContainsKey(firstWord[i]))
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
        }
    }
}