using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);

        }
        [TestMethod]
        public void AvailableCardOK()
        {
            //Create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            Boolean TestData = true;
            //Assign the data to the item
            AnStock.Available = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStock.Available, TestData);


        }
        [TestMethod]
        public void DateAddedCardOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the item
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void CardNoOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            Int32 TestData = 2;
            //assign the data to the item
            AnStock.CardNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardNo, TestData);
        }

        [TestMethod]
        public void CardDescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            string TestData = "This is the card Description";
            //Assign the data to the item
            AnStock.CardDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardDescription, TestData);
        }

        [TestMethod]
        public void CardTypeOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            string TestData = "This is the type of the card";
            //Assign the data to the item
            AnStock.CardType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardType, TestData);
        }

        [TestMethod]
        public void CardPriceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the Item
            decimal TestData = 975;
            //Assign the data to the item
            AnStock.CardPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.CardPrice, TestData);
        }








    }
}

