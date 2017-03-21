using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        double expected, actual;

        [TestMethod()]
        public void SumTest()
        {
            expected = 25.6;
            actual = ArrayCalcs.Sum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double sum = 0;
            foreach (double doub in array)
            {
                sum += doub;
            }

            expected = sum / array.Length;

            actual = ArrayCalcs.Average(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            expected = -4.5;
            actual = ArrayCalcs.Min(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            expected = 12.0;
            actual = ArrayCalcs.Max(array);
            Assert.AreEqual(expected, actual);
        }
    }
}