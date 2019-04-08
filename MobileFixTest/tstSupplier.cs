using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFixVS2015;

namespace MobileFixTest
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(ASupplier);
        }
    }
}
