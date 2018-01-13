using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Roli___The_Coder
{
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }

    public class Roli___The_Coder
    {
        public static void Main()
        {
            var pattern = @"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*)";
            var eventsRegex = new Regex(pattern);

            var events = new Dictionary<int, Event>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Time for Code")
                {
                    break;
                }

                var eventMatch = eventsRegex.Match(line);

                if (!eventMatch.Success)
                {
                    continue;
                }

                var id = int.Parse(eventMatch.Groups["id"].Value);
                var eventName = eventMatch.Groups["eventName"].Value;
                var participantsStr = eventMatch.Groups["participants"].Value;

                var participants = new List<string>();

                if (participantsStr.Length > 0)
                {
                    participants.AddRange(participantsStr
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                }

                if (!events.ContainsKey(id))
                {
                    var @event = new Event
                    {
                        Name = eventName,
                        Participants = participants
                    };

                    events[id] = @event;
                }

                if (events[id].Name == eventName)
                {
                    events[id].Participants.AddRange(participants);
                }              
            }

            foreach (var @event in events)
            {
                @event.Value.Participants = @event.Value
                    .Participants
                    .Distinct()
                    .OrderBy(n => n)
                    .ToList();
            }

            var sortedEvents = events
                .OrderByDescending(pair => pair.Value.Participants.Count)
                .ThenBy(a => a.Value.Name)
                .Select(a => a.Value)
                .ToArray();

            foreach (var @event in sortedEvents)
            {
                Console.WriteLine($"{@event.Name} - {@event.Participants.Count}");

                foreach (var participant in @event.Participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}