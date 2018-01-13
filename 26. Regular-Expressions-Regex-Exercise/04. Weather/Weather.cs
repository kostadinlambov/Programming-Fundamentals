using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class City
{
    public string Name { get; set; }
    public double Temperature { get; set; }
    public string Weather { get; set; }
}

namespace _04.Weather
{
    public class Weather
    {
        public static void Main()
        {          
            var inputLine = Console.ReadLine();

            var listOfCities = new List<City>();

            while (!inputLine.Equals("end"))
            {
                string pattern = @"([A-Z]{2})(\d+\.\d{1,2})([A-Za-z]+)\|";

                Regex regex = new Regex(pattern);
                Match match = regex.Match(inputLine);

                if (match.Success)
                {
                    City city = new City()
                    {
                        Name = match.Groups[1].Value,
                        Temperature = double.Parse(match.Groups[2].Value),
                        Weather = match.Groups[3].Value
                    };

                    if (listOfCities.Select(x => x.Name).Contains(city.Name))
                    {
                        var matchedCity = listOfCities.First(c => c.Name == city.Name);
                        listOfCities.Remove(matchedCity);
                        listOfCities.Add(city);
                    }
                    else
                    {
                        listOfCities.Add(city);
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var city in listOfCities.OrderBy(x => x.Temperature))
            {
                Console.WriteLine($"{city.Name} => {city.Temperature:f2} " +
                                  $"=> {city.Weather}");
            }
        }
    }
}
