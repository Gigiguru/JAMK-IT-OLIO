using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTV16S4
{
    class Car
    {
        // Property = ominaisuus, ominaisuudet aina julkisia
        //näinkin voi tehä, mutta ei suositeltavaa
        //-> public int Speed;
        public int Horsepower { get; set; }
        //sisäinen vakio muuttuja määrittelee maksiminopeuden joka oliolle voidaan asettaa
        private const int maxSpeed = 200; //const tarkoittaa vakiota
        private int speed;
        public int Speed
        {
            // get-aksessori palauttaa propertyn arvon 
            get
            {
                return speed;
            }
            //set akserrorilla asetetaan propertyn arvoa
            set
            {
                if (value > maxSpeed)
                    speed = maxSpeed;
                else
                    speed = value;
            }

        }
        public string Brand { get; set; }
        //contructors
        public Car() {
            //oletuskontruktori
        }
        public Car(int horsepower, int speed)
        {
            Horsepower = horsepower;
            if (speed < maxSpeed)
                this.speed = speed; //this viittaa olioon itseensä
            else
                this.speed = maxSpeed;
        }
        //method
        public void Accelerate(int addition) {
            //kiihdytetaan kaaraa mutta ei yli maksiminopeuttaa
            if (speed + addition < maxSpeed)
                speed = speed + addition;
            else
                speed = maxSpeed;

        }

        public override string ToString()
        {
            
            {
                return Brand + " hv " + Horsepower + " nopeus " + speed;
            }

        }

    }
   

    class Program
    {
        static void TestMyCarClass()
        {
            //Luodaan Car-olio
            Car car = new Car();
            car.Brand = "Toyota";
            car.Horsepower = 120;
            car.Speed = 175;
            //luodaan toinen pirssi         
            Car car2 = new Car();
            car2.Brand = "Porche";
            car2.Horsepower = 300;
            car2.Speed = 9999;
            //luodaan kolmas fiat
            Car fiat = new Car(55, 105);
            fiat.Brand = "fiat";
        //näytetään konsolilla
        Console.WriteLine("ensimmäinen  auto {0}", car.ToString());
            Console.WriteLine("Autosi {1} nopeus on {0}", car.Speed, car.Brand);
            Console.WriteLine("Autosi2 {1} nopeus on {0}", car2.Speed, car2.Brand);
            Console.WriteLine("{1} nopeus on {0}", fiat.Speed, fiat.Brand);
            //kiihdytetaan autoa 20km
            car.Accelerate(20);
            car2.Accelerate(20);
            fiat.Accelerate(50);
            Console.WriteLine("kiihdytetään");
            Console.WriteLine("Autosi {1} nopeus on {0}", car.Speed, car.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}", car2.Speed, car2.Brand);
            Console.WriteLine("{1} nopeus on {0}", fiat.Speed, fiat.Brand);
        }


        static void Main(string[] args)
        {
            TestMyCarClass();
        }
    }
}
