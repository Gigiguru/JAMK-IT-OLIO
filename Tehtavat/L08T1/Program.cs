using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08T1
{
    class Dice
    {
        int numero;
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                Random rnd = new Random();
                int Valu = rnd.Next(1,7);
                numero = Valu;
            }
        }

    }
   
  

    class Program
    {
        static void Main(string[] args)
        {
            Dice Noppe = new Dice();
            Console.WriteLine(numero);
        }
    }
}
