namespace _1.X___Problem
{
    using System;

    public class Program
    {
        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', i) + "x"
                    + new string(' ', n - 2 - 2 * i) + "x");
            }

            Console.WriteLine(new string(' ', n / 2) + "x");

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', n / 2 - 1 - i) + "x"
                                  + new string(' ', 1 + 2 * i) + "x");
            }

        }
    }
}
