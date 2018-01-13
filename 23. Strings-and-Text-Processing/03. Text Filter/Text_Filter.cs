using System;
using System.Linq;

namespace _03.Text_Filter
{
    public class Text_Filter
    {
        public static void Main()
        {           
            var bannedWords = Console.ReadLine()
                .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var text = Console.ReadLine();

            var replacedBannedWords = text;

            for (int i = 0; i < bannedWords.Length; i++)
            {
                replacedBannedWords = replacedBannedWords.Replace(bannedWords[i],
                    new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(replacedBannedWords);
        }
    }
}
