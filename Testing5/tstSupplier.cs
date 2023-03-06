using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void SupplierNumberOK()
        {
            //Creating instance of a class 
            supplierNo supplierNumber = new supplierNo();

            //test to see that it exists
            Assert.IsNotNull(supplierNumber);
        }
        [TestMethod]
        public void SupplierNameOK()
        {
            //New instance creation
            supplierNo supplierNumber = new supplierNo();

            //Test data creation
            string TestData = "amazon";

            //Assign the data to the property
            supplierNumber.supplierName = TestData;

            //Testing to see are two value are the same
            Assert.AreEqual(supplierNumber.supplierName, TestData);
        }
        [TestMethod]
        public void supplierContactNoOK()
        {
            //New instance
            supplierNo supplierNumber = new supplierNo();

            //Test data creation
            decimal TestData = 01933568749;

            //Assigning data to the property
            supplierNumber.supplierContactNo = TestData;

            //test to see if two value are equal
            Assert.AreEqual(supplierNumber.supplierContactNo, TestData);
        }
        [TestMethod]
        public void supplierEmailOK()
        {
            //New instance creation
            supplierNo supplierNumber = new supplierNo();

            //Test data creation
            string TestData = "amazon49@hotmail.com";

            //Assign the data to the property
            supplierNumber.supplierEmail = TestData;

            //Testing to see are two value are the same
            Assert.AreEqual(supplierNumber.supplierEmail, TestData);
        }
        [TestMethod]
        public void supplierAddressOK()
        {
            //New instance
            supplierNo supplierNumber = new supplierNo();

            //Test data creation
            string TestData = "100 Brington Road, E12 QS";

            //Assing data to the property
            supplierNumber.supplierAddress = TestData;

            //Check if two value are the same
            Assert.AreEqual(supplierNumber.supplierAddress, TestData);
        }
        [TestMethod]
        public void dateRegisteredOK()
        {
            //New instance
            supplierNo supplierNumber = new supplierNo();

            //Test data creation
            DateTime TestData = DateTime.Now.Date;

            //Assign data to the property
            supplierNumber.dateRegistered = TestData;

            //Compare the two value
            Assert.AreEqual(supplierNumber.dateRegistered, TestData);
        }
    }
}
