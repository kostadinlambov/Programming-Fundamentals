using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    public class Valid_Usernames
    {
        public static void Main()
        {
            var listOfUsernames = Console.ReadLine();

            var pattern = @"\b(?<userName>[A-Za-z]\w{2,24})\b";
            Regex regex = new Regex(pattern);
            MatchCollection validUserNames = regex.Matches(listOfUsernames);

            var listOfValidUsers = validUserNames
                .Cast<Match>()
                .Select(x => x.Groups["userName"].Value)
                .ToList();

            var maxSum = int.MinValue;
            var currentSum = 0;
            var firstIndex = 0;
            var secondIndex = 0;

            for (int i = 0; i < listOfValidUsers.Count - 1; i++)
            {
                currentSum = listOfValidUsers[i].Length +
                             listOfValidUsers[i + 1].Length;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstIndex = i;
                    secondIndex = i + 1;
                }
            }

            Console.WriteLine(listOfValidUsers[firstIndex]);
            Console.WriteLine(listOfValidUsers[secondIndex]);
        }
    }
}
