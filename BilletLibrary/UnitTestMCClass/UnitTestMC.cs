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
            decimal pris;

            //act
            pris = BilletLibrary.MC.Pris();

            //assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void TestMethodKøretøj()
        {
            //arrange
            string køretøj;

            //act
            køretøj = BilletLibrary.MC.køretøj();

            //assert
            Assert.AreEqual("MC", køretøj);

        }
    }
}
