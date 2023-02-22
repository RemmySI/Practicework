﻿using System;
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
        staffNo AnStaffNo = new staffNo();

        //Capture the name
        AnStaffNo.staffName = txtStaffName.Text;

        //Store the name in the session
        Session["AnStaffNo"] = AnStaffNo;

        //Navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}