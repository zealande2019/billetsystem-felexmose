using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBaseClass
{
    [TestClass]
    public class UnitTestBaseProperties
    {
        [TestMethod]
        public void TestNummerplade()
        {
            //arrange
            bil myCar = new bil();

            //acts
            myCar.Nummerplade = "gftrhdjer";                              
            
            //asserts
            // check wether exeption is thrown.

        }
    }
}
