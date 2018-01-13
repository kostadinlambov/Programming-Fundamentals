using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}