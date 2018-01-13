namespace _11._5_Different_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = i+1; j <= secondNumber; j++)
                {
                    for (int k = j+1; k <= secondNumber; k++)
                    {
                        for (int l = k+1; l <= secondNumber; l++)
                        {
                            for (int m = l+1; m <= secondNumber; m++)
                            {
                                counter++;
                                Console.WriteLine($"{i} {j} {k} {l} {m} ");
                            } 
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
