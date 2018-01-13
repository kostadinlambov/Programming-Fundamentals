using System;
using System.Collections.Generic;
using System.Linq;

public class Upgraded_Matcher
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

            if (i < quantitiesOfTheProducts.Length)
            {
                productQuantityDict[namesOfTheProducts[i]] = quantitiesOfTheProducts[i];
            }

            if (!productPriceDict.ContainsKey(namesOfTheProducts[i]))
            {
                productPriceDict[namesOfTheProducts[i]] = 0;
            }

            productPriceDict[namesOfTheProducts[i]] = pricesOfTheProducts[i];
        }

        var productToPrint = Console.ReadLine()
            .Trim()
            .Split(' ')
            .ToArray();

        while (productToPrint[0] != "done")
        {
            var orderedProduct = productToPrint[0];
            var orderedQuantity = long.Parse(productToPrint[1]);

            productQuantityDict[orderedProduct] -= orderedQuantity;

            if (productQuantityDict[orderedProduct] >= 0)
            {
                var totalPriceOfTheOrder = orderedQuantity * productPriceDict[orderedProduct];
                Console.WriteLine($"{orderedProduct} x {orderedQuantity} costs {totalPriceOfTheOrder:f2}");
            }
            else
            {
                Console.WriteLine($"We do not have enough {orderedProduct}");
                productQuantityDict[orderedProduct] += orderedQuantity;
            }

            productToPrint = Console.ReadLine()
                .Trim()
                .Split(' ')
                .ToArray(); ;
        }
    }
}