using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBilClass
{
    [TestClass]
    public class UnitTestBil
    {
        [TestMethod]
        public void TestMethodPris()
        {
            //arrange
            Boolean brobiz = false;
            bil mycar = new bil(brobiz) ;

            //act
            decimal pris = mycar.Pris();

            //assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod]
        public void TestMethodK�ret�j()
        {
            //arrange
            Boolean brobiz = false;
            bil mycar = new bil(brobiz);

            //act
            string word = mycar.k�ret�j();

            //assert
            Assert.AreEqual("Bil", word);
        }
    }
}
