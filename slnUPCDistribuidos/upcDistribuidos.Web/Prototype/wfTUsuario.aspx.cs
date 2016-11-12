using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace upcDistribuidos.Web.Prototype
{
    public partial class wfTUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewUsu_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnSalUsu_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnBusPer_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open('wfBPersona.aspx', 'Persona', 'location=1,status=1,scrollbars=1,width=800,height=500');</script>");
        }
    }
}