using System;
using System.IO;


namespace _05.Folder_Size
{
    public class Folder_Size
    {
        public static void Main()
        {
            var currentFiles = Directory.GetFiles("../../TestFolder");

            var totalLength = 0L;

            foreach (var file in currentFiles)
            {
                var fileInfo = new FileInfo(file);

                totalLength += fileInfo.Length;
            }

            var folderSize = totalLength / 1024.0 / 1024.0;
            Console.WriteLine(folderSize);
        }
    }
}
