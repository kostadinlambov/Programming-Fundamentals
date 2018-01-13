namespace _10.Сръбско_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static Dictionary<string, Dictionary<string, decimal>> venueSingerMoneyDict =
            new Dictionary<string, Dictionary<string, decimal>>();

        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var tokenCheck = inputLine
                    .Trim()
                    .Split(' ')
                    .ToList();

                int ticketCount;
                bool isNumeric = int.TryParse(tokenCheck[tokenCheck.Count - 1], out ticketCount);
                int ticketPrice;
                bool isNumeric2 = int.TryParse(tokenCheck[tokenCheck.Count - 2], out ticketPrice);

                var venueIndex = tokenCheck.FindIndex(x => x.StartsWith("@"));

                if (tokenCheck.Count > 3 && tokenCheck.Count < 9 && inputLine.IndexOf("@") > -1 && venueIndex > 0 && isNumeric && isNumeric2)
                {
                    GetVenueSingerMoney(inputLine, ticketPrice, ticketCount);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var venue in venueSingerMoneyDict)
            {
                Console.WriteLine(venue.Key);

                var singersSorted = venue.Value
                    .OrderByDescending(i => i.Value)
                    .ToDictionary(i => i.Key, i => i.Value);

                foreach (var singer in singersSorted)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        public static void GetVenueSingerMoney(string inputLine, int ticketPrice, int ticketCount)
        {
            var token = inputLine
                .Trim()
                .Split('@')
                .ToList();

            var sigernNameList = token[0]
                .Trim()
                .Split(' ')
                .ToList();

            if (sigernNameList.Count < 4 && sigernNameList.Count > 0 && token.Count == 2)
            {
                var singerNameString = string.Join(" ", sigernNameList);

                var venueMoneyTicketsList = token[1]
                    .Trim()
                    .Split(' ')
                    .ToList();

                venueMoneyTicketsList.RemoveRange(venueMoneyTicketsList.Count - 2, 2);

                if (venueMoneyTicketsList.Count < 4)
                {
                    var venueName = string.Join(" ", venueMoneyTicketsList);

                    if (!venueSingerMoneyDict.ContainsKey(venueName))
                    {
                        venueSingerMoneyDict[venueName] = new Dictionary<string, decimal>();
                    }

                    var singerNameDict = venueSingerMoneyDict[venueName];

                    if (!singerNameDict.ContainsKey(singerNameString))
                    {
                        singerNameDict[singerNameString] = 0;
                    }

                    singerNameDict[singerNameString] += ticketCount * ticketPrice;
                }
            }
        }
    }
}
