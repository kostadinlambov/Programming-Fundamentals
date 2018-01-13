namespace _3.Megapixels
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var width = int.Parse(Console.ReadLine());
            var heigth = int.Parse(Console.ReadLine());

            var megapixels = (width * heigth)/ 1000000.0;

            Console.WriteLine($"{width}x{heigth} => {Math.Round(megapixels, 1)}MP");
        }
    }
}
