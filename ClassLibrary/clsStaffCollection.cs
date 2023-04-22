using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        List<clsStaff> mThisStaff = new List<clsStaff>();

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();

                AnStaff.staffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["staffNo"]);
                AnStaff.staffAddress = Convert.ToString(DB.DataTable.Rows[Index]["staffAddress"]);
                AnStaff.staffActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["staffActive"]);
                AnStaff.staffBirthDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["staffBirthDate"]);
                AnStaff.staffMoNumber = Convert.ToString(DB.DataTable.Rows[Index]["staffMoNumber"]);
                AnStaff.staffName = Convert.ToString(DB.DataTable.Rows[Index]["staffName"]);
                AnStaff.staffRole = Convert.ToString(DB.DataTable.Rows[Index]["staffRole"]);

                mStaffList.Add(AnStaff);

                Index++;
            }
            
        }
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }

            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {

            }
        }

        public clsStaff ThisStaff { get; set; }
    }
}