using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6T02
{
    class CD
    {
        //Properties
        public string CDNimi { get; set; }
        public string Artisti { get; set; }
        public string Biisi { get; set; }
        public string aika { get; set; }
        public override string ToString()
        {
            return CDNimi + " " + Artisti + " " + Biisi;
        }
        class CDs
        {
            //members = jäsenmuuttujat
            private List<CDs> persons;
            //contrucror
            public CDs()
            {
                persons = new List<CDs>();
            }
            //methods
            public void Add(CD person)
            {
                persons.Add(CDs);
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
