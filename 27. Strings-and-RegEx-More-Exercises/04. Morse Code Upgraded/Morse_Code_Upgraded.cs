using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Morse_Code_Upgraded
{
    public class Morse_Code_Upgraded
    {
        public static void Main()
        {
            var message = Console.ReadLine()
                .Split('|')
                .ToArray();

            var decipheredMessage = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                var pattern = @"((?<zeros>0+)|(?<ones>1+))";

                var regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(message[i]);

                var sum = 0;

                foreach (Match match in matches)
                {
                    if (match.Value.Equals(match.Groups["zeros"].Value))
                    {
                        sum += match.Groups["zeros"].Value.Length * 3;
                        if (match.Groups["zeros"].Value.Length > 1)
                        {
                            sum += match.Groups["zeros"].Value.Length;
                        }
                    }
                    else if (match.Value.Equals(match.Groups["ones"].Value))
                    {
                        sum += match.Groups["ones"].Value.Length * 5;
                        if (match.Groups["ones"].Value.Length > 1)
                        {
                            sum += match.Groups["ones"].Value.Length;
                        }                  
                    }                   
                }

                decipheredMessage.Append((char)sum);
            }

            Console.WriteLine(decipheredMessage.ToString());
        }
    }
}
