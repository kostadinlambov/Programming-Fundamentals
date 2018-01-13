using System;

public class Center_Point
{
    public static void Main()
    {
        var x1 = decimal.Parse(Console.ReadLine());
        var y1 = decimal.Parse(Console.ReadLine());
        var x2 = decimal.Parse(Console.ReadLine());
        var y2 = decimal.Parse(Console.ReadLine());

        FindTheClosestPointToCenter(x1, y1, x2, y2);
    }

    public static void FindTheClosestPointToCenter(decimal x1, decimal y1, decimal x2, decimal y2)
    {
        var firstPointDistanceToCenter = DistanceToCenter(x1, y1);
        var secondPointDistanceToCenter = DistanceToCenter(x2, y2);
        if (firstPointDistanceToCenter <= secondPointDistanceToCenter)
        {
            Console.WriteLine($"({x1}, {y1})");
            return;
        }

        Console.WriteLine($"({x2}, {y2})");
    }

    public static decimal DistanceToCenter(decimal x1, decimal y1)
    {
        var distanceToCenter = (decimal)Math.Sqrt(Math.Pow((double)x1, 2.0) + Math.Pow((double)y1, 2.0));
        return distanceToCenter;
    }
}

