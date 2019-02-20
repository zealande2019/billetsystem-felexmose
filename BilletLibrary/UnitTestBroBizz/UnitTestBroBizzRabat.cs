using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBroBizz
{
    [TestClass]
    public class UnitTestBroBizzRabat
    {
        [TestMethod]
        public void TestMethodBilRabat()
        {
            //Arrange
            Boolean brobiz = true;
            bil mycar = new bil(brobiz);

            //act
            decimal rabatPrice = mycar.Pris();

            //assert
            Assert.AreEqual(228, rabatPrice);

        }

        [TestMethod]
        public void TestMethodMCRabat()
        {
            //arrange
            Boolean brobiz = true;
            MC myMC = new MC(brobiz);

            //acts
            decimal RabatPrice = myMC.Pris();

            //assert
            Assert.AreEqual(Convert.ToDecimal(118.75),RabatPrice);


        }
    }
}
