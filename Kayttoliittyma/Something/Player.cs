using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Player
    {
        public int Money { get; set; }
        public string Name;
        public void NameSet(string X)
        {
            Name = X;
        }
        public List<Animal> Ani = new List<Animal>();
        public List<Items> Ite = new List<Items>();
        public void AniAdd(Animal X)
        {
            Ani.Add(X);

        }
        public void IteAdd(Items X)
        {
            Ite.Add(X);
        }


    }
}

