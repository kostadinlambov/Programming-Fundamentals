namespace _2.Choose_a_Drink_2._0
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            double price;

            if (profession == "Athlete")
            {
                price = 0.70;
                //Console.WriteLine("Water");

            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00;
                // Console.WriteLine("Coffee");
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70;
                // Console.WriteLine("Beer");
            }
            else
            {
                price = 1.20;
                // Console.WriteLine("Tea");
            }

            var totalPrice = quantity * price;

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
