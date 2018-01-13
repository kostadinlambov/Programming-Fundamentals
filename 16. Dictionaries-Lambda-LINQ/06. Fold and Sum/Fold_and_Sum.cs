using System;
using System.Collections.Generic;
using System.Linq;

public class Fold_and_Sum
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var firstRowFront = numbers
            .Take(numbers.Count / 4)
            .Reverse()
            .ToList();

        var firstRowBack = numbers
            .Skip(numbers.Count * 3 / 4)
            .Reverse()
            .ToList();
       
        var firstRow = firstRowFront
            .Concat(firstRowBack)
            .ToList();

        var secondRow = numbers
            .Skip(numbers.Count / 4)
            .Take(numbers.Count / 2)
            .ToList();

        var sum = new List<int>();

        for (int i = 0; i < firstRow.Count; i++)
        {
            sum.Add(firstRow[i] + secondRow[i]);
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}