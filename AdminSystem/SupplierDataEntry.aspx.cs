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
        //New instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();

        //Capture the name
        string supplierName = txtSupplierName.Text;
        string supplierContactNo = txtSupplierContactNo.Text;
        string supplierEmail = txtSupplierEmail.Text;
        string supplierAddress = txtSupplierAddress.Text;
        string dateRegistered = txtDateRegistered.Text;

        string Error = "";
        Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);

        if (Error == "")
        {
            ASupplier.supplierName = supplierName;
            ASupplier.supplierContactNo = supplierContactNo;
            ASupplier.supplierEmail = supplierEmail;
            ASupplier.supplierAddress = supplierAddress;
            ASupplier.dateRegistered = Convert.ToDateTime(dateRegistered);

            Session["ASupplier"] = ASupplier;

            Response.Write("SupplierViewwer.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
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