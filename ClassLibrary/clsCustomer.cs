using System;

namespace ClassLibrary
{
    public class clsCustomer
    { //public validation method 

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
        public int CustomerNo
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

        public string Valid(string lastName,
                            string email,
                            string phoneNo,
                            string dateAdded,
                            string firstName)
        {
            //string variable to store the error
            String Error = "";
            if (firstName.Length == 0)
            {
                Error = Error + "The first name may not be blank :";
            }
            return Error;
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
        public string ContactNumber
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
        private bool mAccountActive;
        public bool AccountActive
        {
            get
            {
                return mAccountActive;
            }
            set
            {
                mAccountActive = value;
            }
        }

        //
        //TEST FIND METHOD - DJ
        //public bool Find(int CustomerNo)
        //{
        //    //create an instance of the data connection
        //    clsDataConnection DB = new clsDataConnection();
        //    //add the parameter for the customer number to search for
        //    DB.AddParameter("CustomerNo", CustomerNo);
        //    //execute the stored procedure
        //    DB.Execute("sproc_tblCustomer_filterByCustNo_DJ");
        //    //if one record is found (there should be either one or zero)
        //    if (DB.Count == 1)
        //    {
        //        //copy the data from the database to the private members
        //        mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
        //        mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
        //        mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
        //        mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
        //        mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
        //        mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
        //        mAccountActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
        //        return true;
        //    }
        //    //if no record is found
        //    else
        //    {
        //        //return false indicating a problem
        //        return false;
        //    }
        //}

        public bool Find(int CustomerNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", CustomerNo);
            //DB.Execute("sproc_tblCustomer_filterByCustNo_DJ");
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            if (DB.Count == 1)
            {
                //set the privare data members to the test data value
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                //mFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]); //naming issue with CustomerFirstName - should be FirstName as property and attribute
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                //mLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]); //naming issue as above
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                //mEmail = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]); //naming issue as above
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]); //naming issue as above
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]); //naming issue as above
                //mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]); //naming issue as above
                mAccountActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
                //return what worked
                return true;
            }
            // if no record is found
            else
            {
                return false;
            }
        }


    }
}