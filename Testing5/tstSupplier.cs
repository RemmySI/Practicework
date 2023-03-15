using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void SupplierNoOK()
        {
            //Creating instance of a class 
            clsSupplier ASupplier = new clsSupplier();

            //test to see that it exists
            Assert.IsNotNull(ASupplier);
        }
        [TestMethod]
        public void SupplierNameOK()
        {
            //New instance creation
            clsSupplier ASupplier = new clsSupplier();

            //Test data creation
            string TestData = "amazon";

            //Assign the data to the property
            ASupplier.supplierName = TestData;

            //Testing to see are two value are the same
            Assert.AreEqual(ASupplier.supplierName, TestData);
        }
        [TestMethod]
        public void SupplierContactNoOK()
        {
            //New instance
            clsSupplier ASupplier = new clsSupplier();

            //Test data creation
            decimal TestData = 01933568749;

            //Assigning data to the property
            ASupplier.supplierContactNo = TestData;

            //test to see if two value are equal
            Assert.AreEqual(ASupplier.supplierContactNo, TestData);
        }
        [TestMethod]
        public void SupplierEmailOK()
        {
            //New instance creation
            clsSupplier ASupplier = new clsSupplier();

            //Test data creation
            string TestData = "amazon49@hotmail.com";

            //Assign the data to the property
            ASupplier.supplierEmail = TestData;

            //Testing to see are two value are the same
            Assert.AreEqual(ASupplier.supplierEmail, TestData);
        }
        [TestMethod]
        public void SupplierAddressOK()
        {
            //New instance
            clsSupplier ASupplier = new clsSupplier();

            //Test data creation
            string TestData = "100 Brington Road, E12 QS";

            //Assing data to the property
            ASupplier.supplierAddress = TestData;

            //Check if two value are the same
            Assert.AreEqual(ASupplier.supplierAddress, TestData);
        }
        [TestMethod]
        public void DateRegisteredOK()
        {
            //New instance
            clsSupplier ASupplier = new clsSupplier();

            //Test data creation
            DateTime TestData = DateTime.Now.Date;

            //Assign data to the property
            ASupplier.dateRegistered = TestData;

            //Compare the two value
            Assert.AreEqual(ASupplier.dateRegistered, TestData);
        }
        [TestMethod]
        public void ActiveOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASupplier.active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.active, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierNoFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //check the address no
            if (ASupplier.supplierNo != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //check the property
            if (ASupplier.supplierName != "amazon")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierContactNoFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //check the property
            if (ASupplier.supplierContactNo != 01933568749)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //check the property
            if (ASupplier.supplierEmail != "amazon49@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //check the property
            if (ASupplier.supplierAddress != "100 Brington Road, E12 QS")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRegisteredFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //check the property
            if (ASupplier.dateRegistered != Convert.ToDateTime("15/02/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 supplierNo = 3;
            //invoke the method
            Found = ASupplier.Find(supplierNo);
            //check the property
            if (ASupplier.active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
