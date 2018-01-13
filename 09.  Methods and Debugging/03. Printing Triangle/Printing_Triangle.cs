using System;

public class Printing_Triangle
{
    public static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());

        PrintTriangle(numberOfLines);
    }

    public static void PrintTriangle(int numberOfLines)
    {
        for (int i = 1; i <= numberOfLines; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        for (int i = numberOfLines-1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

