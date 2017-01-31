using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi
{

    class Vehicle
    {

        public string Name { get; }

        int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (!(value >= 0 && value <= 200))
                    speed = value;
                else
                    speed = 0;
            }
        }

        int tyres;
        public int Tyres
        {
            get
            {
                return tyres;
            }
            set
            {
                if (!(value >= 10 && value <= 25))
                    tyres = 14;
                else
                    tyres = value;
            }
        }

        public Vehicle(string name, int vechileSpeed, int tires)
        {
            if (!(speed >= 0 && speed <= 200))
                vechileSpeed = 0;

            if (tyres >= 10 && tyres <= 25)
                tires = 14;

            speed = vechileSpeed;
            tyres = tires;
            Name = name;
        }

        public void PrintData()
        {
            Console.WriteLine("Vechile: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public override string ToString()
        {
            string s = Name + ", " + Speed + ", " + Tyres;
            return "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle auto0 = new Vehicle ("Opel", 80, 18);
            Vehicle auto1 = new Vehicle("Fiat", 150, 14);
            Vehicle auto2 = new Vehicle("Lada", 199, 15);
            Vehicle auto3 = new Vehicle("auto", 200, 25);

            auto0.PrintData();
            auto1.PrintData();
            auto2.PrintData();
            auto3.PrintData();

            auto0.ToString();
            auto1.ToString();
            auto3.ToString();
            auto3.ToString();
        }

    }
}
