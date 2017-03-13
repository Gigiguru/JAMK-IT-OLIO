using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Dice
    {

        Random rnd1 = new Random();
        int Throw = 0;
        int Min = 1;
        int Max = 8;
        public int Value { get { return Throw; } }
        public void ThrowDice()
        {
            Throw = rnd1.Next(Min, Max);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int ThrowCount = 0, sum = 0;
            Dice noppa = new Dice();
            Console.WriteLine("How many times you want to throw a dice :");
            int.TryParse(Console.ReadLine(), out ThrowCount);
            for (int i = 0; i < ThrowCount; i++)
            {
                noppa.ThrowDice();
                sum = sum + noppa.Value;
                Console.WriteLine(noppa.Value);
            }
            float average = (float)sum / (float)ThrowCount;
            Console.WriteLine("Dice is now thrown {0} times, average is {1}", ThrowCount, average);

        }
    }
}
