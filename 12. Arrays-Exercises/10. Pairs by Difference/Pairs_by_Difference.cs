using System;
using System.Linq;

public class Pairs_by_Difference
{
    public static void Main()
    {
        var numbersArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var numberToCompare = int.Parse(Console.ReadLine());

        var count = 0;

        for (int i = 0; i < numbersArr.Length; i++)
        {
            for (int j = 0; j < numbersArr.Length; j++)
            {
                var difference = numbersArr[i] - numbersArr[j];

                if (difference == numberToCompare)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}

