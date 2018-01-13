using System;

public class Boat_Simulator
{
    public static void Main()
    {
        var firstBoatCharacter = char.Parse(Console.ReadLine());
        var secondBoatCharacter = char.Parse(Console.ReadLine());
        var numberOfLines = int.Parse(Console.ReadLine());

        var firstBoatSpeed = 0;
        var secondBoatSpeed = 0;

        for (int i = 1; i <= numberOfLines; i++)
        {

            var inputString = Console.ReadLine();

            if (inputString == "UPGRADE")
            {
                firstBoatCharacter = (char)(firstBoatCharacter + 3);
                secondBoatCharacter = (char)(secondBoatCharacter + 3);
            }
            else
            {
                if (i % 2 == 1)
                {
                    firstBoatSpeed += inputString.Length;
                }
                else
                {
                    secondBoatSpeed += inputString.Length;
                }
            }

            if (firstBoatSpeed >= 50 || secondBoatSpeed >= 50)
            {
                if (firstBoatSpeed > secondBoatSpeed)
                {
                    Console.WriteLine(firstBoatCharacter);
                    return;
                }
                else
                {
                    Console.WriteLine(secondBoatCharacter);
                    return;
                }
            }

        }

        Console.WriteLine(firstBoatSpeed > secondBoatSpeed ? firstBoatCharacter : secondBoatCharacter);
    }
}
