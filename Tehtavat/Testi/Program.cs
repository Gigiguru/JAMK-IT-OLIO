using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testi
{
    class CD
    {
        //properties
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public string Biisit { get; set; }
        public string Song { get; set; }
        //methods
        public override string ToString()
        {
            return Nimi + " " + Artisti + " " + Biisit;
        }
    }
    class CDs
    {
        //members = jäsenmuuttujat
        private List<CD> cds;
        //contrucror
        public CDs()
        {
            cds = new List<CD>();
        }
        //methods
        public void Add(CD CD)
        {
            cds.Add(CD);
        }
        public CD Get(int index)
        {
            if (index < cds.Count)
            {
                return cds.ElementAt(index);
            }
            else
                return null;
        }
        public void ShowCDs()
        {
            foreach (CD p in cds)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
    class Album
    {
        private List<CD> album;
        public Album()
        {
            album = new List<CD>();
        }


        public void Lisaa(CD CD)
        {
            album.Add(CD);
        }
        public CD Get(int index)
        {
            if (index < album.Count)
            {
                return album.ElementAt(index);
            }
            else
                return null;
        }
        public void Nayta()
        {
            foreach (CD p in album)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan ns henkilorekisteri
            CDs myFriends = new CDs();
            Album moi = new Testi.Album();
         
            CD moi1 = new CD { Nimi = "Dick", Artisti = "Butt", Biisit = "141250-96H3" };
            CD.Add(moi);
            //lisätään kamuja rekisteriin
            CD friend1 = new CD();
            friend1.Nimi = "name:Endless Forms Most Beautiful";
            friend1.Artisti = "Nightwish";
            friend1.Biisit = "Song";
            
            //lisätään kaverit yksi kerrallaan kaveri rekisteriin
            myFriends.Add(friend1);

            //näytetään tämä rekisteri
            Console.WriteLine("***** kaveroi rekisterisi *******");
            myFriends.ShowCDs();
         
        }
    }
}
