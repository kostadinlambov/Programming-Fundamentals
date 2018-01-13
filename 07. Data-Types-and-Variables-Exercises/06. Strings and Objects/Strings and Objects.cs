using System;

public class Strings_and_Objects
{
    public static void Main()
    {
        string firstVariable = "Hello";
        string secondVariable = "World";

        object variableConcatenation = firstVariable + " " + secondVariable;

        string thirdVariable = (string)variableConcatenation;

        Console.WriteLine(thirdVariable);
    }
}
