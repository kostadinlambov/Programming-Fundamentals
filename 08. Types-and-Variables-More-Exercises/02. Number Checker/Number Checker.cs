using System;

public class Number_Checker
{
    public static void Main()
    {
        var inputNumber = Console.ReadLine();

        try
        {
            long integerNumber = long.Parse(inputNumber);
            Console.WriteLine("integer");
        }
        catch 
        {
            Console.WriteLine("floating-point");           
        }
    }
}