using System;
using System.Collections.Generic;
using System.Linq;

public class Phonebook_Upgrade
{
    public static void Main()
    {
        var phoneBook = new SortedDictionary<string, string>();

        var inputLine = Console.ReadLine();

        while (inputLine != "END")
        {
            var token = inputLine
                .Trim()
                .Split(' ')
                .ToList();

            var command = token[0];

            if (command == "A")
            {
                var name = token[1];
                var phoneNumber = token[2];

                if (!phoneBook.ContainsKey(name))
                {
                    phoneBook[name] = string.Empty;
                }

                phoneBook[name] = phoneNumber;
            }
            else if (command == "S")
            {
                var name = token[1];
                var count = 0;

                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
            else if (command == "ListAll")
            {
                foreach (var name in phoneBook)
                {
                    Console.WriteLine($"{name.Key} -> {name.Value}");
                }
            }
            inputLine = Console.ReadLine();
        }
    }
}