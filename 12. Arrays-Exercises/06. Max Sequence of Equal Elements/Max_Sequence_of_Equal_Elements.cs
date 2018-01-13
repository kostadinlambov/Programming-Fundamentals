using System;
using System.Linq;

public class Max_Sequence_of_Equal_Elements
{
    public static void Main()
    {
        var inputLines = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var startIndex = 0;
        var endIndex = 0;
        var maxLength = 0;
        var length = 1;

        for (int i = 0; i < inputLines.Length - 1; i++)
        {
            if (inputLines[i] == inputLines[i+1])
            {
                length++;

                if ( length > maxLength)
                {
                    maxLength = length;
                    startIndex = i-maxLength + 2 ;
                    endIndex = i +1;
                }                               
            }
            else
            {
                length = 1;
            }       
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(inputLines[i] + " ");
        }
        Console.WriteLine();
    }
}

