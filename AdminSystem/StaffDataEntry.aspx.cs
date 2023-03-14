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
        //New instance of clsStaff
        clsStaff AnStaffNo = new clsStaff();

        //Capture the name
        AnStaffNo.staffName = txtStaffName.Text;

        //Store the name in the session
        Session["AnStaffNo"] = AnStaffNo;

        //Navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the address class
        clsStaff AnStaffNo = new clsStaff();

        //Variable to store the primary key
        Int32 StaffNo;

        //Variable to store the result of the find operation
        Boolean Found = false;

        //Get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);

        //Find the record
        Found = AnStaffNo.Find(StaffNo);

        //If found
        if (Found == true)
        {
            //Display the values of the properties in the form
            txtStaffAddress.Text = AnStaffNo.staffAddress;
            txtStaffBirthDate.Text = AnStaffNo.staffBirthDate.ToString();
            txtStaffMoNumber.Text = AnStaffNo.staffMoNumber.ToString();
            txtStaffName.Text = AnStaffNo.staffName;
            txtStaffNo.Text = AnStaffNo.staffNo.ToString();
            txtStaffRole.Text = AnStaffNo.staffRole;
            chkActive.Checked = AnStaffNo.staffActive;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}