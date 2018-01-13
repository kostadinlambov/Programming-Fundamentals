using System;
using System.Collections.Generic;
using System.Linq;

public class Legendary_Farming
{

    public static void Main()
    {
        var keyMaterials = new Dictionary<string, decimal>();
        var otherMaterials = new Dictionary<string, decimal>();

        keyMaterials["shards"] = 0;
        keyMaterials["fragments"] = 0;
        keyMaterials["motes"] = 0;

        while (keyMaterials["shards"] < 250 && keyMaterials["fragments"] < 250 && keyMaterials["motes"] < 250)
        {
            var inputLine = Console.ReadLine().ToLower();

            var token = inputLine
                .Trim()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < token.Length; i += 2)
            {
                var material = token[i + 1];
                var quantity = token[i];

                if (material == "shards" || material == "fragments" || material == "motes")
                {
                    if (!keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] = 0;
                    }

                    keyMaterials[material] += decimal.Parse(quantity);

                    if (keyMaterials["shards"] >= 250 || keyMaterials["fragments"] >= 250 || keyMaterials["motes"] >= 250)
                    {
                        PrintObtainedItem(keyMaterials, otherMaterials);
                        return;
                    }
                }
                else
                {
                    if (!otherMaterials.ContainsKey(material))
                    {
                        otherMaterials[material] = 0;
                    }

                    otherMaterials[material] += decimal.Parse(quantity);
                }
            }
        }
    }

    public static void PrintObtainedItem(Dictionary<string, decimal> keyMaterials, Dictionary<string, decimal> otherMaterials)
    {
        if (keyMaterials["shards"] >= 250)
        {
            Console.WriteLine("Shadowmourne obtained!");
            keyMaterials["shards"] -= 250;
        }
        else if (keyMaterials["fragments"] >= 250)
        {
            Console.WriteLine("Valanyr obtained!");
            keyMaterials["fragments"] -= 250;
        }
        else if (keyMaterials["motes"] >= 250)
        {
            Console.WriteLine("Dragonwrath obtained!");
            keyMaterials["motes"] -= 250;
        }

        var sortedKeyMaterials = keyMaterials
            .OrderByDescending(i => i.Value)
            .ThenBy(i => i.Key)
            .ToDictionary(p => p.Key, p => p.Value);

        var sortedOtherMaterials = otherMaterials
            .OrderBy(i => i.Key)
            .ToDictionary(p => p.Key, p => p.Value);

        foreach (var material in sortedKeyMaterials)
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }

        foreach (var otherMaterial in sortedOtherMaterials)
        {
            Console.WriteLine($"{otherMaterial.Key}: {otherMaterial.Value}");
        }
    }
}

