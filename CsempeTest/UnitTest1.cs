using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using csempe;

namespace CsempeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Csempe c = new Csempe();

            double vartEredm = 687.5;
            double kapottEredm = c.Eredm();

            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
