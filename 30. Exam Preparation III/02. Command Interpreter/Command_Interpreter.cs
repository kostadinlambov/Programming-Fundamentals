using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Command_Interpreter
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split()
                .Select(x => x.Trim())
                .ToList();

            var line = Console.ReadLine();

            while (!line.Equals("end"))
            {
                var commands = line
                    .Split();

                switch (commands[0])
                {
                    case "reverse":
                        var reverseStart = int.Parse(commands[2]);
                        var reverseCount = int.Parse(commands[4]);
                        ReverseMethod(elements, reverseStart, reverseCount);
                        break;

                    case "sort":
                        var sortStart = int.Parse(commands[2]);
                        var sortCount = int.Parse(commands[4]);
                        SortMethod(elements, sortStart, sortCount);
                        break;

                    case "rollRight":
                        var rollRightCount = int.Parse(commands[1]);
                        RollRightMethod(elements, rollRightCount);
                        break;

                    case "rollLeft":
                        var rollLeftCount = int.Parse(commands[1]);
                        RollLeftMethod(elements, rollLeftCount);
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", elements)}]");
        }

        private static bool IsValid(List<string> elements, int start, int count)
        {
            return start >= 0 && start < elements.Count &&
                   count >= 0 && (count + start) <= elements.Count;
        }

        private static void SortMethod(List<string> elements, int sortStart, int sortCount)
        {
            if (!IsValid(elements, sortStart, sortCount))
            {
                Console.WriteLine("Invalid input parameters.");
            }

            else
            {
                elements.Sort(sortStart, sortCount, null);
            }
        }

        private static void ReverseMethod(List<string> elements, int reverseStart, int reverseCount)
        {
            if (!IsValid(elements, reverseStart, reverseCount))
            {
                Console.WriteLine("Invalid input parameters.");
            }

            else
            {
                elements.Reverse(reverseStart, reverseCount);
            }
        }

        private static void RollLeftMethod(List<string> elements, int countForRoll)
        {
            if (countForRoll < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }

            else
            {
                var rotations = countForRoll % elements.Count;

                for (int i = 0; i < rotations; i++)
                {
                    var firstElement = elements.First();

                    elements.RemoveAt(0);
                    elements.Add(firstElement);
                }
            }
        }

        private static void RollRightMethod(List<string> elements, int countForRoll)
        {
            if (countForRoll < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }

            else
            {
                var rotations = countForRoll % elements.Count;

                for (int i = 0; i < rotations; i++)
                {
                    var lastElement = elements.Last();

                    elements.RemoveAt(elements.Count - 1);
                    elements.Insert(0, lastElement);
                }
            }





        }
    }
}
