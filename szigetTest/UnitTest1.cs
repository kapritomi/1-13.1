using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sziget;

namespace szigetTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sziget s = new Sziget();
            int varteredmeny = 5;
            int kapotteredmeny = s.szigethossz();
            int varteredmeny1 = 4;
            int kapotteredmeny1 = s.szigetszam();

            Assert.AreEqual(varteredmeny, kapotteredmeny);
            Assert.AreEqual(varteredmeny1, kapotteredmeny1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Sziget s = new Sziget();
            int varteredmeny1 = 4;
            int kapotteredmeny1 = s.szigetszam();

            Assert.AreEqual(varteredmeny1, kapotteredmeny1);
        }
    }
}
