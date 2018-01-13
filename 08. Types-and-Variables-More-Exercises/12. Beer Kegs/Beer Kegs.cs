using System;

public class Beer_Kegs
{
    public static void Main()
    {
        var numberOFKegs = int.Parse(Console.ReadLine());

        var biggestVolume = 0d;
        var biggestKegModel = string.Empty;

        for (int i = 0; i < numberOFKegs; i++)
        {
            var kegsModel = Console.ReadLine();
            var radius = double.Parse(Console.ReadLine());
            var height = long.Parse(Console.ReadLine());
          
            var volume = Math.PI * Math.Pow(radius, 2.0) * height;

            if (volume > biggestVolume)
            {
                biggestVolume = volume;
                biggestKegModel = kegsModel;
            }
        }

        Console.WriteLine(biggestKegModel);     
    }
}