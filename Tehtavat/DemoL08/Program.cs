using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL08
{
    interface ICalculator
    {
        int Add(int numero1, int numero2);
        int Multiply(int numero1, int numero2);
        int Subract(int numero1, int numero2);
        int Divide(int numero1, int numero2);
    }
    //luokka joka toteuttaa Icalculator-rajapinnan
    public class Calculator : ICalculator
    {
        public int Add(int numero1, int numero2)
        { return numero1 + numero2; }
        public int Multiply(int numero1, int numero2)
        { return numero1 * numero2; }
        public int Subract(int numero1, int numero2)
        { return numero1 - numero2; }
        public int Divide(int numero1, int numero2)
        { return numero1 / numero2; }
    }
    class TestiPeti
    {
        
        static void Main(string[] args)
        {
            //kokeillaan luokkaa calculator
            Calculator laskin = new Calculator();
            int tulos = laskin.Add(10, 20);
            Console.WriteLine("Yhteenlasku 10+20 tulos on" + tulos);
        }
    }
}
