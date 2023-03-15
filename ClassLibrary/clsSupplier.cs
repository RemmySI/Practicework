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
        public bool Find(int AddressNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@supplierNo", supplierNo);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                msupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["supplierNo"]);
                msupplierName = Convert.ToString(DB.DataTable.Rows[0]["supplierName"]);
                msupplierContactNo = Convert.ToDecimal(DB.DataTable.Rows[0]["supplierContactNo"]);
                msupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["supplierEmail"]);
                msupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["supplierAddress"]);
                mdateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateRegistered"]);
                mactive = Convert.ToBoolean(DB.DataTable.Rows[0]["active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

    }
}