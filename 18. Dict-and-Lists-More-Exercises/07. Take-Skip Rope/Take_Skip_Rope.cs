using System;
using System.Collections.Generic;
using System.Linq;

public class Take_Skip_Rope
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var digits = new List<int>();
        var characters = new List<char>();

        for (int i = 0; i < inputLine.Length; i++)
        {
            if (char.IsDigit(inputLine[i]))
            {
                digits.Add(int.Parse(inputLine[i].ToString()));
            }
            else
            {
                characters.Add(inputLine[i]);
            }
        }

        var charactersString = string.Join("", characters);

        var takeList = new List<int>();
        var skipList = new List<int>();

        for (int i = 0; i < digits.Count; i++)
        {
            if (i % 2 == 0)
            {
                takeList.Add(digits[i]);
            }
            else
            {
                skipList.Add(digits[i]);
            }
        }

        var takenCharsPerStep = new List<char>();
        var outputList = new List<char>();
        var totalSkip = 0;

        for (int i = 0; i < takeList.Count; i++)
        {
            takenCharsPerStep = charactersString
                  .Skip(totalSkip)
                  .Take(takeList[i])
                  .ToList();

            outputList.AddRange(takenCharsPerStep);

            totalSkip += skipList[i] + takeList[i];
        }

        Console.WriteLine(string.Join("", outputList));
    }
}

