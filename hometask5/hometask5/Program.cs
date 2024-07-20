using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

namespace hometask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();    
            var arrayWords = str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var result = string.Empty;
            do
            {
                Console.WriteLine("Menu:\n" +
                    "1.Найти слова, содержащие максимальное количество цифр.\n" +
                    "2.Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.\n" +
                    "3.Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».\n" +
                    "4.Вывести на экран сначала вопросительные, а затем восклицательные предложения.\n" +
                    "5.Вывести на экран только предложения, не содержащие запятых.\n" +
                    "6.Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.\n" +
                    "0. exit.");
                var choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        firstMenuPointMethod();
                        break;
                    case "2":
                        secondMenuPointMethod();
                        break;
                    case "3":
                        thirdMenuPointMethod();
                        break;
                    case "4":
                        fourthMenuPointMethod();
                        break;
                    case "5":
                        fifthMenuPointMethod();
                        break;
                    case "6":
                        sixthMenuPointMethod();
                        break;
                    case "0":
                    default:
                        break;

                }
            } while (true);

            void firstMenuPointMethod()
            {
                var counter = 0;
                var maxCount = 0;
                foreach (var item in arrayWords)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (char.IsDigit(item[i]))
                        {
                            counter++;

                        }
                    }
                    if (maxCount < counter)
                    {
                        result = item;
                        maxCount = counter;
                    }
                    counter = 0;
                }
                Console.WriteLine(result);
            }
            void secondMenuPointMethod()
            {
                var longWord = 0;
                var index = 0;
                for (int i = 0; i < arrayWords.Length; i++)
                {
                    if (arrayWords[i].Length > longWord)
                    {
                        longWord = arrayWords[i].Length;
                        index = i;
                    }
                }
                var counter = 0;
                var maxCount = 0;
                int amount;
                Console.WriteLine(arrayWords[index]);
                foreach (var item in arrayWords)
                {
                    if (item.Contains(arrayWords[index]))
                    {
                        counter++;
                    }
                    if (maxCount < counter)
                    {
                        amount = counter;
                    }
                }
                Console.WriteLine(counter);
            }
            void thirdMenuPointMethod()
            {
                var numbersToWords = new Dictionary<string, string>()
                {
                    {"0", "zero" },
                    {"1", "one" },
                    {"2", "two"},
                    {"3", "three" },
                    {"4", "four"},
                    {"5", "five" },
                    {"6", "six" },
                    {"7", "seven"},
                    {"8", "eight" },
                    {"9", "nine" }
                };
                foreach (var numbers in numbersToWords)
                {
                    str = str.Replace(numbers.Key, numbers.Value);
                }
                Console.WriteLine(str);
            }
            void fourthMenuPointMethod()
            {
                for (int i = 0; i < arrayWords.Length; i++)
                {
                    if (arrayWords[i].EndsWith("?") || arrayWords[i].EndsWith("!") && !arrayWords[i].EndsWith("."))
                    {
                        Console.WriteLine(arrayWords[i]);
                    }
                    else
                    {
                        Console.WriteLine("no such sentences");
                    }
                }
            }
            void fifthMenuPointMethod()
            {
                var sentence = str.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i].Contains(","))
                        Console.WriteLine(sentence[i] + ".");
                    else
                    {
                        Console.WriteLine("no such sentences");
                    }
                }
            }
            void sixthMenuPointMethod()
            {
              
                for (int i = 0; i< arrayWords.Length; i++)
                {
                    if (arrayWords[i].EndsWith(arrayWords[i]) && arrayWords[i].StartsWith(arrayWords[i]))
                    {
                        Console.WriteLine(arrayWords[i]);
                    }
                    else
                    {
                        Console.WriteLine("no such words");
                    }
                }    
            }
        }

    }
}
