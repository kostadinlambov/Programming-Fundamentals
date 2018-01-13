using System;

public class Balanced_Brackets
{
    public static void Main()
    {
        var numberOfInputLines = int.Parse(Console.ReadLine());

        bool openingBracket = false;

        for (int i = 1; i <= numberOfInputLines; i++)
        {
            var inputString = Console.ReadLine();

            if (inputString == "(" &&  openingBracket == true)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }

            if (inputString == "(")
            {
                openingBracket = true;
            }

            if (inputString == ")" && openingBracket == false)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }

            if(inputString == ")" )
            {
                openingBracket = false;
            }          
        }

        Console.WriteLine(openingBracket == false ? "BALANCED" : "UNBALANCED");
    }
}
