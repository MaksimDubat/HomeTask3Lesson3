using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9__практическое_занятие_ООП_
{
    public class Teacher : Person
    {
        public string Department {  get; set; }

        public Teacher (string Department, string Name, string Sex) : base (Name, Sex) 
        {
            this.Department = Department;
        }
        public void Explain()
        {
            Console.WriteLine($"Я преподаю на кафедре {Department}");
        }
    }
}
