using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Add_Click(object sender, EventArgs e)
    {
        //New instance of supplierNo
        supplierNo ASupplierNo = new supplierNo();

        //Capture the name
        ASupplierNo.supplierName = txtsupplierName.Text;

        //Store the name in the session
        Session["ASupplierNo"] = ASupplierNo;

        //Navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }
}