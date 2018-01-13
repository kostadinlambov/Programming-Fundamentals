using System;
using System.Numerics;

public class Factorial
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        PrintFactorial(number);
    }

    public static void PrintFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}

