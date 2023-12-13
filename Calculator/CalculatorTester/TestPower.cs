using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class TestPower
    {
        [TestMethod]
        public void KiemTra()
        {
            double x = 1;
            int n = 0;
            double expected = 1;
            Assert.AreEqual(expected, BaiTap.Power(x, n));
        }
        [TestMethod]
        public void KiemTra1()
        {
            double x = 3;
            int n = 2;
            double expected = 2;
            Assert.AreEqual(expected, BaiTap.Power(x, n));
        }
        [TestMethod]
        public void KiemTra2()
        {
            double x = 2;
            int n = -1;
            double expected = 0.5;
            Assert.AreEqual(expected, BaiTap.Power(x, n));
        }
    }
}
