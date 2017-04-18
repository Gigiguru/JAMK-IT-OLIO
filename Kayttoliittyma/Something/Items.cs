using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Items
    {
        public string RecSpecie { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double HappinessPoint { get; set; }
        public string Description { get; set; }
        public Items(string recS, string name, double price, double HaP, string Desc)
        {
            RecSpecie = recS;
            Name = name;
            Price = price;
            HappinessPoint = HaP;
            Description = Desc;
        }
        public override string ToString()
        {
            return RecSpecie + " " + Name + " " + Price + " " + HappinessPoint + " " + Description;
        }
    }
}
