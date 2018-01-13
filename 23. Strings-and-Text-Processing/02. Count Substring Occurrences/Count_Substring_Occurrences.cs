using System;

namespace _02.Count_Substring_Occurrences
{
    public class Count_Substring_Occurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var stringToFindIntoText = Console.ReadLine().ToLower();

            var count = 0;
            var index = -1;
            while ((index = text.IndexOf(stringToFindIntoText, index+1)) >= 0)
            {
                 count++;                 
            }

            Console.WriteLine(count);
        }
    }
}

