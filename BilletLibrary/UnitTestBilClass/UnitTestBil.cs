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
        public void TestMethodKøretøj()
        {
            //arrange
            Boolean brobiz = false;
            bil mycar = new bil(brobiz);

            //act
            string word = mycar.køretøj();

            //assert
            Assert.AreEqual("Bil", word);
        }

        [TestMethod]
        public void TestMethodPrisWeekendRabat()
        {
            //arrange
            bool brobizz = false;
            bil myCar = new bil(brobizz);
           
            //act
            decimal pris = myCar.Pris();

            //assert
            Assert.AreEqual(Convert.ToDecimal(240), pris);
        }

    }
}
