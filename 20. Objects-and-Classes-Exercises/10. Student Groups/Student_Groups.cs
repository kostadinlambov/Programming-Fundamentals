using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.Student_Groups
{
    public class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    public class Town
    {
        public string Name { get; set; }

        public int SeatsCount { get; set; }

        public List<Student> ListOfStudents { get; set; }
    }

    public class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }

    }

    public class Student_Groups
    {
        public static void Main()
        {
            var listOfTowns = new List<Town>();

            listOfTowns = ReadTheInput(); 
          
            var groups = new List<Group>();

            groups = DistributeStudentsIntoGroups(listOfTowns);
      
            Console.WriteLine($"Created {groups.Count} groups in {listOfTowns.Count} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name} => " +
                                  string.Join(", ", group.Students.Select(x => x.Email)));
            }
        }

        private static List<Town> ReadTheInput()
        {
            var listOfTowns = new List<Town>();

            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                if (inputLine.IndexOf("=>") >= 0)
                {
                    var separators = new char[] { '=', '>' };

                    var token = inputLine
                        .Trim()
                        .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var townName = token[0].Trim();
                    var seatscountArr = token[1]
                        .Trim()
                        .Split(' ')
                        .Take(1)
                        .Select(int.Parse)
                        .ToArray();

                    var seatscount = seatscountArr[0];

                    var town = new Town()
                    {
                        Name = townName,
                        SeatsCount = seatscount,
                        ListOfStudents = new List<Student>()
                    };

                    listOfTowns.Add(town);
                }
                else
                {
                    var separators = new char[] { '|' };

                    var token = inputLine
                        .Trim()
                        .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var studentName = token[0].Trim();
                    var email = token[1].Trim();
                    var registrationDate = DateTime.ParseExact(
                        token[2].Trim(),
                        "d-MMM-yyyy",
                        CultureInfo.InvariantCulture);

                    var student = new Student()
                    {
                        Name = studentName,
                        Email = email,
                        RegistrationDate = registrationDate
                    };

                    var town = listOfTowns.Last();
                    town.ListOfStudents.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            return listOfTowns;
        }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> listOfTowns)
        {
           var groups = new List<Group>();

            foreach (var town in listOfTowns)
            {
                var studentsInTown = town.ListOfStudents
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(n => n.Name)
                    .ThenBy(mail => mail.Email)
                    .ToList();

                while (studentsInTown.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = studentsInTown.Take(group.Town.SeatsCount).ToList();
                    studentsInTown = studentsInTown.Skip(group.Town.SeatsCount).ToList();
                    groups.Add(group);
                }
            }

            return groups;
        }
    }
}
