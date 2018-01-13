using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Multiply_Big_Number
{
    public class Multiply_Big_Number
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            SumNumbers(firstNumber, secondNumber);
        }

        private static void SumNumbers(string firstNumber, string secondNumber)
        {
            var firstNumberReversed = firstNumber.Reverse().ToArray();
            var sumList = new List<int>();
            var remainder = 0;

            for (int i = 0; i < firstNumberReversed.Length; i++)
            {
                var sumOfTwoDigits = (firstNumberReversed[i] - '0') * (secondNumber[0] - '0')
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

            if (sumList.Sum() < 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(string.Join("", sumList));
            }
        }
    }
}

