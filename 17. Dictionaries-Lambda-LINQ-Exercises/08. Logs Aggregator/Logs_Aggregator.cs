using System;
using System.Collections.Generic;
using System.Linq;

public class Logs_Aggregator
{
    public static void Main()
    {
        var userIpsDict = new Dictionary<string, List<string>>();
        var userDurationDict = new Dictionary<string, long>();

        var numberOfLogs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLogs; i++)
        {
            var inputData = Console.ReadLine()
                .Trim()
                .Split(' ')
                .ToArray();

            var ipAddress = inputData[0];
            var userName = inputData[1];
            var duration = long.Parse(inputData[2]);

            if (!userIpsDict.ContainsKey(userName))
            {
                userIpsDict[userName] = new List<string>();
            }

            userIpsDict[userName].Add(ipAddress);

            if (!userDurationDict.ContainsKey(userName))
            {
                userDurationDict[userName] = 0;
            }

            userDurationDict[userName] += duration;
        }

        foreach (var user in userIpsDict.OrderBy(x => x.Key))
        {
            var uniqueIps = user.Value.Distinct().OrderBy(x => x);
            
            foreach (var userName in userDurationDict)
            {
                if (user.Key == userName.Key)
                {
                    Console.WriteLine($"{user.Key}: {userName.Value} [" +
                                      string.Join(", ", uniqueIps) +"]");
                }
            }
        }
    }
}

