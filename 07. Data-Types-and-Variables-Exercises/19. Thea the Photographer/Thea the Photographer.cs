using System;

public class Thea_the_Photographer
{
    public static void Main()
    {
        var totalNumberOfPictures = long.Parse(Console.ReadLine());
        var filterTimePerPicture = long.Parse(Console.ReadLine());
        var filterFactor = long.Parse(Console.ReadLine());
        var uploadTimePerFilteredPicture = long.Parse(Console.ReadLine());

        var totalTimeForFiltering = totalNumberOfPictures * filterTimePerPicture;
        var filterFactorPercentage = (double)filterFactor / 100;

        var usefullPictures = (long)Math.Ceiling(totalNumberOfPictures * filterFactorPercentage);
        var totalUploadTime = usefullPictures * uploadTimePerFilteredPicture;

        long totalSeconds = totalTimeForFiltering + totalUploadTime;

        Console.WriteLine(TimeSpan.FromSeconds(totalSeconds).ToString(@"d\:hh\:mm\:ss"));
    }
}
