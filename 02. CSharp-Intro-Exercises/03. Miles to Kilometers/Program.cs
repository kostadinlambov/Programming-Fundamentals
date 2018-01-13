namespace _3.Miles_to_Kilometers
{
   using System;

   public class Program
    {
        public static void Main()
        {
            var milesToConvert = double.Parse(Console.ReadLine());
            var convertingCoefficient = 1.60934;

            var kilometers = milesToConvert * convertingCoefficient;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
