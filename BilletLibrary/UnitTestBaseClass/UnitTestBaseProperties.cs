using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBaseClass
{
    [TestClass]
    public class UnitTestBaseProperties
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerplade()
        {
            //arrange
            bil myCar = new bil(false);
          

            //acts
            myCar.Nummerplade = "gftrhdjer";

            //asserts
            // check wether exeption is thrown.
            //Assert.ThrowsException(() => myCar.Nummerplade = "gftrhdjer");
            Assert.Fail();
        }
    }
}
