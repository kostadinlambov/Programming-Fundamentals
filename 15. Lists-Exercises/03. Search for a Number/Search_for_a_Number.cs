using System;
using System.Linq;

public class Search_for_a_Number
{
    public static void Main()
    {
        var numbersList = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var commandNumbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var chanchedNumbersList = numbersList
            .Take(commandNumbers[0])
            .Skip(commandNumbers[1])
            .ToList();

        foreach (var number in chanchedNumbersList)
        {
            if (number == commandNumbers[2])
            {
                Console.WriteLine("YES!");
                return;
            }
        }

        Console.WriteLine("NO!");
    }
}

