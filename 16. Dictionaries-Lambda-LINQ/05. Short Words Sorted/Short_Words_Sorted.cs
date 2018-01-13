using System;
using System.Linq;

public class Short_Words_Sorted
{
    public static void Main()
    {
        var separators = new char[] {' ','.', ',', ':', ';',
            '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?'};

        var text = Console.ReadLine()
            .ToLower()
            .Trim()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length < 5)
            .Distinct()
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(string.Join(", ", text));
    }
}

