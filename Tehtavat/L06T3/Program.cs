using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6T03
{
    class Kortti
    {
        public int Arvo { get; set; }
        public Tyyppi Ktyyppi { get; set; }
        public enum Tyyppi
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
    }
    class Pakka
    {
        private List<Kortti> kortit;
        public Pakka()
        {
            kortit = new List<Kortti>();
            Kortti kortti;
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    kortti = new Kortti();
                    kortti.Arvo = x;
                    if (i == 0)
                        kortti.Ktyyppi = Kortti.Tyyppi.Clubs;
                    else if (i == 1)
                        kortti.Ktyyppi = Kortti.Tyyppi.Hearts;
                    else if (i == 2)
                        kortti.Ktyyppi = Kortti.Tyyppi.Spades;
                    else if (i == 3)
                        kortti.Ktyyppi = Kortti.Tyyppi.Diamonds;

                    kortit.Add(kortti);
                }
            }

        }
        public Kortti Lisaa()
        {
            Random rnd = new Random();
            Kortti kortti = kortit[rnd.Next(0, kortit.Count)];
            kortit.Remove(kortti);
            return kortti;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pakka pakka = new Pakka();
            List<Kortti> kortit = new List<Kortti>();
            for (int i = 0; i < 52; i++)
            {
                kortit.Add(pakka.Lisaa());
            }
            foreach (Kortti x in kortit)
            {
                Console.WriteLine(x.Arvo + " of " + x.Ktyyppi);
            }
        }
    }
}
