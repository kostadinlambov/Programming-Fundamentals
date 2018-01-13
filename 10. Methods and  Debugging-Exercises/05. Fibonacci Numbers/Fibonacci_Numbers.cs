using System;

public class Fibonacci_Numbers
{
    public static void Main()
    {

        var number = int.Parse(Console.ReadLine());

        PrintFibonacciNúmber(number);
    }

    public static void PrintFibonacciNúmber(int number)
    {
        var fibonacciNumber = 0;

        if (number == 0 || number == 1)
        {
            fibonacciNumber = 1;
        }
        else 
        {
            var firstNumber = 1;
            var secondNumber = 1;

            for (int i = 2; i <= number; i++)
            {
                fibonacciNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fibonacciNumber;
            }
        }

        Console.WriteLine(fibonacciNumber);
    }
}
