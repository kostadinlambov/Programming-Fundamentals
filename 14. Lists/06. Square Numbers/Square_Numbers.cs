using System;
using System.Collections.Generic;
using System.Linq;

public class Square_Numbers
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var listOfSquareNumbers = new List<int>();

        for (int i = 0; i < inputNumbers.Count; i++)
        {
            if (Math.Sqrt(inputNumbers[i]) == (int)Math.Sqrt(inputNumbers[i]))
            {
                listOfSquareNumbers.Add(inputNumbers[i]);
            }
        }

        listOfSquareNumbers.Sort();
        listOfSquareNumbers.Reverse();

        Console.WriteLine(string.Join(" ", listOfSquareNumbers));
    }
}

