using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFixVS2015;

namespace MobileFixTest
{
    [TestClass]
    public class tstClsRepair
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRepair cr = new clsRepair();
            Assert.IsNotNull(cr);
        }

        [TestMethod]
        public void TestProperties()
        {
            clsRepair cr = new clsRepair();
            Int32 id = 1;
            cr.ID = id;
            Assert.AreEqual(cr.ID, id);

            string customerName = "Emma";
            cr.CustomerName = customerName;
            Assert.AreEqual(cr.CustomerName, customerName);

            string customerPhoneNo = "07912546789";
            cr.CustomerPhoneNo = customerPhoneNo;
            Assert.AreEqual(cr.CustomerPhoneNo, customerPhoneNo);

            string phoneModel = "Iphone7";
            cr.PhoneModel = phoneModel;
            Assert.AreEqual(cr.PhoneModel, phoneModel);

            string serialNo_IMEI = "12345678910112";
            cr.SerialNo_IMEI = serialNo_IMEI;
            Assert.AreEqual(cr.SerialNo_IMEI, serialNo_IMEI);

            string fault = "screen broken";
            cr.Fault = fault;
            Assert.AreEqual(cr.Fault, fault);

            string password = "AbCd$12&";
            cr.Password = password;
            Assert.AreEqual(cr.Password, password);
            
            decimal cost = 10;
            cr.Cost = cost;
            Assert.AreEqual(cr.Cost, cost);

            decimal deposit = 5;
            cr.Deposit = deposit;
            Assert.AreEqual(cr.Deposit, deposit);

            decimal balance = 5;
            cr.Balance = balance;
            Assert.AreEqual(cr.Balance, balance);

            string comment = "Something";
            cr.Comment = comment;
            Assert.AreEqual(cr.Comment, comment);
        }
    }
}
