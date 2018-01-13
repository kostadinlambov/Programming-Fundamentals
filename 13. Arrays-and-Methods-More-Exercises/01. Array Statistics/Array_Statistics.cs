using System;
using System.Linq;

public class Array_Statistics
{
    public static void Main()
    {
        var numbersArr = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var minNumber = numbersArr.Min();
        var maxNumber = numbersArr.Max();
        var sum = numbersArr.Sum();
        var average = numbersArr.Average();

        Console.WriteLine($"Min = {minNumber}");
        Console.WriteLine($"Max = {maxNumber}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
    }
}
