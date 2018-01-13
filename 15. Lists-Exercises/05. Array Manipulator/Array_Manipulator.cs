using System;
using System.Collections.Generic;
using System.Linq;

public class Array_Manipulator
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var commandInput = Console.ReadLine();

        while (commandInput != "print")
        {
            var token = commandInput
                  .Trim()
                  .Split(' ')
                  .ToList();

            var commandType = token[0];

            if (commandType == "add")
            {
                var index = int.Parse(token[1]);
                var element = int.Parse(token[2]);

                inputNumbers.Insert(index, element);
            }

            else if (commandType == "addMany")
            {
                var index = int.Parse(token[1]);

                var addRangeElements = token
                    .Skip(2)
                    .Select(int.Parse)
                    .ToList();

                inputNumbers.InsertRange(index, addRangeElements);
            }

            else if (commandType == "contains")
            {
                var element = int.Parse(token[1]);

                var indexOfElement = inputNumbers.IndexOf(element);

                Console.WriteLine(indexOfElement);
            }

            else if (commandType == "remove")
            {
                var index = int.Parse(token[1]);

                inputNumbers.RemoveAt(index);
            }

            else if (commandType == "shift")
            {
                var shiftPositions = int.Parse(token[1]);

                for (int j = 0; j < shiftPositions; j++)
                {
                    var firstElement = inputNumbers[0];

                    for (int i = 0; i < inputNumbers.Count - 1; i++)
                    {
                        inputNumbers[i] = inputNumbers[i + 1];
                    }

                    inputNumbers[inputNumbers.Count - 1] = firstElement;
                }
            }

            else if (commandType == "sumPairs")
            {
                var sumPairsList = new List<int>();

                if (inputNumbers.Count % 2 == 0)
                {
                    for (int i = 0; i < inputNumbers.Count; i += 2)
                    {
                        sumPairsList.Add(inputNumbers[i] + inputNumbers[i + 1]);
                    }                 
                }
                else
                {
                    for (int i = 0; i < inputNumbers.Count-1; i += 2)
                    {
                        sumPairsList.Add(inputNumbers[i] + inputNumbers[i + 1]);
                    }

                    sumPairsList.Add(inputNumbers[inputNumbers.Count-1]);
                }

                inputNumbers = sumPairsList;
            }

            commandInput = Console.ReadLine();
        }

        Console.WriteLine("[" + string.Join(", ", inputNumbers) + "]");
    }
}