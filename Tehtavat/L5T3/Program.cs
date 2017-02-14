using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    abstract class Nisakas

    {
        public int Ika { get; set; }
        abstract public string Liiku();
    }
    class Ihminen : Nisakas
    {
        public float Pituus { get; set; }
        public float Paino { get; set; }
        public string Nimi { get; set; }
        public override string Liiku()
        {
            return "Liikun";
        }
        public void Kasvu()
        {
            Ika++;

        }
    }
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }
        public override string Liiku()
        {
            return "Walking";
        }
        public override string ToString()
        {
            return string.Format("Nimi:{0} Ika:{1} Pituus:{2} Paino:{3} ja sanon", Nimi, Ika, Pituus, Paino);
        }
    }
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }
        public override string Liiku()
        {
            return "Konttaan ";
        }
        public override string ToString()
        {
            return string.Format("Nimi:{0} Ika:{1} Pituus:{2} Paino:{3} ja sanon", Nimi, Ika, Pituus, Paino);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aikuinen aikuinen = new Aikuinen();
            aikuinen.Ika = 35;
            aikuinen.Pituus = 200;
            aikuinen.Paino = 9000;
            aikuinen.Nimi = "Heikki";
            aikuinen.Kasvu();
            aikuinen.Liiku();
            Console.WriteLine("Aikuinen  {0} {1} {2}", aikuinen.ToString(), aikuinen.Liiku(), aikuinen.Auto);

            Vauva vauva = new Vauva();
            vauva.Ika = 1;
            vauva.Pituus = 30;
            vauva.Paino = 8;
            vauva.Nimi = "Babyborn";
            vauva.Kasvu();
            vauva.Liiku();
            Console.WriteLine("Vauva {0} {1} {2}", vauva.ToString(), vauva.Liiku(), vauva.Vaippa);


        }
    }
}

