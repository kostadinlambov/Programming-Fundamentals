using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class Pizza_Ingredients
{
    public static void Main()
    {
        var ingredients = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var ingredientLength = int.Parse(Console.ReadLine());

        var igredientsList = new List<string>();
        var ingredientsCount = 0;

        for (int i = 0; i < ingredients.Length; i++)
        {

            if (ingredients[i].Length == ingredientLength)
            {                     
                Console.WriteLine($"Adding {ingredients[i]}.");

                igredientsList.Add(ingredients[i]);
                ingredientsCount++;
            }

            if (ingredientsCount > 9 || i == ingredients.Length-1)
            {
                Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
                Console.WriteLine($"The ingredients are: " + string.Join(", ", igredientsList) + ".");                                 
                return;
            }
        }
    }
}

