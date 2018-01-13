namespace _8.Calories_Counter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var numberOfIngredients = int.Parse(Console.ReadLine());
            var amountOfCalories = 0;
            var totalAmountOfCalories = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                var typeOfIngredient = Console.ReadLine().ToLower();

                if (typeOfIngredient == "cheese")
                {
                    amountOfCalories = 500;
                }
                else if (typeOfIngredient == "tomato sauce")
                {
                    amountOfCalories = 150;
                }
                else if (typeOfIngredient == "salami")
                {
                    amountOfCalories = 600;
                }
                else if (typeOfIngredient == "pepper")
                {
                    amountOfCalories = 50;
                }

                totalAmountOfCalories += amountOfCalories;
                amountOfCalories = 0;
            }

            Console.WriteLine($"Total calories: {totalAmountOfCalories}");
        }
    }
}
