using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    public class Match_Phone_Number
    {
        public static void Main()
        {
            var phones = Console.ReadLine();
            var pattern = @"\+[359]{3}(-| )[2](\1)[0-9]{3}(\1)[0-9]{4}\b";

            var regex =  new Regex(pattern);

            MatchCollection matches = regex.Matches(phones);

            List<string> matchedPhones = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
