using System;

public class Rectangle_Properties
{
    public static void Main()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var area = width * height;
        var perimeter = 2 * width + 2 * height;
        var diagonal = Math.Sqrt(width * width + height * height);

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}
