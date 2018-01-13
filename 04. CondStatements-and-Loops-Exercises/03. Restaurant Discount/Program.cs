namespace _3.Restaurant_Discount
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var packageType = Console.ReadLine();

            int price = 0;
            int discount = 0;
            double totalPrice = 0;
            var hallName = string.Empty;

            if (groupSize <= 50)
            {
                price = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                price = 5000;
                hallName = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                price = 7500;
                hallName = "Great Hall";
            }

            var packagePrice = 0;

            if (packageType == "Normal")
            {
                discount = 5;
                packagePrice = 500;
            }
            else if (packageType == "Gold")
            {
                discount = 10;
                packagePrice = 750;
            }
            else if (packageType == "Platinum")
            {
                discount = 15;
                packagePrice = 1000;
            }

            totalPrice = (price + packagePrice) * ((100 - discount) / 100.0);
            var pricePerPerson = totalPrice / groupSize;

            if (groupSize <= 120)
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }
        }
    }
}
