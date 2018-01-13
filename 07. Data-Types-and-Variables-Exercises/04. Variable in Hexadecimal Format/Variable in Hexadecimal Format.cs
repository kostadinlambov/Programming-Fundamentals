using System;

public class Variable_in_Hexadecimal_Format
{
    public static void Main()
    {
        var hexafecimalNumber = Console.ReadLine();

        var decimalFormatNumber = Convert.ToInt32(hexafecimalNumber, 16);

        Console.WriteLine(decimalFormatNumber);
    }
}
