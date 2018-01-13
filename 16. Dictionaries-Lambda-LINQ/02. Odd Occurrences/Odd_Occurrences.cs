using System;
using System.Collections.Generic;
using System.Linq;

public class Odd_Occurrences
{
    public static void Main()
    {
        var inputString = Console.ReadLine()
            .ToLower()
            .Trim()
            .Split(' ')
            .ToList();

        var wordsOccurencesDict = new Dictionary<string, int>();

        for (int i = 0; i < inputString.Count; i++)
        {
            if (!wordsOccurencesDict.ContainsKey(inputString[i]))
            {
                wordsOccurencesDict[inputString[i]] = 0;
            }

            wordsOccurencesDict[inputString[i]]++;
        }

        var oddOccurencesWords = new List<string>();

        foreach (var word in wordsOccurencesDict)
        {
            if (word.Value % 2 == 1)
            {
                oddOccurencesWords.Add(word.Key);
            }
        }

        Console.WriteLine(string.Join(", ", oddOccurencesWords));
    }
}