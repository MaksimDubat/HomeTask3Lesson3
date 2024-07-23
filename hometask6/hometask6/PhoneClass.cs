using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask6
{
    public class PhoneClass
    {
        public string number = "58558484";
        public string model = "model1";
        public double weigth = 2.2;

        public PhoneClass() { }
        public PhoneClass(string number, string model, double weigth) 
        {
            this.number = number;
            this.model = model;
            this.weigth = weigth;
        }
        public PhoneClass (string number, string model) : this(number, model, 0)
        {
            this.number = number;
            this.model = model;
        }
        public void phoneOutput()
        {
            Console.WriteLine($"Номер: {number}, модель: {model}");
        }
        public void receiveCall()
        {
            Console.WriteLine($"Звонит {number}");
        }
        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}, {number}, {weigth}");
        }
        public string getNumber()
        {
            return number;
        }
        public void sendMessage(params string[] phoneNumbers)
        {
            foreach (var sendNumber in phoneNumbers)
            {
                Console.WriteLine($"Отправка сообщения на номер:{sendNumber} от {number}");
            }
        }
    }
}
