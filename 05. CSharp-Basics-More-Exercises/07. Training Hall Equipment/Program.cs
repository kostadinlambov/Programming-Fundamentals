namespace _7.Training_Hall_Equipment
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var budget = decimal.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());

            var subtotal = 0m;

            for (int i = 0; i < numberOfItems; i++)
            {

                var itemName = Console.ReadLine();
                var itemPrice = decimal.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                if (itemCount < 2)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }

                subtotal += itemCount * itemPrice;
            }

            var moneyLeft = Math.Abs(budget - subtotal);

            if (budget >= subtotal)
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Money left: ${moneyLeft:F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Not enough. We need ${moneyLeft:F2} more.");
            }
        }
    }
}
