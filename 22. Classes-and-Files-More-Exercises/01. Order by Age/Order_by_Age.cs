using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Order_by_Age
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }


    public class Order_by_Age
    {
        public static void Main()
        {
            var listOfPersons = new List<Person>();

            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var token = inputLine
                    .Trim()
                    .Split(' ')
                    .ToArray();

                var name = token[0];
                var id = token[1];
                var age = int.Parse(token[2]);

                var person = new Person()
                {
                    Name = name,
                    Id = id,
                    Age = age
                };

                listOfPersons.Add(person);

                inputLine = Console.ReadLine();
            }

            foreach (var person in listOfPersons.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id}" +
                                  $" is {person.Age} years old.");
            }
        }
    }
}
