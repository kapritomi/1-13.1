using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using negyszog;

namespace NegyszogTeszt
{
    [TestClass]
    public class UnitTest1
    {
        static double s = 2.0;
        Class1 nsz = new Class1(s);

        [TestMethod]
        public void TestMethod1()
        {
            double vartEredm = 8.0;
            double kapottEredm = nsz.Kerulet();

            Assert.AreEqual(vartEredm, kapottEredm);
        }

        public void TestMethod2()
        {
            double vartEredm1 = 4.0;
            double kapottEredm1 = nsz.Terulet();

            Assert.AreEqual(vartEredm1, kapottEredm1);
        }
    }
}
