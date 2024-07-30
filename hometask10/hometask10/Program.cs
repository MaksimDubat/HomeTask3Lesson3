namespace hometask10
{
    delegate void MathOp();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the maths operation:\n");
            Console.WriteLine("1) summ\n");
            Console.WriteLine("2) subtraction\n");
            Console.WriteLine("3) division\n");
            Console.WriteLine("4) multiplication\n");
            Console.WriteLine("5) percentage of number\n");
            Console.WriteLine("6) square root of a number\n");
            Console.WriteLine("0) exit");
            var mathOperation = Console.ReadLine();
            MathOp mathOp1 = Summ;
            MathOp mathOp2 = Subtraction;
            MathOp mathOp3 = Division;
            MathOp mathOp4 = Multiplication;
            MathOp mathOp5 = PercentageOfNumber;
            MathOp mathOp6 = SquareRoot;
            void Summ() 
            {
                Console.WriteLine("Summ of numbers. Input amount of nubers.\n");
                int amount = Convert.ToInt32(Console.ReadLine());
                List<double> list = new List<double>(amount);
                Console.WriteLine("Input numbers to summ:");
                for (int i = 0; i < amount; i++)
                {
                    double variable = Convert.ToDouble(Console.ReadLine());
                    list.Add(variable);
                }
                double sum = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
                Console.WriteLine("Total is: " + sum);
            }
            void Subtraction()
            {
                Console.WriteLine("Subtraction of numbers Input amount of numbers.\n");
                int amount2 = Convert.ToInt32(Console.ReadLine());
                List<double> list2 = new List<double>(amount2);
                Console.WriteLine("Input numbers to subtract:");
                for (int i = 0; i < amount2; i++)
                {
                    double variable = Convert.ToDouble(Console.ReadLine());
                    list2.Add(variable);
                }
                double sub = 0;
                for (int i = 0; i < list2.Count; i++)
                {
                    sub -= list2[i];
                }
                Console.WriteLine("Total is: " + sub);
            }
            void Division()
            {
                Console.WriteLine("Division of numbers. Input amount of numbers.\n");
                int amount3 = Convert.ToInt32(Console.ReadLine());
                List<double> list3 = new List<double>(amount3);
                Console.WriteLine("Input numbers to divide:");
                for (int i = 0; i < amount3; i++)
                {
                    double variable = Convert.ToDouble(Console.ReadLine());
                    list3.Add(variable);
                }
                double division = list3[0];
                for (int i = 1; i < list3.Count; i++)
                {
                    if (list3[i] != 0)
                        division /= list3[i];
                }
                Console.WriteLine("Total is: " + division);
            }
            void Multiplication()
            {
                Console.WriteLine("Multiplication of numbers.\n");
                int amount4 = Convert.ToInt32(Console.ReadLine());
                List<double> list4 = new List<double>(amount4);
                Console.WriteLine("Input numbers to multiplicate:");
                for (int i = 0; i < amount4; i++)
                {
                    double variable = Convert.ToDouble(Console.ReadLine());
                    list4.Add(variable);
                }
                double multip = list4[0];
                for (int i = 1; i < list4.Count; i++)
                {
                    multip *= list4[i];
                }
                Console.WriteLine("Total is: " + multip);
            }
            void PercentageOfNumber()
            {
                Console.WriteLine("percentage of numbers.\n");
                List<double> list5 = new List<double>();
                double percent = list5[0];
                Console.WriteLine("Input numbers to percent:");
                do
                {
                    double variable = Convert.ToDouble(Console.ReadLine());
                    list5.Add(variable);
                    Console.WriteLine("input number to find how many % in numbers in list:");
                    var part = Convert.ToDouble(Console.ReadLine());
                    for (int i = 1; i < list5.Count; i++)
                    {
                        percent = (list5[i] * part) / 100;
                    }
                } while (Console.ReadLine() == "=");
                Console.WriteLine("Total is: " + percent);
            }
            void SquareRoot()
            {
                Console.WriteLine("Square root of numbers. Input amount of numbers\n");
                int amount6 = Convert.ToInt32(Console.ReadLine());
                List<double> list6 = new List<double>(amount6);
                Console.WriteLine("Input numbers to find square root:");
                for (int i = 0; i < list6.Count; i++)
                {
                    double variable = Convert.ToDouble(Console.ReadLine());
                    list6.Add(variable);
                }
                double square = list6[0];
                for (int i = 1; i < list6.Count; i++)
                {
                    square = Math.Sqrt(list6[i]);
                }
                Console.WriteLine("Total is: " + square);
            }
            switch (mathOperation)
            {
                case "1":
                   mathOp1();
                   break;
                case "2":
                    mathOp2();
                    break;
                case "3":
                   mathOp3();
                    break;
                case "4":
                    mathOp4();
                    break;
                case "5":
                    mathOp5();
                    break;
                case "6":
                    mathOp6();
                    break;
                case "0":
                default:
                    break;

            }
        }
    }
}
    

