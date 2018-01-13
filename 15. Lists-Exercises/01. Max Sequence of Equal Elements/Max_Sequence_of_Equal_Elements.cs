using System;
using System.Linq;

public class Max_Sequence_of_Equal_Elements
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var count = 1;
        var startIndex = 0;
        var endIndex = 0;
        var maxCount = 0;

        for (int i = 0; i < numbers.Count-1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                count++;

                if (count > maxCount)
                {
                    maxCount = count;
                    endIndex = i+1;
                    startIndex = endIndex - maxCount + 1;
                }             
            }
            else
            {
                count = 1;
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i]+ " ");
        }

        Console.WriteLine();
    }
}

