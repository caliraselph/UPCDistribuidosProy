using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Views
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         

        protected void LoginButton_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/frmInicio.aspx");
        }
    }
}