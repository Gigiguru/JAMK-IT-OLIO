using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Person
    {
        public string Firstname { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            using (StreamReader sw = new StreamReader("../../T1.txt"))
            {
                Person temp;
                string line;
                string[] split;

                while ((line = sw.ReadLine()) != null)
                {
                    temp = new Person();
                    split = line.Split(' ');
                    temp.Firstname = split[0];

                    persons.Add(temp);

                }
                Dictionary<string, int> Names = new Dictionary<string, int>();
                for (int i = 0; i < persons.Count; i++)
                {
                    if (Names.ContainsKey(persons[i].Firstname))
                    {
                        Names[persons[i].Firstname]++;
                    }
                    else
                    {
                        Names.Add(persons[i].Firstname, 1);
                    }
                }
                foreach (KeyValuePair<string, int> key in Names)
                {
                    Console.WriteLine(key.Key + " " + key.Value);
                }

            }
        }
    }
}
