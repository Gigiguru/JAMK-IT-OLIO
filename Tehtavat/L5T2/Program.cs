using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Jaakaappi
    {
        //properties
        public string Vihannekset { get; set; }
        public string Hedelmät { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Jaakaappi kaappi = new Jaakaappi();
            kaappi.Hedelmät = "Päärynä" + " Omena";
            kaappi.Vihannekset = "Porkkana" + " pottu";
            
            Console.WriteLine("Jaakaapissa on hedelmiä {0} ja  vihanneksia {1} ", kaappi.Hedelmät, kaappi.Vihannekset);
        }
    }
}

