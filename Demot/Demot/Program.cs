using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Ikkuna
    {
        //properties = ominaisuudet
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Pintaala { get { return Leveys * Korkeus; }   }
        
        public float Piiri { get { return 2 * (Leveys + Korkeus); } }
        //constructors = konstruktorit "rakentajat"
        public Ikkuna()
        {
            //tämä on ns oletuskonstruktori
        }
        public Ikkuna(float leveys, float korkeus) {
            Korkeus = korkeus;
            Leveys = leveys;
        } 
        //methods = metodit
        public float LaskePintaala() {
            return Leveys * Korkeus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunaDemo();
        }
        static void OOIkkunaDemo() {
            //ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;
            //kysyy kayttajalta mitat
            Console.Write("anna leveys millimetreina");
            Leveys = float.Parse(Console.ReadLine());
            Console.Write("Anna korkeus millimetreina ");
            Korkeus= float.Parse(Console.ReadLine());
            Ala = Korkeus * Leveys;
            Piiri = 2*(Leveys + Korkeus);
            Console.WriteLine("Pinta-ala {0} ja piiri {1}" , Ala , Piiri);
            // sama homma olion avulla
            Ikkuna ikkuna = new Demot.Ikkuna();
            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;
            //Ala = ikkuna.LaskePintaala();
            Console.WriteLine("Olion avulla laskettu ikkunana pinta-ala {0} ja piiri {1}",ikkuna.Pintaala, Piiri);
            // Kokeillaan puolta pienemmällä ikkunalla toista konstruktoria
            Ikkuna ikkuna2 = new Demot.Ikkuna(Leveys/2, Korkeus/2);
            Console.WriteLine("Olion avulla laskettu ikkunana2 pinta-ala {0} ja piiri {1}", ikkuna2.Pintaala, ikkuna2.Piiri);



        }//demo1 24.1
    }
}
