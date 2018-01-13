using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> ListOfGrades { get; set; }

        public double Average
        {
            get { return ListOfGrades.Average(); }
        }
    }

    public class Average_Grades
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var listOfStudents= new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var name = inputLine[0];
                var listOfGrades = inputLine
                    .Skip(1)
                    .Select(double.Parse)
                    .ToList();

                var student = new Student()
                {
                    Name = name,
                    ListOfGrades = listOfGrades
                };

                listOfStudents.Add(student);
            }

            var sortedListOfStudents = listOfStudents
                .Where(st => st.Average >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Average)
                .ToList();

            foreach (var student in sortedListOfStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }
    }
}
