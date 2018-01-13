using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Email_Statistics
{
    public class Email_Statistics
    {
        public static void Main()
        {
            var domainUserDict = new Dictionary<string, List<string>>();

            var countOfTheEmails = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTheEmails; i++)
            {
                var email = Console.ReadLine();

                var pattern = @"\b(?<userName>[a-zA-Z]{5,})@(?<mailServer>[a-z]{3,})(?<topLevelDomain>.com|.bg|.org)\b";
                var regex = new Regex(pattern);

                Match match = regex.Match(email);

                if (match.Success)
                {
                    var username = match.Groups["userName"].Value;
                    var mailServer = match.Groups["mailServer"].Value;
                    var topLevelDomain = match.Groups["topLevelDomain"].Value;

                    var domain = mailServer + topLevelDomain;

                    if (!domainUserDict.ContainsKey(domain))
                    {
                        domainUserDict[domain] = new List<string>();
                    }

                    if (!domainUserDict[domain].Any(x => x == username))
                    {
                        domainUserDict[domain].Add(username);
                    }
                }          
            }
              
            foreach (var domain in domainUserDict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");

                foreach (var user in domain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
