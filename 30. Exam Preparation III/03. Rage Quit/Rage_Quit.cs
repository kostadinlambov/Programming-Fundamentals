using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3___Rage_Quit
{
    public class Rage_Quit
    {
        public static void Main()
        {
            var chochkosRage = Console.ReadLine();

            var pattern = @"(?<letters>.*?)(?<digits>\d+)";
            var matches = Regex.Matches(chochkosRage, pattern);

            var rageMessage = new StringBuilder();

            foreach (Match match in matches)
            {
                var currentMessage = match.Groups["letters"].Value;
                var repeatCount = int.Parse(match.Groups["digits"].Value);

                for (int i = 0; i < repeatCount; i++)
                {
                    rageMessage.Append(currentMessage);
                }
            }

            var uniqueSymbolsCount = rageMessage
                .ToString()
                .ToUpper()
                .Distinct()
                .Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(rageMessage.ToString().ToUpper());

        }
    }
}
