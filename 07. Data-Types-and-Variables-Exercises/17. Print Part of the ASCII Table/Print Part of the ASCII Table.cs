using System;

public class Print_Part_of_the_ASCII_Table
{
    public static void Main()
    {
        var startCharIndex = int.Parse(Console.ReadLine());
        var endCharIndex = int.Parse(Console.ReadLine());

        for (int i = startCharIndex; i <= endCharIndex; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}