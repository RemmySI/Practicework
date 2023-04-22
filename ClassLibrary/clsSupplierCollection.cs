using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        List<clsSupplier> mThisSupplier = new List<clsSupplier>();

        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();

                ASupplier.supplierNo = Convert.ToInt32(DB.DataTable.Rows[Index]["supplierNo"]);
                ASupplier.supplierName = Convert.ToString(DB.DataTable.Rows[Index]["supplierName"]);
                ASupplier.supplierContactNo = Convert.ToString(DB.DataTable.Rows[Index]["supplierContactNo"]);
                ASupplier.supplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["supplierEmail"]);
                ASupplier.supplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["supplierAddress"]);
                ASupplier.dateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateRegistered"]);
                ASupplier.active = Convert.ToBoolean(DB.DataTable.Rows[Index]["active"]);

                mSupplierList.Add(ASupplier);

                Index++;
            }

        }
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }

            set
            {
                mSupplierList = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }

            set
            {

            }
        }

        public clsSupplier ThisSupplier { get; set; }
    }
}