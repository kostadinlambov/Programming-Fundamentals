using System;
using System.Linq;

public class Sieve_of_Eratosthenes
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var primes = new bool[number + 1];

        primes = Enumerable
            .Repeat(true, number+1)
            .ToArray();

        primes[0] = primes[1] = false;

        for (int i = 2; i <= number; i++)
        {
            if (primes[i] == true)
            {
                Console.Write(i + " ");

                var n = 1;
   
                while (n * i <= number)
                {
                    primes[n * i] = false;
                    n++;
                }
            }           
        }

        Console.WriteLine();
    }
}

