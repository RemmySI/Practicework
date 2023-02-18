using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class TstStaff
    {
        [TestMethod]
        public void StaffNumberOK()
        {
            //Creating instance of a class 
            staffNo staffNumber = new staffNo();

            //test to see that it exists
            Assert.IsNotNull(staffNumber);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //New instance creation
            staffNo staffNumber = new staffNo();

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
            staffNo staffNumber = new staffNo();

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
            staffNo staffNumber = new staffNo();

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
            staffNo staffNumber = new staffNo();

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
            staffNo staffNumber = new staffNo();

            //Test data creation
            DateTime TestData = DateTime.Now.Date;

            //Assign data to the property
            staffNumber.staffBirthDate = TestData;

            //Compare the two value
            Assert.AreEqual(staffNumber.staffBirthDate, TestData);
        }
    }
}
