using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.Hideout
{
    public class Hideout
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (true)
            {
                var clue = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var pattern = $"\\{clue[0]}+";
                var minimumCountOfChars = int.Parse(clue[1]);

                var regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(inputLine);

                foreach (Match match in matches)
                {
                    if (match.Length >= minimumCountOfChars)
                    {
                        Console.WriteLine($"Hideout found at index {match.Index}" +
                                          $" and it is with size {match.Length}!");
                        return;
                    }
                }
            }
        }
    }
}
