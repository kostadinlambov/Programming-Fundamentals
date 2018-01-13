using System;
using System.Linq;

public class Equal_Sums
{
    public static void Main()
    {

        var numbersArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();


        for (int i = 0; i < numbersArr.Length; i++)
        {
            var leftSum = numbersArr
                .Take(i)
                .Sum();

            var rightSum = numbersArr
                .Skip(i + 1)
                .Sum();

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine("no");
    }
}

