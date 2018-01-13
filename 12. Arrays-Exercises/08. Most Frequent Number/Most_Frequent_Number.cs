using System;
using System.Linq;

public class Most_Frequent_Number
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var count = 1;
        var maxCount = 0;
        int mostFrequentNumber = 0;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            for (int j = 0; j < inputNumbers.Length; j++)
            {
                if (inputNumbers[i] == inputNumbers[j])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostFrequentNumber = inputNumbers[i];
                    }
                }
            }

            count = 1;
        }

        Console.WriteLine(mostFrequentNumber);
    }
}

