using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9__практическое_занятие_ООП_
{
    public class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Person(string Name, string Sex) 
        {
            this.Name = Name;
            this.Sex = Sex;
        }

        public void SetAge()
        {
            this.Age = Age;
            Console.WriteLine("Заполните поле возраста!");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Установлен возраст {Age}");
        }

        public void Greet() => Console.WriteLine($"Привет, меня зовут {Name}");
    }
}
