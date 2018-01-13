using System;
using System.Numerics;

public class Catch_the_Thief
{
    public static void Main()
    {
        var numeralType = Console.ReadLine();
        var countOfIds = int.Parse(Console.ReadLine());

        BigInteger thiefsId = 0;     
        BigInteger minPositiveDifference = ulong.MaxValue;

        for (int i = 0; i < countOfIds; i++)
        {
            BigInteger id = BigInteger.Parse(Console.ReadLine());

            BigInteger differenceToMaxTypeValue;

            if (numeralType == "sbyte")
            {               
                differenceToMaxTypeValue = sbyte.MaxValue - id;

                if (differenceToMaxTypeValue <= minPositiveDifference && differenceToMaxTypeValue >= 0)
                {
                    minPositiveDifference = differenceToMaxTypeValue;
                    thiefsId = id;
                }
            }
            else if (numeralType == "int")
            {
                differenceToMaxTypeValue = int.MaxValue - id;

                if (differenceToMaxTypeValue <= minPositiveDifference && differenceToMaxTypeValue >= 0)
                {
                    minPositiveDifference = differenceToMaxTypeValue;
                    thiefsId = id;
                }
            }
            else if (numeralType == "long")
            {
                differenceToMaxTypeValue = long.MaxValue - id;

                if (differenceToMaxTypeValue <= minPositiveDifference && differenceToMaxTypeValue >= 0)
                {
                    minPositiveDifference = differenceToMaxTypeValue;
                    thiefsId = id;
                }
            }          
        }

        Console.WriteLine(thiefsId);
    }
}