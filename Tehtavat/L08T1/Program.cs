using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08T1
{
    interface ICLASS
    {
        int Heita(int Numero1, int heitto);
    }
    public int Numero
    {
        get
        {
            return Numero;
        }
        set
        {
            if (!(value >= 0 && value <= 200))
                numero = value;
            else
                numero = 0;
        }
    }
    public class Dice : ICLASS
    {
        public int Heita(int Numero1, int heitto)
        { 
        return Numero1 + heitto;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //kokeillaan luokkaa calculator
            Dice laskin = new Dice();
            int tulos = laskin.Heita(10, 20);
            Console.WriteLine("Yhteenlasku 10+20 tulos on" + tulos);
        }
    }
}
