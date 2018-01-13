using System;
using System.Collections.Generic;

public class Primes_in_Given_Range
{
    public static void Main()
    {
        var startNumber = long.Parse(Console.ReadLine());
        var endNumber = long.Parse(Console.ReadLine());

        var listOfPrimesInRange = FindPrimesInRange(startNumber, endNumber);
        Console.WriteLine(string.Join(", ", listOfPrimesInRange));
    }

    private static List<long> FindPrimesInRange(long startNumber, long endNumber)
    {
        var primesList = new List<long>();

        for (long i = startNumber; i <= endNumber; i++)
        {
            if (IsPrime(i))
            {
                primesList.Add(i);
            }
        }
        return primesList;
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

