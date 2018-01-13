using System;
using System.Linq;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

class Closest_Two_Points
{
    static void Main()
    {
        var numberOfPoints = int.Parse(Console.ReadLine());

        Point[] points = new Point[numberOfPoints];

        for (int i = 0; i < points.Length; i++)
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            points[i] = new Point()
            {
                X = inputLine[0],
                Y = inputLine[1]
            };
        }

        FindClosestPoints(points);
    }

    public static void FindClosestPoints(Point[] points)
    {
        Point firstPoint = null;
        Point secondPoint = null;
        var minDistance = double.MaxValue;

        for (int i = 0; i < points.Length - 1; i++)
        {

            for (int j = i + 1; j < points.Length; j++)
            {
                var distanceBetweenPoints = DistanceBetweenPoints(
                    points[i], points[j]);

                if (distanceBetweenPoints < minDistance)
                {
                    minDistance = distanceBetweenPoints;
                    firstPoint = points[i];
                    secondPoint = points[j];
                }
            }
        }

        Console.WriteLine($"{minDistance:f3}");
        Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
        Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
    }

    public static double DistanceBetweenPoints(Point firstPoint, Point secondPoint)
    {
        var firstSide = Math.Pow(firstPoint.X - secondPoint.X, 2);
        var secondSide = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

        var distance = Math.Sqrt(firstSide + secondSide);

        return distance;
    }
}