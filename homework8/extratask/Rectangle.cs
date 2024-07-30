using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extratask
{
    public class Rectangle : Figures
    {
        public int diagonal {  get; set; }

        public Rectangle(int diagonal) 
        {
            this.diagonal = diagonal;
        }
        public override void Square()
        {
           var square = mainParam * Math.Sqrt(Math.Pow(diagonal,2)-Math.Pow(mainParam,2));
           Console.WriteLine(square);
        }
        public override void paramSum()
        {
           var summ = mainParam + diagonal;
           Console.WriteLine($"Cумма стороны и диагонали фигуры {Name} равна {summ} ");
        }
    }
}
