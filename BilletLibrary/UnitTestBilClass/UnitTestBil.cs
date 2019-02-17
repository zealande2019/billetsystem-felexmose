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
        public void TestMethodKøretøj()
        {
            //arrange
            string word;

            //act
            word = BilletLibrary.Bil.køretøj();

            //assert
            Assert.AreEqual("Bil", word);
        }
    }
}
