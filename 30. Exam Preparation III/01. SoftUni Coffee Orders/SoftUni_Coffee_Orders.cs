using System;
using System.Globalization;

namespace _01.SoftUni_Coffee_Orders
{
    class SoftUni_Coffee_Orders
    {
        static void Main()
        {
            var orderdsCount = int.Parse(Console.ReadLine());

            var totalPrice = 0m;

            for (int i = 0; i < orderdsCount; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());

                var orderDate = DateTime.ParseExact(Console.ReadLine(),
                    "d/M/yyyy", 
                    CultureInfo.InvariantCulture);

                var capsulesCount = decimal.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var currentPrice = (daysInMonth * capsulesCount) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");

                totalPrice += currentPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");


        }
    }
}
