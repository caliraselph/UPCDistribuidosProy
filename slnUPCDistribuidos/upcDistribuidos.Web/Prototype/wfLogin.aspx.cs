using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfPrincipal.aspx");
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}