using System;
using System.Numerics;

public class Poke_Mon
{
    public static void Main()
    {
        var pokePower = long.Parse(Console.ReadLine());
        var distance = long.Parse(Console.ReadLine());
        var exhaustionFactor = long.Parse(Console.ReadLine());

        var startPokePower = pokePower;

        var count = 0;

        while (true)
        {
            if (pokePower < distance)
            {
                Console.WriteLine(pokePower);
                Console.WriteLine(count);
                break;
            }
            if (startPokePower / 2 == pokePower && exhaustionFactor > 0)
            {
                pokePower /= exhaustionFactor;
            }
            if (pokePower >= distance)
            {
                pokePower -= distance;
                count++;
            }
        }
    }
}

