using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of Customer class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);

        }
        [TestMethod]
        public void DateAddedCustomerOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void CustomerNoOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerNo = TestData;
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }
        [TestMethod]
        public void CustomerFirstNameOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Sam";
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void CustomerLastNameOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Smith";
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }
        [TestMethod]
        public void CustomerEmailAddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "ss@hotm.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void CustomerPhoneNoOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "2151254207";
            ACustomer.PhoneNo = TestData;
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }
    }
}


