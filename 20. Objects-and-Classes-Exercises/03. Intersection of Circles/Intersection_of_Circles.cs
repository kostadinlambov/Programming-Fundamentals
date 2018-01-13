using System;
using System.Collections.Generic;
using System.Linq;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

public class Circle
{
    public double Radius { get; set; }

    public Point Center { get; set; }

}

public class Intersection_of_Circles
{
    public static void Main()
    {
        List<Circle> circlesList = new List<Circle>();
     
        for (int i = 0; i < 2; i++)
        {
            var point = new Point();
            var circle = new Circle();

            var inputLine = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
          
            point.X = inputLine[0];
            point.Y = inputLine[1];

            circle.Center = point;
            circle.Radius = inputLine[2];

            circlesList.Add(circle);
        }

        var distance = DistanceBetweenTheCircles(circlesList[0], circlesList[1]);

        if (distance <= circlesList[0].Radius + circlesList[1].Radius)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static double DistanceBetweenTheCircles(Circle firstCircle, Circle secondCircle)
    {
        var firstSide = Math.Pow(firstCircle.Center.X - secondCircle.Center.X, 2);
        var secondSide = Math.Pow(firstCircle.Center.Y - secondCircle.Center.Y, 2);

        var distance = Math.Sqrt(firstSide + secondSide);

        return distance;
    }
}

