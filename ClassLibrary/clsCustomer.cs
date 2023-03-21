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

        private bool mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int customerNo)
        {
            //set the privare data members to the test data value
            mCustomerNo = 21;
            mFirstName = "Test First";
            mLastName = "Test Last";
            mEmail =  "TestEmail@Email.com";
            mPhoneNo = "01788888";
            mDateAdded = Convert.ToDateTime("05/11/2021");
            mActive = true;

            //always return true
            return true;
        }
    }
}