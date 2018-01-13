using System;
using System.Collections.Generic;
using System.IO;

namespace _04.Merge_Files
{
    public class Merge_Files
    {
        public static void Main()
        {
            var inputFile1 = "Input1.txt";
            var inputFile2 = "Input2.txt";
            var outputFile = "Output.txt";

            var input1 = File.ReadAllLines(inputFile1);
            var input2 = File.ReadAllLines(inputFile2);

            var output = MergeFiles(input1, input2);
           
            File.WriteAllLines(outputFile, output);
        }

        private static string[] MergeFiles(string[] input1, string[] input2)
        {
            var output = new List<string>();

            var loopLength = input1.Length;

            if (input1.Length > input2.Length)
            {
                loopLength = input2.Length;
            }

            for (int i = 0; i < loopLength; i++)
            {
                output.Add(input1[i]);
                output.Add(input2[i]);

                if (i == loopLength - 1 && 
                    input1.Length > input2.Length)
                {
                    for (int j = i+1; j < input1.Length; j++)
                    {
                        output.Add(input1[j]);
                    }
                }
                else if (i == loopLength - 1 &&
                         input1.Length < input2.Length)
                {
                    for (int j = i + 1; j < input2.Length; j++)
                    {
                        output.Add(input2[j]);
                    }
                }
            }

            return output.ToArray();
        }
    }
}
