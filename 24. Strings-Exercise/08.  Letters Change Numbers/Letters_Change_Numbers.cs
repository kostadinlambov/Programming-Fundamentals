using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _08.Letters_Change_Numbers
{
    public class Letters_Change_Numbers
    {
        public static void Main()
        {
            var inputString = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var totalSum = 0m;

            foreach (var sequence in inputString)
            {
                var firstLetter = sequence.First();
                var numberString = new string(sequence
                    .Where(char.IsDigit)
                    .ToArray());
                var number = decimal.Parse(numberString);
                var lastLetter = sequence.Last();

                var sum = 0m;

                if (char.IsUpper(firstLetter))
                {
                    sum = number / (firstLetter - 'A' + 1);
                }
                else
                {
                    sum = number * (firstLetter - 'a' + 1);
                }

                if (char.IsUpper(lastLetter))
                {
                    sum -= lastLetter - 'A' + 1;
                }
                else
                {
                    sum += lastLetter - 'a' + 1;
                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}