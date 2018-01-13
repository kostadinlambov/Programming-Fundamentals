using System;
using System.Collections.Generic;
using System.Linq;


public class Dragon
{
    public decimal DragonDamage { get; set; }
    public decimal DragonHealth { get; set; }
    public decimal DragonArmor { get; set; }
}

public class Dragon_Army
{
    public static void Main()
    {
        var dragonArmyDict = new Dictionary<string, Dictionary<string, Dragon>>();

        var numberOfDragons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfDragons; i++)
        {
            var inputLine = Console.ReadLine()
                .Trim()
                .Split(' ')
                .ToArray();

            var dragonType = inputLine[0];
            var dragonName = inputLine[1];

            decimal defaultDamage = 45;
            decimal defaultHealth = 250;
            decimal defaultArmor = 10;

            decimal dragonDamage = 0;
            decimal dragonHealth = 0;
            decimal dragonArmor = 0;

            dragonDamage = inputLine[2] != "null" ? decimal.Parse(inputLine[2]) : defaultDamage ;
            dragonHealth = inputLine[3] != "null" ? decimal.Parse(inputLine[3]) : defaultHealth;
            dragonArmor = inputLine[4] != "null" ? decimal.Parse(inputLine[4]) : defaultArmor;

            var dragon = new Dragon()
            {
                DragonDamage = dragonDamage,
                DragonHealth = dragonHealth,
                DragonArmor = dragonArmor
            };

            if (!dragonArmyDict.ContainsKey(dragonType))
            {
                dragonArmyDict[dragonType] = new Dictionary<string, Dragon>();
            }

            if (!dragonArmyDict[dragonType].ContainsKey(dragonName))
            {
                dragonArmyDict[dragonType][dragonName] = new Dragon();
            }

            dragonArmyDict[dragonType][dragonName] = dragon;      
        }

        foreach (var dragonType in dragonArmyDict)
        {
            var averageDamage = dragonType.Value.Values.Select(x => x.DragonDamage).Average();
            var averageHealth = dragonType.Value.Values.Select(x => x.DragonHealth).Average();
            var averageArmor = dragonType.Value.Values.Select(x => x.DragonArmor).Average();
            Console.WriteLine($"{dragonType.Key}::" +
                              $"({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

            foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.DragonDamage}, " +
                                  $"health: {dragon.Value.DragonHealth}, armor: {dragon.Value.DragonArmor}");
            }
        }        
    }
}

