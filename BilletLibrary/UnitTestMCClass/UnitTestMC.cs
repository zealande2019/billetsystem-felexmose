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
        public void TestMethodK�ret�j()
        {
            //arrange
            string k�ret�j;

            //act
            k�ret�j = BilletLibrary.MC.k�ret�j();

            //assert
            Assert.AreEqual("MC", k�ret�j);

        }
    }
}
