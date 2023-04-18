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
        //Create new instance
        clsStaff clsStaff = new clsStaff();

        //Get data from the session object
        clsStaff staffNo = (clsStaff)Session["AnStaffNo"];

        //display the name
        Response.Write(staffNo.staffName);
    }
}