using System;
using System.Linq;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

public class Distance_Between_Points
{
    public static void Main()
    {
        Point firstPoint = new Point();
        Point secondPoint = new Point();

        for (int i = 1; i <= 2; i++)
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            if (i % 2 == 1)
            {
                firstPoint.X = inputLine[0];
                firstPoint.Y = inputLine[1];
            }
            else
            {
                secondPoint.X = inputLine[0];
                secondPoint.Y = inputLine[1];
            }
        }

        var distanceBetweenPoints =
            DistanceBetweenPoints(firstPoint, secondPoint);

        Console.WriteLine($"{distanceBetweenPoints:f3}");
    }

    public static double DistanceBetweenPoints(Point firstPoint, Point secondPoint)
    {
        var firstSide = Math.Pow(firstPoint.X - secondPoint.X, 2);
        var secondSide = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

        var distance = Math.Sqrt(firstSide + secondSide);

        return distance;
    }
}