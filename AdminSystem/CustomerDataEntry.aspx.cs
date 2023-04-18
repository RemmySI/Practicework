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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.FirstName = txtFirstName.Text;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomerNo = new clsCustomer();
        Int32 CustomerNo;
        Boolean Found = false;
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        Found = ACustomerNo.Find(CustomerNo);
        if (Found == true)
        {
            txtFirstName.Text = ACustomerNo.FirstName;
            txtLastName.Text = ACustomerNo.LastName;
            txtEmail.Text = ACustomerNo.Email;
            txtContactNumber.Text = ACustomerNo.ContactNumber;
            txtDateAdded.Text = ACustomerNo.DateAdded.ToString();
            chkActive.Checked = ACustomerNo.AccountActive;
        }
    }
}