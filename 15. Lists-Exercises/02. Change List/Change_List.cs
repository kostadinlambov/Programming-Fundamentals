using System;
using System.Collections.Generic;
using System.Linq;

public class Change_List
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var command = Console.ReadLine();

        while (command != "Odd" && command != "Even")
        {
            var token = command
                .Trim()
                .Split(' ')
                .ToList();

            if (token[0] == "Delete")
            {
                var numberToRemove = int.Parse(token[1]);
                numbers.RemoveAll(x => x == numberToRemove);
            }
            else if (token[0]== "Insert")
            {
                var elementToInsert = int.Parse(token[1]);
                var index = int.Parse(token[2]);

                numbers.Insert(index, elementToInsert);
            }

            command = Console.ReadLine();
        }

        var listOfOddNumbers = new List<int>();
        var listOfEvenNumbers = new List<int>();

        if (command == "Odd")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    listOfOddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", listOfOddNumbers));
        }
        else if (command == "Even")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    listOfEvenNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", listOfEvenNumbers));
        }
    }
}

