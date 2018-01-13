using System;
using System.Linq;

public class Odd_Filter
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < inputNumbers.Count; i++)
        {
            if (inputNumbers[i] % 2 == 1)
            {
                inputNumbers.RemoveAt(i);
                i = -1;
            }
        }

        var changedNumbersArr = inputNumbers.ToArray();

        for (int i = 0; i < inputNumbers.Count; i++)
        {
            if (inputNumbers[i] > inputNumbers.Average())
            {
                changedNumbersArr[i]++;
            }
            else
            {
                changedNumbersArr[i]--;
            }
        }

        Console.WriteLine(string.Join(" ", changedNumbersArr));
    }
}