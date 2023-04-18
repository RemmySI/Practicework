using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 msupplierNo;
        public Int32 supplierNo
        {
            get
            {
                return msupplierNo;
            }
            set
            {
                msupplierNo = value;

            }
        }

        private string msupplierName;
        public string supplierName
        {
            get
            {
                return msupplierName;
            }
            set
            {
                msupplierName = value;
            }
        }

        private string msupplierContactNo;
        public string supplierContactNo
        {
            get
            {
                return msupplierContactNo;
            }
            set
            {
                msupplierContactNo = value;
            }
        }
        private string msupplierEmail;
        public string supplierEmail
        {
            get
            {
                return msupplierEmail;
            }
            set
            {
                msupplierEmail = value;
            }
        }

        private string msupplierAddress;
        public string supplierAddress
        {
            get
            {
                return msupplierAddress;
            }
            set
            {
                msupplierAddress = value;
            }
        }

        private DateTime mdateRegistered;
        public DateTime dateRegistered

        {
            get
            {
                return mdateRegistered;

            }
            set
            {
                mdateRegistered = value;
            }
        }

        private bool mactive;
        public bool active
        {
            get
            {
                return mactive;
            }
            set
            {
                mactive = value;
            }
        }
        public bool Find(int supplierNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierNo", supplierNo);
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            if (DB.Count == 1)


            {
                //set the privare data members to the test data value
                msupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["supplierNo"]);
                msupplierName = Convert.ToString(DB.DataTable.Rows[0]["supplierName"]);
                msupplierContactNo = Convert.ToString(DB.DataTable.Rows[0]["supplierContactNo"]);
                msupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["supplierEmail"]);
                msupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["supplierAddress"]);
                mdateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateRegistered"]);

                //always return true
                return true;
            }
            else
            {

                return false;
            }
        }

    }
}
