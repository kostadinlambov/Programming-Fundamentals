using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.Only_Letters
{
    public class Only_Letters
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var pattern = @"\d+";
            var regex = new Regex(pattern);

            var splitInputLine = regex
                .Split(inputLine)
                .ToArray();

            var outputMessage = new StringBuilder();

            outputMessage.Append(splitInputLine[0]);

            for (int i = 1; i < splitInputLine.Length; i++)
            {
                var firstChar = new string(splitInputLine[i].Take(1).ToArray());
                outputMessage.Append(firstChar);
                outputMessage.Append(splitInputLine[i]);
            }

            MatchCollection matches = regex.Matches(inputLine);

            if (matches.Count > 0)
            {
                var lastMatch = matches
                    .Cast<Match>()
                    .Last();

                if (char.IsDigit(inputLine[inputLine.Length - 1]))
                {
                    outputMessage.Append(lastMatch.Value);
                    Console.WriteLine(outputMessage.ToString());                 
                }
                else
                {
                    Console.WriteLine(outputMessage.ToString());
                }

                return;
            }

            Console.WriteLine(outputMessage.ToString());
        }
    }
}
