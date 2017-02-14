using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L5T1;
namespace L5Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab05Teht01();
        }
        static void Lab05Teht01() {
            //programmed by Van 7.2
            //tetataan Tyre ja vehicle luokka
            //luodaan ensimmäinen ajoneuvo
            Vehicle auto = new Vehicle();
            auto.Brand = "BMW";
            auto.Model = "320";
            //ostetaan parit renkaat
            Tyre rinkula = new L5T1.Tyre();
            rinkula.Branch = "Hankook";
            rinkula.Size = "205 /55R16";
            //laitetaan bemariin taakse renkaat
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);
            //näytetään auto tiedot
            Console.WriteLine("autossasi {0} on seuraavat tiedot {1}", auto.Brand, auto.ToString());
            //eturenkaat
            Tyre plaaa = new L5T1.Tyre();
            plaaa.Branch = "asus";
            plaaa.Size = "205 /00000";
            //laitetaan bemariin taakse renkaat
            auto.AddTyre(plaaa);
            auto.AddTyre(plaaa);
            Console.WriteLine("autossasi {0} on seuraavat tiedot {1}", auto.Brand, auto.ToString());


        }
        
    }
}
