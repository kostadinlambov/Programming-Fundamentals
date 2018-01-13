using System;

public class Vowel_or_Digit
{
    public static void Main()
    {
        var inputSymbol = char.Parse(Console.ReadLine());
        var vowels = "aeiouAEIOU";

        bool isVowel = vowels.IndexOf(inputSymbol) >= 0;

        if (isVowel)
        {
            Console.WriteLine("vowel");
        }
        else if (Char.IsDigit(inputSymbol))
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}