using System;
using System.IO;
using System.Linq;

namespace _02.Line_Numbers
{
    public class Line_Numbers
    {
        public static void Main()
        {
            var inputFile = "inputFile.txt";
            var outputFile = "outputFile.txt";

            var file = File.ReadAllLines(inputFile);
        
            var linesWithNumbers = file
                .Select((line, index) => $"{index +1}. {line}")
                .ToArray();

            if (!File.Exists(outputFile))
            {
                File.Create(outputFile);
            }

            File.WriteAllLines(outputFile, linesWithNumbers);
        }
    }
}
