using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace _1.Convert_from_Base_10_to_Base_N
{
   public class Convert_from_Base_10_to_Base_N
    {
        public static void Main()
        {
            var stack = new Stack<BigInteger>();
            var digits = "0123456789ABCDEF";

            var inputNumbers = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            var newBase= inputNumbers[0];
            var base10NumberToBeConverted = inputNumbers[1];

            while (base10NumberToBeConverted > 0)
            {
                BigInteger remainder = base10NumberToBeConverted % newBase;
                stack.Push(remainder);
                base10NumberToBeConverted = base10NumberToBeConverted /newBase;
            }

            var convertedNumber = string.Empty;

            while (stack.Count > 0)
            {
                var newNumber = stack.Pop();
                convertedNumber += digits[(int)newNumber];
            }

            Console.WriteLine(convertedNumber);
        }
    }
}
