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
        public void TestMethodK�ret�j()
        {
            //arrange
            Boolean brobizz = false;
            MC myMc = new MC(brobizz);

            //act
            string k�ret�j = myMc.k�ret�j();

            //assert
            Assert.AreEqual("MC", k�ret�j);

        }
    }
}
