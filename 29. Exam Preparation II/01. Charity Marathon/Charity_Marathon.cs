using System;

namespace _01.Charity_Marathon
{
    public class Charity_Marathon
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var numberOfRunnenrs = int.Parse(Console.ReadLine());
            var averageNumOfLapsPerRunner = int.Parse(Console.ReadLine());
            var lengthOfTheTrack = int.Parse(Console.ReadLine());
            var capacityOfTheTrack = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            var maxNumbRunnersForAllDays = capacityOfTheTrack * days;
            if (numberOfRunnenrs > maxNumbRunnersForAllDays)
            {
                numberOfRunnenrs = maxNumbRunnersForAllDays;
            }

            var totalMeters = (long)numberOfRunnenrs * averageNumOfLapsPerRunner
                              * lengthOfTheTrack;

            var totalKilometers = totalMeters / 1000;

            var totalRaisedMoney = totalKilometers * moneyPerKm;

            Console.WriteLine($"Money raised: {totalRaisedMoney:f2}");
        }
    }
}
