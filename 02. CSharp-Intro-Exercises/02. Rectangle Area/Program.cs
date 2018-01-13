namespace _2.Rectangle_Area
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;

            Console.WriteLine($"{area:F2}");
        }
    }
}
