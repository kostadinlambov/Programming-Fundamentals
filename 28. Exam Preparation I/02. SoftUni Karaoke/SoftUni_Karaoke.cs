using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    public class SoftUni_Karaoke
    {
        public static void Main()
        {
            var participipantsSongsAwardsDict = new Dictionary<string,  List<string>>();

            var listOfParticipants = Console.ReadLine()
                .Trim()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var listOfAvailableSongs = Console.ReadLine()
                .Trim()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var stagePerformance = Console.ReadLine();

            while (!stagePerformance.Equals("dawn"))
            {
                var separators = new char[] { ',' };

                var tokens = stagePerformance
                    .Trim()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var separatorsToTrim = new char[] { ' ', ',', '\t' };

                var participant = tokens[0].Trim(separatorsToTrim);
                var song = tokens[1].Trim(separatorsToTrim);

                if (listOfParticipants.Any(x => x.Contains(participant) ) 
                    && listOfAvailableSongs.Any(x => x.Contains(song)))
                {
                    if (!participipantsSongsAwardsDict.ContainsKey(participant))
                    {
                        participipantsSongsAwardsDict[participant] = new List<string>();
                    }

                    if (tokens.Length > 2)
                    {
                        var award = tokens[2].Trim(separatorsToTrim);

                        if (!participipantsSongsAwardsDict[participant].Any(x => x.Contains(award)))
                        {
                            participipantsSongsAwardsDict[participant].Add(award);
                        }                        
                    }
                }

                stagePerformance = Console.ReadLine();
            }

            if (participipantsSongsAwardsDict.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                var sortedDict = participipantsSongsAwardsDict
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var participant in sortedDict)
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                    foreach (var award in participant.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
