using System;

public class Reverse_an_Array_of_Integers
{
    public static void Main()
    {
        var countOfNumbers = int.Parse(Console.ReadLine());
        var inputArr = new int[countOfNumbers];

        for (int i = 0; i < countOfNumbers; i++)
        {
            inputArr[i] = int.Parse(Console.ReadLine());
        }

        var reversedArr = new int[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            reversedArr[i] = inputArr[inputArr.Length - 1 - i];
        }

        Console.WriteLine(string.Join(" ", reversedArr));
    }
}

