using System;
using System.Linq;

namespace _04.Character_Multiplier
{
    public class Character_Multiplier
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .ToArray();
          
            var result = MiltiplyStrings(inputLine[0], inputLine[1]);
            Console.WriteLine(result);
        }

        private static long MiltiplyStrings(string firstString, string secondString)
        {
            var sum = 0L;

            if (firstString.Length >= secondString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    var product = firstString[i] * secondString[i];
                    sum += product;
                }
                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    var product = secondString[i] * firstString[i];
                    sum += product;
                }
                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }

            return sum;
        }
    }
}
