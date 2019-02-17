using BilletLibrary;
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
            bil mycar = new bil() ;

            //act
            decimal pris = mycar.Pris();

            //assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        public void TestMethodK�ret�j()
        {
            //arrange
            bil mycar = new bil();

            //act
            string word = mycar.k�ret�j();

            //assert
            Assert.AreEqual("Bil", word);
        }
    }
}
