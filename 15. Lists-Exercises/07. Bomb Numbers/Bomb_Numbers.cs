using System;
using System.Linq;

public class Bomb_Numbers
{
    public static void Main()
    {
        var numbersList = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(decimal.Parse)
            .ToList();

        var specialNumberList = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var specialNumber = specialNumberList[0];
        var specialNumberPower = specialNumberList[1];

        for (int i = 0; i < numbersList.Count; i++)
        {

            if (numbersList[i] == specialNumber)
            {
                if (i - specialNumberPower <= 0 && i + specialNumberPower <= numbersList.Count-1)
                {
                    var rangeToRemove = i + specialNumberPower+1;
                    var startPosition = 0;
                    numbersList.RemoveRange(startPosition, rangeToRemove);
                    i = -1;
                }
                else if (i - specialNumberPower >= 0 && i + specialNumberPower >= numbersList.Count - 1)
                {
                    var rangeToRemove =  specialNumberPower + numbersList.Count - i;
                    var startPosition = i - specialNumberPower;
                    numbersList.RemoveRange(startPosition, rangeToRemove);
                    i = -1;
                }
                else if (i - specialNumberPower >= 0 && i + specialNumberPower <= numbersList.Count - 1)
                {
                    var rangeToRemove = 2* specialNumberPower + 1;
                    var startPosition = i - specialNumberPower;
                    numbersList.RemoveRange(startPosition, rangeToRemove);
                    i = -1;
                }
                else
                {
                    var rangeToRemove = numbersList.Count;
                    var startPosition = 0;
                    numbersList.RemoveRange(startPosition, rangeToRemove);
                    i = -1;
                }
            }
        }

        Console.WriteLine(numbersList.Sum());
    }
}