using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using helo;

namespace helo_teszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string vartEredm = "Helló Világ!";
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                helo.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                Assert.AreEqual(kapottEredm, vartEredm);
            }
        }
    }
}
