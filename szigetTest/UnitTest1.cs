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

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Sziget s = new Sziget();
            int varteredmeny1 = 4;
            int kapotteredmeny1 = s.szigetszam();

            Assert.AreEqual(varteredmeny1, kapotteredmeny1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Sziget s = new Sziget();
            int varteredmeny = 5;
            int kapotteredmeny = s.szigethossz();

            Assert.AreNotEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Sziget s = new Sziget();
            int varteredmeny1 = 4;
            int kapotteredmeny1 = s.szigetszam();

            Assert.AreNotEqual(varteredmeny1, kapotteredmeny1);
        }
    }
}
