using System;

public class Last_K_Numbers_Sums_Sequence
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var steps = int.Parse(Console.ReadLine());

        var sumSequenceArr = new decimal[number];

        sumSequenceArr[0] = 1;

        decimal sumOfTlastKNumbers = 0m;

        for (int i = 1; i < sumSequenceArr.Length; i++)
        {
            
            if (i - steps < 0)
            {
                for (int l = 0; l <i; l++)
                {
                    sumOfTlastKNumbers += sumSequenceArr[l];
                }
            }
            else
            {
                for (int j = i - steps; j <= i - 1; j++)
                {
                    sumOfTlastKNumbers += sumSequenceArr[j];
                }
            }

            sumSequenceArr[i] = sumOfTlastKNumbers;
            sumOfTlastKNumbers = 0;
        }

        Console.WriteLine(string.Join(" ", sumSequenceArr));
    }
}

