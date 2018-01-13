using System;
using System.Numerics;

public class Factorial_Trailing_Zeroes
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var factorial = CalculateFactorial(number);

        int numberOfTrailingZeros = CalculateTrailingZeros(factorial);
        Console.WriteLine(numberOfTrailingZeros);
    }

    public static int CalculateTrailingZeros(BigInteger number)
    {
        var count = 0;

        while (number > 0)
        {
            var lastDigit = number % 10;
            number = number / 10;
            if (lastDigit == 0)
            {
                count++;
            }
            else
            {
                return count;
            }
        }

        return count;
    }


    public static BigInteger CalculateFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}