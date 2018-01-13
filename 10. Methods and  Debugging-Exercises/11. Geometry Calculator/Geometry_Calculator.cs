using System;

public class Geometry_Calculator
{
    public static void Main()
    {
        var figureType = Console.ReadLine();

        if (figureType == "triangle")
        {
            CalculateTriangleArea();
        }
        else if (figureType == "square")
        {
            CalculateSquareArea();
        }
        else if (figureType == "rectangle")
        {
            CalculateRectangleArea();
        }
        else if (figureType == "circle")
        {
            CalculateCircleArea();
        }

    }

    private static void CalculateCircleArea()
    {
        var radius = decimal.Parse(Console.ReadLine());

        var area = Math.PI * (double)(radius * radius);
        Console.WriteLine($"{area:f2}");
    }

    public static void CalculateRectangleArea()
    {
        var width = decimal.Parse(Console.ReadLine());
        var height = decimal.Parse(Console.ReadLine());

        var area = width * height;
        Console.WriteLine($"{area:f2}");
    }

    public static void CalculateSquareArea()
    {
        var side = decimal.Parse(Console.ReadLine());

        var area = side * side;
        Console.WriteLine($"{area:f2}");
    }

    public static void CalculateTriangleArea()
    {
        var side = decimal.Parse(Console.ReadLine());
        var height = decimal.Parse(Console.ReadLine());

        var area = side * height / 2;
        Console.WriteLine($"{area:f2}");
    }
}