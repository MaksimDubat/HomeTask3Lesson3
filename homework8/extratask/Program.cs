using System.Linq.Expressions;

namespace extratask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру:\n" +
                    "1. Треугольник.\n" +
                    "2. Прямоугольник.\n" +
                    "3. Круг.\n" +
                    "0. Выход.");
                var choise = Console.ReadLine();
                switch (choise) 
                {
                    case "1":
                        Console.WriteLine("Введите имя фигуры (например Сложная :) )\n");
                        var name = Console.ReadLine();
                        Console.WriteLine("Введите катет: ");
                        var triangleLeg = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите синус угла:");
                        var triangleSin = Convert.ToInt32(Console.ReadLine());
                        Figures triangle = new Triangle(triangleLeg,triangleSin);
                        triangle.SetName(name);
                        Console.WriteLine("Введите основной параметр:");
                        var triangleMainParam = Convert.ToInt32(Console.ReadLine());    
                        triangle.mainParam = triangleMainParam;
                        triangle.paramSum();
                        triangle.Square();
                        break;
                    case "2":
                        Console.WriteLine("Введите имя фигуры (например Сложная :) )\n");
                        var name2 = Console.ReadLine();
                        Console.WriteLine("Введите диагональ:");
                        var rectangleDiagonal = Convert.ToInt32(Console.ReadLine());
                        Figures rectangle = new Rectangle(rectangleDiagonal);
                        rectangle.SetName(name2);
                        Console.WriteLine("Введите основной параметр:");
                        var rectangleMainParam = Convert.ToInt32(Console.ReadLine());
                        rectangle.mainParam = rectangleMainParam;
                        rectangle.paramSum();
                        rectangle.Square();
                        break;
                    case "3":
                        Console.WriteLine("Введите имя фигуры (например Сложная :) )\n");
                        var name3 = Console.ReadLine();
                        Figures circle = new Circle();
                        circle.SetName(name3);
                        Console.WriteLine("Введите основной параметр:");
                        var circleMainParam = Convert.ToInt32(Console.ReadLine());
                        circle.mainParam = circleMainParam;
                        circle.paramSum();
                        circle.Square();
                        break;
                    case "0":
                        default:
                        break;
                }
            }
        }
    }
}
