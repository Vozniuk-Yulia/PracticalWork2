using System;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\knute\oop\laboratory8\PracticalWork2\Task2\listOfEmployees.txt";
            List<Employee> employees = new List<Employee>();
            List<string> temp = new List<string>();
            string[] list = File.ReadAllLines(path);
            foreach (var str in list)
            {
                temp.AddRange(str.Split(' '));
                employees.Add(new Employee
                {
                    Surname = temp[0],
                    Salary = Convert.ToInt32(temp[1]),
                    ExperienceOfWork = Convert.ToInt32(temp[2]),
                });
                temp.Clear();
            }
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Surname}");
                Console.WriteLine($"{employee.Salary}");
                Console.WriteLine($"{employee.ExperienceOfWork}");
            }
            Console.WriteLine("List of employees after sorting by salary:");
            employees.Sort((employee1, employee2) => employee2.Salary.CompareTo(employee1.Salary));
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Surname}");
                Console.WriteLine($"{employee.Salary}");
            }
        }
    }
}