using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calculator;

namespace calculator_test
{
    [TestClass]
    public class UnitTest1
    {
        Calculator a = new Calculator();
        [TestMethod]

        public void hibamethodus()
        {

            double varteredmeny1 = a.eredmeny();
            double kapotteredmeny1 = 10.0;
            double eredmeny = a.eredmeny();
            double kivonaskapotteredmeny = 10.0;
            double szorzaskapotteredmeny = 10.0;
            double osztaskapotteredmeny = 10.0;

            Assert.AreNotEqual(varteredmeny1, kapotteredmeny1);
            Assert.AreNotEqual(kivonaskapotteredmeny, kapotteredmeny1);
            Assert.AreNotEqual(szorzaskapotteredmeny, kapotteredmeny1);
            Assert.AreNotEqual(osztaskapotteredmeny, kapotteredmeny1);

        }
        [TestMethod]
        public void jomethodus()
        {
            double varteredmeny = a.eredmeny();

            double eredmeny = a.eredmeny();
            double kapotteredmeny = 20.0;
            double kivonaskapotteredmeny = 0.0;
            double szorzaskapotteredmeny = 100.0;
            double osztaskapotteredmeny = 1.0;

            Assert.AreEqual(kapotteredmeny, varteredmeny);
            Assert.AreEqual(kivonaskapotteredmeny, varteredmeny);
            Assert.AreEqual(szorzaskapotteredmeny, varteredmeny);
            Assert.AreEqual(osztaskapotteredmeny, varteredmeny);


        }
        [TestMethod]
        public void nulla()
        {
            double kapotteredmeny = a.eredmeny();
            double varteredmeny = 0;
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        public void TestMethod1()
        {
                       
        }
        
    }
}
