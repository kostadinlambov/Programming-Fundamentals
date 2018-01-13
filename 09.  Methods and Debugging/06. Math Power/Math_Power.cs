using System;

public class Math_Power
{
    public static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());

        var result = RaiseToPower(number, power);
        Console.WriteLine(result);
    }

    public static double RaiseToPower(double number, int power)
    {
        var result = 1.0;

        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }
}

