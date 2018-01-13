using System;
using System.Linq;

public class Pokemon_Don_t_Go
{
    public static void Main()
    {
        var seq = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(decimal.Parse)
            .ToList();

        var sumRemovedElements = 0m;

        while (seq.Count != 0)
        {
            decimal removedElement = 0;

            var index = int.Parse(Console.ReadLine());

            if (index < 0)
            {
                removedElement = seq[0];
                sumRemovedElements += removedElement;
                seq.RemoveAt(0);
                seq.Insert(0, seq[seq.Count - 1] );
            }
            else if (index > seq.Count-1)
            {
                removedElement = seq[seq.Count - 1];
                sumRemovedElements += removedElement;
                seq.RemoveAt(seq.Count - 1);
                seq.Add(seq[0]);
            }
            else
            {
                removedElement = seq[index];
                sumRemovedElements += removedElement;
                seq.RemoveAt(index);
            }
           
            for (int i = 0; i < seq.Count; i++)
            {
                if (seq[i] <= removedElement)
                {
                    seq[i] += removedElement;
                }
                else
                {
                    seq[i] -= removedElement;
                }
            }
        }

        Console.WriteLine(sumRemovedElements);
    }
}

