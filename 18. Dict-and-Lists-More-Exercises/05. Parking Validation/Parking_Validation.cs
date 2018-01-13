using System;
using System.Collections.Generic;
using System.Linq;

public class Parking_Validation
{
    public static void Main()
    {
        var userLicensePlateNumberDict = new Dictionary<string, string>();

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var tokens = Console.ReadLine()
                .Trim()
                .Split(' ')
                .ToArray();

            var command = tokens[0];
            var userName = tokens[1];

            if (command == "register")
            {
                var licensePlateNumber = tokens[2];

                if (Register(userLicensePlateNumberDict, userName, licensePlateNumber))
                {
                    Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                }
            }
            else if (command == "unregister")
            {
                if (!userLicensePlateNumberDict.ContainsKey(userName))
                {
                    Console.WriteLine($"ERROR: user {userName} not found");
                    continue;
                }

                userLicensePlateNumberDict.Remove(userName);

                Console.WriteLine($"user {userName} unregistered successfully");
            }
        }

        foreach (var user in userLicensePlateNumberDict)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }

    private static bool Register(Dictionary<string, string> userLicensePlateNumberDict,
        string userName, string licensePlateNumber)
    {
        if (userLicensePlateNumberDict.ContainsKey(userName))
        {
            Console.WriteLine($"ERROR: already " +
                              $"registered with plate number {userLicensePlateNumberDict[userName]}");
            return false;
        }

        if (!IsLicencePlateValid(licensePlateNumber))
        {
            Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
            return false;
        }

        if (!IsLicencePlateBusy(licensePlateNumber, userLicensePlateNumberDict))
        {
            Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
            return false;
        }

        userLicensePlateNumberDict[userName] = licensePlateNumber;
        return true;
    }

    private static bool IsLicencePlateBusy(string licensePlateNumber,
        Dictionary<string, string> userLicensePlateNumberDict)
    {
        foreach (var licencePlates in userLicensePlateNumberDict)
        {
            if (licencePlates.Value == licensePlateNumber)
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsLicencePlateValid(string licensePlateNumber)
    {
        if (licensePlateNumber.Length != 8)
        {
            return false;
        }

        var firstTwoCharacters = licensePlateNumber
            .Take(2)
            .ToList();

        var fourMiddleCharacters = licensePlateNumber
            .Skip(2)
            .Take(4)
            .ToList();

        var lastTwoCharacters = licensePlateNumber
            .Skip(6)
            .Take(2)
            .ToList();

        for (int i = 0; i < firstTwoCharacters.Count; i++)
        {
            if (!(char.IsLetter(firstTwoCharacters[i])
                  && char.IsUpper(firstTwoCharacters[i])))
            {
                return false;
            }
        }

        for (int i = 0; i < fourMiddleCharacters.Count; i++)
        {
            if (!char.IsDigit(fourMiddleCharacters[i]))
            {
                return false;
            }
        }

        for (int i = 0; i < lastTwoCharacters.Count; i++)
        {
            if (!(char.IsLetter(lastTwoCharacters[i])
                  && char.IsUpper(lastTwoCharacters[i])))
            {
                return false;
            }
        }

        return true;
    }
}

