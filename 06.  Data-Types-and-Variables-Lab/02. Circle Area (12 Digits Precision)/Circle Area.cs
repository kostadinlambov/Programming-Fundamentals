using System;

public class Circle_Area
{
    public static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double area = radius * radius * Math.PI;

        Console.WriteLine($"{area:f12}");
    }
}
