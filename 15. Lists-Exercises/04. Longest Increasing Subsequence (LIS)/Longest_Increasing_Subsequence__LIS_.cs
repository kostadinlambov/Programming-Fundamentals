using System;
using System.Collections.Generic;
using System.Linq;

public class Longest_Increasing_Subsequence__LIS_
{
    public static void Main()
    {
        var inputSequence = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var maxLen = 0;
        var lastIndex = -1;

        var lengthOfLIS = new int[inputSequence.Length];
        var prev = new int[inputSequence.Length];

        for (int x = 0; x < inputSequence.Length; x++)
        {
            lengthOfLIS[x] = 1;
            prev[x] = -1;

            for (int i = 0; i <= x -1; i++)
            {
                if (inputSequence[i] < inputSequence[x] && lengthOfLIS[i]+ 1 > lengthOfLIS[x])
                {
                    lengthOfLIS[x] = 1 + lengthOfLIS[i];
                    prev[x] = i;
                }
            }

            if (lengthOfLIS[x] > maxLen)
            {
                maxLen = lengthOfLIS[x];
                lastIndex = x;
            }
        }

        var longestSeq = new List<int>();

        while (lastIndex != -1)
        {
            longestSeq.Add(inputSequence[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        longestSeq.Reverse();

        Console.WriteLine(string.Join(" ", longestSeq));
    }
}

