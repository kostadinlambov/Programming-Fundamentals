using System.Collections.Generic;

namespace _6.DNA_Sequences
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var matchSum = int.Parse(Console.ReadLine());

            var nucleicAcidsDictionary = new Dictionary<string, int>()
            {
                {"A", 1 },
                {"C", 2 },
                {"G", 3 },
                {"T", 4 },
            };

            var sequenceCounter = 0;
            var sumOfNucleicAcidsValues = 0;

            foreach (var firstNucleicAcid in nucleicAcidsDictionary)
            {
                foreach (var secondNucleicAcid in nucleicAcidsDictionary)
                {
                    foreach (var thirdNucleicAcid in nucleicAcidsDictionary)
                    {                                       
                        sequenceCounter++;
                        if (sequenceCounter > 4)
                        {
                            Console.WriteLine();
                            sequenceCounter = 1;
                        }

                        sumOfNucleicAcidsValues = firstNucleicAcid.Value + secondNucleicAcid.Value +
                                                  thirdNucleicAcid.Value;

                        if (sumOfNucleicAcidsValues >= matchSum)
                        {
                            Console.Write($"O{firstNucleicAcid.Key}{secondNucleicAcid.Key}{thirdNucleicAcid.Key}O ");
                        }
                        else
                        {
                            Console.Write($"X{firstNucleicAcid.Key}{secondNucleicAcid.Key}{thirdNucleicAcid.Key}X ");
                        }

                    }
                }
            }
        }
    }
}
