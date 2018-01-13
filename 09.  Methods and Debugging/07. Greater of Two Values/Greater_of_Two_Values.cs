using System;

public class Greater_of_Two_Values
{
    public static void Main()
    {
        var variableType = Console.ReadLine();

        if (variableType == "int")
        {
            var firstValue = int.Parse(Console.ReadLine());
            var secondValue = int.Parse(Console.ReadLine());
            var result = GetMax(firstValue, secondValue);
            Console.WriteLine(result);
        }
        else if (variableType == "char")
        {
            var firstValue = char.Parse(Console.ReadLine());
            var secondValue = char.Parse(Console.ReadLine());
            var result = GetMax(firstValue, secondValue);
            Console.WriteLine(result);
        }
        else if (variableType == "string")
        {
            var firstValue = Console.ReadLine();
            var secondValue = Console.ReadLine();
            var result = GetMax(firstValue, secondValue);
            Console.WriteLine(result);
        }
    }

    public static int GetMax(int firstValue, int secondValue)
    {
        var maxValue = Math.Max(firstValue, secondValue);
        return maxValue;
    }

    public static char GetMax(char firstValue, char secondValue)
    {
        var maxValue = Math.Max(firstValue, secondValue);
        return (char)maxValue;
    }

    public static string GetMax(string firstValue, string secondValue)
    {
        if (firstValue.CompareTo(secondValue) >= 0)
        {
            return firstValue;
        }

        return secondValue;
    }
}

