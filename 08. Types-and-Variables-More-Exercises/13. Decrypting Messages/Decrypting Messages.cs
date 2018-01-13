using System;

    public class Decrypting_Messages
    {
        public static void Main()
        {
            var key = int.Parse(Console.ReadLine());
            var numberOfLines = int.Parse(Console.ReadLine());

            var message = string.Empty;

            for (int i = numberOfLines - 1; i >= 0; i--)
            {
                var character = char.Parse(Console.ReadLine());

                message += (char) (key + character);
            }

            Console.WriteLine(message);
        }
    }