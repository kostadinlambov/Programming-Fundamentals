using System;
using System.IO;

namespace _05.Write_to_File
{
    public class Write_to_File
    {
        public static void Main()
        {
            var inputText = File.ReadAllText("../../sample_text.txt");

            var separators = new char[] { '.', ',', '!', '?', ':'};

            var replacedText = inputText;

            for (int i = 0; i < separators.Length; i++)
            {
                replacedText = replacedText.Replace(separators[i].ToString(), "");
            }

            Console.WriteLine(replacedText);

            File.WriteAllText("output.txt", replacedText);
        }
    }
}
