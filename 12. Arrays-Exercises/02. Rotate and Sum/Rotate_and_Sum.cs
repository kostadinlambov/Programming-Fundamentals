using System;
using System.Linq;

public class Rotate_and_Sum
{
    public static void Main()
    {

        var inputArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var numberOfRotations = int.Parse(Console.ReadLine());
        var rotatedArr = new int[inputArr.Length];
        var sum = new int[inputArr.Length];

        for (int i = 0; i < numberOfRotations; i++)
        {
            var lastNumber = inputArr[inputArr.Length - 1];

            for (int j = inputArr.Length - 1; j > 0; j--)
            {
                rotatedArr[j] = inputArr[j - 1];
            }

            rotatedArr[0] = lastNumber;

            for (int k = 0; k < inputArr.Length; k++)
            {
                sum[k] += rotatedArr[k];
            }

            inputArr = rotatedArr;
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}

