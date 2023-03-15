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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //New instance of supplierNo
        clsSupplier ASupplierNo = new clsSupplier();

        //Capture the name
        ASupplierNo.supplierName = txtSupplierName.Text;

        //Store the name in the session
        Session["ASupplierNo"] = ASupplierNo;

        //Navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsSupplier ASupplier = new clsSupplier();
        //variable to store the primary key
        Int32 supplierNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        supplierNo = Convert.ToInt32(txtSupplierNo.Text);
        //find the record
        Found = ASupplier.Find(supplierNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplierName.Text = ASupplier.supplierName;
            txtSupplierContactNo.Text = ASupplier.supplierContactNo.ToString();
            txtSupplierEmail.Text = ASupplier.supplierEmail;
            txtSupplierAddress.Text = ASupplier.supplierAddress;
            txtDateRegistered.Text = ASupplier.dateRegistered.ToString();
            chkActive.Checked = ASupplier.active;
        }
    }
}