using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of supplierNo
        clsSupplier ASupplierNo = new clsSupplier();

        //get the data from the session object
        ASupplierNo = (clsSupplier) Session["ASupplierNo"];

        //display the supplier name on the page
        Response.Write(ASupplierNo.supplierName);
    }
}