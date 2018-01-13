namespace _7.Sum_Arrays
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var arr2 = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (arr1.Length >= arr2.Length)
            {
                var newArr2 = new int[arr1.Length];
                var sum = new int[arr1.Length];

                for (int i = 0; i < arr1.Length; i++)
                {
                    newArr2[i] = arr2[i % arr2.Length];
                    sum[i] = arr1[i] + newArr2[i];
                }

                Console.WriteLine(string.Join(" ", sum));
            }
            else
            {
                var newArr1 = new int[arr2.Length];
                var sum = new int[arr2.Length];

                for (int i = 0; i < arr2.Length; i++)
                {
                    newArr1[i] = arr1[i % arr1.Length];
                    sum[i] = arr2[i] + newArr1[i];
                }

                Console.WriteLine(string.Join(" ", sum));
            }
        }
    }
}
