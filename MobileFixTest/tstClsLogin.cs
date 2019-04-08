using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFixVS2015;
using MobileFixVS2015.AppCode;

namespace MobileFixTest
{
    [TestClass]
    public class tstClsLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLogin cl = new clsLogin();
            Assert.IsNotNull(cl);
        }

        [TestMethod]
        public void TestProperties()
        {
            clsLogin cl = new clsLogin();
            string user = "User";
            cl.UserName = user;
            Assert.AreEqual(cl.UserName, user);

            string password = "pass123";
            cl.Password = password;
            Assert.AreEqual(cl.Password, password);
        }

        [TestMethod]
        public void UserNameMinLessOne()
        {            
            clsLogin lg = new clsLogin();
            Boolean OK = false;
            string Name = "";
            OK = lg.isUserValid(Name);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void UserNameMinBoundary()
        {
            clsLogin lg = new clsLogin();
            Boolean OK = false;
            string Name = "b";
            OK = lg.isUserValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void UserNameMinPlusOne()
        {
            clsLogin lg = new clsLogin();
            Boolean OK = false;
            string Name = "bb";
            OK = lg.isUserValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void UserNameMaxLessOne()
        {
            clsLogin lg = new clsLogin();
            Boolean OK = false;
            string Name = "coolcarisblack";
            OK = lg.isUserValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void UserNameMaxBoundary()
        {
            clsLogin lg = new clsLogin();
            Boolean OK = false;
            string Name = "coolcarwasblack";
            OK = lg.isUserValid(Name);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            clsLogin lg = new clsLogin();
            Boolean OK = false;
            string Name = "coo0lcarwasblack";
            OK = lg.isUserValid(Name);
            Assert.IsFalse(OK);
        }
    }
}
