using System;
using System.Linq;

public class Sort_Times
{
    public static void Main()
    {
        var timesList = Console.ReadLine()
            .Trim()
            .Split(' ')
            .ToList();

        timesList.Sort();

        Console.WriteLine(string.Join(", ", timesList));
    }
}

