using System;
using System.Collections.Generic;
using System.Data;

public class A_Miner_Task
{
    public static void Main()
    {
        var resourceQuantityDict = new Dictionary<string, long>();

        var inputLine = Console.ReadLine();

        var count = 1;
        var resourse = string.Empty;
        var quantity = 0l;

        while (inputLine != "stop")
        {
            if (count % 2 == 1)
            {
                resourse = inputLine;

                if (!resourceQuantityDict.ContainsKey(resourse))
                {
                    resourceQuantityDict[resourse] = 0;
                }
            }
            else
            {
                quantity = long.Parse(inputLine);

                resourceQuantityDict[resourse] += quantity;
            }

            count++;
            inputLine = Console.ReadLine();
        }

        foreach (var resource in resourceQuantityDict)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }
    }
}

