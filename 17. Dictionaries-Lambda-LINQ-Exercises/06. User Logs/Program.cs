using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var messageDict = new SortedDictionary<string, Dictionary<string, int>>();

        var inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            var token = inputLine
                .Trim()
                .Split(' ')
                .ToArray();

            var ipAddressArr = token[0]
                .Trim()
                .Split('=')
                .ToArray();

            var ipAddress = ipAddressArr[1];

            var messageArr = token[1]
                .Trim()
                .Split('=')
                .ToArray();

            var message = messageArr[1];

            var userNameArr = token[2]
                .Trim()
                .Split('=')
                .ToArray();

            var userName = userNameArr[1];

            if (!messageDict.ContainsKey(userName))
            {
                messageDict[userName] = new Dictionary<string, int>();
            }

            if (!messageDict[userName].ContainsKey(ipAddress))
            {
                messageDict[userName][ipAddress] = 0;
            }

            messageDict[userName][ipAddress]++;

            inputLine = Console.ReadLine();
        }
    
        foreach (var user in messageDict)
        {
            Console.WriteLine($"{user.Key}: ");

            foreach (var ipAdress in user.Value)
            {
                if (ipAdress.Equals(user.Value.Last()))
                {
                    Console.WriteLine($" {ipAdress.Key} => {ipAdress.Value}.");
                }
                else
                {
                    Console.Write($" {ipAdress.Key} => {ipAdress.Value},");
                }                                             
            }
        }
    }
}

