namespace _9.Count_the_Integers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var counter = 0;
            while (true)
            {
                try
                {
                    var inputLine = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch 
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
