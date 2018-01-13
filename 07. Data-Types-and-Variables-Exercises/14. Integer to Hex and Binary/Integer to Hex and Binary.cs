using System;

public class Integer_to_Hex_and_Binary
{
    public static void Main()
    {
        var decimalNumber = int.Parse(Console.ReadLine());

        var hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper();
        var binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine(hexadecimalNumber);
        Console.WriteLine(binaryNumber);
    }
}
