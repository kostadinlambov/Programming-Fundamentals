using System;
using System.Linq;

public class Extract_Middle_1__2_or_3_Elements
{
    public static void Main(string[] args)
    {
        var numbersArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        if (numbersArr.Length == 1)
        {
            Console.WriteLine("{ " + string.Join(", ", numbersArr) + " }");           
        }
        else if (numbersArr.Length % 2 == 0)
        {
            var elementsToPrint = new int[2];
            var j = 0;

            for (int i = numbersArr.Length / 2 - 1; i <= numbersArr.Length / 2; i++)
            {
                elementsToPrint[j] = numbersArr[i];
                j++;
            }
            
            Console.WriteLine("{ " + string.Join(", ", elementsToPrint) + " }");
        }
        else if (numbersArr.Length % 2 == 1)
        {
            var elementsToPrint = new int[3];
            var j = 0;

            for (int i = numbersArr.Length / 2 - 1; i <= numbersArr.Length / 2 + 1; i++)
            {
                elementsToPrint[j] = numbersArr[i];
                j++;
            }

            Console.WriteLine("{ " + string.Join(", ", elementsToPrint) + " }");
        }
    }
}