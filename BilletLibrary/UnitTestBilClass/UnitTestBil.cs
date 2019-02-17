using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBilClass
{
    [TestClass]
    public class UnitTestBil
    {
        [TestMethod]
        public void TestMethodPris()
        {
            //arrange
            decimal pris;

            //act
            pris = BilletLibrary.Bil.Pris();

            //assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        public void TestMethodK�ret�j()
        {
            //arrange
            string word;

            //act
            word = BilletLibrary.Bil.k�ret�j();

            //assert
            Assert.AreEqual("Bil", word);
        }
    }
}
