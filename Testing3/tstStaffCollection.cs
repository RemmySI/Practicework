using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.staffNo = 2;
            TestItem.staffName = "John Smith";
            TestItem.staffAddress = "Mangrove 1";
            TestItem.staffMoNumber = "7845123456";
            TestItem.staffRole = "Manager";
            TestItem.staffBirthDate = DateTime.Parse("18/08/1998");
            TestItem.staffActive = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
    }
}
