namespace _5.Character_Stats
{
    using System;
	
    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', currentHealth)
                + new string('.', maximumHealth - currentHealth) + "|");
            Console.WriteLine("Energy: |" + new string('|', currentEnergy)
                    + new string('.', maximumEnergy - currentEnergy) + "|");
        }
    }
}
