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
        staffNo AnStaffNo = new staffNo();

        //Get data from the session object
        AnStaffNo = (staffNo)Session["AnStaffNo"];

        //display the name
        Response.Write(AnStaffNo.staffName);
    }
}