using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6T02
{
    class CD
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public string Biisit { get; set; }
        public string Aika { get; set; }
        public override string ToString()
        {
            return Nimi + Artisti + Biisit + Aika;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<CD> cd = new List<CD>();
            cd.Add(new CD { Nimi = "- name:Endless Forms Most Beautiful" });
            cd.Add(new CD { Artisti = "- artist: Nightwish " });
            cd.Add(new CD { Artisti = "- Song:" });
            cd.Add(new CD { Biisit = " - Weak Fantasy, ", Aika = " 6:29" });
            cd.Add(new CD { Biisit = " - Elan, ", Aika = "5:23" });
            cd.Add(new CD { Biisit = " - Yours Is an Empty Hope, ", Aika = "4:45" });
            cd.Add(new CD { Biisit = " - Our Decades in the Sun, ", Aika = "6:37" });
            cd.Add(new CD { Biisit = " - My Walden,", Aika = "4:38" });
            cd.Add(new CD { Biisit = " - Endless Forms Most Beautiful, ", Aika = "5:07" });
            cd.Add(new CD { Biisit = " - Edema Ruh, ", Aika = "5:15" });
            cd.Add(new CD { Biisit = " - Alpenglow,", Aika = "4:45" });
            cd.Add(new CD { Biisit = " - The Eyes of Sharbat Gula,", Aika = "6:03" });
            cd.Add(new CD { Biisit = " - The Greatest Show on Earth,", Aika = "24:00" });
            Console.WriteLine("CD data:");
            foreach (CD cdi in cd)
            {
                Console.WriteLine(cdi.ToString());
            }
        }

    }
}
