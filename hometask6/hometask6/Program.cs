namespace hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneClass phone1 = new PhoneClass();
            phone1.phoneOutput();
            phone1.receiveCall("Неизвестный абонент");
            phone1.receiveCall();
            Console.WriteLine(phone1.getNumber());
            phone1.sendMessage("5454545454");
            PhoneClass phone2 = new PhoneClass("4548484", "Iphone", 2.4);
            phone2.phoneOutput();
            phone2.receiveCall("Nick");
            phone2.receiveCall();
            Console.WriteLine(phone2.getNumber());
            phone2.sendMessage(phone1.getNumber());
            PhoneClass phone3 = new PhoneClass("4848484848", "Samsung");
            phone3.phoneOutput();
            phone3.receiveCall("Pol");
            phone3.receiveCall();
            Console.WriteLine(phone3.getNumber());
            phone3.sendMessage("34343434");
        }
    }
}
