using System;
using System.Linq;
using System.Numerics;


namespace _02.Convert_from_Base_N_to_Base_10
{

    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
            .Split(' ')
            .ToArray();

            var baseToConvert = BigInteger.Parse(inputLine[0]);
            var numberToConvert = BigInteger.Parse(inputLine[1]);

            BigInteger result = new BigInteger(0);


            var naumberAsString = numberToConvert.ToString();

            for (int power = 0; power < naumberAsString.Length; power++)
            {
                var num = int.Parse(naumberAsString[naumberAsString.Length - 1 - power].ToString());
                var tempNumber = num * BigInteger.Pow(baseToConvert, power);
                result += tempNumber;
            }

            Console.WriteLine(result);
        }
    }
}

