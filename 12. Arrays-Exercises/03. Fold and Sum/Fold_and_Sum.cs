using System;
using System.Linq;

public class Fold_and_Sum
{
    public static void Main()
    {

        var inputArr = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var firstRowFront = inputArr
            .Take(inputArr.Length / 4)
            .Reverse()
            .ToArray();

        var firstRowBack = inputArr
            .Reverse()
            .Take(inputArr.Length / 4)
            .ToArray();

        var firstRow = firstRowFront
            .Concat(firstRowBack)
            .ToArray();

        var secondRow = inputArr
            .Skip(inputArr.Length / 4)
            .Take(inputArr.Length / 2)
            .ToArray();

        var sum = new int[inputArr.Length / 2];

        for (int i = 0; i < inputArr.Length / 2; i++)
        {
            sum[i] = firstRow[i] + secondRow[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}