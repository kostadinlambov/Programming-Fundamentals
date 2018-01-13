using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonTypeAndIndex
{
    public string EvolutionType { get; set; }

    public int EvolutionIndex { get; set; }
}

public class Pokemon_Evolution
{
    public static void Main()
    {
        var pokemonDict = new Dictionary<string, List<PokemonTypeAndIndex>>();

        var separators = new char[] { ' ', '-', '>', '\t' };
        var inputLine = Console.ReadLine();

        while (inputLine != "wubbalubbadubdub")
        {
            var tokens = inputLine
                .Trim()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var pokemonName = tokens[0];

            if (tokens.Length > 1)
            {
                var evolutionType = tokens[1];
                var evolutionIndex = int.Parse(tokens[2]);

                var pokemonTypeAndIndex = new PokemonTypeAndIndex()
                {
                    EvolutionIndex = evolutionIndex,
                    EvolutionType = evolutionType
                };

                if (!pokemonDict.ContainsKey(pokemonName))
                {
                    pokemonDict[pokemonName] = new List<PokemonTypeAndIndex>();
                }

                pokemonDict[pokemonName].Add(pokemonTypeAndIndex);
            }
            else
            {
                if (pokemonDict.ContainsKey(pokemonName))
                {
                    foreach (var pokemon in pokemonDict)
                    {
                        if (pokemon.Key == pokemonName)
                        {
                            Console.WriteLine($"# {pokemon.Key}");

                            foreach (var typeIndex in pokemon.Value)
                            {
                                Console.WriteLine($"{typeIndex.EvolutionType} <-> {typeIndex.EvolutionIndex}");
                            }
                        }

                    }

                }
            }

            inputLine = Console.ReadLine();
        }

        foreach (var pokemon in pokemonDict)
        {
            Console.WriteLine($"# {pokemon.Key}");

            foreach (var typeIndex in pokemon.Value.OrderByDescending(x => x.EvolutionIndex))
            {
                Console.WriteLine($"{typeIndex.EvolutionType} <-> {typeIndex.EvolutionIndex}");
            }
        }
    }
}

