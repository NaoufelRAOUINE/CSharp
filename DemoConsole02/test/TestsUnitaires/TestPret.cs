using System;
using DemoConsole02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitaires
{
    [TestClass]
    public class TestPret
    {
        [TestMethod]
        public void TestMensualite()
        {
            Pret pretTest = new Pret(5, 15, 100000);
            double dblMenssualiteAttendue = 790.79;
            double dblMensualiteCalculee = Math.Round(pretTest.CalculMensualite(),2);

            Assert.AreEqual(dblMenssualiteAttendue, dblMensualiteCalculee);
        }
    }
}
