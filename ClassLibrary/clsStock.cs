using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockNo;
        public bool Available { get; set; }
        public decimal CardPrice { get; set; }
        public string CardType { get; set; }
        public string CardDescription { get; set; }
        public int CardNo 
        {
            get
            {
                return mStockNo;
            }
            set {
                mStockNo = value;
            }
        }
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



        public bool Find(int CardNo)
        {
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mStockNo = 21;
            //always return true;
            return true;
        }

    



    }
}