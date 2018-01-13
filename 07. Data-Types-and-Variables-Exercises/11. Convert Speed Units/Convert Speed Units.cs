using System;

public class Convert_Speed_Units
{
    public static void Main()
    {
        var distanceInMeter = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var seconds = int.Parse(Console.ReadLine());

        var totalSeconds = hours * 3600 + minutes * 60 + seconds;

        var meterPerSecond = (float)distanceInMeter / totalSeconds;
        var kilometerPerHour = ((float) distanceInMeter / 1000) / ((float)totalSeconds/3600);
        var milesPerHour = ((float)distanceInMeter / 1609) / ((float)totalSeconds / 3600);

        Console.WriteLine($"{meterPerSecond}");
        Console.WriteLine($"{kilometerPerHour}");
        Console.WriteLine($"{milesPerHour}");
    }
}