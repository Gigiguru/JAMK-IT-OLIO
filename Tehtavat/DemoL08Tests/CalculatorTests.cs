using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoL08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL08.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //AAA-periaate
            //arrange = alustus, valmistelu
            Calculator calc = new Calculator();
            int n1 = 5;
            int n2 = 8;
            int expected = 13;
            //act=toimi
            int actual = calc.Add(n1, n2);
            //assert=tarkistus
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]

        public void Vahennys()
        {
            //AAA-periaate
            //arrange = alustus, valmistelu
            Calculator calc = new Calculator();
            int n1 = 5;
            int n2 = 3;
            int expected = 2;
            //act=toimi
            int actual = calc.Subract(n1, n2);
            //assert=tarkistus
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]

        public void Jako()
        {
            //AAA-periaate
            //arrange = alustus, valmistelu
            Calculator calc = new Calculator();
            int n1 = 10;
            int n2 = 5;
            int expected = 2;
            //act=toimi
            int actual = calc.Divide(n1, n2);
            //assert=tarkistus
            Assert.AreEqual(expected, actual);
            Assert.
        }
        [TestMethod()]
      
        public void AddTestZero()
        {
            //AAA-periaate
            //arrange = alustus, valmistelu
            Calculator calc = new Calculator();
            int n1 = 0;
            int n2 = 0;
            int expected = 0;
            //act=toimi
            int actual = calc.Add(n1, n2);
            //assert=tarkistus
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MultiplyTest()
        {
            //AAA-periaate
            //arrange = alustus, valmistelu
            Calculator calc = new Calculator();
            int n1 = 5;
            int n2 = 8;
            int expected = 40;
            //act=toimi
            int actual = calc.Multiply(n1, n2);
            //assert=tarkistus
            Assert.AreEqual(expected, actual);
            
        }
    }
}