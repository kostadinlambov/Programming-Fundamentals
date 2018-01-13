using System;
using System.Linq;

public class Sort_Numbers
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(decimal.Parse)
            .ToList();

        inputNumbers.Sort();

        Console.WriteLine(string.Join(" <= ", inputNumbers));
    }
}