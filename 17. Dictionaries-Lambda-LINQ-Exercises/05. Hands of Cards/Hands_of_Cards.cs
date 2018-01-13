using System;
using System.Collections.Generic;
using System.Linq;

public class Hands_of_Cards
{
    public static void Main()
    {
        var playerValueDict = new Dictionary<string, List<string>>();

        var inputLine = Console.ReadLine();

        while (inputLine != "JOKER")
        {
            var token = inputLine
                .Split(':')
                .ToArray();

            var personName = token[0];
            var cards = token[1]
                .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();

            for (int i = 0; i < cards.Count; i++)
            {
                if (!playerValueDict.ContainsKey(personName))
                {
                    playerValueDict[personName] = new List<string>();
                }

                playerValueDict[personName].Add(cards[i]);
            }
          
            inputLine = Console.ReadLine();
        }

        foreach (var player in playerValueDict)
        {
            var cardsValue = CalculateCardsValue(player.Value);
            Console.WriteLine($"{player.Key}: {cardsValue}");
        }
    }

    public static int CalculateCardsValue(List<string> cardsList)
    {
        var card = cardsList
            .Distinct()
            .ToList();

        var cardsPower = new Dictionary<string, int>
        {
            {"2", 2},
            {"3", 3},
            {"4", 4},
            {"5", 5},
            {"6", 6},
            {"7", 7},
            {"8", 8},
            {"9", 9},
            {"10", 10},
            {"J", 11},
            {"Q", 12},
            {"K", 13},
            {"A", 14},           
        };

        var cardsType = new Dictionary<string, int>
        {
            {"S", 4},
            {"H", 3},
            {"D", 2},
            {"C", 1},          
        };

        var sum = 0;

        for (int i = 0; i < card.Count; i++)
        {
            var cardPower = card[i].Substring(0, card[i].Length - 1);
            var cardType = card[i].Substring(card[i].Length - 1);
            sum += cardsPower[cardPower] * cardsType[cardType];
        }

        return sum;
    }
}

