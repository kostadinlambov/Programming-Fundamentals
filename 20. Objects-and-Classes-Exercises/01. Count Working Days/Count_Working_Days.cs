using System;
using System.Globalization;
using System.Linq;

public class Count_Working_Days
{
    public static void Main(string[] args)
    {
        var datesStringArr = new string[2];

        for (int i = 0; i < datesStringArr.Length; i++)
        {
            datesStringArr[i] = Console.ReadLine();
        }

        var firstDateString = datesStringArr[0];
        var secondDatetring = datesStringArr[1];

        var firstDate = DateTime.ParseExact(
            firstDateString,
            "dd-MM-yyyy",
            CultureInfo.InvariantCulture);

        var secondDate = DateTime.ParseExact(
            secondDatetring,
            "dd-MM-yyyy",
            CultureInfo.InvariantCulture);

        var officialHolidays = new DateTime[]
        {
            new DateTime(2016, 01, 01),
            new DateTime(2016, 03, 03),
            new DateTime(2016, 05, 01),
            new DateTime(2016, 05, 06),
            new DateTime(2016, 05, 24),
            new DateTime(2016, 09, 06),
            new DateTime(2016, 09, 22),
            new DateTime(2016, 11, 01),
            new DateTime(2016, 12, 24),
            new DateTime(2016, 12, 25),
            new DateTime(2016, 12, 26)
        };

        var workingDaysCount = 0;

        for (DateTime currentDate = firstDate; 
            currentDate <= secondDate; currentDate = currentDate.AddDays(1))
        {
            var checkDay = new DateTime(2016, currentDate.Month,
                currentDate.Day);

            if (currentDate.DayOfWeek != DayOfWeek.Saturday
                && currentDate.DayOfWeek != DayOfWeek.Sunday
                && !officialHolidays.Contains(checkDay))
            {
                workingDaysCount++;
            } 
        }

        Console.WriteLine(workingDaysCount);
    }
}