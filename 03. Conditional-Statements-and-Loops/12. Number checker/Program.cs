namespace _12.Number_checker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                var input = decimal.Parse(Console.ReadLine());

                Console.WriteLine("It is a number.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
