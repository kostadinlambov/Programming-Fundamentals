using System;
using System.Linq;

public class Reverse_an_Array_of_Strings
{
    public static void Main()
    {
        var inputString = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var reversedString = new string[inputString.Length];

        for (int i = 0; i < inputString.Length; i++)
        {
            reversedString[i] = inputString[inputString.Length - 1 - i];
        }

        Console.WriteLine(string.Join(" ", reversedString));
    }
}

