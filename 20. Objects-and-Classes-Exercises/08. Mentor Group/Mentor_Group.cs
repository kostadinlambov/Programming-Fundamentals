using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.Mentor_Group
{
    public class Student
    {
        public string Name { get; set; }

        public List<DateTime> AttendanceDates { get; set; }

        public List<string> Comments { get; set; }

    }

    public class Mentor_Group
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var listOfStudents = new List<Student>();

            while (inputLine != "end of dates")
            {
                var token = inputLine
                    .Trim()
                    .Split(' ')
                    .ToArray();

                var student = new Student()
                {
                    Name = token[0],
                    AttendanceDates = new List<DateTime>(),
                    Comments = new List<string>()
                };

                var userName = token[0];

                if (!listOfStudents.Any(a => a.Name == userName))
                {
                    student.Name = userName;                   
                    listOfStudents.Add(student);
                }

                if (token.Length > 1)
                {            
                    var datesInput = token[1]
                        .Split(',')
                        .ToList();

                    var dates = new List<DateTime>();

                    for (int i = 0; i < datesInput.Count; i++)
                    {
                        var newDate = DateTime.ParseExact(
                            datesInput[i],
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture);

                        dates.Add(newDate);
                    }

                    if (listOfStudents.Any(a => a.Name == userName))
                    { 
                        student = listOfStudents.First(a => a.Name == userName);
                        student.AttendanceDates.AddRange(dates);
                    }
                }

                inputLine = Console.ReadLine();
            }

            var commentsInput = Console.ReadLine();

            while (commentsInput != "end of comments")
            {
                var token = commentsInput
                    .Split('-')
                    .ToArray();

                var userName = token[0];
                var comment = token[1];

                if (listOfStudents.Any(a => a.Name == userName))
                {
                    var student = listOfStudents.First(a => a.Name == userName);
                    student.Comments.Add(comment);
                }

                commentsInput = Console.ReadLine();
            }

            foreach (var user in listOfStudents.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{user.Name}");
                Console.WriteLine("Comments:");

                foreach (var comment in user.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in user.AttendanceDates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
