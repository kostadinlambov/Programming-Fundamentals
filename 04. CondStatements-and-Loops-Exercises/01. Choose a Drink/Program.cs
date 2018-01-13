namespace _1.Choose_a_Drink
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var profession = Console.ReadLine();

            if (profession == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else 
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
