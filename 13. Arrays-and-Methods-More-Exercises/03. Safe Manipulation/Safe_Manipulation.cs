using System;
using System.Linq;

public class Safe_Manipulation
{
    public static void Main()
    {
        var inputStringArr = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var command = Console.ReadLine()
            .Split(' ')
            .ToArray();

        while (command[0] != "END")
        {
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
                var replaceIndex = int.Parse(command[1]);

                if (replaceIndex <= inputStringArr.Length - 1 && replaceIndex >= 0)
                {
                    inputStringArr[replaceIndex] = command[2];
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            command = Console.ReadLine()
                .Split(' ')
                .ToArray();
        }

        Console.WriteLine(string.Join(", ", inputStringArr));
    }
}

