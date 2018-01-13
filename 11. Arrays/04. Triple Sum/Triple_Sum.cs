using System;
using System.Linq;

public class Triple_Sum
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine();

        var numbersArr = inputNumbers
            .Trim()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        long count = 0;

        for (long i = 0; i < numbersArr.Length-1; i++)
        {
            for (long j = i + 1; j < numbersArr.Length; j++)
            {
                for (long k = 0; k < numbersArr.Length; k++)
                {
                    if (j > i)
                    {
                        if (numbersArr[i] + numbersArr[j] == numbersArr[k])
                        {
                            Console.WriteLine($"{numbersArr[i]} + {numbersArr[j]} == {numbersArr[k]}");
                            count++;
                            break;
                        }
                    }                
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

