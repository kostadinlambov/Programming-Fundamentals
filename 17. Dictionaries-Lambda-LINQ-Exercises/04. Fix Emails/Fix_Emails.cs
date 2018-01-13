using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Fix_Emails
{
    public static void Main()
    {
        var nameEmailsDict = new Dictionary<string, string>();

        var inputLine = Console.ReadLine();

        var count = 1;
        var name = string.Empty;
        var eMail = string.Empty;

        while (inputLine != "stop")
        {
            if (count % 2 == 1 )
            {
                name = inputLine;

                if (!nameEmailsDict.ContainsKey(name))
                {
                    nameEmailsDict[name] = string.Empty;
                }
            }
            else
            {
                eMail = inputLine;
                nameEmailsDict[name] = eMail;
            }

            count++;
            inputLine = Console.ReadLine();
        }

        var fixedEmails = nameEmailsDict
            .Where(x => !x.Value.EndsWith("us") &&
                        !x.Value.EndsWith("uk"))
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var nameOfPerson in fixedEmails)
        {
            Console.WriteLine($"{nameOfPerson.Key} -> {nameOfPerson.Value}");
        }
    }
}
