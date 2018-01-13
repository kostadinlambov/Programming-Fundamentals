using System;

public class Max_Method
{
    public static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var thirdNumber = int.Parse(Console.ReadLine());

        var maxNumber = GetMax(firstNumber,
            GetMax(secondNumber, thirdNumber));

        Console.WriteLine(maxNumber);
    }

    public static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }
}