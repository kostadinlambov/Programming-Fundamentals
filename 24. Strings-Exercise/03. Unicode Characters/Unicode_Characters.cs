using System;

namespace _03.Unicode_Characters
{
    public class Unicode_Characters
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var outputString = string.Empty;

            foreach (var letter in inputString)
            {
                var unicodeCharacter = $"\\u{(int)letter:x4}";
                outputString = string.Concat(outputString, unicodeCharacter);
            }

            Console.WriteLine(outputString);          
        }
    }
}
