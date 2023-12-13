using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CalculatorTester
{
    [TestClass]
    public class TestRadix
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix1()
        {
            int number = -1;
            Radix r = new Radix(number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix2()
        {
            int number = -1;
            Radix r = new Radix(number);
            int radix = 1;
            r.ConvertDecimalToAnother(radix);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix4()
        {
            int number = -1;
            Radix r = new Radix(number);
            int radix = 17;
            r.ConvertDecimalToAnother(radix);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\Testdataradix.csv", "Testdataradix#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestRadix3()
        {
            int number = int.Parse(TestContext.DataRow[0].ToString());
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            string expected = TestContext.DataRow[2].ToString();
            Calculator.Radix r = new Calculator.Radix(number);
            Assert.AreEqual(expected, r.ConvertDecimalToAnother(radix));

        }


    }
}
