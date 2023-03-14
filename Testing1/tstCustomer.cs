using ClassLibrary;
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
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //instance of class being created 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variabel to store result of search
            Boolean Found = false;
            //record if data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 CustomerNo = 21;
            //Invoke method
            Found = ACustomer.Find(CustomerNo);
            // check customer number
            if (ACustomer.CustomerNo != 21)
            {
                OK = false;
            }
            //test to see that the result is ok/correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            //imvoke the method
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.DateAdded != Convert.ToDateTime("05/11/2021"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.FirstName != "Test First")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.LastName != "Test Last")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Email != "TestEmail@Email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.PhoneNo != "01788888")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}


