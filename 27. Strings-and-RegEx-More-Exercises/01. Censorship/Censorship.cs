using System;

namespace _01.Censorship
{
    public class Censorship
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var sentence = Console.ReadLine();

            var replacedSentence = string.Empty;
            if (sentence.IndexOf(word) > -1)
            {
              replacedSentence = sentence.Replace(word, new string('*', word.Length));
            }
         
            Console.WriteLine(replacedSentence);
        }
    }
}
