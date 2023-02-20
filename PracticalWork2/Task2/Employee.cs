using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Employee
    {
        string surname="";
        int salary;
        int experienceOfWork;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int ExperienceOfWork
        {
            get { return experienceOfWork; }
            set { experienceOfWork = value; }
        }
        public Employee(string surname, int salary,int experienceOfWork)
        {
            Surname = surname;
            Salary = salary;
            ExperienceOfWork = experienceOfWork;
        }
        public Employee() { }
    }
}
