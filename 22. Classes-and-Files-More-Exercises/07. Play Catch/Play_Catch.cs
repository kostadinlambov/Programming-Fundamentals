using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Play_Catch
{
    public class Play_Catch
    {
        public static void Main()
        {
            var numbersArr = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var numberOfExceptions = 0;

            while (numberOfExceptions < 3)
            {
                var tokens = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var command = tokens[0];

                try
                {
                    switch (command)
                    {
                        case "Replace":
                            var index = int.Parse(tokens[1]);
                            var element = int.Parse(tokens[2]);
                            numbersArr[index] = element;
                            break;
                        case "Print":
                            var startIndex = int.Parse(tokens[1]);
                            var endIndex = int.Parse(tokens[2]);

                            var listToPrint = new List<int>();
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                               listToPrint.Add(numbersArr[i]);
                            }
                            Console.WriteLine(string.Join(", ", listToPrint));
                            break;
                        case "Show":
                            var indexToShow = int.Parse(tokens[1]);
                            Console.WriteLine(numbersArr[indexToShow]);
                            break;
                    }
                }
                catch (Exception exc)
                {
                    if (exc is IndexOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        numberOfExceptions++;
                    }
                    else if (exc is FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        numberOfExceptions++;
                    }
                }           
            }

            Console.WriteLine(string.Join(", ", numbersArr));
        }
    }
}
