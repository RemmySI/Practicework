using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.supplierNo = 1;
            TestItem.supplierName = "alibaba";
            TestItem.supplierContactNo = "07856162654";
            TestItem.supplierEmail = "alibaba54@gmail.com";
            TestItem.supplierAddress = "24 shipton road, NN10 9BE";
            TestItem.dateRegistered = DateTime.Parse("20/02/2022");
            TestItem.active = true;

            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.supplierNo = 1;
            TestSupplier.supplierName = "alibaba";
            TestSupplier.supplierContactNo = "07856162654";
            TestSupplier.supplierEmail = "alibaba54@gmail.com";
            TestSupplier.supplierAddress = "24 shipton road, NN10 9BE";
            TestSupplier.dateRegistered = DateTime.Parse("20/02/2022");
            TestSupplier.active = true;

            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.supplierNo = 1;
            TestItem.supplierName = "alibaba";
            TestItem.supplierContactNo = "07856162654";
            TestItem.supplierEmail = "alibaba54@gmail.com";
            TestItem.supplierAddress = "24 shipton road, NN10 9BE";
            TestItem.dateRegistered = DateTime.Parse("20/02/2022");
            TestItem.active = true;

            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }
    }
}
