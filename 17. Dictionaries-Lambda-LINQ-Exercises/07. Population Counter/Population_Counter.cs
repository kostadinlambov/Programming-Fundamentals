using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

public class Population_Counter
{
    public static void Main()
    {
        var countryCityPopulationDict = new Dictionary<string, Dictionary<string, long>>();
        var inputData = Console.ReadLine();
      
        while (inputData != "report")
        {
            var token = inputData
                .Trim()
                .Split('|')
                .ToArray();

            var city = token[0];
            var country = token[1];
            var population = long.Parse(token[2]);

            if (!countryCityPopulationDict.ContainsKey(country))
            {
                countryCityPopulationDict[country] = new Dictionary<string, long>();
            }

            if (!countryCityPopulationDict[country].ContainsKey(city))
            {
                countryCityPopulationDict[country][city] = 0;
            }

            countryCityPopulationDict[country][city] += population;

            inputData = Console.ReadLine();
        }

        var sortedDictionary = countryCityPopulationDict
            .OrderByDescending(x => x.Value.Select(p => p.Value).Sum())
            .ToDictionary(k => k.Key, v => v.Value);

        foreach (var country in sortedDictionary)
        {
            var countryTotalPopulation = country.Value.Select(p => p.Value).Sum();

            Console.WriteLine($"{country.Key} (total population: {countryTotalPopulation})");

            foreach (var city in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}

