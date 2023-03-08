using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //New instance of class 
        clsCustomer ACustomer = new clsCustomer();
        //Get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //Display First Name on page
        Response.Write(ACustomer.FirstName);
    }
}