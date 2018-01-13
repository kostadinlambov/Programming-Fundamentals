namespace _11.Odd_Number
{
    using System;

    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                var number = Math.Abs(int.Parse(Console.ReadLine()));
                if (number % 2 == 1)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}
