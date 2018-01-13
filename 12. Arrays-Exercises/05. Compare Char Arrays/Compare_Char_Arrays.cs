using System;
using System.Linq;

public class Compare_Char_Arrays
{
    public static void Main()
    {
        var firstInputLine = Console.ReadLine();
        var secondInputLine = Console.ReadLine();

        var firstCharArr = firstInputLine
                   .Split(' ')
                   .Select(char.Parse)
                   .ToArray();

        var secondCharArr = secondInputLine
            .Split(' ')
            .Select(char.Parse)
            .ToArray();

        if (firstInputLine.CompareTo(secondInputLine) < 0)
        {         
            Console.WriteLine(string.Join("", firstCharArr));
            Console.WriteLine(string.Join("", secondCharArr));
        }
        else
        {
            Console.WriteLine(string.Join("", secondCharArr));
            Console.WriteLine(string.Join("", firstCharArr));
        }
    }
}

