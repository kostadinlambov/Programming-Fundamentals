using System;
using System.Text.RegularExpressions;

namespace _06.Replace__a_Tag
{
    public class Replace__a_Tag
    {
        public static void Main()
        {
            var inputTag = Console.ReadLine();

            while (inputTag != "end")
            {
                var pattern = @"<(\w+).*?href.*?=(.*)>(.*?)<\/\1>";
                var replacement = @"[URL href=$2]$3[/URL]";

                var regex = new Regex(pattern);

                var replacedTags = regex.Replace(inputTag, replacement);

                Console.WriteLine(replacedTags);

                inputTag = Console.ReadLine();
            }
        }
    }
}
