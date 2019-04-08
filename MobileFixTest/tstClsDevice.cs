using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFix;

namespace MobileFixTest
{
    [TestClass]
    public class tstClsDevice
    {
        [TestMethod]
        public void TestInstanceCreatedOK()
        {
            clsDevice cd = new clsDevice();
            Assert.IsNotNull(cd);
        }

        [TestMethod]
        public void TestProperties()
        {
            clsDevice cd = new clsDevice();
            string model = "Iphone7";
            cd.Model = model;
            Assert.AreEqual(cd.Model, model);

            string manufacture = "Samsung";
            cd.Manufacture = manufacture;
            Assert.AreEqual(cd.Manufacture, manufacture);

            Int32 id = 1;
            cd.ID = id;
            Assert.AreEqual(cd.ID, id);
        }
    }
}
