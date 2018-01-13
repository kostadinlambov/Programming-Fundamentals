using System;

public class Boolean_Variable
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var booleanVariable = Convert.ToBoolean(inputLine);

        Console.WriteLine(booleanVariable ? "Yes" : "No");
    }
}