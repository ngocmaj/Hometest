using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CalculatorTester
{
    [TestClass]
    public class TestPoly
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn1()
        {
            int n = 2;
            List<int> a = new List<int>() { 1, 2 };
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn2()
        {
            int n = 2;
            List<int> a = new List<int>() { 1, 2, 3, 4 };
            Polynomial p = new Polynomial(n, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolyn3()
        {
            int n = -1;
            List<int> a = new List<int>() {1,2 };
            Polynomial p = new Polynomial(n, a);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void TestPolyn4()
        {
            int n = 2;
            List<int> a = new List<int>() { 1, 2, 3 };
            int x = 1;
            int expected = 6;
            Polynomial p = new Polynomial(n, a);
            Assert.AreEqual(expected, p.Cal(x));
        }
    }
}