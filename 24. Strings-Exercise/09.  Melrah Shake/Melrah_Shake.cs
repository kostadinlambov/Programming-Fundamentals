using System;

namespace _09.Melrah_Shake
{
    public class Melrah_Shake
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstMatch = inputString.IndexOf(pattern);
                var lastMatch = inputString.LastIndexOf(pattern);

                if (firstMatch >= 0 && lastMatch >= 0 && pattern.Length > 0)
                {
                    inputString = inputString.Remove(lastMatch, pattern.Length);
                    inputString = inputString.Remove(firstMatch, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(inputString);
                    break;
                }
            }
        }
    }
}
