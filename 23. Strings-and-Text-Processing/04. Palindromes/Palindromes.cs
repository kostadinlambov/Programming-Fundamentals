using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] { ' ', ',', '?', '!', '.' },
                    StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var listOFPalindromes = new List<string>();
     
            foreach (var word in text)
            {
                var reversedWord = new string(word.Reverse().ToArray());

                if (word.CompareTo(reversedWord) == 0)
                {
                    listOFPalindromes.Add(word);
                }
            }

            listOFPalindromes.Sort();

            Console.WriteLine(string.Join(", ", listOFPalindromes.Distinct()));
        }
    }
}
