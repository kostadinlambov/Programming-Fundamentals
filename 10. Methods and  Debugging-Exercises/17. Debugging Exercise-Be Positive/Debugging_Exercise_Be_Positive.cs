using System;
using System.Collections.Generic;
using System.Linq;

public class Debugging_Exercise_Be_Positive
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            var numbersToPrint = new List<int>();

            int[] inputNumbers = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int j = 0; j < inputNumbers.Length; j++)
            {
                int currentNum = inputNumbers[j];

                if (currentNum >= 0)
                {
                    numbersToPrint.Add(currentNum);
                }
                else
                {
                    if (j < inputNumbers.Length - 1)
                    {
                        currentNum += inputNumbers[j + 1];

                        if (currentNum >= 0)
                        {
                            numbersToPrint.Add(currentNum);           
                        }
                    }

                    j++;
                }
            }

            if (numbersToPrint.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbersToPrint));
            }
            else
            {
                Console.WriteLine("(empty)");
            }
 
        }
    }
}

