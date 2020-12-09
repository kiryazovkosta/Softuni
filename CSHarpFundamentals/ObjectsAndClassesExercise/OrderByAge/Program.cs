// You will receive an unknown number of lines. Each line will be consisted of an array of 3 elements.
// The first element will be a string and it will represent the name of a person.
// The second element will be a string and it will represent the ID of the person.
// The last element will be an integer - the age of the person. When you receive the command "End", print all the people, ordered by age. 
// Georgi 123456 20

namespace OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string  Name { get; set; }
        public string Id  { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine() ?? string.Empty;
                if (input == "End")
                {
                    break;
                }

                var personData = input.Split(" ");
                if (personData.Length == 3)
                {
                    var name = personData[0];
                    var id = personData[1];
                    var age = int.Parse(personData[2]);
                    persons.Add(new Person(name, id, age));
                }
            }

            persons = persons.OrderBy(p => p.Age).ToList();
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
