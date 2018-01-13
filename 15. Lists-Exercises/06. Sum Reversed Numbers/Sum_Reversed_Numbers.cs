using System;
using System.Collections.Generic;
using System.Linq;

public class Sum_Reversed_Numbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(' ')           
            .ToList();

        var numbersWithReversedDigitsList = new List<string>();

        for (int i = 0; i < numbers.Count; i++)
        {
            var reversedNumber = ReversNumber(numbers[i]);

            numbersWithReversedDigitsList.Add(reversedNumber);
        }

        var sumNumbers = numbersWithReversedDigitsList
            .Select(int.Parse)
            .Sum();

        Console.WriteLine(sumNumbers);
    }

    public static string ReversNumber(string numberToReverse)
    {
        var reversedNumber = string.Empty;

        for (int j = 0; j < numberToReverse.Length; j++)
        {
            reversedNumber += numberToReverse[numberToReverse.Length - 1 - j];
        }

        return reversedNumber;
    }
}

