using System;

public class String_Concatenation
{
    public static void Main()
    {
        var delimiter = char.Parse(Console.ReadLine());
        var evenOrOdd = Console.ReadLine();
        var numberOfLines = int.Parse(Console.ReadLine());

        string stringConcatenation = null;

        for (int i = 1; i <= numberOfLines; i++)
        {
            var inputString = Console.ReadLine();

            if (evenOrOdd == "even" && i % 2 == 0)
            {
                stringConcatenation += inputString + delimiter;
            }
            else if (evenOrOdd == "odd" && i % 2 == 1)
            {
                stringConcatenation += inputString + delimiter;
            }
        }

        var outputString = stringConcatenation.TrimEnd(delimiter);

        Console.WriteLine(outputString);
    }
}