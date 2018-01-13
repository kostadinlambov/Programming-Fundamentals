using System;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    public class Match_Dates
    {
        public static void Main()
        {
            var inputDates = Console.ReadLine();

            var pattern = @"\b(?<day>\d{2})(.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var regex = new Regex(pattern);

            MatchCollection dates = regex.Matches(inputDates);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
