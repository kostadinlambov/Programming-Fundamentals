using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }

    public class Nether_Realms
    {
        public static void Main()
        {
            var listOfDemons = new List<Demon>();

            var pattern = @"\s*,\s*";

            var demonsName = Regex.Split(Console.ReadLine(), pattern)
                .Select(d => d.Trim())
                .Where(d => d.Length > 0)
                .ToList();

            for (int i = 0; i < demonsName.Count; i++)
            {

                var demon = new Demon()
                {
                    Name = demonsName[i],
                    Health = 0,
                    Damage = 0.0
                };

                if (demonsName[i].ToCharArray().Any(char.IsDigit))
                {
                    demon.Damage = Regex.Matches(demonsName[i], @"(-?\d+(?:\.\d+)?)")
                        .Cast<Match>()
                        .Select(n => n.Value.Trim())
                        .Select(double.Parse)
                        .Sum();
                }

                demon.Health = Regex.Matches(demonsName[i], @"[^\d+\-\/\.\*]")
                    .Cast<Match>()
                    .Select(n => n.Value.Trim())
                    .Select(char.Parse)
                    .Sum(x => x);


                for (int j = 0; j < demonsName[i].Length; j++)
                {
                    if (demonsName[i][j].Equals('*'))
                    {
                        demon.Damage *= 2.0;
                    }
                    else if (demonsName[i][j].Equals('/'))
                    {
                        demon.Damage /= 2.0;
                    }
                }

                listOfDemons.Add(demon);
            }

            foreach (var demon in listOfDemons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, " +
                                  $"{demon.Damage:f2} damage");
            }
        }
    }
}
