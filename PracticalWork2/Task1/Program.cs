using System;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\knute\oop\laboratory8\PracticalWork2\Task1\listofstudents.txt";
            List<Student> students = new List<Student>();
            List<string> parts = new List<string>();
            string[] list = File.ReadAllLines(path);
            foreach (var str in list)
            {
                parts.AddRange(str.Split(' '));
                students.Add(new Student
                {
                    Name = parts[0],
                    Mark1 = Convert.ToInt32(parts[1]),
                    Mark2 = Convert.ToInt32(parts[2]),
                    Average = (Convert.ToInt32(parts[1]) + Convert.ToInt32(parts[2])) / 2,
                });

                parts.Clear();
            }
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine($"{student.Average}");
            }
            Console.WriteLine("List of students after filter average mark:");
            double averageGrade = students.Average(s => s.Average);
            List<Student> filteredStudents = students.Where(s => s.Average >= averageGrade).ToList();
            Console.WriteLine($"Average mark: {averageGrade}");
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Mark1}, {student.Mark2}");
            }
        }
    }
}