using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
        
    {
        Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperation()
        {
            int expected = 15;
            int actual = cal.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubOperation()
        {
            int expected = 5;
            int actual = cal.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(10, 0);
            c.Execute("/");
        }
    }
}
