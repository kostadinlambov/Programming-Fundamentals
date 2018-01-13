using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Football_Standings
{
    public class Football_Standings
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());

            var pattern =
                $@"{key}(?<firstTeam>.*?){key}.*{key}(?<secondTeam>.*?){
                        key
                    }.*?(?<firstTeamScore>\d+):(?<secondTeamScore>\d+)";

            var footballMatches = new Dictionary<string, Score>();

            var line = Console.ReadLine();

            while (!line.Equals("final"))
            {
                var match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    var firstTeam = new string(match.Groups["firstTeam"]
                        .Value
                        .ToUpper()
                        .Reverse()
                        .ToArray());

                    var secondTeam = new string(match.Groups["secondTeam"]
                        .Value
                        .ToUpper()
                        .Reverse()
                        .ToArray());

                    var firstTeamScore = int.Parse(match.Groups["firstTeamScore"].Value);
                    var secondTeamScore = int.Parse(match.Groups["secondTeamScore"].Value);

                    if (!footballMatches.ContainsKey(firstTeam))
                    {
                        footballMatches[firstTeam] = new Score();
                    }

                    if (!footballMatches.ContainsKey(secondTeam))
                    {
                        footballMatches[secondTeam] = new Score();
                    }

                    if (firstTeamScore > secondTeamScore)
                    {
                        footballMatches[firstTeam].Points += 3;
                    }

                    else if (firstTeamScore < secondTeamScore)
                    {
                        footballMatches[secondTeam].Points += 3;
                    }

                    else
                    {
                        footballMatches[firstTeam].Points++;
                        footballMatches[secondTeam].Points++;
                    }

                    footballMatches[firstTeam].Goals += firstTeamScore;
                    footballMatches[secondTeam].Goals += secondTeamScore;
                }

                line = Console.ReadLine();
            }

            footballMatches = footballMatches
                .OrderByDescending(x => x.Value.Points)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            var topThreeTeams = footballMatches
                .OrderByDescending(x => x.Value.Goals)
                .ThenBy(x => x.Key)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("League standings:");

            var index = 1;

            foreach (var footballMatch in footballMatches)
            {
                var team = footballMatch.Key;
                var points = footballMatch.Value.Points;

                Console.WriteLine($"{index++}. {team} {points}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var topTeam in topThreeTeams)
            {
                var team = topTeam.Key;
                var scoredGoals = topTeam.Value.Goals;

                Console.WriteLine($"- {team} -> {scoredGoals}");
            }
        }
    }

    public class Score
    {
        public int Goals { get; set; }

        public int Points { get; set; }
    }
}