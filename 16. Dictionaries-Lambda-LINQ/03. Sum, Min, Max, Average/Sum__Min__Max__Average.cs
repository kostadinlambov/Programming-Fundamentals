using System;
using System.Collections.Generic;
using System.Linq;

public class Sum__Min__Max__Average
{
    public static void Main()
    {

        var n = int.Parse(Console.ReadLine());

        var listOfNumbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            listOfNumbers.Add(number);
        }

        Console.WriteLine($"Sum = {listOfNumbers.Sum()}");
        Console.WriteLine($"Min = {listOfNumbers.Min()}");
        Console.WriteLine($"Max = {listOfNumbers.Max()}");
        Console.WriteLine($"Average = {listOfNumbers.Average()}");
    }
}