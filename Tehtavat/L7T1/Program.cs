using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List = new List<string>();
            while (true)
            {
                string Arrays;
                Console.Write("Give a text line (enter ends)");
                Arrays = Console.ReadLine();
                List.Add(Arrays);
                if (Arrays == "")
                {
                    goto Step1;
                }
            }


        Step1:
            using (StreamWriter sw = new StreamWriter("../../T1.txt"))
            {
                foreach (string item in List)
                {
                    sw.WriteLine(item);
                }
            }
            using (StreamReader sw = new StreamReader("../../T1.txt"))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
