using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    public class Extract_Emails
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"(?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-z]+([-.]\w*)*(\.[a-z]+)";

            var regex = new Regex(pattern);

            MatchCollection eMails = regex.Matches(text);

            foreach (Match eMail in eMails)
            {
                Console.WriteLine(eMail.Value);
            }
        }
    }
}
