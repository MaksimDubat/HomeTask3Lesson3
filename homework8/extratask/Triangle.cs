using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extratask
{
    public class Triangle : Figures
    {
        public int leg {  get; set; }
        public double triangleSin { get; set; }

        public Triangle(int  leg, double triangleSin)
        {
            this.leg = leg;
            this.triangleSin = triangleSin;
        }
        public override void Square()
        {
            
            var square = (mainParam * leg) / 2 * Math.Sin(triangleSin);
            Console.WriteLine($"Площадь {Name} равна {square}");
        }
        public override void paramSum()
        {
            var summ = mainParam + leg;
            Console.WriteLine($"Катета и гипотенузы в фигуре{Name} равна {summ}");
        }
    }
}
