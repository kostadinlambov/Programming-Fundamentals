using System;
using System.Collections.Generic;
using System.Linq;

public class Rectangle
{
    public double Top { get; set; }
    public double Left { get; set; }
    public double Width { get; set; }
    public double Height{ get; set; }

    public double Bottom
    {
        get { return Top + Height; }
    }

    public double Right
    {
        get { return Left + Width; }
    }

    public double CalcArea()
    {
        return Width * Height;
    }
    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Rectangle_Position
{
    public static void Main()
    {
        var rectamgleList = new List<Rectangle>();

        for (int i = 0; i < 2; i++)
        {
            Rectangle rectangle = new Rectangle();

            var inputLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            rectangle.Left = inputLine[0];
            rectangle.Top = inputLine[1];
            rectangle.Width = inputLine[2];
            rectangle.Height = inputLine[3];

            rectamgleList.Add(rectangle);
        }

        IsFirstInsideTheSecond(rectamgleList);

    }

    private static void IsFirstInsideTheSecond(List<Rectangle> rectamgleList)
    {
        var firstRectangle = rectamgleList[0];
        var secondRectangle = rectamgleList[1];

        if (firstRectangle.Left >= secondRectangle.Left
            && firstRectangle.Top <= secondRectangle.Top
            && firstRectangle.Right <= secondRectangle.Right
            && firstRectangle.Bottom <= secondRectangle.Bottom)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }
}