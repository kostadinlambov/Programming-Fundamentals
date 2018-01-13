using System;

public class Greeting
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int years = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}. You are {years} years old.");
    }
}
