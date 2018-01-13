using System;
using System.Numerics;

class Sentence_the_Thief
{
    static void Main()
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

        BigInteger sentenceDuration;

        if (thiefsId > 0)
        {
            sentenceDuration = (BigInteger)Math.Ceiling((decimal)thiefsId / sbyte.MaxValue);
        }
        else
        {
            sentenceDuration = (BigInteger)Math.Ceiling((decimal)thiefsId / sbyte.MinValue);
        }

        Console.WriteLine(sentenceDuration > 1
            ? $"Prisoner with id {thiefsId} is sentenced to {sentenceDuration} years"
            : $"Prisoner with id {thiefsId} is sentenced to {sentenceDuration} year");
    }
}
