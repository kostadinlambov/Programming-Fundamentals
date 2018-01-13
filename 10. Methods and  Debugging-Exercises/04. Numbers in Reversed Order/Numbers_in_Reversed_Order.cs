using System;

public class Numbers_in_Reversed_Order
{
    public static void Main()
    {
        var number = Console.ReadLine();

        var reversedNumber = ReverseDigitsInNumber(number);
        Console.WriteLine(reversedNumber);
    }

    public static string ReverseDigitsInNumber(string number)
    {
        string reversedNumber= string.Empty;

        for (int i = 0; i < number.Length; i++)
        {
            reversedNumber += number[number.Length - 1 - i];
        }
        return reversedNumber;
    }
}