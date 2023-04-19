using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing3
  
    [TestClass]
    public class TstStaff
    {

        string StaffNo = "5";
        string StaffName = "Gabrielius Vaitkus";
        string StaffAddress = "15 bridge meadow";
        string StaffMoNumber = "7845123433";
        string StaffRole = "Director";
        string StaffBirthDate = DateTime.Now.Date.ToString();
        string StaffActive = "True";
        
        [TestMethod]
        public void StaffNumberOK()
        {
            //Creating instance of a class 
            clsStaff staffNumber = new clsStaff();

            //test to see that it exists
            Assert.IsNotNull(staffNumber);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //New instance creation
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            string TestData = "Will Smith";

            //Assign the data to the property
            staffNumber.staffName = TestData;

            //Testing to see are two value are the same
            Assert.AreEqual(staffNumber.staffName, TestData);
        }

        [TestMethod]
        public void StaffAddressOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            string TestData = "Knight Avenue 2";

            //Assing data to the property
            staffNumber.staffAddress = TestData;

            //Check if two value are the same
            Assert.AreEqual(staffNumber.staffAddress, TestData);
        }

        [TestMethod]
        public void staffMoNumberOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            decimal TestData = 7415687415;

            //Assigning data to the property
            staffNumber.staffMoNumber = TestData;

            //test to see if two value are equal
            Assert.AreEqual(staffNumber.staffMoNumber, TestData);
        }

        [TestMethod]
        public void staffRoleOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            string TestData = "Analyst";

            //Assign data to the property
            staffNumber.staffRole = TestData;

            //Comparing the two values
            Assert.AreEqual(staffNumber.staffRole, TestData);
        }

        [TestMethod]
        public void staffBirthDateOK()
        {
            //New instance
            clsStaff staffNumber = new clsStaff();

            //Test data creation
            DateTime TestData = DateTime.Now.Date;

            //Assign data to the property
            staffNumber.staffBirthDate = TestData;

            //Compare the two value
            Assert.AreEqual(staffNumber.staffBirthDate,
                            TestData);
        }

        [TestMethod]
        public void staffActiveOK()
        {
            //Create new instance
            clsStaff staffNumber = new clsStaff();

            //Create test data
            Boolean TestData = true;

            //Assign data to the property
            staffNumber.staffActive = TestData;

            //Compare the two value
            Assert.AreEqual(staffNumber.staffActive, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create new instance
            clsStaff staffNumber = new clsStaff();

            //Boolean var to store the results
            Boolean Found = false;

            //Create test data
            int staffNo = 2;

            //invoke the method
            Found = staffNumber.Find(staffNo);

            //Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //Create an instance of the class
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffNo != 2)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffName != "John Smith")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffAddress != "Mangrove 1")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffMoNumberFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffMoNumber != 7845123456)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffRole != "Manager")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffBirthDateFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffBirthDate != Convert.ToDateTime("18/08/1998"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffActiveFound()
        {
            clsStaff staffNumber = new clsStaff();

            //Boolean to store the result
            Boolean Found = false;

            //Boolean variable to record if data is OK
            Boolean OK = true;

            //create test data
            Int32 staffNo = 2;

            //Invoke the method
            Found = staffNumber.Find(staffNo);

            //Check the staff number
            if (staffNumber.staffActive != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff staffNumber = new clsStaff();
            String Error = "";
            Error = staffNumber.Valid(staffNo, StaffName, StaffAddress, StaffMoNumber, StaffRole, StaffBirthDate, StaffActive);
        }
    }
}
