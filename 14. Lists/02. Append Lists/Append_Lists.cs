using System;
using System.Collections.Generic;
using System.Linq;

public class Append_Lists
{
    public static void Main()
    {

        var inputLists = Console.ReadLine()
            .Trim()
            .Split('|')
            .Reverse()
            .ToList();

        var sortedLists = new List<int>();

        for (int i = 0; i < inputLists.Count; i++)
        {
            var token = inputLists[i]
                .Trim()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            sortedLists.AddRange(token);    
        }

        Console.WriteLine(string.Join(" ", sortedLists));
    }
}