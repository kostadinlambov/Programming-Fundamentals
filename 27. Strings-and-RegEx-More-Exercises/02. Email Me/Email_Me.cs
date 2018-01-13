using System;
using System.Linq;

namespace _02.Email_Me
{
    public class Email_Me
    {
        public static void Main()
        {
            var eMail = Console.ReadLine()
                .Split('@')
                .ToArray();

            var frontPartSum = eMail[0].Sum(x => x);
            var backPartSum = eMail[1].Sum(x => x);

            Console.WriteLine(frontPartSum >= backPartSum ?
                "Call her!" : "She is not the one.");
        }
    }
}
