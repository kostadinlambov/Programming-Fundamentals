using System;
using System.Globalization;

public class Day_of_Week
{
    public static void Main()
    {
        var dateInputString = Console.ReadLine();

        var date = DateTime.ParseExact(
            dateInputString,
            "d-M-yyyy",
            CultureInfo.InvariantCulture);

        var dayOfTheWeek = date.DayOfWeek;

        Console.WriteLine(dayOfTheWeek);
    }
}