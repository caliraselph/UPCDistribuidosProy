using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Views
{
    public partial class wfTPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNew2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfBPersona.aspx");
        }
    }
}