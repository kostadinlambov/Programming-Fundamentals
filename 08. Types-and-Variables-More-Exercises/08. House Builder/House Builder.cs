using System;

public class House_Builder
{
    public static void Main()
    {
        long sbytePrice = 0;
        long intPrice = 0;

        for (int i = 0; i < 2; i++)
        {
            var inputNumber = long.Parse(Console.ReadLine());
          
            if (inputNumber <= sbyte.MaxValue && inputNumber >= 0)
            {
                sbytePrice = inputNumber;
            }
            else if (inputNumber > sbyte.MaxValue)
            {
                intPrice = inputNumber;
            }
        }

        decimal totalIntPrice = 10 * intPrice;
        decimal totalSbytePrice = 4 * sbytePrice;

        decimal totalPrice = totalIntPrice + totalSbytePrice;

        Console.WriteLine(totalPrice);
    }
}
