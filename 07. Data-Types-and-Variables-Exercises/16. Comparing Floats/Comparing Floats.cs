using System;

public class Comparing_Floats
{
    public static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        var difference = Math.Abs(firstNumber - secondNumber);

        Console.WriteLine(difference > eps ? "False" : "True");
    }
}

