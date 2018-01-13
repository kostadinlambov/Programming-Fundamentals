using System;

public class Calculate_Triangle_Area
{
    public static void Main()
    {
        var triangleBase = double.Parse(Console.ReadLine());
        var triangleHeight = double.Parse(Console.ReadLine());
        var area = GetTriangleArea(triangleBase, triangleHeight);
        Console.WriteLine(area);
    }

    public static double GetTriangleArea(double triangleBase,
        double triangleHeight)
    {
        var area = triangleBase * triangleHeight / 2;
        return area;
    }
}

