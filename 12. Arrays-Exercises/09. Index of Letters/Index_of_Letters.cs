using System;

public class Index_of_Letters
{
    public static void Main()
    {
        var inputString = Console.ReadLine();

        for (int i = 0; i < inputString.Length; i++)
        {
            Console.WriteLine($"{inputString[i]} -> {inputString[i] - 'a'}");
        }
    }
}

