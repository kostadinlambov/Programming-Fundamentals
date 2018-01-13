namespace _1.Debit_Card_Number
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber:D4} {secondNumber:D4} " +
                              $"{thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
