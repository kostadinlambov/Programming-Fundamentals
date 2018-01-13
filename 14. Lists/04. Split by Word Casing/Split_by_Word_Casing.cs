using System;
using System.Collections.Generic;
using System.Linq;

public class Split_by_Word_Casing
{
    public static void Main()
    {
        var separator = new char[] {' ',';',',',':', '.', '!',
            '(', ')', '\"','\'', '\\', '/', '[', ']'};

        var inputString = Console.ReadLine()
            .Split(separator, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var lowerCaseWords= new List<string>();
        var upperCaseWords= new List<string>();
        var mixedCaseWords= new List<string>();

        for (int i = 0; i < inputString.Count; i++)
        {

            if (IsUpperCase(inputString[i]))
            {
                upperCaseWords.Add(inputString[i]);
            }
            else if (IsLowerCase(inputString[i]))
            {
                lowerCaseWords.Add(inputString[i]);
            }
            else
            {
                mixedCaseWords.Add(inputString[i]);
            }
        }

        Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
        Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
        Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
    }

    public static bool IsLowerCase(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (!char.IsLower(word[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsUpperCase(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (!char.IsUpper(word[i]))
            {
                return false;
            }
        }
        return true;
    }
}