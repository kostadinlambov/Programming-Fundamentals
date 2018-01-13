using System;

public class Multiply_Evens_by_Odds
{
    public static void Main()
    {
        var digits = int.Parse(Console.ReadLine());

        var product = GetMultipleOfEvensAndOdds(Math.Abs(digits));

        Console.WriteLine(product);
    }

    public static int GetMultipleOfEvensAndOdds(int digits)
    {        
        var sumOddDigits = 0;
        var sumEvenDigits = 0;

        while (digits > 0)
        {         
            var lastDigit = digits % 10;

            if (lastDigit % 2 == 1)
            {
                sumOddDigits += lastDigit;
            }
            else
            {
                sumEvenDigits += lastDigit;
            }

            digits = digits / 10;
        }

        var productEvenOddNumbers = sumEvenDigits * sumOddDigits;

        return productEvenOddNumbers;
    }
}

