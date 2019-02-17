using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMCClass
{
    [TestClass]
    public class UnitTestMC
    {
        [TestMethod]
        public void TestMethodPris()
        {
            //arrange
            MC myMC = new MC();

            //act
            decimal pris = myMC.Pris();

            //assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void TestMethodK�ret�j()
        {
            //arrange
            MC myMc = new MC();

            //act
            string k�ret�j = myMc.k�ret�j();

            //assert
            Assert.AreEqual("MC", k�ret�j);

        }
    }
}
