using System;
using System.Linq;

public class Debugging___Sequence_of_Commands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] arrayOfNumbers = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            var stringParams = command
                .Split(ArgumentsDelimiter)
                .ToArray();

            int[] args = new int[2];

            if (stringParams[0].Equals("add") ||
                stringParams[0].Equals("subtract") ||
                stringParams[0].Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                PerformAction(arrayOfNumbers, stringParams[0], args);
            }
            else
            {
                PerformAction(arrayOfNumbers, stringParams[0], args);
            }
            
            PrintArray(arrayOfNumbers);

            command = Console.ReadLine();
        }
    }

    public static void PerformAction(long[] arrayOfNumbers, string action, int[] args)
    {
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arrayOfNumbers[pos] *= value;
                break;
            case "add":
                arrayOfNumbers[pos] += value;
                break;
            case "subtract":
                arrayOfNumbers[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arrayOfNumbers);
                break;
            case "rshift":
                ArrayShiftRight(arrayOfNumbers);
                break;
        }
    }

    public static void ArrayShiftRight(long[] array)
    {
        var lastNumber = array[array.Length-1];

        for (int i = array.Length-1; i >= 1; i--)
        {          
            array[i] = array[i - 1];
        }

        array[0] = lastNumber;
    }

    private static void ArrayShiftLeft(long[] array)
    {

        var firstNumber = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = firstNumber;
    }

    public static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
