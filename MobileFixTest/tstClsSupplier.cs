using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFixVS2015;

namespace MobileFixTest
{
    [TestClass]
    public class tstClsSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
           
            clsSupplier cs = new clsSupplier();
            Assert.IsNotNull(cs);
        }

        [TestMethod]
        public void TestProperties()
        {
            clsSupplier cs = new clsSupplier();
            Int32 id = 1;
            cs.ID = id;
            Assert.AreEqual(cs.ID, id);

            string name = "BT";
            cs.Name = name;
            Assert.AreEqual(cs.Name, name);

            string address = "28 Leire Street";
            cs.Address = address;
            Assert.AreEqual(cs.Address, address);

            string town = "Leicester";
            cs.Town = town;
            Assert.AreEqual(cs.Town, town);

            string postcode = "LE4 6NT";
            cs.Postcode = postcode;
            Assert.AreEqual(cs.Postcode, postcode);

            string contactname = "Tom";
            cs.ContactName = contactname;
            Assert.AreEqual(cs.ContactName, contactname);

            string contactnumber = "07912895643";
            cs.ContactNumber = contactnumber;
            Assert.AreEqual(cs.ContactNumber, contactnumber);
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "";
            OK = cs.isNameValid(Name);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void NameMinBoundary()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "b";
            OK = cs.isNameValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "bb";
            OK = cs.isNameValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "asdfghjklasdfghjklasdfghjklasdfghj";
            OK = cs.isNameValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "asdfghjklasdfghjklasdfghjklasdfghjs";
            OK = cs.isNameValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "asdfghjklasdfghjklasdfghjklasdfghjsa";
            OK = cs.isNameValid(Name);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void NameMid()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "asdfghjklasdfgh";
            OK = cs.isNameValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsSupplier cs = new clsSupplier();
            Boolean OK = false;
            string Name = "";
            Name = Name.PadRight(50, 'b');
            OK = cs.isNameValid(Name);
            Assert.IsFalse(OK);
        }
    }
}
