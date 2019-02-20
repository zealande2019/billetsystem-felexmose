using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMCClass
{
    [TestClass]
    public class UnitTestMC
    {
        [TestMethod]
        public void TestMethodPris()
        {
            //arrange
            MC myMC = new MC(false);

            //act
            decimal pris = myMC.Pris();

            //assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void TestMethodKøretøj()
        {
            //arrange
            Boolean brobizz = false;
            MC myMc = new MC(brobizz);

            //act
            string køretøj = myMc.køretøj();

            //assert
            Assert.AreEqual("MC", køretøj);

        }
    }
}
