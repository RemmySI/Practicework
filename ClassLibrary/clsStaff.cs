using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private string mStaffName;
        public string staffName
        {
            get
            {
                return mStaffName;
            }

            set
            {
                mStaffName = value;
            }
        }

        private bool mStaffActive;
        public bool staffActive
        {
            get
            {
                return mStaffActive;
            }

            set
            {
                mStaffActive = value;
            }
        }
        private Int32 mStaffNo;
        public Int32 staffNo
        {
            get
            {
                //This line sends data out
                return mStaffNo;
            }

            set
            {
                //This line allows data in
                mStaffNo = value;
            }
        }

        private string mStaffAddress;
        public string staffAddress
        {
            get
            {
                return mStaffAddress;
            }

            set
            {
                mStaffAddress = value;
            }
        }

        private decimal mStaffMoNumber;
        public decimal staffMoNumber
        {
            get
            {
                return mStaffMoNumber;
            }

            set
            {
                mStaffMoNumber = value;
            }
        }

        private string mStaffRole;
        public string staffRole
        {
            get
            {
                return mStaffRole;
            }

            set
            {
                mStaffRole = value;
            }
        }

        private DateTime mStaffBirthDate;
        public DateTime staffBirthDate
        {
            get
            {
                return mStaffBirthDate;
            }

            set
            {
                mStaffBirthDate = value;
            }
        }

        public bool Find(int staffNo)
        {
            mStaffNo = 21;
            mStaffActive = true;
            mStaffAddress = "Knight Avenue 2";
            mStaffBirthDate = DateTime.Now.Date;
            mStaffMoNumber = 7415687415;
            mStaffName = "Will Smith";
            mStaffRole = "Analyst";
            //always return true
            return true;
        }

    }
}