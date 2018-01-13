namespace _8.SMS_Typing
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var numberOfCharacters = int.Parse(Console.ReadLine());

            char letter;
            var message = string.Empty;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                var textMessageNumbers = Console.ReadLine();

                if (textMessageNumbers != "0")
                {
                    var numberOfDigits = textMessageNumbers.Length;

                    var mainDigit = int.Parse(textMessageNumbers[0].ToString());

                    var offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }

                    var letterIndex = offset + numberOfDigits - 1;

                    letter = (char)(letterIndex + 'a');
                    message += letter;
                }
                else
                {         
                    letter = ' ';
                    message += letter;
                }
                            
            }

            Console.WriteLine(message);
        }
    }
}
