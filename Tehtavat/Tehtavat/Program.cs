using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            //T1();
            //T2();
            //T3();
            //T4();
            T5();
            //T6();
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
            int summa = luku[0] + luku[1]+ luku[2];
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
            int tunti = sekuntti / 60;
            int minuutti = tunti / 60;
            int sek = minuutti / 60;
            Console.WriteLine(tunti + minuutti + sek);
        }
    }
}
