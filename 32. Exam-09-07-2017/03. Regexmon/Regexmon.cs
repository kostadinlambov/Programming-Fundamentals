using System;
using System.Text.RegularExpressions;


public class Regexmon
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var didimonPattern= @"(?<didimonPattern>[^a-zA-Z-]+)";

        var bojomonPattern = @"(?<bojomonPattern>[a-zA-Z]+-[a-zA-Z]+)";

        while (true)
        {      
            var didimonMatchCheck = Regex.IsMatch(inputLine, didimonPattern);
            if (didimonMatchCheck)
            {
                var regex = new Regex(didimonPattern);
                Match didimonMatch = regex.Match(inputLine);
                var didisMatch = didimonMatch.Groups["didimonPattern"].Value;
                Console.WriteLine(didisMatch);
                var indexOfDidisMatch = inputLine.IndexOf(didisMatch);
                inputLine = inputLine.Substring(indexOfDidisMatch+ didisMatch.Length);
            }
            else
            {
                break;
            }

            var bojomonMatchCheck = Regex.IsMatch(inputLine, bojomonPattern);

            if (bojomonMatchCheck)
            {
                var regex = new Regex(bojomonPattern);
                Match bojomonMatch = regex.Match(inputLine);
                var bojosMatch = bojomonMatch.Groups["bojomonPattern"].Value;
                Console.WriteLine(bojosMatch);
                var indexOfBojosMatch = inputLine.IndexOf(bojosMatch);
                inputLine = inputLine.Substring(indexOfBojosMatch + bojomonMatch.Length);
            }
            else
            {
                break;
            }          
        }      
    }
}

