namespace _3.Back_in_30_Minutes
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 30;

            if (minutes >= 60)
            {
                minutes = minutes % 60;
                hours++;
            }

            if (hours >= 24)
            {
                hours = hours % 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
