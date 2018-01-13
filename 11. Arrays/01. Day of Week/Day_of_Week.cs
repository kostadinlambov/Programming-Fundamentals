using System;

public class Day_of_Week
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        string[] daysOfTheWeek =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        if (number >= 1 && number <=7)
        {
            Console.WriteLine(daysOfTheWeek[number - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }      
    }
}

