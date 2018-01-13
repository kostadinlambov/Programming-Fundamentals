namespace _4.Beverage_Labels
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100Ml = int.Parse(Console.ReadLine());
            var sugarContentPer100Ml = int.Parse(Console.ReadLine());

            var totalEnergyContent = (volume/100.0) * energyContentPer100Ml;
            var totalsugarContent = (volume/100.0) * sugarContentPer100Ml;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergyContent}kcal, {totalsugarContent}g sugars");
        }
    }
}
