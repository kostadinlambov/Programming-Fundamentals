using System;

public class Exchange_Variable_Values
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before:\na = {a}\nb = {b}");

        int tempVariable = a;
        a = b;
        b = tempVariable;

        Console.WriteLine($"After:\na = {a}\nb = {b}");
    }
}