using System;
using System.Linq;

namespace _03.Karate_Strings
{
    public class Karate_Strings
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().ToList();

            var totalStrength = 0;

            for (int i = 0; i < inputLine.Count; i++)
            {
                if (inputLine[i].Equals('>'))
                {
                  var currentStrength = inputLine[i + 1] - '0';
                    totalStrength += currentStrength;

                    var distanceToNextGreaterThanSign = inputLine.Skip(i+1).ToList().IndexOf('>');

                    if (distanceToNextGreaterThanSign > 0)
                    {
                        if (distanceToNextGreaterThanSign >= totalStrength)
                        {
                            inputLine.RemoveRange(i + 1, totalStrength);
                            totalStrength -= currentStrength;
                        }
                        else
                        {
                            inputLine.RemoveRange(i + 1, distanceToNextGreaterThanSign);

                            totalStrength -= distanceToNextGreaterThanSign;
                        }
                    }
                    else
                    {
                        if (i+1 + totalStrength > inputLine.Count - 1)
                        {
                            inputLine.RemoveRange(i + 1, inputLine.Count - i -1);
                        }
                        else
                        {
                            inputLine.RemoveRange(i + 1, totalStrength);
                        }                     
                    }
                }
            }

            Console.WriteLine(string.Join("", inputLine));
        }
    }
}
