using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Creature
    {
        public string Name { get; set; }
    }
    class NFisher : Creature
    {
        public string PhoneNumber { get; set; }
        public NFisher() { }
        public NFisher(string name, string phonenumber)
        {
            Name = name;
            PhoneNumber = phonenumber;
        }
        public override string ToString()
        {
            return " - Fisherman: " + Name + "Phone: " + PhoneNumber + "\n";
        }

    }
    class Fisher : Creature
    {
        public string PhoneNumber { get; set; }
        public Fisher() { }
        public Fisher(string name, string phonenumber)
        {
            Name = name;
            PhoneNumber = phonenumber;
        }
        public override string ToString()
        {
            return "Fisher " + Name + " got a new fish";
        }

    }
    class FishItsefl : Creature
    {
        public double Lenght { get; set; }
        public double Weight { get; set; }
        public FishItsefl() { }
        public FishItsefl(string name, double lenght, double weight)
        {
            Name = name;
            Weight = weight;
            Lenght = lenght;
        }
        public override string ToString()
        {
            return "- specie :" + Name + " " + Lenght + "cm " + Weight + "kg";
        }

    }
    class Location : Creature
    {
        public string Loca { get; set; }
        public string Place { get; set; }
        public Location() { }
        public Location(string loca, string place)
        {
            Loca = loca;
            Place = place;
        }
        public override string ToString()
        {
            return "- place:" + Loca + "\n" + "- location:" + Place + "\n";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Creature> NEWfisherman = new List<Creature>();
            NEWfisherman.Add(new NFisher("Kirsi Kernel", "020-12345678"));
            Console.WriteLine("A new fisherman added to register:");
            foreach (Creature X in NEWfisherman)
            {
                Console.WriteLine(X.ToString());
            }
            List<Creature> Fisher = new List<Creature>();
            Fisher.Add(new Fisher("Kirsi Kernel", ""));
            Fisher.Add(new FishItsefl("Pike", 120, 4.5));
            Fisher.Add(new Location("The Lake of Jyväskylä", "Jyväskylä "));
            Fisher.Add(new Fisher("Kirsi Kernel", ""));
            Fisher.Add(new FishItsefl("Salmon", 190, 12.2));
            Fisher.Add(new Location("River Teno", "The Northern edge of Finland "));
            foreach (Creature X in Fisher)
            {
                Console.WriteLine(X.ToString());
            }
            Console.WriteLine("All fishes in register");
            Console.WriteLine("Fisherman Kirsi Kernel has got following fishes:");
            List<Creature> FISHCAUGHT = new List<Creature>();

            FISHCAUGHT.Add(new FishItsefl("Pike", 120, 4.5));
            FISHCAUGHT.Add(new Location("The Lake of Jyväskylä", "Jyväskylä "));

            FISHCAUGHT.Add(new FishItsefl("Salmon", 190, 12.2));
            FISHCAUGHT.Add(new Location("River Teno", "The Northern edge of Finland "));
            foreach (Creature y in FISHCAUGHT)
            {
                Console.WriteLine(y.ToString());

            }



        }
    }
}
