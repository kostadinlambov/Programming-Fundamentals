using System;

public class Draw_a_Filled_Square
{
    public static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());

        PrintHeaderRow(numberOfLines);
        PrintMiddleRow(numberOfLines);
        PrintHeaderRow(numberOfLines);
    }

    public static void PrintHeaderRow(int numberOfLines)
    {
        Console.WriteLine(new string('-', 2 * numberOfLines));
    }

    public static void PrintMiddleRow(int numberOfLines)
    {
        for (int i = 0; i < numberOfLines - 2; i++)
        {
            Console.Write('-');
            for (int j = 0; j < numberOfLines - 1; j++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
