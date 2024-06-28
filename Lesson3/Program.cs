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
            Console.WriteLine("0 exit.\n");
            string selection = Console.ReadLine();
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

            }
            FirstTaskMethod();
            static void FirstTaskMethod()
            {
                Console.WriteLine("Conditional program for displaying the name of the season by number of the months.\n");
                for (int i = 0; i < 13; i++)
                {
                    Console.WriteLine("Choose the month (for example 1), press 0 to main menu \n");
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
               Console.WriteLine("fjfjf");
            }
        }
    }
}
