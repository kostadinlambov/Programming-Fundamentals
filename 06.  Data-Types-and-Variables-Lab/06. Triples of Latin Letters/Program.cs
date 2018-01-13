using System;

public class Triples_of_Latin_Letters
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    char firstLetter = (char)(i + 'a');
                    char secondLetter = (char)(j + 'a');
                    char thirdLetter = (char)(k + 'a');

                    Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");                
                }
            }
        }
    }
}
