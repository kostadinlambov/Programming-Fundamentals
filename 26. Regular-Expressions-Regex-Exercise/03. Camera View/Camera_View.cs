using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    public class Camera_View
    {
        public static void Main()
        {
            var numbersArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var elementsToSkip = numbersArr[0];
            var elementsToTake= numbersArr[1];

            var text = Console.ReadLine();

            string pattern = @"\|<";

            Regex regex = new Regex(pattern);

            string[] splitInputText= regex.Split(text);
              
            List<string> resultList = new List<string>();

            for (int i = 1; i < splitInputText.Length; i++)
            {
                var result = splitInputText[i]
                    .Skip(elementsToSkip)
                    .Take(elementsToTake)
                    .ToArray();

                resultList.Add(new string(result));
            }

            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
