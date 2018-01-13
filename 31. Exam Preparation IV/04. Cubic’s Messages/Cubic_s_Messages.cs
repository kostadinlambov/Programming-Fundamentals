using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Cubic_s_Messages
{
    public class Cubic_s_Messages
    {
        public static void Main()
        {
            var output = new StringBuilder();

            var line = Console.ReadLine();

            while (!line.Equals("Over!"))
            {
                var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]+)?$";
                var match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    var messageLenght = int.Parse(Console.ReadLine());

                    var message = match.Groups["message"].Value;

                    if (message.Length == messageLenght)
                    {
                        var digitsBeforeMessage = match.Groups["leftPart"].Value;
                        var digitsAfterMessage = match.Groups["rightPart"].Value;

                        var currentMessage = new StringBuilder();

                        var verificationCode = digitsBeforeMessage + digitsAfterMessage;

                        foreach (var character in verificationCode)
                        {
                            var index = 0;
                            var isDigit = int.TryParse(character.ToString(), out index);
                            var isValidIndex = index >= 0 && index < message.Length;

                            if (isValidIndex && isDigit)
                            {
                                var messageChar = message[index];

                                currentMessage.Append(messageChar);
                            }

                            else
                            {
                                currentMessage.Append(" ");
                            }
                        }

                        output.AppendLine($"{message} == {currentMessage}");
                    }
                }

                line = Console.ReadLine();
            }

            Console.Write(output.ToString());
        }
    }
}
