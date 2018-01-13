using System;

class Make_a_Word
{
    static void Main()
    {
        var numberOfCharacters= int.Parse(Console.ReadLine());

        string word = null;

        for (int i = 0; i < numberOfCharacters; i++)
        {
            var charecter = Console.ReadLine();

            word += charecter;
        }

        Console.WriteLine($"The word is: {word}");
    }
}