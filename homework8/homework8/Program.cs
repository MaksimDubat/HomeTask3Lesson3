using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите имя собаки:");
            string name = Console.ReadLine();

            Animal Dog = new Dog();
            Dog.SetName(name);
            Dog.Eat();
            Console.ReadKey();

        }
    }
}
