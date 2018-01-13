using System;

public class Prime_Checker
{
    public static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(number));       
    }

    private static bool IsPrime(long number)
    {
        bool primeCheck = false;

        if (number == 0 || number == 1)
        {
            return primeCheck;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return primeCheck;
            }
        }

        return true;
    }
}

