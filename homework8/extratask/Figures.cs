using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extratask
{
    public abstract class Figures
    {
        public string Name { get; set; }
        public int mainParam {  get; set; }
        public void SetName(string name)
        {
            Name = name;
        }
        public abstract void Square();

        public abstract void paramSum();
    }
}
