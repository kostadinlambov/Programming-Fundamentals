using System;
using System.Linq;

public class Manipulate_Array
{
    public static void Main()
    {
        var inputStringArr = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            var command = Console.ReadLine()
                .Split(' ')
                .ToArray();
                
            if (command[0] == "Distinct")
            {
                inputStringArr = inputStringArr
                    .Distinct()
                    .ToArray();
            }
            else if (command[0] == "Reverse")
            {
                inputStringArr = inputStringArr
                    .Reverse()
                    .ToArray();
            }
            else if (command[0] == "Replace")
            {
                inputStringArr[int.Parse(command[1])] = command[2];
            }
        }

        Console.WriteLine(string.Join(", ", inputStringArr));
    }
}

