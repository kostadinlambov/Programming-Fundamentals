using System;

public class Water_Overflow
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var tankCapacity = 255;
        var sum = 0;

        for (int i = 0; i < n; i++)
        {
            var quantitiesOfWater = int.Parse(Console.ReadLine());

            sum += quantitiesOfWater;
            if (sum > tankCapacity)
            {
                Console.WriteLine("Insufficient capacity!");
                sum -= quantitiesOfWater;
            }
        }

        Console.WriteLine(sum);
    }
}