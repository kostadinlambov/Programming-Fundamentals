using System.Diagnostics;

namespace _8.Sum_of_Odd_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var counter = 0;
            var current = 1;
            var sum = 0;
            while (counter != n)
            {
                if(current % 2 == 1)
                {                 
                    counter++;
                    sum += current;
                    Console.WriteLine(current);
                }

                current++;
            }
            Console.WriteLine($"Sum: {sum}");

            //var n = int.Parse(Console.ReadLine());
            //var current = 1;
            //var sum = 0;

            //while (n > 0)
            //{
            //    Console.WriteLine(current);
            //    sum += current;
            //    current = current + 2;
            //    n--;
            //}
            //Console.WriteLine($"Sum: {sum}");
        }
    }
}
