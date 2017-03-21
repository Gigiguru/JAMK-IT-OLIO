using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
   
    class ArrayCalcs
    {

        static public double Sum(double[] X)
        {
            double sum = 0;
            foreach (double item in X)
            {
                sum += item;
            }
            return sum;
        }
        static public double Average(double[] X)
        {


            return Sum(X) / X.Length;

        }
        static public double Min(double[] X)
        {
            return X.Min();
        }
        static public double Max(double[] X)
        {
            return X.Max();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine("Sum=" + ArrayCalcs.Sum(array));
            Console.WriteLine("Ave={0:F2}", ArrayCalcs.Average(array));
            Console.WriteLine("Min=" + ArrayCalcs.Min(array));
            Console.WriteLine("Max=" + ArrayCalcs.Max(array));


        }
    }
}
