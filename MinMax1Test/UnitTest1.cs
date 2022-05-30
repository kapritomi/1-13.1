using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MinMax1;

namespace MinMax1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MinMax m = new MinMax();

            int varteredmeny = 3;
            int kapotteredmeny = m.min();

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MinMax m = new MinMax();

            int varteredmeny = 10;
            int kapotteredmeny = m.max();

            Assert.AreEqual(varteredmeny, kapotteredmeny);

        }
        [TestMethod]
        public void TestMethod3()
        {
            MinMax m = new MinMax();

            int varteredmeny = 3;
            int kapotteredmeny = m.min();

            Assert.AreNotEqual(varteredmeny, kapotteredmeny);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MinMax m = new MinMax();

            int varteredmeny = 10;
            int kapotteredmeny = m.max();

            Assert.AreNotEqual(varteredmeny, kapotteredmeny);

        }
    }
}
