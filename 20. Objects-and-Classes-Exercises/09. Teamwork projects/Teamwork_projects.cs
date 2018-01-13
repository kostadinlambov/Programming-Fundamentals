using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Teamwork_projects
{
    public class Team
    {
        public string TeamName { get; set; }

        public List<string> Members { get; set; }

        public string CreatorName { get; set; }
    }

    public class Teamwork_projects
    {
        public static void Main()
        {
            var listOfTeams = new List<Team>();

            var countOfTeamsToRegister = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeamsToRegister; i++)
            {
                var token = Console.ReadLine()
                    .Trim()
                    .Split('-')
                    .ToArray();

                var creatorName = token[0];
                var teamName = token[1];

                var team = new Team()
                {
                    CreatorName = String.Empty,
                    TeamName = String.Empty,
                    Members = new List<string>()
                };

                if (listOfTeams.Any(n => n.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (listOfTeams.Any(n => n.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    team.CreatorName = creatorName;
                    team.TeamName = teamName;

                    Console.WriteLine($"Team {team.TeamName}" +
                                      $" has been created by {team.CreatorName}!");

                    listOfTeams.Add(team);
                }
            }

            var separators = new char[] { '-', '>' };

            var inputLine = Console.ReadLine();

            while (inputLine != "end of assignment")
            {
                var token = inputLine
                    .Trim()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var userName = token[0];
                var teamToJoin = token[1];

                if (!listOfTeams.Any(n => n.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }            
                else if (listOfTeams.Select(x => x.Members).Any(x => x.Contains(userName))
                    || listOfTeams.Select(x => x.CreatorName).Contains(userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamToJoin}!");
                }
                else
                {
                    var team = listOfTeams.First(t => t.TeamName == teamToJoin);
                    team.Members.Add(userName);
                }

                inputLine = Console.ReadLine();
            }

            var teamToDisband = listOfTeams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            var regularTeams = listOfTeams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(n => n.TeamName)
                .ToList();

            foreach (var team in regularTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamToDisband)
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}
