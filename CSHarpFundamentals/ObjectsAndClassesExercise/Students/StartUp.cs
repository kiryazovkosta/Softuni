using System;

namespace Students
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var students = CreateStudents(count);

            students = students.OrderByDescending(s => s.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static List<Student> CreateStudents(int count)
        {
            var students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                var studentData = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries) ?? new string[] { };
                if (studentData.Length == 3)
                {
                    students.Add(new Student()
                    {
                        FirstName = studentData[0],
                        LastName = studentData[1],
                        Grade = double.Parse(studentData[2])
                    });
                }
            }

            return students;
        }
    }
}
