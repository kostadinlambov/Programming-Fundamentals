using System;
using System.Linq;

public class Randomize_Words
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var random = new Random();

        for (int pos1 = 0; pos1 < words.Length; pos1++)
        {
            var pos2= random.Next(0, words.Length);

            if (pos1 != pos2)
            {
                var old  = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = old;
            }                                         
        }

        Console.WriteLine(string.Join("\r\n", words));
    }
}

