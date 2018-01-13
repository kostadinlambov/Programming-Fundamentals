using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory_Matcher
{
    public static void Main()
    {
        var namesOfTheProducts = Console.ReadLine()
            .Trim()
            .Split(' ')
            .ToArray();

        var quantitiesOfTheProducts = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        var pricesOfTheProducts = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(decimal.Parse)
            .ToArray();

        var productQuantityDict = new Dictionary<string, long>();
        var productPriceDict = new Dictionary<string, decimal>();

        for (int i = 0; i < namesOfTheProducts.Length; i++)
        {
            if (!productQuantityDict.ContainsKey(namesOfTheProducts[i]))
            {
                productQuantityDict[namesOfTheProducts[i]] = 0;
            }

            productQuantityDict[namesOfTheProducts[i]] = quantitiesOfTheProducts[i];

            if (!productPriceDict.ContainsKey(namesOfTheProducts[i]))
            {
                productPriceDict[namesOfTheProducts[i]] = 0;
            }

            productPriceDict[namesOfTheProducts[i]] = pricesOfTheProducts[i];
        }

        var productToPrint = Console.ReadLine();

        while (productToPrint != "done")
        {

            Console.WriteLine($"{productToPrint} costs: {productPriceDict[productToPrint]};" +
                              $" Available quantity: { productQuantityDict[productToPrint]}");

            productToPrint = Console.ReadLine();
        }
    }
}