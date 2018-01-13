using System;
using System.Linq;

public class Grab_and_Go
{
    public static void Main()
    {
        var numbersArr = Console.ReadLine()
            .Split(' ')
            .Reverse()
            .Select(long.Parse)
            .ToArray();

        var numberToSearch = long.Parse(Console.ReadLine());

        for (int i = 0; i < numbersArr.Length; i++)
        {

            if (numbersArr[i] == numberToSearch)
            {
                var sum = numbersArr
                    .Skip(i + 1)
                    .Sum();

                Console.WriteLine(sum);
                return;
            }
        }
        Console.WriteLine("No occurrences were found!");
    }
}

