using System;
using System.Text;

namespace _08.Mines
{
    public class Mines
    {
        public static void Main()
        {
            var path = Console.ReadLine();

            int startIndex = 0;
            int endIndex = 0;

            while ((startIndex = path.IndexOf("<", startIndex)) != -1
                   && (endIndex = path.IndexOf(">", startIndex)) != -1)
            {
                string bombChars = path.Substring(startIndex + 1, 2);
                int bombStrength = CalculateMineStr(bombChars);

                int leftFromTheBomb = Math.Max(0, startIndex - bombStrength);
                int rightFromTheBomb = Math.Min(path.Length - 1, endIndex + bombStrength);

                var sb = new StringBuilder(path);

                for (int i = leftFromTheBomb; i <= rightFromTheBomb; i++)
                {
                    sb[i] = '_';
                }

                path = sb.ToString();
            }

            Console.WriteLine(path);
        }

        private static int CalculateMineStr(string bombChars)
        {
            return Math.Abs(bombChars[0] - bombChars[1]);
        }
    }
}
