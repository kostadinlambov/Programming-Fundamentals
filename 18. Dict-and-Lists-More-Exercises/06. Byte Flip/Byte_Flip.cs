using System;
using System.Collections.Generic;
using System.Linq;

public class Byte_Flip
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Split(' ')
            .ToList();       

        for (int i = 0; i < inputNumbers.Count; i++)
        {
            if (inputNumbers[i].Length != 2)
            {
                inputNumbers.RemoveAt(i);
                i--;
            }
            else
            {
                var inputNumbersCharArr = inputNumbers[i].ToCharArray();
                Array.Reverse(inputNumbersCharArr);
                inputNumbers[i] = string.Join("", inputNumbersCharArr);
            }
        }

        inputNumbers.Reverse();

        var intFromHexNumbers = new List<int>();
        var outputString = string.Empty;
        for (int i = 0; i < inputNumbers.Count; i++)
        {
            intFromHexNumbers.Add(Convert.ToInt32(inputNumbers[i], 16));
            outputString += (char)intFromHexNumbers[i];
        }

        Console.WriteLine(outputString);
    }
}

