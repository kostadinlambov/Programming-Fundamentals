namespace _4.Photo_Gallery
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Input ##############################################
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSizeInBytes = decimal.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());

            // photoName ##############################################
            var photoName = string.Format($"Name: DSC_{photoNumber:D4}.jpg");
            //var photoName1 = $"Name: DSC_{photoNumber:D4}.jpg";
            Console.WriteLine(photoName);
        
            // Date ##############################################
            var seconds = 0;

            var date = new DateTime(year, month, day, hours, minutes, seconds);

            var outputFormat = "dd'/'MM'/'yyyy HH:mm";
            var dateOutputAsString = date.ToString(outputFormat);

            Console.WriteLine($"Date Taken: {dateOutputAsString}");

            // Size ##############################################
            if (photoSizeInBytes > 0 && photoSizeInBytes < 1000)
            {
                Console.WriteLine($"Size: {photoSizeInBytes}B");
            }
            else if (photoSizeInBytes >= 1000 && photoSizeInBytes < 1000000)
            {
                Console.WriteLine($"Size: {photoSizeInBytes / 1000 }KB");
            }
            else if (photoSizeInBytes >= 1000000)
            {
                Console.WriteLine($"Size: {photoSizeInBytes / 1000000}MB");
            }

            // Orientation ##############################################
            var orientation = string.Empty;

            if (photoWidth < photoHeight)
            {
                orientation = "portrait";
            }
            else if (photoWidth > photoHeight)
            {
                orientation = "landscape";
            }
            else if (photoWidth == photoHeight)
            {
                orientation = "square";
            }

            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");
        }
    }
}
