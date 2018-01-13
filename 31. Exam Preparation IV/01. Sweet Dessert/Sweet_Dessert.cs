using System;

namespace _01.Sweet_Dessert
{
    public class Sweet_Dessert
    {
        public static void Main()
        {

            var budget = decimal.Parse(Console.ReadLine());
            var guestsCount = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berryPrice = decimal.Parse(Console.ReadLine());

            var portions = 6;

            var neededProductsPerPortion = Math.Ceiling(guestsCount / (decimal)portions);

            var moneySpendOnBanans = neededProductsPerPortion * (2 * bananaPrice);
            var moneySpendOnEggs = neededProductsPerPortion * (4 * eggPrice);
            var moneySpendOnBerries = neededProductsPerPortion * (0.2m * berryPrice);

            var totalSpendMoney = moneySpendOnBanans + moneySpendOnEggs + moneySpendOnBerries;

            if (budget >= totalSpendMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalSpendMoney:F2}lv.");
            }

            else
            {
                var neededMoney = totalSpendMoney - budget;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
