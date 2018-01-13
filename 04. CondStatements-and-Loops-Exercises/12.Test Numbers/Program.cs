namespace _12.Test_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var seconNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var product = 1;
            var sum = 0;
            var countOfCombinations = 0;

            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= seconNumber; j++)
                {
                    product = i * j * 3;
                    sum += product;
                    countOfCombinations++;

                    if (sum >= thirdNumber)
                    {
                        Console.WriteLine($"{countOfCombinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {thirdNumber}");
                        return;
                    }
                   
                }
            }

           if(sum <= thirdNumber)
            {
                Console.WriteLine($"{countOfCombinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}

