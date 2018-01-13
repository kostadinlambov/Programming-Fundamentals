using System;
using System.IO;
using System.Linq;

namespace _1.Odd_Lines
{
    public class Odd_Lines
    {
        public static void Main()
        {
            var inputFile = "inputFile.txt";
            var outputFile = "oddLines.txt";

            var file = File.ReadAllLines(inputFile);     

            var oddLines = file
                .Where((line, index) => index % 2 == 1);

            if (!File.Exists(outputFile))
            {
                File.Create(outputFile);
            }

            File.WriteAllLines(outputFile, oddLines);
        }
    }
}
