using System;
using System.Linq;

public class Jump_Around
{
    public static void Main()
    {
        var inputArr = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var indexRight = inputArr[0];
        var sum = inputArr[0];
        var indexLeft = -1;

        try
        {
            while (true)
            {
                if (indexRight < inputArr.Length && indexRight >= 0)
                {
                    sum += inputArr[indexRight];
                    indexLeft = indexRight - inputArr[indexRight];
                    indexRight += inputArr[indexRight];
                }
                else if (indexLeft < inputArr.Length && indexLeft >= 0)
                {
                    sum += inputArr[indexLeft];
                    indexLeft -= inputArr[indexLeft];
                    indexRight = indexLeft + inputArr[indexLeft];
                }
                else
                {
                    Console.WriteLine(sum);
                    return;
                }
            }
        }

        catch (IndexOutOfRangeException)
        {
            Console.WriteLine(sum);          
        }
    }
}