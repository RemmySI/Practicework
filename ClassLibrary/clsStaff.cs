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
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //Add the parameter for the staff no to search for
            DB.AddParameter("@staffNo", staffNo);

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");

            //If one record is found (There should be either one or zero)
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["staffNo"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["staffAddress"]);
                mStaffActive = Convert.ToBoolean(DB.DataTable.Rows[0]["staffActive"]);
                mStaffBirthDate = Convert.ToDateTime(DB.DataTable.Rows[0]["staffBirthDate"]);
                mStaffMoNumber = Convert.ToDecimal(DB.DataTable.Rows[0]["staffMoNumber"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["staffName"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["staffRole"]);

                //Return that everything worked OK
                return true;
            }

            //If no record was found
            else
            {
                //Return false indicating a problem
                return false;
            }
        }

        //Validation method
        public string Valid (string staffName, string staffAddress, string staffRole, string staffBirthDate)
        {
            String Error = "";

            DateTime DateTemp;

            if (staffName.Length == 0 | staffAddress.Length == 0 | staffRole.Length == 0)
            {
                Error = Error + "This box may not be blank : ";
            }

            if (staffName.Length > 50 | staffAddress.Length > 50 | staffRole.Length > 50)
            {
                Error = Error + "This box must be less than 50 characters : ";
            }

            DateTemp = Convert.ToDateTime(staffBirthDate);
            
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }

            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }
            
            return Error;
        }
    }
}