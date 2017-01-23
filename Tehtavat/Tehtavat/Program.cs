using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    class Program
    {
        static void Main(string[] args) //T20 <-- 
        {
            int input = 0;
            string s = "";
           

            
                Console.WriteLine("Anna tehtava nro (0-> 19, 20 lopettaa)");
                s = Console.ReadLine();
                int.TryParse(s, out input);

                switch (input)
                {
                case 0:
                    T1();
                    break;
                case 1:
                    T2();
                    break;
                case 2:
                    T3();
                    break;
                case 3:
                    T4();
                    break;
                case 4:
                    T5();
                    break;
                case 5:
                    T6();
                    break;
                case 6:
                    T7();
                    break;
                case 7:
                    T8();
                    break;
                case 8:
                    T9();
                    break;
                case 9:
                    T10();
                    break;
                case 10:
                    T11();
                    break;
                case 11:
                    T12();
                    break;
                case 12:
                    T13();
                    break;
                case 13:
                    T14();
                    break;
                case 14:
                    T15();
                    break;
                case 15:
                    T16();
                    break;
                case 16:
                    T17();
                    break;
                case 17:
                    T18();
                    break;
                case 18:
                    T19();
                    break;
                case 19:
                    T19();
                    break;
                case 20:
                    break;
                
               
                }

        }
        static void T1()
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi.");
            }
            else if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            else
            {
                Console.WriteLine("Ei kelpaa");
            }
            ///OKV
            ///console.Writeline("Anna 1,2,3")
            ///string retval = Console.Readline();
            ///int luku = int.parse(retval);
            ///if luku (luku == 1)
            ///{
            ///retval ="yksi";
            ///}
            ///if luku (luku == 2)
            ///{
            ///retval ="kaksi";
            ///}
            ///if luku (luku == 3)
            ///{
            ///retval ="kolme";
            ///}
            ///else
            ///{
            ///retval ="joku muu";
            /// }
            ///console.writeline(retval);
        }
        static void T2()
        {

            int luku;
            Console.Write("Anna numero > ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1 || luku == 0)
            {
                Console.WriteLine("Numero 0");
            }
            else if (luku == 2 || luku == 3)
            {
                Console.WriteLine("Numero 1");
            }
            else if (luku == 4 || luku == 5)
            {
                Console.WriteLine("Numero 2");
            }
            else if (luku == 6 || luku == 7)
            {
                Console.WriteLine("Numero 3");
            }
            else if (luku == 8 || luku == 9)
            {
                Console.WriteLine("Numero 4");
            }
            else if (luku == 10 || luku == 12)
            {
                Console.WriteLine("Numero 5");
            }

        }
        static void T3() {
            int[] luku = new int[] { 0, 1, 2 };
            Console.WriteLine("anna kolme lukua");
            for (int i = 0; i < 3; i++)
            {
                luku[i] = int.Parse(Console.ReadLine());
            }
            int summa = luku[0] + luku[1] + luku[2];
            int jako = summa / 3;
            Console.WriteLine(summa);
            Console.Write(jako);
            // Console.Write(luku[1]);

        }
        static void T4() {
            int ika;
            Console.WriteLine("ikasi");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("alaikäinen");
            }
            else if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("wanhus");
            }
            else
            {
                Console.WriteLine("seniooori");
            }


        }
        static void T5() {
            int sekuntti;
            Console.Write("anna sekuntti ");
            sekuntti = int.Parse(Console.ReadLine());
            int tunti = sekuntti / 3600;
            int minuutti = (sekuntti % 3600) / 60;
            int sek = (sekuntti % 3600) % 60;


            Console.Write(string.Format("voidaan ilmaista {0} tunti {1} minuutti {2} sekuntti ", tunti, minuutti, sek));
        }
        static void T6() {
            double bensa = 1.595;
            double kulutus = 7.02 / 100;
            double bensaa;

            Console.Write("anna matka ");
            bensaa = double.Parse(Console.ReadLine());
            double kulu = kulutus * bensaa;
            double kustan = (kulutus * bensaa) * bensa;

            Console.Write(string.Format("Bensaa kuluu {0} litraa , kustannus {1:.##} euroa", kulu, kustan));
        }
        static void T7()
        {
            int vuosi;

            Console.Write("anna vuosi ");
            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 4 == 0 && vuosi % 100 != 0 ||
            vuosi % 400 == 0)
                Console.Write("Vuosi " + vuosi + " on karkausvuosi");
            else
                Console.Write("Vuosi " + vuosi + " ei ole karkausvuosi");

        }
        static void T8() {
            int[] luku = new int[] { 0, 1, 2 };
            Console.WriteLine("anna kolme lukua");
            for (int i = 0; i < 3; i++)
            {
                luku[i] = int.Parse(Console.ReadLine());
            }
            int suurin = luku.Max();
            Console.WriteLine(suurin);

        }
        static void T9() {
            string input = "";
            int Sum = 0, newNumber;
            while (input != "0")
            {
                Console.Write("syötä numeroita (0 laskee yhteen): ");
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out newNumber))
                {
                    Console.WriteLine("E onnistu");
                }
                Sum += newNumber;
            }
            Console.WriteLine(" yhteensä {0}", Sum);
            Console.ReadKey();
        }
        static void T10() {
            int[] arvot = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int luku;
            luku = int.Parse(Console.ReadLine());
            if ((luku - arvot[0]) == 0)
            {
                Console.Write("Hep ");

            }
            else if ((luku - arvot[2]) == 0)
            {
                Console.Write("Hep");

            }
            else if ((luku - arvot[3]) == 0)
            {
                Console.Write("Hep");

            }
            else if ((luku - arvot[4]) == 0)
            {
                Console.Write("Hep");

            }
            else if ((luku - arvot[5]) == 0)
            {
                Console.Write("Hep");

            }
            else if ((luku - arvot[6]) == 0)
            {
                Console.Write("Hep");

            }
            else if ((luku - arvot[7]) == 0)
            {
                Console.Write("Hep");

            }
            else if ((luku - arvot[8]) == 0)
            {
                Console.Write("Hep");

            }
            else if ((luku - arvot[9]) == 0)
            {
                Console.Write("Hep");

            }
        }
        static void T11() {

            string vali = " ";
            string tahti = "*";
            Console.WriteLine("Anna luku");
            int kysy = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= kysy; i++)  //korkeus
            {
                for (int d = kysy; d > 0; d--) //vali
                {
                    Console.Write(vali);
                }

                for (int e = 0; e < i; e++) //tahdet
                {
                    Console.Write(tahti);
                }

                Console.WriteLine();

            }
        }
        static void T12() {
            int[] luku = new int[] { 0, 1, 2, 3, 4 };
            Console.WriteLine("anna kolme lukua");
            for (int i = 0; i < 5; i++)
            {
                luku[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort<int>(luku);
            Array.Reverse(luku);
            foreach (int i in luku) Console.Write(i + " ");

        }
        static void T13() {
            int[] luku = new int[] { 0, 1, 2, 3, 4 };
            Console.WriteLine("anna 5 lukua");
            for (int i = 0; i < 5; i++)
            {
                luku[i] = int.Parse(Console.ReadLine());
            }
            int moi = luku[0] + luku[1] + luku[2] + luku[3] + luku[4];
            int suurin = luku.Max();
            int min = luku.Min();
            int arvo = (moi - luku.Max()) - luku.Min();
            Console.WriteLine("kokonais pojot {0}", arvo);

        }
        static void T14() {
            int[] arvosana = new int[6];
            int input = 0;
            string s = "";
            bool kytkin = true;

            while (kytkin)
            {
                Console.WriteLine("Anna arvosana (9 lopettaa)");
                s = Console.ReadLine();
                int.TryParse(s, out input);

                switch (input)
                {
                    case 0:
                        arvosana[0]++;
                        break;
                    case 1:
                        arvosana[1]++;
                        break;
                    case 2:
                        arvosana[2]++;
                        break;
                    case 3:
                        arvosana[3]++;
                        break;
                    case 4:
                        arvosana[4]++;
                        break;
                    case 5:
                        arvosana[5]++;
                        break;
                    case 9:
                        kytkin = false;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < arvosana.Length; i++)
            {
                Console.Write(i + ". ");
                for (int x = 0; x < arvosana[i]; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void T15()
        {
            int korkeus = 2; // tästä miinus 3 on ekan rivin pituus
            string[] rivit;
            string s = "";

            // tulostetaan kysymys, ja ajetaan if lauseen sulkujen sisällä integer korkeus muuttujaan
            // (jos ei saada integeriä käyttäjän syötöstä, mennään else haaraan ja tulostetaan virhe
            Console.WriteLine("kuusen korkeus? (minimi 2)");
            if (int.TryParse(Console.ReadLine(), out korkeus))
            {
                // jos korkeus on liien pieni ni niin tulostetaan että liian pieni ja suljetaan ohjelma (koska ohjelmassa ei ole mainlooppia)
                if (korkeus < 2)
                {
                    Console.WriteLine("Korkeus on liian pieni, ohjelma lopetetaan.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                rivit = new string[korkeus];

                // tehdään sisennykset merkillä #
                for (int i = 0; i < korkeus; i++)
                {
                    // eka rivi
                    if (i == 0)
                    {
                        s = "";
                        // mitä -3 tulee, katso kuva kuusirapellys.png
                        for (int x = 0; x < korkeus - 3; x++)
                        {
                            s += "#";
                        }
                        rivit[i] = s;
                    }
                    else // toisesta rivistä eteenpäin
                    {
                        s = "";
                        for (int x = 0; x < korkeus - 3 - i; x++)
                        {
                            s += "#";
                        }
                        rivit[i] = s;
                    }
                }

                // tehdään merkit * kuusen muotoon sisennysten perään
                for (int i = 0; i < korkeus; i++)
                {
                    // ensimmäinen rivi
                    if (i == 0)
                    {
                        rivit[i] += "*";
                    }
                    else // toisesta rivistä eteenpäin
                    {
                        s = "";
                        // guom i+(i+1):lla saadaan tarvittavien tähtien määrä tulosteeseen. taas katso kuva kuusirapellys.png
                        // joka pitäisi olla solution explorerissa tehtava 15 alla.
                        for (int x = 0; x < i + (i + 1); x++)
                        {
                            s += "*";
                        }
                        rivit[i] += s;
                    }

                    // muokataan kaksi viimeistä riviä vastaamaan ensimmäistä riviä jotta saadaan puun jalka
                    rivit[rivit.Length - 1] = rivit[0];
                    rivit[rivit.Length - 2] = rivit[0];
                }

                // vaihdetaan sisennyksen merkit '#' vastaamaan ' ' eli välilyöntiä.
                for (int i = 0; i < korkeus; i++)
                {
                    rivit[i] = rivit[i].Replace('#', ' ');
                }

                // tulostetaan puu
                foreach (string ss in rivit)
                {
                    Console.WriteLine(ss);
                }
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

        }
        static void T16() {
            int luku = 0;
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 100);
            Console.WriteLine(randomNumber);
            int yritys = 0;
            bool loop = true;
            while (loop)
            {
                yritys++;
                Console.WriteLine("anna luku");
                luku = int.Parse(Console.ReadLine());
                if (luku == randomNumber)
                {
                    Console.WriteLine("jee oikein {0}:lla yrityksella", yritys);
                    loop = false;
                }
                else if (luku < randomNumber)
                {
                    Console.WriteLine("Luku suurempi");

                }
                else
                {
                    Console.WriteLine("luku pienempi");

                }

            }






        }
        static void T17() {
            int[] taulu1 = new int[] { 0, 1, 2, 3, 4 };
            Console.WriteLine("taulukko1");
            Console.WriteLine("anna 5 lukua");
            for (int i = 0; i < 5; i++)
            {
                taulu1[i] = int.Parse(Console.ReadLine());
            }
            int[] taulu2 = new int[] { 0, 1, 2, 3, 4 };
            Console.WriteLine("taulukko1");
            Console.WriteLine("anna 5 lukua");
            for (int i = 0; i < 5; i++)
            {
                taulu2[i] = int.Parse(Console.ReadLine());
            }
            int[] taulu3 = taulu1.Concat(taulu2).ToArray();

            Array.Sort(taulu3);

            foreach (int i in taulu3)
            {
                Console.Write(i + ", ");
            }

        }
        static void T18() {

            Console.WriteLine("Give a sentence to check for palindrome");
            string s = Console.ReadLine();

            if (IsPalindrome(s))
            {
                Console.WriteLine("{0} is palindrome", s);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", s);
            }
        }

        static bool IsPalindrome(string s)
        {

            int fromBeginning = 0, fromEnd = s.Length - 1;

            // iteroidaan jokainen kirjain alusta ja lopusta 1 kerrallaan kunnes ensimmäinen ja viimeinen indexi on sama
            for (fromBeginning = 0; fromBeginning < fromEnd; fromBeginning++, fromEnd--)
            {
                // luetaan pois erikoismerkit alusta
                while (!char.IsLetterOrDigit(s[fromBeginning]))
                {
                    fromBeginning++;
                }

                // luetaan pois erikoismerkit lopusta
                while (!char.IsLetterOrDigit(s[fromEnd]))
                {
                    fromEnd--;
                }

                // palautetaan false jos kirjaimet eivät ole samat
                if (char.ToLower(s[fromBeginning]) != char.ToLower(s[fromEnd]))
                {
                    return false;
                }
            }
            // palautetaan tosi koska kaikki oli samat ja kirjaimet loppu
            return true;
        }
        static void T19()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string[] sana = { "Hirsipuu" };
            string arvaasana = sana[random.Next(0, sana.Length)];
            string arvaasanaUppercase = arvaasana.ToUpper();
            StringBuilder Nayta = new StringBuilder(arvaasana.Length);
            for (int i = 0; i < arvaasana.Length; i++)
                Nayta.Append('_');
            List<char> oikein = new List<char>();
            List<char> vaarin = new List<char>();
            int elama = 10;
            bool voitto = false;
            int kirjaimia = 0;
            string syotto;
            char arvaa;
            while (!voitto && elama > 0)
            {
                Console.Write("arvaa sana");
                syotto = Console.ReadLine().ToUpper();
                arvaa = syotto[0];
                if (oikein.Contains(arvaa))
                {
                    Console.WriteLine("kirjain {0} on kaytetty ja se oli oikein", arvaa);
                    continue;
                }
                else if (vaarin.Contains(arvaa))
                {
                    Console.WriteLine("kirjain {0} on kaytetty ja se oli vaarin", arvaa);
                    continue;
                }
                if (arvaasanaUppercase.Contains(arvaa))
                {
                    oikein.Add(arvaa);
                    for (int i = 0; i < arvaasana.Length; i++)
                    {
                        if (arvaasanaUppercase[i] == arvaa)
                        {
                            Nayta[i] = arvaasana[i];
                            kirjaimia++;
                        }
                    }
                    if (kirjaimia == arvaasana.Length)
                        voitto = true;
                }
                else
                {
                    vaarin.Add(arvaa);
                    Console.WriteLine("Voe ei kirjain {0} ei kuulunut", arvaa);
                    elama--;
                }
                Console.WriteLine(Nayta.ToString());
            }
            if (voitto)
                Console.WriteLine("voitit,izi Game izi life");
            else
                Console.WriteLine("havisit, sana olikin {0}", arvaasana);


        }
    
    }
}
