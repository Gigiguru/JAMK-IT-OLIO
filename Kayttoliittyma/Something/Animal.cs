using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    public class Animal
    {
        public virtual string Species { get; set; }
        public string Name { get; set; }
        public double Happiness { get; set; }
        public Animal(string spcecie, string name, double happiness)
        {
            Species = spcecie;
            Name = name;
            Happiness = happiness;
        }
        public override string ToString()
        {
            return Species + Name + Happiness;
        }
    }
}
