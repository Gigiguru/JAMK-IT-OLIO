using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T1
{
    public class Vehicle
    {
        // sonstant and variables
        private const int maxTyres = 4;
        private int countTyres = 0;
        //properties
        public string Brand { get; set; }
        public string Model { get; set; }
        //taulukon koko kiintea
        public Tyre[] Tyres { get; }
        //tyypitetty
        public List<Tyre> Renkaat { get; }
        //constructor
        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
            Renkaat = new List<Tyre>();
        }
        //methods
        public void AddTyre(Tyre tyre)
        {
            if (countTyres < maxTyres)
            {
                Tyres[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", tyre.ToString(), this.Brand);
            }
            else
            {
                Console.WriteLine("E onnistu");
            }

        }
        //metodi jolla lisätään listaan uuusi rengas
        public void AddTyreToList(Tyre tyre)
        {
            Renkaat.Add(tyre);
        }
      public override string ToString()
        {
            string retval = "Ajoneuvo valmsitaja" + Brand + "malli" + Model + "\n renkaita";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre != null)
                {
                    retval += "\n" + tyre.ToString();
                }
            }
            //ja listataaan alkiot myös listalla
          //  foreach (Tyre tyre in renktaat)
           // {
            //    retval += "\n " + tyre.ToString();
            //}
            return retval;
        }
    }
    public class Tyre
    {
        public string Branch { get; set; }
        public string Size { get; set; }
        public override string ToString()
        {
            //return "Valmistaja:" + Branch + "koko" + Size;
            return String.Format("Valmistaja on {0} koko on {1}", Branch, Size);
        }
    }
}
