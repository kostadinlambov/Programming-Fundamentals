using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Numbers
{
    public class Match_Hexadecimal_Numbers
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine();

            var pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputNumbers);

            var matchedHexNumbers = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", matchedHexNumbers));
        }
    }
}
