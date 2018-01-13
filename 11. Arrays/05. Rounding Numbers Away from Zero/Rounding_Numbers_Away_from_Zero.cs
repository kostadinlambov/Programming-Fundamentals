using System;
using System.Linq;

public class Rounding_Numbers_Away_from_Zero
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine();

        var numbersArr = inputNumbers
            .Split(' ')
            .Select(decimal.Parse)
            .ToArray();

        for (int i = 0; i < numbersArr.Length; i++)
        {
            var roundedNumber = Math.Round(numbersArr[i],MidpointRounding.AwayFromZero);
            Console.WriteLine($"{numbersArr[i]} => {roundedNumber}");
        }
    }
}

