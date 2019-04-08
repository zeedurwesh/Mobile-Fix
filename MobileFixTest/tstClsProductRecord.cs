using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFixVS2015;

namespace MobileFixTest
{
    [TestClass]
    public class tstClsProductRecord
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductRecord pr = new clsProductRecord();
            Assert.IsNotNull(pr);
        }

        [TestMethod]
        public void TestProperties()
        {
            clsProductRecord pr = new clsProductRecord();
            Int32 id = 1;
            pr.ID = id;
            Assert.AreEqual(pr.ID, id);

            string serialNo_IMEI = "12345678910112";
            pr.SerialNo_IMEI = serialNo_IMEI;
            Assert.AreEqual(pr.SerialNo_IMEI, serialNo_IMEI);

            Int32 supplierID = 2;
            pr.SupplierId = supplierID;
            Assert.AreEqual(pr.SupplierId, supplierID);

            string supplierName = "Cosco";
            pr.SupplierName = supplierName;
            Assert.AreEqual(pr.SupplierName, supplierName);

            Int32 deviceId = 3;
            pr.DeviceId = deviceId;
            Assert.AreEqual(pr.DeviceId, deviceId);

            string deviceModel = "Samsung";
            pr.DeviceModel = deviceModel;
            Assert.AreEqual(pr.DeviceModel, deviceModel);

            decimal price = 15;
            pr.Price = price;
            Assert.AreEqual(pr.Price, price);

            string description = "Asdgdg";
            pr.Description = description;
            Assert.AreEqual(pr.Description, description);

            string status = "Basfa";
            pr.Status = status;
            Assert.AreEqual(pr.Status, status);

            Boolean returned = true;
            pr.Returned = returned;
            Assert.AreEqual(pr.Returned, returned);

        }
    }
}
