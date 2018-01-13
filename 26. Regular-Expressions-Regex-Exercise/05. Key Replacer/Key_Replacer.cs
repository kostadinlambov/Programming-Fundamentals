using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    public class Key_Replacer
    {
        public static void Main()
        {
            var keysString = Console.ReadLine();
            var text = Console.ReadLine();

            var firstMatchPattern = @"\b(?<start>[A-Za-z]+)(<|\||\\).*(<|\||\\)(?<end>[A-Za-z]+)\b";
            var regex = new Regex(firstMatchPattern);
            Match match = regex.Match(keysString);
            
            var startKey = string.Empty;
            var endKey = string.Empty;

            if (match.Success)
            {
                startKey = match.Groups["start"].Value;
                endKey = match.Groups["end"].Value;
            }

            var secondMatchPattern = $"{startKey}(.*?)?{endKey}";          
            var secondRegex = new Regex(secondMatchPattern);
            MatchCollection matches = secondRegex.Matches(text);

            var listOfMatches = new List<string>();

            foreach (Match newMatch in matches)
            {
                if (!newMatch.Groups[1].Value.Equals(String.Empty))
                {
                    listOfMatches.Add(newMatch.Groups[1].Value);
                }            
            }

            Console.WriteLine(listOfMatches.Count > 0 ? string.Join("", listOfMatches) : "Empty result");
        }
    }
}
