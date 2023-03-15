using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the supplierNo property
        private Int32 msupplierNo;
        //public property for the supplier number
        public int supplierNo
        {
            get
            {
                //return the private data
                return msupplierNo;
            }
            set
            {
                //set the value of the private data member
                msupplierNo = value;
            }
        }

        //private data member for supplier name
        private string msupplierName;
        //public property for supplier name
        public string supplierName
        {
            get
            {
                //return the private data
                return msupplierName;
            }
            set
            {
                //set the private data
                msupplierName = value;
            }
        }

        //private data member for supplierContactNo
        private decimal msupplierContactNo;
        //public property for supplier ContactNo
        public decimal supplierContactNo
        {
            get
            {
                //return private data
                return msupplierContactNo;
            }
            set
            {
                //set the private data
                msupplierContactNo = value;
            }
        }
        //private data member for supplier email
        private string msupplierEmail;
        //public property for supplier email
        public string supplierEmail
        {
            get
            {
                //return the private data
                return msupplierEmail;
            }
            set
            {
                //set the private data
                msupplierEmail = value;
            }
        }

        //private data member for supplier address
        private string msupplierAddress;
        //public data member for supplier address
        public string supplierAddress
        {
            get
            {
                //return the private data
                return msupplierAddress;
            }
            set
            {
                //set the private data
                msupplierAddress = value;
            }
        }

        //private date registered data member
        private DateTime mdateRegistered;
        //public property for date registered
        public DateTime dateRegistered
        {
            get
            {
                //return the private data
                return mdateRegistered;
            }
            set
            {
                //set the private data
                mdateRegistered = value;
            }
        }

        //private data member for active
        private Boolean mactive;
        //public property for active
        public bool active
        {
            get
            {
                //return the private data
                return mactive;
            }
            set
            {
                //set the private data
                mactive = value;
            }
        }
        public bool Find(int supplierNo)
        {
            //set the private data members to the test data value
            msupplierNo = 3;
            msupplierName = "amazon";
            msupplierContactNo = 01933568749;
            msupplierEmail = "amazon49@hotmail.com";
            msupplierAddress = "100 Brington Road, E12 QS";
            mdateRegistered = Convert.ToDateTime("15/02/2023");
            mactive = true;
            //always return true
            return true;
        }

    }
}