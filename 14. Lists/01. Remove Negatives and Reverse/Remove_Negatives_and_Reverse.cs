using System;
using System.Linq;

public class Remove_Negatives_and_Reverse
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .Reverse()
            .ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.RemoveAt(i);
                i = i - 1;
            }
        }

        if (numbers.Count > 0)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}
