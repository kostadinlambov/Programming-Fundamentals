using System;
using System.Linq;

namespace Problem_1.Sino_The_Walker
{
    public class Sino_The_Walker
    {
        public static void Main()
        {
            var startTime = Console.ReadLine()
                .Split(':')
                .Select(int.Parse)
                .ToArray();

            var startTimeInSeconds = startTime[0] * 3600 +
                                     startTime[1] * 60 + startTime[2];

            var NumberOfSteps = int.Parse(Console.ReadLine());
            var timeForEachstep = int.Parse(Console.ReadLine());

            long arrivalTimeInSeconds = startTimeInSeconds
                                        + (long) NumberOfSteps * timeForEachstep;

            var seconndsArrTime = arrivalTimeInSeconds % 60;
            var minutesArrTime = (arrivalTimeInSeconds / 60) % 60;
            var hoursArrTime = (arrivalTimeInSeconds / 3600) % 24;

            Console.WriteLine($"Time Arrival: {hoursArrTime:D2}:{minutesArrTime:D2}:" +
                              $"{seconndsArrTime:D2}");
        }
    }
}
