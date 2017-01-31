using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5_Opiskelija_
{
    class Opiskelija
    {
        string tunnus;
        public string Tunnus
        { get; set; }

        public string Enimi
        { get; set; }

        public string Snimi
        { get; set; }
        public override string ToString()
        {
            string s = tunnus + ", " + Enimi + ", " + Snimi;
            return s;
        }
        public void Tayta()
        {
            Console.WriteLine("Syötä Tunnus");
            tunnus = Console.ReadLine();
            Console.WriteLine("Syötä Etunimi");
            Enimi = Console.ReadLine();
            Console.WriteLine("Syötä Sukunimi");
            Snimi = Console.ReadLine();
        }
        class Program
        {
            static void Main(string[] args)
            {
                Opiskelija[] oppi = new Opiskelija[5];
                for (int i = 0; i < 5; i++)
                {
                    oppi[i] = new Opiskelija();
                    oppi[i].Tayta();

                }
                foreach (Opiskelija o in oppi)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }
    }
}