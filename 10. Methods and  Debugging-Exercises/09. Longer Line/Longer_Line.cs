using System;

public class Longer_Line
{
    public static void Main()
    {
        var x1 = decimal.Parse(Console.ReadLine());
        var y1 = decimal.Parse(Console.ReadLine());
        var x2 = decimal.Parse(Console.ReadLine());
        var y2 = decimal.Parse(Console.ReadLine());
        var x3 = decimal.Parse(Console.ReadLine());
        var y3 = decimal.Parse(Console.ReadLine());
        var x4 = decimal.Parse(Console.ReadLine());
        var y4 = decimal.Parse(Console.ReadLine());

        var firstLineLength = FindLineLength(x1, y1, x2, y2);
        var secondLineLength = FindLineLength(x3, y3, x4, y4);

        if (firstLineLength >= secondLineLength)
        {
            FindTheClosestPointToCenter(x1, y1, x2, y2);
        }
        else
        {
            FindTheClosestPointToCenter(x3, y3, x4, y4);
        }
    }

    public static decimal FindLineLength(decimal x1, decimal y1, decimal x2, decimal y2)
    {
        var lineLength = (decimal)Math.Sqrt(Math.Pow((double)Math.Abs(x1 - x2), 2.0)
                                            + Math.Pow((double)Math.Abs(y1 - y2), 2.0));
        return lineLength;
    }

    public static void FindTheClosestPointToCenter(decimal x1, decimal y1, decimal x2, decimal y2)
    {
        var firstPointDistanceToCenter = DistanceToCenter(x1, y1);
        var secondPointDistanceToCenter = DistanceToCenter(x2, y2);

        if (firstPointDistanceToCenter <= secondPointDistanceToCenter)
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");           
            return;
        }

        Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
    }

    public static decimal DistanceToCenter(decimal x1, decimal y1)
    {
        var distanceToCenter = (decimal)Math.Sqrt(Math.Pow((double)x1, 2.0) + Math.Pow((double)y1, 2.0));
        return distanceToCenter;
    }

}

