namespace hometask13

{
    using System;
    using System.Text.Json;
    using System.Xml.Serialization;

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\masson\\source\\repos\\hometask13\\hometask13\\objects";
            //string path = "C:\\Users\\masson\\OneDrive\\Рабочий стол\\test";
            if (Directory.GetDirectories(path).Length + Directory.GetFiles(path).Length == 0)
            {
                throw new FileSearchException("директория пуста");
            }
            string[] files = Directory.GetFiles(path,"*",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("Выберите файл (файлы идут в порядковом номере)");
            int fileNuber = Convert.ToInt32(Console.ReadLine());
            try
            {                
                if (!files.Contains(".json"))
                {
                    throw new FileSearchException("Не содержит json");
                }
                else if (files[fileNuber].EndsWith(".txt"))  // и другие.. 
                {
                    throw new FileSearchException("Неверный формат");
                }
            }
            catch 
            {

            }
            string fileName = files[fileNuber-1];
            string json = File.ReadAllText(fileName);
            Squad? sq = JsonSerializer.Deserialize<Squad>(json);
            Console.WriteLine("Объект десериализован:\n"+sq?.field1+" "+sq?.field2+" "+sq?.field3);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Squad));
            using (FileStream fs = new FileStream("C:\\Users\\masson\\source\\repos\\hometask13\\hometask13\\Squad.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, sq);
                Console.WriteLine("Объект был сериализован в формат xml");
            }
        }
    }
}
