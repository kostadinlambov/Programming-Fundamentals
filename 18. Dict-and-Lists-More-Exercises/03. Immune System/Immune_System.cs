using System;
using System.Collections.Generic;

public class Immune_System
{
    public static void Main()
    {
        var virurNameTimeToDefeatDict = new Dictionary<string, int>();

        var initialHealth = long.Parse(Console.ReadLine());
        var remainingHealth = initialHealth;

        var inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            var virusStrength = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {
                virusStrength += inputLine[i];
            }

            virusStrength = virusStrength / 3;

            if (!virurNameTimeToDefeatDict.ContainsKey(inputLine))
            {
                virurNameTimeToDefeatDict[inputLine] = virusStrength * inputLine.Length; ;
            }
            else
            {
                virurNameTimeToDefeatDict[inputLine] = virusStrength * inputLine.Length / 3;
            }

            var minutesToDefeatTheVirus = virurNameTimeToDefeatDict[inputLine] / 60;
            var secondsToDefeatTheVirus = virurNameTimeToDefeatDict[inputLine] % 60;

            if (remainingHealth >= virurNameTimeToDefeatDict[inputLine])
            {
                remainingHealth -= virurNameTimeToDefeatDict[inputLine];

                Console.WriteLine($"Virus {inputLine}: {virusStrength} => " +
                                  $"{virurNameTimeToDefeatDict[inputLine]} seconds");
                Console.WriteLine($"{inputLine} defeated in" +
                                  $" {minutesToDefeatTheVirus}m {secondsToDefeatTheVirus}s.");

                Console.WriteLine($"Remaining health: {remainingHealth}");
            }
            else
            {
                Console.WriteLine($"Virus {inputLine}: {virusStrength} => " +
                                  $"{virurNameTimeToDefeatDict[inputLine]} seconds");
                Console.WriteLine("Immune System Defeated.");
                return;
            }

            var regainedImmunsystemStrength = (long)(remainingHealth * 1.2);

            if (regainedImmunsystemStrength > initialHealth)
            {
                remainingHealth = initialHealth;
            }
            else
            {
                remainingHealth = regainedImmunsystemStrength;
            }

            inputLine = Console.ReadLine();
        }

        Console.WriteLine($"Final Health: {(int)remainingHealth}");
    }
}

