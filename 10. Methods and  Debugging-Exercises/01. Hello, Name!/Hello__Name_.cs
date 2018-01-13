using System;

public class Hello__Name_
{
    public static void Main()
    {
        var name = Console.ReadLine();

        PrintName(name);
    }

    public static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
