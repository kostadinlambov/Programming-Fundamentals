namespace _10.Triangle_of_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
