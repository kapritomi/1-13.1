using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Henger;

namespace HengerTeszt
{
    [TestClass]
    public class UnitTest1
    {
        
        
        [TestMethod]
        public void TestMethod1()
        {
            Hengerr H = new Hengerr();

            double vartEredm = 31.42;

            double kapottEredm = H.getKerulet();

            Assert.AreEqual(vartEredm,kapottEredm);

        }
    }
}
