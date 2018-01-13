using System;
using System.Linq;

public class Heists
{
    public static void Main()
    {
        var inputLine = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        var jewelsPrice = inputLine[0];
        var goldPrice = inputLine[1];

        var totalEarnings = 0l;

        var loot = Console.ReadLine();

        while (loot != "Jail Time")
        {

            var lootArr = loot
                .Split(' ')
                .ToArray();

            var heistEarningsString = lootArr[0];
            var heistExpensesString = long.Parse(lootArr[1]);

            for (int i = 0; i < heistEarningsString.Length; i++)
            {
                if (heistEarningsString[i] == '%')
                {
                    totalEarnings += jewelsPrice;
                }
                else if (heistEarningsString[i] == '$')
                {
                    totalEarnings += goldPrice;
                }
            }

            totalEarnings -= heistExpensesString;

            loot = Console.ReadLine();
        }

        if (totalEarnings >= 0)
        {
            Console.WriteLine($"Heists will continue. " +
                              $"Total earnings: {totalEarnings}.");
        }
        else
        {
            Console.WriteLine($"Have to find another job." +
                              $" Lost: {Math.Abs(totalEarnings)}.");
        }
    }
}

