using System;

public class Cube_Properties
{
    public static void Main(string[] args)
    {
        var sideOfTheCube = double.Parse(Console.ReadLine());
        var parameter = Console.ReadLine();

        if (parameter == "face")
        {
            CalculateFaceDiagonal(sideOfTheCube);
        }
        else if (parameter == "space")
        {
            CalculateSpaceDiagonal(sideOfTheCube);
        }
        else if (parameter == "volume")
        {
            CalculateVolume(sideOfTheCube);
        }
        else if (parameter == "area")
        {
            CalculateSurfaceArea(sideOfTheCube);
        }
    }

    private static void CalculateSurfaceArea(double sideOfTheCube)
    {
        var surfaceArea = 6 * Math.Pow(sideOfTheCube, 2.0);
        Console.WriteLine($"{surfaceArea:f2}");
    }

    public static void CalculateVolume(double sideOfTheCube)
    {
        var volume = Math.Pow(sideOfTheCube, 3.0);
        Console.WriteLine($"{volume:f2}");
    }

    public static void CalculateSpaceDiagonal(double sideOfTheCube)
    {
        var spaceDiagonal = Math.Sqrt(3 * Math.Pow(sideOfTheCube, 2.0));
        Console.WriteLine($"{spaceDiagonal:f2}");
    }

    public static void CalculateFaceDiagonal(double sideOfTheCube)
    {
        var faceDiagonal = Math.Sqrt(2 * Math.Pow(sideOfTheCube, 2.0));
        Console.WriteLine($"{faceDiagonal:f2}");
    }
}

