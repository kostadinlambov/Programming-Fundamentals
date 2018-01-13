namespace _15.Neighbour_Wars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstPlayerDamage = int.Parse(Console.ReadLine());
            var secondPlayerDamage = int.Parse(Console.ReadLine());

            var firstPlayerName = "Pesho";
            var secondPlayerName = "Gosho";

            var firstPlayerAttackName = "Roundhouse kick";
            var secondPlayerAttackName = "Thunderous fist";

            var startHealthPoints = 100;

            var firstPlayerRemainingHealtPoints = startHealthPoints;
            var secondPlayerRemainingHealtPoints = startHealthPoints;

            var count = 0;

            while (firstPlayerRemainingHealtPoints >= 0 && secondPlayerRemainingHealtPoints >= 0)
            {
                count++;

                if (count % 2 == 1)
                {
                    secondPlayerRemainingHealtPoints -= firstPlayerDamage;

                    if (secondPlayerRemainingHealtPoints <= 0)
                    {
                        Console.WriteLine($"{firstPlayerName} won in {count}th round.");
                        return;
                    }

                    Console.WriteLine($"{firstPlayerName} used {firstPlayerAttackName} " +
                                      $"and reduced { secondPlayerName} to " +
                                      $"{secondPlayerRemainingHealtPoints} health.");
                }
                else if (count % 2 == 0)
                {
                    firstPlayerRemainingHealtPoints -= secondPlayerDamage;

                    if (firstPlayerRemainingHealtPoints <= 0)
                    {
                        Console.WriteLine($"{secondPlayerName} won in {count}th round.");
                        return;
                    }

                    Console.WriteLine($"{secondPlayerName} used {secondPlayerAttackName} " +
                                      $"and reduced { firstPlayerName} to " +
                                      $"{firstPlayerRemainingHealtPoints} health.");
                }

                if (count % 3 == 0)
                {
                    firstPlayerRemainingHealtPoints += 10;
                    secondPlayerRemainingHealtPoints += 10;
                }
            }
        }
    }
}
