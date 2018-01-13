using System;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    public class Match_Numbers
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var regex = new Regex(pattern);

            MatchCollection numbers = regex.Matches(inputString);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
