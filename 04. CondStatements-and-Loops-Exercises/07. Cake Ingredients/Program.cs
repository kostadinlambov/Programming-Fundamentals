namespace _7.Cake_Ingredients
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var numberOfIngredients = 0;

            while (command != "Bake!")
            {
                numberOfIngredients++;

                Console.WriteLine($"Adding ingredient {command}. ");

                command = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
        }
    }
}
