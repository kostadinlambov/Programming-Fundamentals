using System;
using System.Linq;

public class Count_Numbers
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        inputNumbers.Sort();

        var count = 1;

        for (int i = 0; i < inputNumbers.Count; i++)
        {
            var number = inputNumbers[i];

            if ((i < inputNumbers.Count-1 && inputNumbers[i] != inputNumbers[i+1])
                || i == inputNumbers.Count-1)
            {
                Console.WriteLine($"{number} -> {count}");
                count = 0;           
            }
            count++;
        }
    }
}

