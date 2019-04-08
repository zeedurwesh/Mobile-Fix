using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFix;

namespace Test_Framework
{
    [TestClass]
    public class tstDevice
    {
        [TestMethod]
        public void ManufacturePropertyOK()
        {
            //create an instance of the class we want to create
            clsDevice ADevice = new clsDevice();
            //create some test data to the property
            string SomeManufacture = "Apple";
            //assign the data to the property
            ADevice.Manufacture = SomeManufacture;
            //test to see that the two values are same
            Assert.AreEqual(ADevice.Manufacture, SomeManufacture);
        }

        public void ModelPropertyOK()
        {
            //create an instance of the class we want to create
            clsDevice ADevice = new clsDevice();
            //create some test data to the property
            string SomeModel = "Iphone7";
            //assign the data to the property
            ADevice.Model = SomeModel;
            //test to see that the two values are same
            Assert.AreEqual(ADevice.Model, SomeModel);
        }

        public void TypePropertyOK()
        {
            //create an instance of the class we want to create
            clsDevice ADevice = new clsDevice();
            //create some test data to the property
            string SomeType = "Phone";
            //assign the data to the property
            ADevice.Type = SomeType;
            //test to see that the two values are same
            Assert.AreEqual(ADevice.Type, SomeType);
        }

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsDevice AManufacture = new clsDevice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to the property
            string SomeManufacture = "Samsung";
            //invoke the method
            OK = AManufacture.Valid(SomeManufacture);
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        public void ManufactureMinLessOne()
        {
            //create an instance of the class we want to create
            clsDevice AManufacture = new clsDevice();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to the property
            string SomeManufacture = "";
            //invoke the method
            OK = AManufacture.Valid(SomeManufacture);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        }
    }

 