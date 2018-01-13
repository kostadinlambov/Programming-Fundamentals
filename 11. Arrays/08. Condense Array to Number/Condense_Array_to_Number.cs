using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

public class Condense_Array_to_Number
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        while (nums.Length > 1)
        {
            var condensed = new int[nums.Length - 1];

            for (int i = 0; i < nums.Length-1; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];
            }

            nums = condensed;
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}

