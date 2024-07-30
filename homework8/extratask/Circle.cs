using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extratask
{
    public class Circle : Figures
    {

        public override void Square()
        {
           var square = Math.Pow(mainParam, 2) * Math.PI;
        }
        public override void paramSum()
        {
            Console.WriteLine($"Фигура {Name} имеет только один параметр, а не сумму {mainParam}");
        }
    }
}
