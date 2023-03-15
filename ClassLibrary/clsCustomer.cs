using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private DateTime mDateAdded;
        public DateTime DateAdded

        {
            get
            {
                return mDateAdded;

            }
            set
            {
                mDateAdded = value;
            }
        }

        //Private variable 
        private Int32 mCustomerNo;
        public Int32 CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;

            }
        }
        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        private string mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private string mPhoneNo;
        public string PhoneNo
        {
            get
            {
                return mPhoneNo;
            }
            set
            {
                mPhoneNo = value;
            }
        }

        public bool Find(int customerNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", CustomerNo);
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            if (DB.Count == 1)


            {
                //set the privare data members to the test data value
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);

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