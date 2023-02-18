using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Creating instance of a class 
            staffNo staffNumber = new staffNo();

            //test to see that it exists
            Assert.IsNotNull(staffNumber);
        }
    }
}
