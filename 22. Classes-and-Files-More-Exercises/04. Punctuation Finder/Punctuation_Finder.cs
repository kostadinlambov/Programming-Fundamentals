using System;
using System.Collections.Generic;
using System.IO;

namespace _04.Punctuation_Finder
{
    public class Punctuation_Finder
    {
        public static void Main()
        {
            var inputText = File.ReadAllText("../../sample_text.txt");

            var separators = new char[] {'.', ',', '!', '?', ':'};

            var punctuationMarksList = new List<char>();

            for (int i = 0; i < inputText.Length; i++)
            {
                for (int j = 0; j < separators.Length; j++)
                {
                    if (inputText[i] == separators[j])
                    {
                        punctuationMarksList.Add(inputText[i]);
                    }
                }
            }

            var outputText = string.Join(", ", punctuationMarksList);
            Console.WriteLine(outputText);

            File.WriteAllText("output.txt", outputText);
        }
    }
}
