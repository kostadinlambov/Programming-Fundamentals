using System;
using System.Linq;

public class Largest_Common_End
{
    public static void Main()
    {
        var firstWordsArr = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var secondWordsArr = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var firstWordsArrReversed = firstWordsArr
            .Reverse()
            .ToArray();

        var secondWordsArrReversed = secondWordsArr
            .Reverse()
            .ToArray();

        var countForwards = 0;
        var countBackwards = 0;
             
        if (firstWordsArr.Length >= secondWordsArr.Length)
        {
            for (int i = 0; i < secondWordsArr.Length; i++)
            {
                if (firstWordsArr[i].CompareTo(secondWordsArr[i]) == 0)
                {
                    countForwards++;
                }
                else
                {
                    break;
                }
                
            }

            for (int i = 0; i < secondWordsArr.Length; i++)
            {
                if (firstWordsArrReversed[i].CompareTo(secondWordsArrReversed[i]) == 0)
                {
                    countBackwards++;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(countForwards >= countBackwards ? countForwards : countBackwards);
        }
        else
        {
            for (int i = 0; i < firstWordsArr.Length; i++)
            {
                if (firstWordsArr[i].CompareTo(secondWordsArr[i]) == 0)
                {
                    countForwards++;
                }
                else
                {
                    break;
                }

            }

            for (int i = 0; i < firstWordsArr.Length; i++)
            {
                if (firstWordsArrReversed[i].CompareTo(secondWordsArrReversed[i]) == 0)
                {
                    countBackwards++;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(countForwards >= countBackwards ? countForwards : countBackwards);
        }
    }
}

