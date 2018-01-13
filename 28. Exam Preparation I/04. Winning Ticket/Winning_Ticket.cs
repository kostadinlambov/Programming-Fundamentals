using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    public class Winning_Ticket
    {
        public static void Main()
        {
            var inputLine = Regex.Split(Console.ReadLine(), @"\s*,\s*")
                .Select(t => t.Trim())
                .Where(t => t.Length > 0)
                .ToArray();

            foreach (var t in inputLine)
            {
                if (t.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftSide = t.Substring(0, 10);
                    var rightSide = t.Substring(10);
                    var leftLongestSequence = FindMaxEqualSeq(leftSide);
                    var rightLongestSequence = FindMaxEqualSeq(rightSide);
                    var leftChar = leftLongestSequence[0];
                    var rightChar = rightLongestSequence[0];
                    if (leftLongestSequence.Length >= 6 && rightLongestSequence.Length >= 6
                        && leftChar == rightChar && "@#$^".Contains(leftChar))
                    {
                        var count = Math.Min(leftLongestSequence.Length,
                            rightLongestSequence.Length);

                        Console.Write($"ticket \"{t}\" - {count}{leftChar}");
                        if (count == 10)
                        {
                            Console.WriteLine(" Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{t}\" - no match");
                    }
                }
            }
        }

        static string FindMaxEqualSeq(string s)
        {
            var bestStr = "" + s[0];
            var max = 1;
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                var count = 1;
                while (i + count < s.Length && s[i + count] == s[i])
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        bestStr = s.Substring(i, count);
                    }
                }
            }

            return bestStr;
        }
    }
}
