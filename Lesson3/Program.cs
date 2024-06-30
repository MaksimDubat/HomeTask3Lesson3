namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HomeTask3. Сonditional statements\n");
            Console.WriteLine("Choose the menu point:\n");
            Console.WriteLine("1) Conditional program for displaying the name of the season by number of the months.\n");
            Console.WriteLine("2) Switch-case program displaying the name of the season by number of the months.\n");
            Console.WriteLine("3) Program for detecting whether a number is even or odd.\n");
            Console.WriteLine("4) Program for temperature.\n");
            Console.WriteLine("5) Program for rainbow color choose.\n");
            Console.WriteLine("6) Calculator.\n");
            Console.WriteLine("0 exit.\n");
            var selection = Console.ReadLine();
            switch (selection) 
            {
                case "0":
                    default:
                    break;
                case "1":
                    FirstTaskMethod();
                    break;
                case "2":
                    SecondTaskMethod();
                    break;
                case "3":
                    ThirdTaskMethod();
                    break;
                case "4":
                    FourthTaskMetod();
                    break;
                case "5":
                    FifthTaskMethod();
                    break;

            }
            FirstTaskMethod();
            static void FirstTaskMethod()
            {
                Console.WriteLine("Conditional program for displaying the name of the season by number of the months.\n");
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("Choose the month (for example 1)\n");
                    var month = Convert.ToInt32(Console.ReadLine());
                    if (month == 1)
                        Console.WriteLine("Its winter. January.");
                    else if (month == 2)
                        Console.WriteLine("Its winter. February.");
                    else if (month == 3)
                        Console.WriteLine("Its spring. March.");
                    else if (month == 4)
                        Console.WriteLine("Its spring. April.");
                    else if (month == 5)
                        Console.WriteLine("Ist spring. May.");
                    else if (month == 6)
                        Console.WriteLine("Its summer. June.");
                    else if (month == 7)
                        Console.WriteLine("Its summer. July.");
                    else if (month == 8)
                        Console.WriteLine("Its summer. August.");
                    else if (month == 9)
                        Console.WriteLine("Its autumn. September.");
                    else if (month == 10)
                        Console.WriteLine("Its autumn. October.");
                    else if (month == 11)
                        Console.WriteLine("Its autumn. November.");
                    else if (month == 12)
                        Console.WriteLine("Its winter. December.");
                }
            }
            SecondTaskMethod();
            static void SecondTaskMethod()
            {
                Console.WriteLine("Switch-case program displaying the name of the season by number of the months.\n");
                var monthSelection = Console.ReadLine();
                Console.WriteLine("Choose the month (for example 1)");
                switch (monthSelection) 
                {
                    case "0":
                        default:
                        break;
                    case "1":
                        Console.WriteLine("Its winter. January.");
                        break;
                    case "2":
                        Console.WriteLine("Its winter. February.");
                        break;
                    case "3":
                        Console.WriteLine("Its spring. March.");
                        break;
                    case "4":
                        Console.WriteLine("Its spring. April.");
                        break;
                    case "5":
                        Console.WriteLine("Ist spring. May.");
                        break;
                    case "6":
                        Console.WriteLine("Its summer. June.");
                        break;
                    case "7":
                        Console.WriteLine("Its summer. July.");
                        break;
                    case "8":
                        Console.WriteLine("Its summer. August.");
                        break;
                    case "9":
                        Console.WriteLine("Its autumn. September.");
                        break;
                    case "10":
                        Console.WriteLine("Its autumn. October.");
                        break;
                    case "11":
                        Console.WriteLine("Its autumn. November.");
                        break;
                    case "12":
                        Console.WriteLine("Its winter. December.");
                        break;

                }
            }
            ThirdTaskMethod();
            static void ThirdTaskMethod()
            {
                Console.WriteLine("Choose the amount of number for detecting whether a number is even or odd:\n");
                Console.WriteLine("Write '0' to end the programm\n");
                do
                {
                    Console.WriteLine("Input the numbers:\n");
                    var number = Convert.ToInt32(Console.ReadLine());
                    if (number % 2 == 0)
                        Console.WriteLine("The number is even");
                    else Console.WriteLine("The number is odd");
                } while (Console.ReadLine()=="0");
            }
            FourthTaskMetod();
            static void FourthTaskMetod()
            {
                Console.WriteLine("Input the temperature for detecting the type of the wheather:\n");
                Console.WriteLine("Write 'all' to end the programm\n");
                do
                {
                    var temperature = Convert.ToInt32(Console.ReadLine());
                    if (temperature > -5)
                        Console.WriteLine($"{temperature} is warm");
                    else if (temperature <= -5 && temperature > -20)
                        Console.WriteLine($"{temperature} is normal");
                    else if (temperature > -20)
                        Console.WriteLine($"{temperature} is cold");
                } while (Console.ReadLine()=="all");
            }
            FifthTaskMethod();
            static void FifthTaskMethod()
            {
                Console.WriteLine("Program for rainbow color choose.\n");
                Console.WriteLine("Input the number that match the color in rainbow:\n");
                Console.WriteLine("Write 'all' to end the programm\n");
                do { 
                var color = Convert.ToInt32(Console.ReadLine());
                if (color == 1)
                    Console.WriteLine("Color is red");
                else if (color == 2)
                    Console.WriteLine("Color is orange");
                else if (color == 3)
                    Console.WriteLine("Color is yellow");
                else if (color == 4)
                    Console.WriteLine("Color is green");
                else if (color == 5)
                    Console.WriteLine("Color is light blue");
                else if (color == 6)
                    Console.WriteLine("Color is dark blue");
                else if (color == 7)
                    Console.WriteLine("Color is purple");
                else
                    Console.WriteLine("Error, try next, the area of numbers is 7");
                } while (Console.ReadLine()=="all");

            }
        }
    }
}
