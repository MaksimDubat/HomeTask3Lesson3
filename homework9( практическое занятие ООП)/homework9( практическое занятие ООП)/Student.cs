using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9__практическое_занятие_ООП_
{
    public class Student : Person
    {
        public int idGroup { get; set; }

        public Student(string Name, string sex, int idGroup) : base(Name, sex)
        {
            this.idGroup = idGroup;
        }

        public void Study()
        {
            Console.WriteLine($"Меня зовут {Name}, я учусь в группе {idGroup}");
        }
        public void ShowAge()
        {
            Console.WriteLine($"Возраст {Name}: {Age}");
        }
    }
}
