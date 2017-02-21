using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L6T4
{
    class Pelaaja
    {
        public string Enimi { get; set; }
        public string Snimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }

        public Pelaaja()
        {

        }
        public Pelaaja(string enimi, string snimi, int ika, int numero)
        {
            Enimi = enimi;
            Snimi = snimi;
            Ika = ika;
            Numero = numero;
        }

        public override string ToString()
        {
            return Numero + " " + Snimi + " " + Enimi + " " + Ika + " ";
        }

    }
    class Joukkue
    {
        private List<Pelaaja> pelaajat;
        public string Nimi { get; set; }
        public string Kkaupunki { get; set; }
        public Joukkue()
        {
        }
        public Joukkue(string name)
        {
            pelaajat = new List<Pelaaja>();
            Haepelaajat(name);
        }
        public void Haepelaajat(string joukkue)
        {

            string line = "";
            string[] data;
            using (StreamReader x = new StreamReader("../../JYP.txt"))
            {
                while ((line = x.ReadLine()) != null)
                {
                    Pelaaja pelaaja = new Pelaaja();
                    data = line.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                    pelaaja.Numero = int.Parse(data[0]);
                    pelaaja.Snimi = data[1];
                    pelaaja.Enimi = data[2];
                    pelaaja.Ika = int.Parse(data[3]);
                    pelaajat.Add(pelaaja);

                }
            }
        }
        public void Add(string enimi, string snimi, int ika, int numero)
        {
            Pelaaja temp = new Pelaaja(enimi, snimi, ika, numero);
            pelaajat.Add(temp);

        }
        public void Poista(int pnumero)
        {
            pelaajat.RemoveAll(a => a.Numero == pnumero);
        }
        public void Tallenna(string joukkue)
        {
            string x;
            using (StreamWriter y = new StreamWriter("../../JYP.txt"))
            {
                foreach (Pelaaja a in pelaajat)
                {
                    x = a.ToString();
                    y.WriteLine(x);

                }

            }

        }
        public override string ToString()
        {
            string moi = "";
            foreach (Pelaaja x in pelaajat)
            {
                moi += x.ToString() + "\n";
            }
            return moi;


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue JYP = new Joukkue("JYP");
            JYP.Kkaupunki = "Jyväskylä";
            JYP.Add("Heli", "kopteri", 16, 5);
            Console.WriteLine(JYP.ToString());

            JYP.Poista(5);
            Console.WriteLine(JYP.ToString());

            JYP.Add("Keli", "Hopteri", 15, 8);
            JYP.Tallenna("JYP");
            Console.WriteLine(JYP.ToString());



        }
    }
}