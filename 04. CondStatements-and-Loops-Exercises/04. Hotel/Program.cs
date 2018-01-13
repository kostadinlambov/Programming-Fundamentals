namespace _4.Hotel
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var nightsCountStudio = nightsCount;
            var pricePerNightStudio = 0d;
            var pricePerNightDouble = 0d;
            var pricePerNightSuite = 0d;
            var discountMultiplier = 0d;

            if (month == "May" || month == "October")
            {
                pricePerNightStudio = 50;
                pricePerNightDouble = 65;
                pricePerNightSuite = 75;
            }
            else if (month == "June" || month == "September")
            {
                pricePerNightStudio = 60;
                pricePerNightDouble = 72;
                pricePerNightSuite = 82;
            }
            else if (month == "July" || month == "August"
                || month == "December")
            {
                pricePerNightStudio = 68;
                pricePerNightDouble = 77;
                pricePerNightSuite = 89;
            }

            if (nightsCount > 7 && (month == "May" || month == "October"))
            {
                discountMultiplier = (100 - 5) / 100.0;
                pricePerNightStudio *= discountMultiplier;
            }

            if (nightsCount > 14 && (month == "June" || month == "September"))
            {
                discountMultiplier = (100 - 10) / 100.0;
                pricePerNightDouble *= discountMultiplier;
            }
            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                nightsCountStudio--;
            }

            if (nightsCount > 14 && (month == "July"
                || month == "August" || month == "December"))
            {
                discountMultiplier = (100 - 15) / 100.0;
                pricePerNightSuite *= discountMultiplier;
            }

            var totalPriceStudio = nightsCountStudio * pricePerNightStudio;
            var totalPriceDouble = nightsCount * pricePerNightDouble;
            var totalPriceSuite = nightsCount * pricePerNightSuite;

            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:F2} lv.");
        }
    }
}
