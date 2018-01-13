namespace _13.Game_of_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstNumberInput = int.Parse(Console.ReadLine());
            var secondNumberInput = int.Parse(Console.ReadLine());

            var magicalNumber = int.Parse(Console.ReadLine());

            var countOfCombinations = 0;
            var sum = 0;
            var firstNumber = 0;
            var secondNumber = 0;
            var magicNumbersCount = 0;

            for (int i = firstNumberInput; i <= secondNumberInput; i++)
            {
                for (int j = firstNumberInput; j <= secondNumberInput; j++)
                {
                    
                    sum = i + j;
                    countOfCombinations++;

                    if (sum == magicalNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                        magicNumbersCount++;
                    }
                }
            }

            if (magicNumbersCount > 0)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{countOfCombinations} combinations - neither equals {magicalNumber}");
            }          
        }
    }
}
