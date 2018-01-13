using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.Word_Count
{
    public class Word_Count
    {
        public static void Main()
        {
            var wordsToCountFile = "words.txt";
            var textFile = "input.txt";
            var outputFile = "output.txt";

            var wordsToCount = File.ReadAllText(wordsToCountFile)
                .Trim()
                .Split(' ')
                .ToArray();

            var separators = new char[] {' ', ',', '.', '?', '!', '\'','-'};

            var text = File.ReadAllText(textFile)
                .ToLower()
                .Trim()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var wordsCountDict = new Dictionary<string, int>();

            for (int i = 0; i < wordsToCount.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (wordsToCount[i] == text[j])
                    {
                        if (!wordsCountDict.ContainsKey(wordsToCount[i]))
                        {
                            wordsCountDict[wordsToCount[i]] = 0;
                        }

                        wordsCountDict[wordsToCount[i]]++;
                    }                  
                }         
            }

            var sortedWords = wordsCountDict
                .OrderByDescending(x => x.Value)
                .Select(x => $"{x.Key} - {x.Value}")
                .ToArray();

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }

            File.WriteAllLines(outputFile, sortedWords);
        }
    }
}
