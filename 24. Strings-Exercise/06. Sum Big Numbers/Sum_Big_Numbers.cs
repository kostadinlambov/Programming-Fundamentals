using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Sum_Big_Numbers
{
    public class Sum_Big_Numbers
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            if (firstNumber.Length >= secondNumber.Length)
            {
                SumNumbers(firstNumber, secondNumber);
            }
            else
            {
                SumNumbers(secondNumber, firstNumber);
            }
        }

        private static void SumNumbers(string firstNumber, string secondNumber)
        {
            var firstNumberReversed = firstNumber.Reverse().ToArray();
            var secondNumberReversed = secondNumber.Reverse().ToArray();
            var sumList = new List<int>();
            var remainder = 0;

            for (int i = 0; i < secondNumberReversed.Length; i++)
            {
                var sumOfTwoDigits = firstNumberReversed[i] - '0' + secondNumberReversed[i] - '0'
                    + remainder;
                if (sumOfTwoDigits > 9)
                {
                    remainder = sumOfTwoDigits / 10;
                    sumOfTwoDigits %= 10;
                }
                else
                {
                    remainder = 0;
                }
                sumList.Add(sumOfTwoDigits);
            }

            for (int i = secondNumberReversed.Length; i < firstNumberReversed.Length; i++)
            {
                var sumOfTwoDigits = firstNumberReversed[i] - '0' + remainder;
                if (sumOfTwoDigits > 9)
                {
                    remainder = sumOfTwoDigits / 10;
                    sumOfTwoDigits %= 10;
                }
                else
                {
                    remainder = 0;
                }
                sumList.Add(sumOfTwoDigits);
            }

            if (remainder > 0)
            {
                sumList.Add(remainder);
            }

            sumList.Reverse();

            for (int i = 0; i < sumList.Count; i++)
            {
                if (sumList[i] == 0)
                {
                    sumList.RemoveAt(i);
                    i--;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join("", sumList));
        }
    }
}
