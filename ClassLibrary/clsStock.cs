using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Available { get; set; }
        public decimal CardPrice { get; set; }
        public string CardType { get; set; }
        public string CardDescription { get; set; }
        public int CardNo { get; set; }
        public DateTime DateAdded { get; set; }
    }
}