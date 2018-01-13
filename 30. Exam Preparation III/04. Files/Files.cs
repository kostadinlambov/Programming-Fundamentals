using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    public class Files
    {
        public static void Main()
        {
            var files = new Dictionary<string, Dictionary<string, long>>();

            var filesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < filesCount; i++)
            {
                var filePathData = Console.ReadLine()
                    .Split('\\')
                    .Select(x => x.Trim())
                    .ToArray();

                var fileRoot = filePathData[0];

                var fileData = filePathData
                    .Last()
                    .Split(';')
                    .Select(x => x.Trim())
                    .ToArray();

                var fileName = fileData[0];
                var fileSize = long.Parse(fileData[1]);

                if (!files.ContainsKey(fileRoot))
                {
                    files[fileRoot] = new Dictionary<string, long>();
                }

                if (!files[fileRoot].ContainsKey(fileName))
                {
                    files[fileRoot][fileName] = 0;
                }

                files[fileRoot][fileName] = fileSize;
            }

            var filesToSearch = Console.ReadLine()
                .Split();

            var extension = filesToSearch[0];
            var root = filesToSearch[2];

            if (!files.ContainsKey(root))
            {
                Console.WriteLine("No");
                return;
            }

            var resultFiles = files[root]
                .Where(x => x.Key.EndsWith(extension))
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            if (resultFiles.Count > 0)
            {
                foreach (var file in resultFiles)
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
