﻿using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Use_Your_Chains__Buddy
{
    public class Use_Your_Chains__Buddy
    {
        public static void Main()
        {
            var paragraphRegex = new Regex(@"<p>(?<message>.+?)<\/p>");

            var text = Console.ReadLine();

            var paragraphs = paragraphRegex.Matches(text)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z\d]", " "))
                .Select(a => Regex.Replace(a, @"\s+", " "))
                .ToArray();

            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13String(paragraphs[i]);
            }

            var result = new StringBuilder();

            foreach (var paragraph  in paragraphs)
            {
                result.Append(paragraph);
            }

            Console.WriteLine(result.ToString());
        }

        private static string Rot13String(string input)
        {
            var result = new StringBuilder();

            foreach (var letter in input)
            {
                result.Append(Rot13(letter));
            }

            return result.ToString();
        }

        private static char Rot13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }

            var offset = char.IsUpper(letter) ? 'A' : 'a';

            var rotatedLetter = (char)((letter - offset + 13) % 26 + offset);

            return rotatedLetter;
        }
    }
}
