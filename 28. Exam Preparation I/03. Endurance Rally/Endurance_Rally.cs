using System;
using System.Linq;

namespace _03.Endurance_Rally
{
    public class Endurance_Rally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var zones = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();

            var checkPoints = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            var isAnyFuelLeft = true;

            if (drivers.Length > 0 && zones.Length >0 
                && checkPoints.Length > 0)
            {
                for (int i = 0; i < drivers.Length; i++)
                {
                    var fuel = (decimal)drivers[i][0];

                    for (int k = 0; k < zones.Length; k++)
                    {
                        if (checkPoints.Any(x => x.Equals(k)))
                        {
                            fuel += zones[k];
                        }
                        else
                        {
                            fuel -= zones[k];
                        }

                        if (fuel <= 0)
                        {
                            Console.WriteLine($"{drivers[i]} - reached {k}");
                            isAnyFuelLeft = false;
                            break;
                        }
                    }

                    if (isAnyFuelLeft)
                    {
                        Console.WriteLine($"{drivers[i]} - fuel left {fuel:F2}");
                    }
                    isAnyFuelLeft = true;
                }
            }        
        }
    }
}
