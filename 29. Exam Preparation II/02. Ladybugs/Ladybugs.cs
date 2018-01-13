using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.LadybugsNew
{
    public class LadybugsNew
    {
        public static void Main()
        {
            var sizeOfTheField = int.Parse(Console.ReadLine());

            var rangeOfTheBugsArr = new long[sizeOfTheField];

            var indexesOfAllLadyBugs = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(long.Parse)
                .Where(x => x < sizeOfTheField && x >= 0)
                .Distinct()
                .ToList();

            indexesOfAllLadyBugs.Sort();

            foreach (var index in indexesOfAllLadyBugs)
            {
                rangeOfTheBugsArr[index] = 1;
            }

            var command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                var tokens = command
                    .Split(' ')
                    .ToList();

                var ladyBugIndex = long.Parse(tokens[0]);
                var flyDirection = tokens[1];
                var flyLength = long.Parse(tokens[2]);

                if (ladyBugIndex > rangeOfTheBugsArr.Length - 1 && ladyBugIndex < 0)
                {
                    continue;
                }

                if (ladyBugIndex < rangeOfTheBugsArr.Length && ladyBugIndex >= 0
                    && rangeOfTheBugsArr[ladyBugIndex] == 1)
                {
                    if (flyDirection.Equals("right"))
                    {
                        MoveRight(ladyBugIndex, flyLength, rangeOfTheBugsArr);
                    }
                    else if (flyDirection.Equals("left"))
                    {
                        MoveLeft(ladyBugIndex, flyLength, rangeOfTheBugsArr);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", rangeOfTheBugsArr));
        }

        private static void MoveLeft(long ladyBugIndex, long flyLength, long[] rangeOfTheBugsArr)
        {

            long newIndex = ladyBugIndex - flyLength;
            rangeOfTheBugsArr[ladyBugIndex] = 0;

            if (newIndex >= 0 && newIndex < rangeOfTheBugsArr.Length
                && rangeOfTheBugsArr[newIndex] == 0)
            {
                rangeOfTheBugsArr[newIndex] = 1;
                return;
            }
            while (newIndex >= 0 && newIndex < rangeOfTheBugsArr.Length
                   && rangeOfTheBugsArr[newIndex] == 1)
            {

                newIndex -= flyLength;

                if (newIndex >= 0 && newIndex < rangeOfTheBugsArr.Length
                    && rangeOfTheBugsArr[newIndex] == 0)
                {
                    rangeOfTheBugsArr[newIndex] = 1;
                    break;
                }
                if (newIndex < 0 && newIndex > rangeOfTheBugsArr.Length - 1)
                {
                    break;
                }
            }
        }

        public static void MoveRight(long ladyBugIndex, long flyLength, long[] rangeOfTheBugsArr)
        {
            long newIndex = ladyBugIndex + flyLength;
            rangeOfTheBugsArr[ladyBugIndex] = 0;

            if (newIndex >= 0 && newIndex < rangeOfTheBugsArr.Length
                && rangeOfTheBugsArr[newIndex] == 0)
            {
                rangeOfTheBugsArr[newIndex] = 1;
                return;
            }
            while (newIndex >= 0 && newIndex < rangeOfTheBugsArr.Length)
            {
                newIndex += flyLength;

                if (newIndex >= 0 && newIndex < rangeOfTheBugsArr.Length
                    && rangeOfTheBugsArr[newIndex] == 0)
                {
                    rangeOfTheBugsArr[newIndex] = 1;
                    break;
                }
                if (newIndex < 0 && newIndex > rangeOfTheBugsArr.Length - 1)
                {
                    break;
                }
            }
        }
    }
}
