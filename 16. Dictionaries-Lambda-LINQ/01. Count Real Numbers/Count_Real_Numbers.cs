using System;
using System.Collections.Generic;
using System.Linq;

public class Count_Real_Numbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(decimal.Parse)
            .ToList();

        var numberOfOccurences = new Dictionary<decimal, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (!numberOfOccurences.ContainsKey(numbers[i]))
            {
                numberOfOccurences[numbers[i]] = 0;
            }

            numberOfOccurences[numbers[i]]++;
        }

        foreach (var number in numberOfOccurences.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }
}

