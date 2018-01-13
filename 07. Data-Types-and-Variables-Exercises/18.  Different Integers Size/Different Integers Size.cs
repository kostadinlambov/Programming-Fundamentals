using System;

public class Different_Integers_Size
{
    public static void Main()
    {
        var inputInteger = Console.ReadLine();

        try
        {
            long n = long.Parse(inputInteger);

            Console.WriteLine($"{n} can fit in:");

            if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
            {              
                Console.WriteLine($"* sbyte");
            }

            if (n >= byte.MinValue && n <= byte.MaxValue)
            {
                Console.WriteLine($"* byte");
            }

            if (n >= short.MinValue && n <= short.MaxValue)
            {
                Console.WriteLine($"* short");
            }

            if (n >= ushort.MinValue && n <= ushort.MaxValue)
            {
                Console.WriteLine($"* ushort");
            }

            if (n >= int.MinValue && n <= int.MaxValue)
            {
                Console.WriteLine($"* int");
            }

            if (n >= uint.MinValue && n <= uint.MaxValue)
            {
                Console.WriteLine($"* uint");
            }

            if (n >= long.MinValue && n <= long.MaxValue)
            {
                Console.WriteLine($"* long");
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine($"{inputInteger} can't fit in any type");
        }
    }
}