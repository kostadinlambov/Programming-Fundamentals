using System;
using System.Linq;

public class Sum_Adjacent_Equal_Numbers
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(decimal.Parse)
            .ToList();
        if (inputNumbers.Count == 1)
        {
            Console.WriteLine(inputNumbers[0]);
        }
        else
        {
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                if (inputNumbers[i] == inputNumbers[i + 1])
                {
                    inputNumbers[i] += inputNumbers[i + 1];
                    inputNumbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", inputNumbers));
        }


    }
}