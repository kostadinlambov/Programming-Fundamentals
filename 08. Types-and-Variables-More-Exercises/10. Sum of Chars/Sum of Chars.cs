using System;

public class Sum_of_Chars
{
    public static void Main()
    {
        var numberOfCharacters = int.Parse(Console.ReadLine());

        var totalSum = 0;

        for (int i = 0; i < numberOfCharacters; i++)
        {
            var character = char.Parse(Console.ReadLine());

            totalSum += character;
        }

        Console.WriteLine($"The sum equals: {totalSum}");
    }
}
