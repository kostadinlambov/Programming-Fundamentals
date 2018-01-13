using System;
using System.Linq;

public class Largest_3_Numbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(' ')          
            .Select(int.Parse)           
            .ToList();

        numbers.Sort();
        numbers.Reverse();

        var largestNumbers = numbers
            .Take(3)
            .ToList();

        Console.WriteLine(string.Join(" ", largestNumbers));
    }
}

