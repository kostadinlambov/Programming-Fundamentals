using System;

public class Master_Numbers
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (IsSumDivisibleBySeven(i) && IsSymmetric(i)
                && HasOneEvenDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool HasOneEvenDigit(int number)
    {
        while (number > 0)
        {
            var lastDigit = number % 10;
            if (lastDigit % 2 == 0)
            {
                return true;
            }
            number = number / 10;
        }
        return false;
    }

    public static bool IsSumDivisibleBySeven(int number)
    {
        var sumOfDigits = 0;
        while (number > 0)
        {
            var lastDigit = number % 10;
            number = number / 10;
            sumOfDigits += lastDigit;
        }

        if (sumOfDigits % 7 == 0)
        {
            return true;
        }
        return false;
    }

    public static bool IsSymmetric(int number)
    {
        var reversedNumber = string.Empty;
        var inputNumberAsString = number.ToString();

        for (int j = 0; j < inputNumberAsString.Length; j++)
        {
            reversedNumber += inputNumberAsString[inputNumberAsString.Length - 1 - j];
        }

        for (int i = 0; i < inputNumberAsString.Length; i++)
        {
            if (inputNumberAsString[i] != reversedNumber[i])
            {
                return false;
            }
        }

        return true;
    }
}

